using QLCHWF.CustomMessageBox;
using QLCHWF.Presenters;

namespace QLCHWF.Views.ImportOrder
{
    public partial class frmViewImportOrder : Form, IViewImportOrder
    {
        public frmViewImportOrder()
        {
            InitializeComponent();
        }

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

        public DateTime DateStart
        {
            get
            {
                switch (cboDateCreated.SelectedIndex)
                {
                    case 1:
                        return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    case 2:
                        return DateTime.Now.AddDays(-1);
                    case 3:
                        return DateTime.Now.AddDays(-14);
                    case 4:
                        return DateTime.Now.AddDays(-7);
                    case 5:
                        return DateTime.Now.AddMonths(-1);
                    case 6:
                        return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
                    case 7:
                        return dtpStart.Value;
                    default:
                        return DateTime.MinValue;
                }
            }
        }

        public DateTime DateEnd
        {
            get
            {
                switch (cboDateCreated.SelectedIndex)
                {
                    case 7:
                        return dtpEnd.Value;
                    default:
                        return DateTime.Now;
                }
            }
        }
        public BindingSource OrderBindingSource
        {
            get { return importOrderBindingSource; }
        }
        public event EventHandler? LoadImportOrder;
        public event EventHandler? RemoveImportOrder;
        public event EventHandler? SearchImportOrder;
        public event EventHandler? ShowAdd;
        public event EventHandler? ShowReport;
        public event EventHandler ShowDetail;

        private void cboDateCreated_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDateCreated.SelectedIndex == 7)
            {
                dtpStart.Visible = true;
                dtpEnd.Visible = true;
            }
            else
            {
                dtpStart.Visible = false;
                dtpEnd.Visible = false;
                SearchImportOrder?.Invoke(sender,e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAdd?.Invoke(sender, e);
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            if (AuthPresenter.User != null)
            {
                if (AuthPresenter.User.UserRole.Permission.CanExportImportOrder == false)
                {
                    MyMessageBox.Show(@"Bạn không có quyền này.");
                    return;
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dgvImportOrder.ExportToExcel(saveFileDialog.FileName);
                MyMessageBox.Show(@"Xuất thành công!");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ShowReport?.Invoke(sender, e);
        }

        private void frmViewImportOrder_Load(object sender, EventArgs e)
        {
            LoadImportOrder?.Invoke(sender,e);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadImportOrder?.Invoke(sender,e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchImportOrder?.Invoke(sender,e);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ShowDetail?.Invoke(sender,e);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var dialogResult = MyMessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi đã chọn ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            RemoveImportOrder?.Invoke(sender,e);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchImportOrder?.Invoke(sender,e);
            }
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
