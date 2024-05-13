using QLCHWF.CustomMessageBox;

namespace QLCHWF.Views.Provider
{
    public partial class frmViewProvider : Form, IViewProvider
    {
        public string SearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public int OptionIndex
        {
            get { return cboOptionSearch.SelectedIndex; }
            set { cboOptionSearch.SelectedIndex = value; }
        }

        public BindingSource ProviderBindingSource
        {
            get { return providerBindingSource; }
        }
        public event EventHandler? RemoveProvider;
        public event EventHandler? LoadProvider;
        public event EventHandler? SearchProvider;
        public event EventHandler? ShowAddProvider;
        public event EventHandler? ShowUpdateProvider;
        public event EventHandler ShowOrderHistory;

        public frmViewProvider()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProvider?.Invoke(sender, e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadProvider?.Invoke(sender, e);
        }

        private void frmViewProvider_Load(object sender, EventArgs e)
        {
            LoadProvider?.Invoke(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAddProvider?.Invoke(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ShowUpdateProvider?.Invoke(sender, e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var dialogResult = MyMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            RemoveProvider?.Invoke(sender, e);
        }

        private void btnHistoryImport_Click(object sender, EventArgs e)
        {
            ShowOrderHistory?.Invoke(sender,e);
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
