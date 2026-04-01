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
            id = cat.id;
            this.parent = parent;
        }

        private void CategoryCard_Load(object sender, EventArgs e)
        {
            CategoryName.Text = categoryName;
        }

        private void CategoryCard_Click(object sender, EventArgs e)
        {
            parent.Hide();
            SelectProductUserForm second_form = new(parent, this);
            second_form.Show();
        }
    }
}
