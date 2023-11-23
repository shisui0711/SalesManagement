using Guna.UI2.WinForms;
using QLCHBanHoaQuaWF.Presenters;
using System.Text.RegularExpressions;

namespace QLCHBanHoaQuaWF.Views.ImportOrder
{
    public partial class frmAddImportOrder : Form, IAddImportOrder
    {
        private int _quantityBackup;
        public frmAddImportOrder()
        {
            InitializeComponent();
        }

        public string ProviderSearchText
        {
            get { return txtProviderSearch.Text; }
            set { txtProviderSearch.Text = value; }
        }
        public string? ProductSearchText
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        public decimal TotalPrice
        {
            get { return decimal.Parse(lblTotalPrice.Text); }
            set { lblTotalPrice.Text = value.ToString(); }
        }
        public int EmployeeID
        {
            get { return AuthPresenter.User.EmployeeID; }
        }
        public int ProviderID
        {
            get { return int.Parse(lsbProvider.SelectedValue!.ToString()!); }
        }
        public void AddControl(Control control)
        {
            pnlProduct.Controls.Add(control);
        }

        public void ClearControl()
        {
            pnlProduct.Controls.Clear();
        }

        public DataGridView OrderedGridView
        {
            get { return dgvProductSelect; }
            set { dgvProductSelect = value as Guna2DataGridView; }
        }
        public event EventHandler<DataGridViewCellEventArgs>? RemoveProduct;

        public BindingSource ProviderBindingSource
        {
            get { return providerBindingSource; }
        }
        public event EventHandler? LoadProduct;
        public event EventHandler? LoadProvider;
        public event EventHandler? SearchProvider;
        public event EventHandler? SearchProduct;
        public event EventHandler? AddImportOrder;

        private void frmAddImportOrder_Resize(object sender, EventArgs e)
        {
            pnlBodyLeft.Width = this.Width * 2 / 5;
        }

        private void dgvProductSelect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductSelect.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvProductSelect.ColumnCount - 3)
                {
                    var cells = dgvProductSelect.Rows[e.RowIndex].Cells;
                    var quantity = int.Parse(cells["QuantityColumn"].Value.ToString());
                    if (quantity > 1)
                    {
                        cells["QuantityColumn"].Value = quantity - 1;
                        cells["TotalPriceColumn"].Value = decimal.Parse(cells["UnitPriceColumn"].Value.ToString()!) * (quantity - 1);
                    }
                }
                if (e.ColumnIndex == dgvProductSelect.ColumnCount - 2)
                {
                    var cells = dgvProductSelect.Rows[e.RowIndex].Cells;
                    cells["QuantityColumn"].Value = int.Parse(cells["QuantityColumn"].Value.ToString()) + 1;
                    cells["TotalPriceColumn"].Value = decimal.Parse(cells["UnitPriceColumn"].Value.ToString()!) * int.Parse(cells["QuantityColumn"].Value.ToString());
                }



                if (e.ColumnIndex == dgvProductSelect.ColumnCount - 1)
                {
                    RemoveProduct?.Invoke(sender, e);
                }
            }
        }

        private void dgvProductSelect_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string? cellValue = dgvProductSelect.Rows[e.RowIndex].Cells["QuantityColumn"].Value.ToString();
            if (!Regex.IsMatch(cellValue ?? string.Empty, @"\d+") || int.Parse(cellValue) < 1)
            {
                dgvProductSelect.Rows[e.RowIndex].Cells["QuantityColumn"].Value = _quantityBackup;
                MessageBox.Show("Số lượng không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var rowSeleted = dgvProductSelect.Rows[e.RowIndex];
            var unitPrice = decimal.Parse(rowSeleted.Cells["UnitPriceColumn"].Value.ToString()!);
            var quantity = decimal.Parse(rowSeleted.Cells["QuantityColumn"].Value.ToString());
            rowSeleted.Cells["TotalPriceColumn"].Value = unitPrice * quantity;
        }

        private void dgvProductSelect_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _quantityBackup = int.Parse(dgvProductSelect.Rows[e.RowIndex].Cells["QuantityColumn"].Value.ToString()!);
        }

        private void dgvProductSelect_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductSelect.RowCount == 0)
            {
                return;
            }

            ReCalculateTotalPrice();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddImportOrder_Load(object sender, EventArgs e)
        {
            LoadProduct?.Invoke(sender, e);
            LoadProvider?.Invoke(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddImportOrder?.Invoke(sender, e);
        }

        private void dgvProductSelect_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ReCalculateTotalPrice();
        }

        private void dgvProductSelect_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvProductSelect.RowCount == 0)
            {
                lblTotalPrice.Text = "0";
                return;
            }
            ReCalculateTotalPrice();
        }

        private void ReCalculateTotalPrice()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgvProductSelect.Rows)
            {
                sum += decimal.Parse(row.Cells["TotalPriceColumn"].Value.ToString());
            }

            lblTotalPrice.Text = sum.ToString();
        }
    }
}
