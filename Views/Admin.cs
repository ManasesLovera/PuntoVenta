using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Microsoft.EntityFrameworkCore;
using PuntoVenta.Business.Services;

namespace PuntoVenta.Views
{
    public partial class Admin : Form
    {
        private ApplicationDbContext? _context;
        public Admin()
        {
            InitializeComponent();
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            _context = new ApplicationDbContext();
            this._context.Products.Load();
            dgvAdminProducts.DataSource = _context.Products.Local.ToBindingList();
        }
    }
}
