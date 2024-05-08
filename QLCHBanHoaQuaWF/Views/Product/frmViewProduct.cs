namespace QLCHWF.Views.Product
{
    public partial class frmViewProduct : Form, IViewProduct
    {
        public string SearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        public BindingSource ProductBindingSource
        {
            get { return productBindingSource; }
        }
        public event EventHandler? RemoveProduct;

        public event EventHandler? LoadProduct;

        public event EventHandler? SearchProduct;

        public event EventHandler? ShowAddProduct;
        public event EventHandler? ShowUpdateProduct;
        public frmViewProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddProduct?.Invoke(sender, e);
        }

        private void frmViewProduct_Load(object sender, EventArgs e)
        {
            LoadProduct?.Invoke(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadProduct?.Invoke(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateProduct?.Invoke(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveProduct?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProduct?.Invoke(this, EventArgs.Empty);
        }
    }
}
