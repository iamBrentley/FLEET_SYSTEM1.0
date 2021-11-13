using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLEET_SYSTEM1._0
{
    public partial class HomeWindow : System.Windows.Forms.Form
    {
        public HomeWindow()
        {
            InitializeComponent();
            SidePanel.Height = btnVehicles.Height;
            SidePanel.Top = btnVehicles.Top;
            vehicleMaintenance_Scrn1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTripsUsage.Height;
            SidePanel.Top = btnTripsUsage.Top;
            tripsAndUsage_Scrn1.BringToFront();
        }

        private void btnVehicleMaintenanceRec_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnVehicles.Height;
            SidePanel.Top = btnVehicles.Top;
            vehicleMaintenance_Scrn1.BringToFront();
        }

        private void btnServiceSchedule_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnServiceSchedule.Height;
            SidePanel.Top = btnServiceSchedule.Top;
            serviceScheduling_Scrn1.BringToFront();
        }

        private void btnTimesheetManage_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTimesheetManage.Height;
            SidePanel.Top = btnTimesheetManage.Top;
            timesheetManagement_Scrn1.BringToFront();
        }

        private void btnDriversAndFleet_Click(object sender, EventArgs e)
        {
            //SidePanel.Height = btnDriversAndFleet.Height;
            //SidePanel.Top = btnDriversAndFleet.Top;
            //driversAndFleet_Scrn1.BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Maximized;
          
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SignUpPage signup = new SignUpPage();
            signup.Show();
            this.Close();
        }

        public static HomeWindow home = new HomeWindow();

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpPage SignUp = new SignUpPage();
            SignUp.Show();
            this.Dispose();

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            //SidePanel.Height = btnOrders.Height;
            //SidePanel.Top = btnOrders.Top;
            //orders_scrn1.BringToFront();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
