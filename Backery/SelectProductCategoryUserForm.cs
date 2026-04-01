using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.Json;


namespace Backery
{
    public partial class SelectProductCategoryUserForm : Form
    {
        MainMenu parent;
        public List<ProductInCheck> productsInCheck = [];
        public SelectProductCategoryUserForm(MainMenu mm)
        {
            InitializeComponent();
            parent = mm;
        }

        private void SelectProductCategoryUserForm_Load(object sender, EventArgs e)
        {
            BackButton.Size = new(Convert.ToInt32(Size.Width * 0.1), Convert.ToInt32(Size.Height * 0.1));
            CategoryPanel.Size = new(Convert.ToInt32(Size.Width * 0.95), Convert.ToInt32(Size.Height * 0.6));
            InsertInPanel();
        }

        public async void InsertInPanel()
        {
            CategoryPanel.Controls.Clear();
            int page = Convert.ToInt32(PageSelector.Value);
            int limit = int.Parse(CatsCount.Text);

            List<CategoryClass> categories = await ApiClient.GetCategoriesAsync(string.Format("http://185.196.41.109:9000/categories/used?limit={0}&page={1}", limit, page));
            CategoryPanel.RowCount = Convert.ToInt32(categories.Count / 3) + 1;
            foreach (CategoryClass category in categories)
            {
                CategoryCard card = new(category, this);
                CategoryPanel.Controls.Add(card);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            parent.Show();
            Close();
        }

        private void CatsCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertInPanel();
        }

        private void PageSelector_ValueChanged(object sender, EventArgs e)
        {
            InsertInPanel();
        }

        public void Terminate()
        {
            parent.Show();
            Close();
        }
    }
}
