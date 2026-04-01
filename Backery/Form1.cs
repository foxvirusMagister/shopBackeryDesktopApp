namespace Backery
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Logo.Size = new Size(Convert.ToInt32(Size.Width * 0.5), Convert.ToInt32(Size.Height));
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Hide();
            SelectProductCategoryUserForm second_form = new(this);
            second_form.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new(this);
            Hide();
            loginScreen.Show();
        }
    }
}
