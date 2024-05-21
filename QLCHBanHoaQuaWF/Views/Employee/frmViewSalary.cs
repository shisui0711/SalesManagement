using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCHWF.CustomMessageBox;
using QLCHWF.Extensions;

namespace QLCHWF.Views.Employee
{
    public partial class frmViewSalary : Form,IViewSalary
    {
        public frmViewSalary()
        {
            InitializeComponent();
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Now;
        }

        public DateTime StartDate
        {
            get { return dtpStart.Value; }
        }
        public DateTime EndDate
        {
            get { return dtpEnd.Value; }
        }

        public BindingSource SalaryBindingSource
        {
            get { return salaryTableBindingSource; }
        }
        public event EventHandler CalculateSalary;

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            CalculateSalary?.Invoke(sender,e);
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dgvSalary.ExportToExcel(saveFileDialog.FileName);
                    MyMessageBox.Show(@"Xuất file thành công");
                }
                catch (Exception exception)
                {
                    MyMessageBox.Show($"Lỗi: {exception.Message}");
                }
            }
        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
