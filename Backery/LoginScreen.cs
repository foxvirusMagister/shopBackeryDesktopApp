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
    public partial class LoginScreen : Form
    {
        MainMenu root;
        public LoginScreen(MainMenu root)
        {
            InitializeComponent();
            this.root = root;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            root.Show();
            Terminate();
        }

        private void ClearField(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "Пароль" || textBox.Text == "Логин")
            {
                if (textBox.Text == "Пароль") textBox.PasswordChar = '*';
                textBox.Clear();
            }
        }

        private async void EnterButton_Click(object sender, EventArgs e)
        {
            FileInfo fileToken = new("token");
            if (! fileToken.Exists)
            {string username = UsernameField.Text;
            string password = PasswordField.Text;
            string result = await ApiClient.GetTokenAsync(username, password);
                if (result != "")
                {
                    FileInfo file = new("token");
                    using (StreamWriter stream = file.CreateText())
                    {
                        await stream.WriteAsync(result.ToString());
                    }
                    Login();
                }
                else
                {
                    DialogsClass.MessageDialog("Неверные данные!");
                }
            }
            else
            {
                Login();
            }
        }

        private void Login()
        {
            FileInfo file = new("token");
            string? token;
            using (StreamReader stream = new("token"))
            {
                token = stream.ReadLine();
            }
            if (token != null)
            {
                AdminProductCategoriesForm categoriesForm = new(root, this, token);
                categoriesForm.Show();
                Hide();
            }
            PasswordField.Clear();
            UsernameField.Clear();
            
        }

        public void Terminate()
        {
            FileInfo token_file = new("token");
            if (token_file.Exists) token_file.Delete();
        }
    }
}