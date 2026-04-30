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
    public partial class CategoryCard : UserControl
    {
        public string categoryName = "";
        public int id;
        SelectProductCategoryUserForm parent;
        public CategoryCard(CategoryClass cat, SelectProductCategoryUserForm parent)
        {
            InitializeComponent();
            categoryName = cat.name;
            id = (int)cat.id;
            this.parent = parent;
        }

        private async void CategoryCard_Load(object sender, EventArgs e)
        {
            CategoryName.Text = categoryName;
            List<ProductClass> productClass = await ApiClient.GetProductsAsync(string.Format("http://185.196.41.109:9000/products?limit=1&page=1&filter=category_id eq {0}", id));
            Image productImg = await ApiClient.GetProductImageAsync(productClass[0]);
            CategoryImage.Image = productImg;
        }

        private void CategoryCard_Click(object sender, EventArgs e)
        {
            parent.Hide();
            SelectProductUserForm second_form = new(parent, this);
            second_form.Show();
        }
    }
}
