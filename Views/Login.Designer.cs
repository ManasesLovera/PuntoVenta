namespace PuntoVenta
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            cbSeePassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.login;
            pictureBox1.Location = new Point(515, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 452);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 55);
            label1.Name = "label1";
            label1.Size = new Size(222, 31);
            label1.TabIndex = 1;
            label1.Text = "Punto de Venta APP";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(337, 235);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(481, 213);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(481, 275);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 10.2F);
            txtUsername.Location = new Point(594, 210);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(136, 30);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.2F);
            txtPassword.Location = new Point(594, 272);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(136, 30);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 255, 192);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F);
            btnLogin.ForeColor = Color.FromArgb(0, 64, 0);
            btnLogin.Location = new Point(554, 351);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 37);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // cbSeePassword
            // 
            cbSeePassword.AutoSize = true;
            cbSeePassword.Location = new Point(736, 280);
            cbSeePassword.Name = "cbSeePassword";
            cbSeePassword.Size = new Size(18, 17);
            cbSeePassword.TabIndex = 7;
            cbSeePassword.UseVisualStyleBackColor = true;
            cbSeePassword.CheckedChanged += cbSeePassword_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSeePassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private CheckBox cbSeePassword;
    }
}
