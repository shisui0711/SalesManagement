using QLCHWF.CustomMessageBox;

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
            var dialogResult = MyMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            RemoveProduct?.Invoke(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProduct?.Invoke(this, EventArgs.Empty);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
        public int CurrentPage
        {
            get
            {
                try
                {
                    return int.Parse(btnCurrentPage.Text);
                }
                catch
                {
                    return 0;
                }
            }
            set { btnCurrentPage.Text = value.ToString(); }
        }
        public event EventHandler? PreviousPage;
        public event EventHandler? NextPage;
        public void DisableNextPage()
        {
            btnNext.Enabled = false;
        }

        public void DisablePreviousPage()
        {
            btnPrevious.Enabled = false;
        }

        public void EnablePreviousPage()
        {
            btnPrevious.Enabled = true;
        }

        public void EnableNextPage()
        {
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextPage?.Invoke(sender, e);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousPage?.Invoke(sender, e);
        }

    }
}
