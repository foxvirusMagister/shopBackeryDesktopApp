using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Backery
{
    public partial class AdminProductsListForm : Form
    {
        AdminProductCategoriesForm parent;
        public AdminCategoryCard category_card;
        public AdminProductsListForm(AdminProductCategoriesForm parent, AdminCategoryCard category_card)
        {
            InitializeComponent();
            this.parent = parent;
            this.category_card = category_card;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AdminProductDetails detailsForm = new(this, "add", null, null);
            detailsForm.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void CatsCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertInPanel();
        }

        public async void InsertInPanel()
        {
            
            ProductPanel.Controls.Clear();
            int page = Convert.ToInt32(PageSelector.Value);
            int limit = int.Parse(CatsCount.Text);
            int category_id = category_card.id;

            List<ProductClass> products = await ApiClient.GetProductsAsync(string.Format("http://185.196.41.109:9000/products?limit={0}&page={1}&filter=category_id eq {2}", limit, page, category_id));
            ProductPanel.RowCount = Convert.ToInt32(products.Count / 4) + 1;
            foreach (ProductClass product in products)
            {
                AdminProductCard card = new(product, this, await ApiClient.GetProductImageAsync(product), parent, categoryCard: category_card);
                ProductPanel.Controls.Add(card);
            }
        }

        private void AdminProductsListForm_Load(object sender, EventArgs e)
        {
            InsertInPanel();
        }
    }
}
