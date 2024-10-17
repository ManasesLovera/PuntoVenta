using PuntoVenta.Business.Services;
using PuntoVenta.Views;

namespace PuntoVenta
{
    public partial class Login : Form
    {
        private readonly UserService _userService;

        public Login(UserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void cbSeePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeePassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool isAuthenticated = await _userService.AuthenticateAsync(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!");
                // Proceed to the next form
                var dashboardForm = new Admin();
                dashboardForm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
