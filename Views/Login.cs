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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Call Authenticate method
            var user = Authenticate(username, password);

            if (user != null)
            {
                // Navigate based on role
                if (user.Role == Role.Admin)
                {
                    this.Hide();
                    var dashboardForm = new Admin();
                    dashboardForm.ShowDialog();
                    this.Show();
                }
                else if (user.Role == Role.Cashier)
                {
                    this.Hide();
                    var cashierForm = new Cashier();
                    cashierForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user role!");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private User? Authenticate(string username, string password)
        {
            if (_context == null) return null;

            var user = _context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            return user;
        }
    }
}
