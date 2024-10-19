using Data;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using PuntoVenta.Business.Services;
using PuntoVenta.Views;

namespace PuntoVenta
{
    public partial class Login : Form
    {
        private ApplicationDbContext? _context;
        public Login()
        {
            _context = new ApplicationDbContext();
            InitializeComponent();
        }

        private void cbSeePassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbSeePassword.Checked ? '\0' : '*';
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Call Authenticate method
            var user = await AuthenticateAsync(username, password);

            if (user != null)
            {
                MessageBox.Show("Login successful!");

                // Navigate based on role
                if (user.Role == Role.Admin)
                {
                    var dashboardForm = new Admin();
                    dashboardForm.ShowDialog();
                }
                else if (user.Role == Role.Cashier)
                {
                    var cashierForm = new Cashier();
                    cashierForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid user role!");
                }

                // Hide login form after successful login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private async Task<User?> AuthenticateAsync(string username, string password)
        {
            if (_context == null) return null;

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            return user;
        }
    }
}
