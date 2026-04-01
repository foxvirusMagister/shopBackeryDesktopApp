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
    public partial class SelectProductUserForm : Form
    {
        SelectProductCategoryUserForm parent;
        CategoryCard category_card;
        public SelectProductUserForm(SelectProductCategoryUserForm parent, CategoryCard category_card)
        {
            InitializeComponent();
            this.parent = parent;
            this.category_card = category_card;
        }

        private void SelectProductUserForm_Load(object sender, EventArgs e)
        {
            BackButton.Size = new(Convert.ToInt32(Size.Width * 0.1), Convert.ToInt32(Size.Height * 0.1));
            ProductPanel.Size = new(Convert.ToInt32(Size.Width * 0.95), Convert.ToInt32(Size.Height * 0.6));
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
                ProductCardUser card = new(product, this, await ApiClient.GetProductImageAsync(product), parent);
                ProductPanel.Controls.Add(card);
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

        private void CartButton_Click(object sender, EventArgs e)
        {
            CartForm cart = new(parent, this);
            Hide();
            cart.Show();
        }

        public void Terminate()
        {
            parent.Terminate();
            Close();
        }
    }
}
