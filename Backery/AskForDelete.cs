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
    public partial class AskForDelete : Form
    {
        CategoryClass category;
        AdminProductCategoriesForm categories;

        public AskForDelete(CategoryClass category, AdminProductCategoriesForm categories)
        {
            InitializeComponent();
            this.category = category;
            this.categories = categories;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void YesButton_Click(object sender, EventArgs e)
        {
            int response = await ApiClient.DeleteCategoryAsync(category);
            if (response == category.id)
            {
                MessageBox.Show("Успех!");
                Close();
                categories.InsertInPanel();
            }
        }
    }
}
