using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoVenta.Business.Services;

namespace PuntoVenta.Views
{
    public partial class Admin : Form
    {
        private readonly ProductService _productService;
        public Admin(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }
        public Admin()
        {
            InitializeComponent();
        }

        private async void Admin_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = await _productService.GetAll();
        }
    }
}
