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
    public partial class ProductCardUser : UserControl
    {
        public ProductClass product_info;
        SelectProductUserForm current_form;
        public SelectProductCategoryUserForm root;

        public ProductCardUser(ProductClass product_info, SelectProductUserForm current_form, Image img, SelectProductCategoryUserForm root)
        {
            InitializeComponent();
            this.product_info = product_info;
            this.current_form = current_form;
            ProductPicture.Image = img;
            this.root = root;
        }

        private async void ProductCardUser_Load(object sender, EventArgs e)
        {
            ProductName.Text = product_info.name;
            ProductCost.Text = product_info.price.ToString();
            Margin = new(10);
        }

        private void ProductCardUser_Click(object sender, EventArgs e)
        {
            ProductDetailsShowUser product_details = new(product_info, ProductPicture.Image, root);
            product_details.ShowDialog();
        }
    }
}
