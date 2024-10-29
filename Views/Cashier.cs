using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVenta.Views
{
    public partial class Cashier : Form
    {
        private ApplicationDbContext? _context;
        public Cashier()
        {
            InitializeComponent();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            _context = new ApplicationDbContext();
            this._context.Products.Load();
            dgvProducts.DataSource = _context.Products.Local.ToBindingList();
        }
    }
}
