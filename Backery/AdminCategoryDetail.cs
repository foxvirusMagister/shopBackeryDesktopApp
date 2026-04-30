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
        public CategoryClass? categoryClass;
        AdminCategoryCard? creator;
        AdminProductCategoriesForm parent;
        string mode = "change";
        public AdminCategoryDetail(AdminProductCategoriesForm parent, string mode = "change", AdminCategoryCard? creator = null, CategoryClass? categoryClass = null)
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
                OkButton.Text = "Изменить";
            }
            else if (mode == "create")
            {
                OkButton.Text = "Создать";
            }
        }

        private async void OkButton_Click(object sender, EventArgs e)
        {
            if (mode == "change")
            {
                if (categoryClass != null)
                {
                    if (categoryClass.id != null)
                    {
                        categoryClass.name = CategoryNameField.Text;
                        var response = await ApiClient.PutCategoryAsync(categoryClass);
                        if (response.name != string.Empty)
                        {
                            MessageBox.Show("Успех");
                            parent.InsertInPanel();
                            Close();
                        }

                    }
                }
            }
            else if (mode == "create")
            {
                categoryClass = new();
                categoryClass.name = CategoryNameField.Text;
                var response = await ApiClient.PostCategoryAsync(categoryClass);
                if (response.name != string.Empty)
                {
                    MessageBox.Show("Успех");
                    parent.InsertInPanel();
                    Close();
                }
            }
        }
    }
}
