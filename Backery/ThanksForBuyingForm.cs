using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backery
{
    public partial class ThanksForBuyingForm : Form
    {
        ChoicePaymentForm parent;
        SelectProductCategoryUserForm root;
        double totalPrice;
        string checkText = "";
        public ThanksForBuyingForm(ChoicePaymentForm parent, SelectProductCategoryUserForm root, double totalPrice)
        {
            InitializeComponent();
            this.parent = parent;
            this.root = root;
            this.totalPrice = totalPrice;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitFrom();
        }

        private void ThanksForBuyingForm_Load(object sender, EventArgs e)
        {
            checkText = "";
            checkText += string.Format("Номер чека {0}\r\n \r\n", DateTime.UtcNow.Ticks.ToString());
            checkText += string.Format("Всего продуктов в корзине {0}\r\n", root.productsInCheck.Count.ToString());
            checkText += string.Format("Итоговая цена: {0} руб.\r\n \r\n", totalPrice.ToString());
            foreach (ProductInCheck product in root.productsInCheck)
            {
                checkText += string.Format("Название продукта: {0}\r\n", product.name);
                checkText += string.Format("Цена продукта: {0} руб.\r\n", product.price.ToString());
                checkText += string.Format("Количество таких продуктов: {0}\r\n", product.amount.ToString());
                checkText += string.Format("Цена продукта учитывая количество: {0} руб.\r\n", (product.price * product.amount).ToString());
                checkText += string.Format("Категория продукта: {0}\r\n \r\n", product.category);
            }
            checkText += "СПАСИБО ЗА ПОКУПКУ";

            CheckPreview.Text = checkText;
        }

        private void GetCheck_Click(object sender, EventArgs e)
        {
            SaveCheck.FileName = "Чек номер " + DateTime.UtcNow.Ticks.ToString();
            DialogResult savefile_Dialog = SaveCheck.ShowDialog();
            
            if (savefile_Dialog == DialogResult.OK)
            {
                FileInfo file = new(SaveCheck.FileName);
                using (StreamWriter stream = file.CreateText())
                {
                    stream.WriteLine(checkText);
                }
                DialogsClass.MessageDialog("Успех!\r\nЧек был сохранен!");
                ExitFrom();
            }
        }

        void ExitFrom()
        {
            root.productsInCheck.Clear();
            Close();
            parent.Close();

        }
    }
}
