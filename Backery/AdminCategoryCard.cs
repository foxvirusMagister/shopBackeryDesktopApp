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
        public AdminCategoryCard(AdminProductCategoriesForm parent, MainMenu root, CategoryClass categoryClass)
        {
            InitializeComponent();
            this.parent = parent;
            this.root = root;
            this.categoryClass = categoryClass;
        }

        private void AdminCategoryCard_Load(object sender, EventArgs e)
        {
            CategoryName.Text = categoryClass.name;
        }

        private void AdminCategoryCard_Click(object sender, EventArgs e)
        {

        }

        void CreateDetails(string? mode=null)
        {
            if (mode != null)
            {
                AdminCategoryDetail categoryDetail = new(categoryClass, this, parent, mode);
                categoryDetail.ShowDialog();
            }
            else
            {
                AdminCategoryDetail categoryDetail = new(categoryClass, this, parent);
                categoryDetail.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDetails();
        }
    }
}
