using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backery
{
    public partial class AdminProductDetails : Form
    {
        string type = "edit";
        Image? img;
        ProductClass? productInfo;
        AdminCategoryCard? card;
        List<CategoryClass> categories;
        bool changedImage = false;
        AdminProductsListForm productsList;

        public int FindIdCategoryWithName(List<CategoryClass> list, string name)
        {
            foreach (CategoryClass category in list)
            {
                if (category.name == name) return (int)category.id;
            }
            return -1; // Не найдено
        }

        public AdminProductDetails(AdminProductsListForm productsList, string type, Image? img, ProductClass? productInfo, AdminCategoryCard? card = null)
        {
            InitializeComponent();
            this.type = type;
            this.img = img;
            this.productInfo = productInfo;
            this.card = card;
            this.productsList = productsList;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void BackGround_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void AdminProductDetails_Load(object sender, EventArgs e)
        {
            categories = await ApiClient.GetCategoriesAsync("http://185.196.41.109:9000/categories");
            if (categories.Count > 0)
            {
                foreach (CategoryClass category in categories)
                {
                    CategoryField.Items.Add(category.name);
                }
            }
            if (type == "edit") // Если указанный тип edit то меняем названия кнопок и добавляем данные в поля
            {
                CompleteButton.Text = "Изменить";
                if (img != null)
                {
                    productPicture.Image = img;
                }
                if (productInfo != null)
                {
                    DetailField.Text = productInfo.content;
                    NameField.Text = productInfo.name;
                    CostField.Text = Convert.ToString(productInfo.price);
                }
                
            }
            else // Иначе (он будет create / add или другое)
            {
                CompleteButton.Text = "Добавить"; // Меняем текст кнопки, все остальное пустое и стандартное
            }
            CategoryField.SelectedItem = productsList.category_card.categoryName;
        }

        private void DetailField_Click(object sender, EventArgs e)
        {
            if (type != "edit") DetailField.Clear(); // По нажатию на поле ввода оно очищается
        }

        private void CostField_Click(object sender, EventArgs e)
        {
            if (type != "edit") CostField.Clear(); // По нажатию на поле ввода оно очищается
        }

        private void NameField_Click(object sender, EventArgs e)
        {
            if (type != "edit") NameField.Clear(); // По нажатию на поле ввода оно очищается
        }

        private void productPicture_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = PictureImageDialog.ShowDialog(); // Показываем диалог с выбором файла картинки
            if (dialogResult == DialogResult.OK)
            {
                FileInfo file = new(PictureImageDialog.FileName); // Находим файл
                if (file.Exists) // Если он есть то загружаем в picture box
                {
                    using (FileStream stream = file.OpenRead()) // Создаем поток для чтения файла
                    {
                        img = Image.FromStream(stream); // Присваемаем переменной картинку из потока
                        productPicture.Image = img; // Присваеваем картинку виджету
                        changedImage = true;
                    }
                }
            }
        }

        private async void CompleteButton_Click(object sender, EventArgs e) // Обработка нажатия кнопки завершения
        {
            if (type == "edit") // если тип edit
            {
                bool willcreate = true;
                double result;
                if (double.TryParse(Encoding.UTF8.GetBytes(CostField.Text), out result)) // проверка стоимости на соответсвие виду double
                {
                    productInfo.price = result;
                }
                else
                {
                    DialogsClass.MessageDialog("Стоимость не является числом!\r\nВведите корректные данные!");
                    willcreate = false;
                }
                if (NameField.Text == "Название" || NameField.Text == "") // Проверка что пользователь ввел название
                {
                    DialogsClass.MessageDialog("Название отсутствует!\r\nПоле с названием должно быть заполнено!");
                    willcreate = false;
                }
                else
                {
                    productInfo.name = NameField.Text;
                }
                if (DetailField.Text == "Состав" || DetailField.Text == "") // Проверка что пользователь ввел состав, иначе вместо него будет состав не указан
                {
                    productInfo.content = "состав не указан";
                }
                else productInfo.content = DetailField.Text;
                if (CategoryField.Text == "")
                {
                    DialogsClass.MessageDialog("Категория не выбрана!\r\nПоле категории должно быть заполнено!");
                    willcreate = false;
                }
                else productInfo.category_id = FindIdCategoryWithName(categories, CategoryField.Text);
                if (willcreate)
                {
                    if (changedImage) productInfo.picture_key = PictureImageDialog.SafeFileName.Substring(0, PictureImageDialog.SafeFileName.Length - 5);
                var puttingProduct = await ApiClient.PutProductAsync(productInfo);
                    if (puttingProduct == 0)
                    {
                        if (changedImage)
                        {
                            var puttingImage = await ApiClient.PutImageAsync(PictureImageDialog.FileName, PictureImageDialog.SafeFileName.Substring(0, PictureImageDialog.SafeFileName.Length - 5));
                            if (puttingImage == 0)
                            {
                                DialogsClass.MessageDialog("Успех!");
                            }
                        }
                        else DialogsClass.MessageDialog("Успех");
                        productsList.InsertInPanel();
                        Close();
                    }
                }
            }
            else // создание новой
            {
                bool willcreate = true;
                productInfo = new();
                
                double result;
                if (double.TryParse(Encoding.UTF8.GetBytes(CostField.Text), out result)) // проверка стоимости на соответсвие виду double
                {
                    productInfo.price = result;
                }
                else
                {
                    DialogsClass.MessageDialog("Стоимость не является числом!");
                    willcreate = false;
                }
                if (NameField.Text == "Название" || NameField.Text == "") // Проверка что пользователь ввел название
                {
                    DialogsClass.MessageDialog("Название отсутствует!");
                    willcreate = false;
                }
                else
                {
                    productInfo.name = NameField.Text;
                }
                if (DetailField.Text == "Состав" || DetailField.Text == "") // Проверка что пользователь ввел состав, иначе вместо него будет состав не указан
                {
                    productInfo.content = "состав не указан";
                }
                else productInfo.content = DetailField.Text;
                if (img == null) // если картинки нет то она стандартная
                {
                    productInfo.picture_key = "default";
                }
                else
                {
                    productInfo.picture_key = PictureImageDialog.SafeFileName.Substring(0, PictureImageDialog.SafeFileName.Length - 5);
                }
                if (CategoryField.Text == "")
                {
                    DialogsClass.MessageDialog("Категория не выбрана!");
                    willcreate = false;
                }
                else productInfo.category_id = FindIdCategoryWithName(categories, CategoryField.Text);
                if (willcreate) // если обязательные условия выполнились
                {
                    var puttingProduct = await ApiClient.PostProductAsync(productInfo); // Создаем продукт
                    if (img != null) // если есть картинка то добавляем ее на сервер
                    {
                        if (puttingProduct == 0)
                        {
                            var puttingImage = await ApiClient.PutImageAsync(PictureImageDialog.FileName, PictureImageDialog.SafeFileName.Substring(0, PictureImageDialog.SafeFileName.Length - 5));
                            DialogsClass.MessageDialog("Успех!");
                            productsList.InsertInPanel();
                            Close();
                        }
                    }
                    else
                    {
                        if (puttingProduct == 0)
                        {
                            DialogsClass.MessageDialog("Успех!");
                            productsList.InsertInPanel();
                            Close();
                        }
                    }

                }
            }
        }
    }
}
