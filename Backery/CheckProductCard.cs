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
    public partial class CheckProductCard : UserControl
    {
        ProductInCheck product_info;
        int place;

        public CheckProductCard(ProductInCheck product_info, Image img, int place)
        {
            InitializeComponent();
            this.product_info = product_info;
            ProductImage.Image = img;
            this.place = place;
        }

        private void CheckProductCard_Load(object sender, EventArgs e)
        {
            ProductName.Text = product_info.name;
            ProductPrice.Text = product_info.price.ToString();
            ProductCount.Text = product_info.amount.ToString() + " шт.";
            Margin = new(10);
        }

        private void ProductImage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
