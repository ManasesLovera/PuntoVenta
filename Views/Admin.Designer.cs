namespace PuntoVenta.Views
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelIngresos = new Label();
            labelCajeros = new Label();
            labelVentas = new Label();
            labelProductos = new Label();
            tabPage2 = new TabPage();
            button5 = new Button();
            textBox3 = new TextBox();
            dgvAdminProducts = new DataGridView();
            button6 = new Button();
            tabPage3 = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            tabPage4 = new TabPage();
            button3 = new Button();
            textBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminProducts).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(179, 31);
            label1.TabIndex = 0;
            label1.Text = "PuntoVenta APP";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(30, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(910, 558);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(labelIngresos);
            tabPage1.Controls.Add(labelCajeros);
            tabPage1.Controls.Add(labelVentas);
            tabPage1.Controls.Add(labelProductos);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(902, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dashboard";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelIngresos
            // 
            labelIngresos.AutoSize = true;
            labelIngresos.Location = new Point(553, 326);
            labelIngresos.Name = "labelIngresos";
            labelIngresos.Size = new Size(120, 20);
            labelIngresos.TabIndex = 7;
            labelIngresos.Text = "Ingresos totales: ";
            // 
            // labelCajeros
            // 
            labelCajeros.AutoSize = true;
            labelCajeros.Location = new Point(553, 129);
            labelCajeros.Name = "labelCajeros";
            labelCajeros.Size = new Size(114, 20);
            labelCajeros.TabIndex = 6;
            labelCajeros.Text = "Cajeros totales: ";
            // 
            // labelVentas
            // 
            labelVentas.AutoSize = true;
            labelVentas.Location = new Point(148, 326);
            labelVentas.Name = "labelVentas";
            labelVentas.Size = new Size(108, 20);
            labelVentas.TabIndex = 5;
            labelVentas.Text = "Ventas totales: ";
            // 
            // labelProductos
            // 
            labelProductos.AutoSize = true;
            labelProductos.Location = new Point(148, 129);
            labelProductos.Name = "labelProductos";
            labelProductos.Size = new Size(131, 20);
            labelProductos.TabIndex = 4;
            labelProductos.Text = "Productos totales: ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(dgvAdminProducts);
            tabPage2.Controls.Add(button6);
            tabPage2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(902, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Productos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(192, 255, 255);
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = Color.Navy;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Navy;
            button5.Location = new Point(765, 34);
            button5.Name = "button5";
            button5.Size = new Size(94, 33);
            button5.TabIndex = 11;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(579, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 30);
            textBox3.TabIndex = 10;
            // 
            // dgvAdminProducts
            // 
            dgvAdminProducts.AllowUserToOrderColumns = true;
            dgvAdminProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAdminProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminProducts.Location = new Point(39, 99);
            dgvAdminProducts.Name = "dgvAdminProducts";
            dgvAdminProducts.RowHeadersWidth = 51;
            dgvAdminProducts.Size = new Size(820, 385);
            dgvAdminProducts.TabIndex = 9;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 255, 192);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.Green;
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.FromArgb(0, 64, 0);
            button6.Location = new Point(39, 34);
            button6.Name = "button6";
            button6.Size = new Size(91, 33);
            button6.TabIndex = 8;
            button6.Text = "Agregar";
            button6.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Controls.Add(button2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(902, 525);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Inventario";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 255);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(767, 37);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 7;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(581, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 27);
            textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(820, 385);
            dataGridView1.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Green;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0, 64, 0);
            button2.Location = new Point(41, 37);
            button2.Name = "button2";
            button2.Size = new Size(91, 33);
            button2.TabIndex = 4;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(dataGridView2);
            tabPage4.Controls.Add(button4);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(902, 525);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Cajeros";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 255, 255);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(767, 37);
            button3.Name = "button3";
            button3.Size = new Size(94, 33);
            button3.TabIndex = 7;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(581, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 27);
            textBox2.TabIndex = 6;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(41, 102);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(820, 385);
            dataGridView2.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 255, 192);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = Color.Green;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(0, 64, 0);
            button4.Location = new Point(41, 37);
            button4.Name = "button4";
            button4.Size = new Size(91, 33);
            button4.TabIndex = 4;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 642);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminProducts).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label labelIngresos;
        private Label labelCajeros;
        private Label labelVentas;
        private Label labelProductos;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private Button button4;
        private Button button5;
        private TextBox textBox3;
        private DataGridView dgvAdminProducts;
        private Button button6;
    }
}