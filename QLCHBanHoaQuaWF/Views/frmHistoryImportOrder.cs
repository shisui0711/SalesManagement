using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF.Views
{
    public partial class frmHistoryImportOrder : Form, IHistoryImport
    {
        public frmHistoryImportOrder()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public BindingSource ImportBindingSource
        {
            get { return importOrderBindingSource; }
        }
    }
}
