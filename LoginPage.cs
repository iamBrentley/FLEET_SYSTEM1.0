using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FLEET_SYSTEM1._0
{
    public partial class LoginPage : Form
    {
        string LoggedUsersID;
        string LoggedUsersName;
        string LoggedUsersSurname;
        string LoggedUsersPosition;
        //Connectionstring
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\FLEET_SYSTEM1.0\WILDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginPage()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUpPage signup = new SignUpPage();
            signup.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            //Checking if any information was entered
            if (txtUsername.Text != "" || txtPassword.Text != "")
            {
                //Dataadapter object
                SqlDataAdapter adpt;

                adpt = new SqlDataAdapter("select Users.UserID, Employees.EmployeeName, Employees.EmployeeSurname, Employees.EmployeePosition from Users, Employees where Users.Username = '" + txtUsername.Text + "' and Users.Password = '" + txtPassword.Text + "' and Users.UserID = Employees.EmployeeID", connect);

                //Storing the data in a data table
                DataTable dt = new DataTable();

                adpt.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("User has been found\n" +
                        "User id: " + dt.Rows[0][0] + "\n" +
                        "User name: " + dt.Rows[0][1] + "\n" +
                        "User surname: " + dt.Rows[0][2] + "\n" +
                        "User postion: " + dt.Rows[0][3] + "\n");

                    //Storing the user in the custom class library
                    LoggedUsersID = dt.Rows[0][0].ToString();
                    LoggedUsersName = dt.Rows[0][1].ToString();
                    LoggedUsersSurname = dt.Rows[0][2].ToString();
                    LoggedUsersPosition = dt.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("Couldn't log in please enter valid information");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the required information");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //Opening the connection
            connect.Open();

            if (connect.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection Successful");
            }
            else
            {
                MessageBox.Show("An Error has occurred", "Failed to Connect", MessageBoxButtons.OK);
            }

            //try
            //{
            //    Library.Connection.connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Z:\WILDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
