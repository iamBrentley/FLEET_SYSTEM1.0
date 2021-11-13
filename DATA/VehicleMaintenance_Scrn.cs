using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace FLEET_SYSTEM1._0
{
    public partial class VehicleMaintenance_Scrn : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WILDatabase.mdf;Integrated Security=True;Connect Timeout=30");


        public VehicleMaintenance_Scrn()
        {
            InitializeComponent();
        }

        private void threadCool() 
        {
            Thread.Sleep(300);
        }
        private void buttonSeize() 
        {
            btnShow.Enabled = false;
            btnSite_GAU.Enabled = false;
            btnSite_KZN.Enabled = false;
            btnSite_CPT.Enabled = false;
            btnSite_LIM.Enabled = false;

            threadCool();

            btnShow.Enabled = true;
            btnSite_GAU.Enabled = true;
            btnSite_KZN.Enabled = true;
            btnSite_CPT.Enabled = true;
            btnSite_LIM.Enabled = true;
        }
        private void VehicleMaintenance_Scrn_Load(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT VehicleID, CompanyID, SiteID, CargoTypeID, VehicleName, VehicleType, DriverID FROM dbo.Vehicle", con);
                DataTable dtbl = new DataTable("Vehicle");
                ada.Fill(dtbl);
                gridCompVehicles.DataSource = dtbl.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish connection to the server\n" +
                    "", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            buttonSeize();

            try
            {
                con.Open();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT VehicleID, CompanyID, SiteID, CargoTypeID, VehicleName, VehicleType, DriverID FROM dbo.Vehicle", con);
                DataTable dtbl = new DataTable("Vehicle");
                ada.Fill(dtbl);
                gridCompVehicles.DataSource = dtbl.DefaultView;
                //gridCompVehicles.DataSource = dtbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish connection to the server\n" +
                   "", ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void btnSite_GAU_Click(object sender, EventArgs e)
        {
            buttonSeize();
            try
            {
                con.Open();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT VehicleID, CompanyID, SiteID, CargoTypeID, VehicleName, VehicleType FROM dbo.Vehicle WHERE SiteID = 'ST_GAU'", con);
                DataTable dtbl = new DataTable("Vehicle");
                ada.Fill(dtbl);
                gridCompVehicles.DataSource = dtbl.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish connection to the server\n" +
                  "", ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnSite_KZN_Click(object sender, EventArgs e)
        {
            buttonSeize();
            try
            {
                con.Open();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT VehicleID, CompanyID, SiteID, CargoTypeID, VehicleName, VehicleType FROM dbo.Vehicle WHERE SiteID = 'ST_KZN'", con);
                DataTable dtbl = new DataTable("Vehicle");
                ada.Fill(dtbl);
                gridCompVehicles.DataSource = dtbl.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish connection to the server\n" +
                  "", ex.Message);
                
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSite_CPT_Click(object sender, EventArgs e)
        {
            buttonSeize();
            try
            {
                con.Open();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT VehicleID, CompanyID, SiteID, CargoTypeID, VehicleName, VehicleType FROM dbo.Vehicle WHERE SiteID = 'ST_CPT'", con);
                DataTable dtbl = new DataTable("Vehicle");
                ada.Fill(dtbl);
                gridCompVehicles.DataSource = dtbl.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish connection to the server\n" +
                  "", ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void btnSite_LIM_Click(object sender, EventArgs e)
        {
            buttonSeize();
            try
            {
                con.Open();
                SqlDataAdapter ada = new SqlDataAdapter("SELECT VehicleID, CompanyID, SiteID, CargoTypeID, VehicleName, VehicleType FROM dbo.Vehicle WHERE SiteID = 'ST_LIM'", con);
                DataTable dtbl = new DataTable("Vehicle");
                ada.Fill(dtbl);
                gridCompVehicles.DataSource = dtbl.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to establish connection to the server\n" +
                  "", ex.Message);

            }
            finally
            {
                con.Close();
            }
        }
    }
}
