using System.Reflection;
using QLCHWF.CustomMessageBox;

namespace QLCHWF.Views.Employee
{
    public partial class frmAddEmployee : Form, IAddEmployee
    {
        public string EmployeeName
        {
            get { return txtEmployeeName.Text; }
            set { txtEmployeeName.Text = value; }
        }
        public string Email
        {
            get { return txtEmail.Text; }
            set { txtAddress.Text = value; }
        }
        public string Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }
        public string Address
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }
        public decimal? Salary
        {
            get
            {
                try
                {
                    return decimal.Parse(txtSalary.Text);
                }
                catch
                {
                    return null;
                }
            }
            set { txtSalary.Text = value.ToString(); }
        }

        public void Reset()
        {
            var fieldTypes = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f => f.Name.StartsWith("txt"));
            foreach (var fieldType in fieldTypes)
            {
                UserControl control = (UserControl)fieldType.GetValue(this)!;
                control.Text = String.Empty;
            }
        }

        public event EventHandler? AddEmployee;

        public void Focus(string name)
        {
            var textBoxField = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(x => x.Name == "txt" + name).FirstOrDefault();
            if (textBoxField != null)
            {
                var textBox = (UserControl)textBoxField.GetValue(this)!;
                textBox.Focus();
            }
        }
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee?.Invoke(sender, e);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

        }

        public void ShowMessage(string message)
        {
            MyMessageBox.Show(message);
        }
    }
}
