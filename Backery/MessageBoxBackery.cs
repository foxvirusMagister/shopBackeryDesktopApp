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
    public partial class MessageBoxBackery : Form
    {
        string messageText;
        public MessageBoxBackery(string messageText)
        {
            InitializeComponent();
            this.messageText = messageText;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void MessageBoxBackery_Load(object sender, EventArgs e)
        {
            TextField.Text = messageText;
        }
    }
}
