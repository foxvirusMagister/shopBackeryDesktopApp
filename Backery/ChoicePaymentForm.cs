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
    public partial class ChoicePaymentForm : Form
    {
        SelectProductCategoryUserForm root;
        CartForm parent;
        public double totalPrice;
        public ChoicePaymentForm(SelectProductCategoryUserForm root, CartForm parent, double totalPrice)
        {
            InitializeComponent();
            this.root = root;
            this.parent = parent;
            this.totalPrice = totalPrice;
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            ThanksForBuyingForm endCheck = new(this, root, totalPrice);
            endCheck.Show();
            Hide();
        }

        private void ChoicePaymentForm_Load(object sender, EventArgs e)
        {
            TotalPrice.Text = totalPrice.ToString();
        }

        private void ChoicePaymentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.terminate();

        }
    }
}
