using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHWF.Views.Employee
{
    public partial class frmViewSalary : Form,IViewSalary
    {
        public frmViewSalary()
        {
            InitializeComponent();
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
                dgvSalary.ExportToExcel(saveFileDialog.FileName);
                MessageBox.Show(@"Xuất thành công!");
            }
        }
    }
}
