using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_System.UserControls;

namespace POS_System
{
    public partial class Report : Form
    {
        UserControls.SalesReport salesR = new UserControls.SalesReport();
        UserControls.StockMovementReport stockMovementR = new UserControls.StockMovementReport();
        UserControls.CustomerActivityReport customerActivityR = new UserControls.CustomerActivityReport();

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(salesR);
            salesR.Dock = DockStyle.Fill;

            pnlSel.Width = btnSR.Width;
            pnlSel.Height = 5;
            pnlSel.Top = btnSR.Bottom - pnlSel.Height - 1;
            pnlSel.Left = btnSR.Left;
        }

        private void btnSR_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(salesR);
            salesR.Dock = DockStyle.Fill;

            pnlSel.Width = btnSR.Width;
            pnlSel.Height = 5;
            pnlSel.Top = btnSR.Bottom - pnlSel.Height - 1;
            pnlSel.Left = btnSR.Left;
        }

        private void btnCAR_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(customerActivityR);
            customerActivityR.Dock = DockStyle.Fill;

            pnlSel.Width = btnCAR.Width;
            pnlSel.Height = 5;
            pnlSel.Top = btnCAR.Bottom - pnlSel.Height - 1;
            pnlSel.Left = btnCAR.Left;
        }

        private void btnSMR_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(stockMovementR);
            stockMovementR.Dock = DockStyle.Fill;


            pnlSel.Width = btnSMR.Width;
            pnlSel.Height = 5;
            pnlSel.Top = btnSMR.Bottom - pnlSel.Height - 1;
            pnlSel.Left = btnSMR.Left;
        }
    }
}
