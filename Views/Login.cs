namespace PuntoVenta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cbSeePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSeePassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            } else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
