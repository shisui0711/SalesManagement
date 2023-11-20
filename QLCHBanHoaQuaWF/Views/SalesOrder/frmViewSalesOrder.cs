using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views.SalesOrder
{
    public partial class frmViewSalesOrder : Form,IViewSalesOrder
    {
        public frmViewSalesOrder()
        {
            InitializeComponent();
        }

        public string SearchText
        {
            get { return txtSearch.Text;}
            set { txtSearch.Text = value; }
        }

        public int OptionIndex
        {
            get { return cboOptionSearch.SelectedIndex;}
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
            get { return salesOrderBindingSource; }
        }
        public event EventHandler? LoadSalesOrder;
        public event EventHandler? RemoveSalesOrder;
        public event EventHandler? SearchSalesOrder;
        public event EventHandler? ShowAdd;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAdd?.Invoke(sender,e);
        }

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
            }
        }

        private void frmViewSalesOrder_Load(object sender, EventArgs e)
        {
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.ExportToExcel(dgvSalesOrder, saveFileDialog.FileName);
                MessageBox.Show("Xuất thành công!");
            }
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx";
            openFileDialog.Title = "Select an Excel File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.ImportFromExcel(dgvSalesOrder,openFileDialog.FileName);
                MessageBox.Show("Nhập thành công");
            }
        }
    }
}
