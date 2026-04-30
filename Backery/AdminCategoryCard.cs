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
    public partial class AdminCategoryCard : UserControl
    {
        AdminProductCategoriesForm parent;
        MainMenu root;
        CategoryClass categoryClass;
        public string categoryName = "";
        public int id;
        public AdminCategoryCard(AdminProductCategoriesForm parent, MainMenu root, CategoryClass categoryClass)
        {
            InitializeComponent();
            this.parent = parent;
            this.root = root;
            this.categoryClass = categoryClass;
            id = (int)categoryClass.id;
            categoryName = categoryClass.name;
        }

        private void AdminCategoryCard_Load(object sender, EventArgs e)
        {
            CategoryName.Text = categoryClass.name;
        }

        private void AdminCategoryCard_Click(object sender, EventArgs e)
        {
            AdminProductsListForm productsForm = new(parent, this);
            parent.Hide();
            productsForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AdminCategoryDetail categoryDetail = new(parent, creator: this, categoryClass: categoryClass);
            categoryDetail.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            AskForDelete deleteDialog = new(categoryClass, parent);
            deleteDialog.ShowDialog();
        }
    }
}
