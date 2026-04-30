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
    public partial class AdminProductCategoriesForm : Form
    {
        MainMenu root;
        LoginScreen parent;
        string token;

        public AdminProductCategoriesForm(MainMenu root, LoginScreen parent, string token)
        {
            InitializeComponent();
            this.root = root;
            this.parent = parent;
            this.token = token;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void AdminProductCategoriesForm_Load(object sender, EventArgs e)
        {
            InsertInPanel();
        }

        public async void InsertInPanel()
        {
            CategoryPanel.Controls.Clear();
            int page = Convert.ToInt32(PageSelector.Value);
            int limit = int.Parse(CatsCount.Text);

            List<CategoryClass> categories = await ApiClient.GetCategoriesAsync(string.Format("http://185.196.41.109:9000/categories?limit={0}&page={1}", limit, page));
            CategoryPanel.RowCount = Convert.ToInt32(categories.Count / 3) + 1;
            foreach (CategoryClass category in categories)
            {
                AdminCategoryCard card = new(this, root, category);
                CategoryPanel.Controls.Add(card);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AdminCategoryDetail categoryDetail = new(this, "create");
            categoryDetail.ShowDialog();
        }
    }
}
