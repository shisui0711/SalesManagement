using System.IO;

namespace QLCHBanHoaQuaWF.Views.Product
{
    public partial class frmProduct : Form
    {
        public Models.Product Product
        {
            get { return _product; }
        }

        public event EventHandler? Clicked;
        private readonly Models.Product _product;
        public frmProduct(Models.Product product)
        {
            InitializeComponent();
            _product = product;
            using (MemoryStream ms = new MemoryStream(product.ImageData))
            {
                ptbProduct.Image = Image.FromStream(ms);
            }

            lblProductName.Text = _product.ProductName;
            lblUnitPrice.Text = _product.UnitPrice.ToString();
            lblInventory.Text = _product.Inventory.ToString();

            lblProductName.Click += pnlProduct_Click;
            lblUnitPrice.Click += pnlProduct_Click;
            lblInventory.Click += pnlProduct_Click;
            lbl1.Click += pnlProduct_Click;
            lbl2.Click += pnlProduct_Click;
            ptbProduct.Click += pnlProduct_Click;
        }

        private void pnlProduct_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
