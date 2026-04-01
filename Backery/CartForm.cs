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
    public partial class CartForm : Form
    {
        SelectProductCategoryUserForm root;
        SelectProductUserForm parent;
        public double totalPrice = 0;

        public CartForm(SelectProductCategoryUserForm root, SelectProductUserForm parent)
        {
            InitializeComponent();
            this.root = root;
            this.parent = parent;
        }

        public async void InsertInPanel()
        {
            ProductsPanel.Controls.Clear();
            ProductsPanel.RowCount = Convert.ToInt32(root.productsInCheck.Count / 4) + 1;
            int place = 0;
            foreach (ProductInCheck product in root.productsInCheck)
            {
                CheckProductCard card = new(product, await ApiClient.GetProductImageAsync(product), place);
                ProductsPanel.Controls.Add(card);
                place++;
                totalPrice += product.price * product.amount;
            }
            totalPrice = Math.Round(totalPrice, 2);
            TotalPriceLabel.Text = "Цена: " + totalPrice.ToString();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            InsertInPanel();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            ChoicePaymentForm choicePaymentForm = new(root, this, totalPrice);
            Hide();
            choicePaymentForm.Show();
        }

        private void CartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        public void terminate()
        {
            Close();
            parent.Terminate();
        }
    }
}
