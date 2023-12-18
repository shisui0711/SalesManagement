﻿using System.Windows.Forms.DataVisualization.Charting;
using QLCHBanHoaQuaWF.Models;

namespace QLCHBanHoaQuaWF.Views.Statistics
{
    public partial class frmStatistics : Form, IViewStatistics
    {
        public frmStatistics()
        {
            InitializeComponent();
        }

        public BindingSource TopProductBindingSource
        {
            get { return topProductBindingSource; }
        }
        public BindingSource TopCustomerBindingSource
        {
            get { return topCustomerBindingSource; }
        }

        public BindingSource TopEmployeeBindingSource
        {
            get { return topEmployeeBindingSource; }
        }
        public Chart RevenueChart
        {
            get { return chartRevenue; }
        }
        public Chart ProductChart
        {
            get { return chartProduct; }
        }
        public DateTime StartDate
        {
            get
            {
                if (btnCustom.Checked)
                {
                    return dtpStart.Value;
                }

                if (btn30day.Checked)
                {
                    return DateTime.Now.AddDays(-30);
                }

                if (btnToday.Checked)
                {
                    return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                }

                if (btn7day.Checked)
                {
                    return DateTime.Now.AddDays(-7);
                }

                if (btnThisMonth.Checked)
                {
                    return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                }

                if (btnYesterday.Checked)
                {
                    return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(-1).Day, 0, 0, 0);
                }

                if (btnThisWeek.Checked)
                {
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                    {
                        return DateTime.Now.AddDays(-6);
                    }
                    return DateTime.Now.AddDays(-(DateTime.Now.DayOfWeek - DayOfWeek.Monday));
                }

                return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0); ;
            }
            set { dtpStart.Value = value; }
        }
        public DateTime EndDate
        {
            get {
                if (btnCustom.Checked)
                {
                    return dtpEnd.Value;
                }
                return DateTime.Now;
            }
            set { dtpEnd.Value = value; }
        }
        public int SalesOrdered
        {
            get { return int.Parse(lblSalesOrdered.Text);}
            set { lblSalesOrdered.Text = value.ToString(); }
        }
        public int ImportOrdered
        {
            get { return int.Parse(lblImportOrdered.Text);}
            set { lblImportOrdered.Text = value.ToString(); }
        }
        public decimal Revenue
        {
            get { return decimal.Parse(lblRevenue.Text);}
            set { lblRevenue.Text = value.ToString(); }
        }
        public decimal Profit
        {
            get {return decimal.Parse(lblProfit.Text);}
            set { lblProfit.Text = value.ToString(); }
        }
        public int CountEmployee
        {
            get { return int.Parse(lblCountEmployee.Text);}
            set { lblCountEmployee.Text = value.ToString(); }
        }
        public int CountCustomer {
            get { return int.Parse(lblCountCustomer.Text); }
            set { lblCountCustomer.Text = value.ToString(); }
        }
        public int CountProvider {
            get { return int.Parse(lblCountProvider.Text); }
            set { lblCountProvider.Text = value.ToString(); }
        }
        public int CountProduct {
            get { return int.Parse(lblCountProduct.Text); }
            set { lblCountProduct.Text = value.ToString(); }
        }

        public event EventHandler LoadStatistics;
        public event EventHandler CountAnimation;

        private void frmStatistics_Load(object sender, EventArgs e)
        {
            LoadStatistics?.Invoke(sender,e);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            LoadStatistics?.Invoke(sender,e);
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            LoadStatistics?.Invoke(sender,e);
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            LoadStatistics?.Invoke(sender, e);
        }

        private void btn7day_Click(object sender, EventArgs e)
        {
            LoadStatistics?.Invoke(sender, e);
        }

        private void btn30day_Click(object sender, EventArgs e)
        {
            LoadStatistics?.Invoke(sender, e);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            LoadStatistics?.Invoke(sender, e);
        }

        private void btnCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCustom.Checked)
            {
                dtpStart.Visible = true;
                dtpEnd.Visible = true;
                btnConfirm.Visible = true;
            }
            else
            {
                dtpStart.Visible = false;
                dtpEnd.Visible = false;
                btnConfirm.Visible = false;
            }
        }

    }
}
