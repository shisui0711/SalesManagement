using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QLCHBanHoaQuaWF.Views.Customer;
using QLCHBanHoaQuaWF.Views.Employee;
using QLCHBanHoaQuaWF.Views.Product;

namespace QLCHBanHoaQuaWF.Views
{
    public partial class frmMain : Form,IViewMain
    {
        public TabControl NavigationBar
        {
            get { return tbcNav; }
        }
        public event EventHandler? LoadPages;
        public event EventHandler? Logout;
        private bool IsLogout;
        private IViewCustomer _viewCustomer;
        private IViewEmployee _viewEmployee;
        private IViewProduct _viewProduct;
        public frmMain(IViewCustomer viewCustomer,IViewEmployee viewEmployee,IViewProduct viewProduct)
        {
            InitializeComponent();
            _viewCustomer = viewCustomer;
            _viewEmployee = viewEmployee;
            _viewProduct = viewProduct;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadPages?.Invoke(sender,e);
            //IsLogout = false;
            //Form Customer
            //var formCustomer = _viewCustomer as Form;
            //if (formCustomer != null)
            //{
            //    formCustomer.TopLevel = false;
            //    tabCustomer.Controls.Add(formCustomer);
            //    formCustomer.Dock = DockStyle.Fill;
            //    formCustomer.Show();
            //}

            //Form Employee
            //var formEmployee = _viewEmployee as Form;
            //if (formEmployee != null)
            //{
            //    formEmployee.TopLevel = false;
            //    tabEmployee.Controls.Add(formEmployee);
            //    formEmployee.Dock = DockStyle.Fill;
            //    formEmployee.Show();
            //}

            //Form Product
            //var formProduct = _viewProduct as Form;
            //if (formProduct != null)
            //{
            //    formProduct.TopLevel = false;
            //    tabProduct.Controls.Add(formProduct);
            //    formProduct.Dock = DockStyle.Fill;
            //    formProduct.Show();
            //}
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLogout)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            IsLogout = true;
            this.Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {

        }
    }
}
