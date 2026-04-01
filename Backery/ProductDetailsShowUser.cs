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
    public partial class ProductDetailsShowUser : Form
    {
        ProductClass product_info;
        SelectProductCategoryUserForm root;
        public ProductDetailsShowUser(ProductClass product_info, Image img, SelectProductCategoryUserForm root)
        {
            InitializeComponent();
            this.product_info = product_info;
            Text = "Информация о продукте '" + product_info.name + "'";
            ProductPicture.Image = img;
            this.root = root;
        }

        private void ProductDetailsShowUser_Load(object sender, EventArgs e)
        {
            ProductName.Text = product_info.name;
            ProductPrice.Text = product_info.price.ToString();
            ProductContent.Text = product_info.content;

        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            ProductInCheck productInCheck = new();
            productInCheck.price = product_info.price;
            productInCheck.name = product_info.name;
            productInCheck.amount = (int)ProductAmount.Value;
            productInCheck.id = product_info.id;
            productInCheck.category = product_info.category;
            productInCheck.picture_key = product_info.picture_key;
            

            root.productsInCheck.Add(productInCheck);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
