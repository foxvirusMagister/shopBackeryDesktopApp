using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backery
{
    public partial class AdminProductCard : UserControl
    {
        public ProductClass product_info;
        AdminProductsListForm current_form;
        public AdminProductCategoriesForm root;
        public AdminCategoryCard categoryCard;
        public AdminProductCard(ProductClass product_info, AdminProductsListForm current_form, Image img, AdminProductCategoriesForm root, AdminCategoryCard categoryCard)
        {
            InitializeComponent();
            this.product_info = product_info;
            this.current_form = current_form;
            ProductPicture.Image = img;
            this.root = root;
            this.categoryCard = categoryCard;
        }

        private void AdminProductCard_Click(object sender, EventArgs e)
        {

        }

        private void AdminProductCard_Load(object sender, EventArgs e)
        {
            ProductName.Text = product_info.name;
            ProductCost.Text = product_info.price.ToString();
            Margin = new(10);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AdminProductDetails detailsForm = new(current_form, "edit", ProductPicture.Image, product_info, card: categoryCard);
            detailsForm.ShowDialog();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            AdminDeleteProductDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var result = await ApiClient.DeleteProductAsync(product_info);
                if (result == product_info.id)
                {
                    DialogsClass.MessageDialog("Успех!");
                    current_form.InsertInPanel();
                }
            }
        }
    }
}
