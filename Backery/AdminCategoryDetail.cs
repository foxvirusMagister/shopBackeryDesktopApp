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
    public partial class AdminCategoryDetail : Form
    {
        public CategoryClass categoryClass;
        AdminCategoryCard creator;
        AdminProductCategoriesForm parent;
        string mode = "change";
        public AdminCategoryDetail(CategoryClass categoryClass, AdminCategoryCard creator, AdminProductCategoriesForm parent, string mode = "change")
        {
            InitializeComponent();
            this.categoryClass = categoryClass;
            this.creator = creator;
            this.parent = parent;
            this.mode = mode;
        }

        private void CategoryNameField_Click(object sender, EventArgs e)
        {
            if (mode == "create") CategoryNameField.Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AdminCategoryDetail_Load(object sender, EventArgs e)
        {
            if (mode == "change")
            {
                CategoryNameField.Text = categoryClass.name;

            }
        }
    }
}
