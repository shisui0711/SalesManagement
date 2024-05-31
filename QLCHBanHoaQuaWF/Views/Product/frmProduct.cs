using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHWF.Models;

namespace QLCHWF.Views.Product
{
    public partial class frmProduct : Form
    {
        public Models.Product Product
        {
            get { return _product; }
        }

        public event EventHandler? Clicked;
        private readonly Models.Product _product;
        public frmProduct(Models.Product product,EProductMode mode)
        {
            InitializeComponent();
            _product = product;
            if (mode == EProductMode.Import)
            {
                lblMode.Text = "Giá nhập";
                lblUnitPrice.Text = _product.ImportUnitPrice.ToString();
            }
            else if (mode == EProductMode.Sales)
            {
                lblMode.Text = "Giá bán";
                lblUnitPrice.Text = _product.UnitPrice.ToString();
            }
            if (product.ImageData == null)
            {
                ptbProduct.Image = ptbProduct.ErrorImage;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(product.ImageData))
                {
                    ptbProduct.Image = Image.FromStream(ms);
                }
            }
            lblProductName.Text = _product.ProductName;
            lblInventory.Text = _product.Inventory.ToString();

            lblProductName.Click += pnlProduct_Click;
            lblUnitPrice.Click += pnlProduct_Click;
            lblInventory.Click += pnlProduct_Click;
            lbl1.Click += pnlProduct_Click;
            lblMode.Click += pnlProduct_Click;
            ptbProduct.Click += pnlProduct_Click;
        }
        public frmProduct(Models.Product product)
        {
            InitializeComponent();
            _product = product;
            if (product.ImageData == null)
            {
                ptbProduct.Image = ptbProduct.ErrorImage;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream(product.ImageData))
                {
                    ptbProduct.Image = Image.FromStream(ms);
                }
            }
            lblProductName.Text = _product.ProductName;
            lblUnitPrice.Text = _product.UnitPrice.ToString();
            lblInventory.Text = _product.Inventory.ToString();

            lblProductName.Click += pnlProduct_Click;
            lblUnitPrice.Click += pnlProduct_Click;
            lblInventory.Click += pnlProduct_Click;
            lbl1.Click += pnlProduct_Click;
            lblMode.Click += pnlProduct_Click;
            ptbProduct.Click += pnlProduct_Click;
        }

        private void pnlProduct_Click(object? sender, EventArgs e)
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
