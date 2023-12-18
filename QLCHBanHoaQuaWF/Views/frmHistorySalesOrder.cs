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
    public partial class frmHistorySalesOrder : Form, IHistorySales
    {
        public frmHistorySalesOrder()
        {
            InitializeComponent();
        }

        public BindingSource SalesBindingSource
        {
            get { return salesOrderBindingSource; }
        }
    }
}
