using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Planner
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlannerDB;Integrated Security=True");


        private void clearBtn_Click(object sender, EventArgs e)
        {
            userTbt.Clear();
            passwordTbt.Clear();

            userTbt.Focus();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            String username, password;
            username = userTbt.Text;
            password = passwordTbt.Text;

            try
            {
                String querry = "select * from login where username = '" + userTbt.Text + "'and  password='" + passwordTbt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = userTbt.Text;
                    password = passwordTbt.Text;

                    //page that needed to be load next
                    PlannerMain planner = new PlannerMain();

                    planner.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userTbt.Clear();
                    passwordTbt.Clear();

                    //to focus username
                    userTbt.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void singinBtn_Click(object sender, EventArgs e)
        {
            if(userTbt.Text =="" && passwordTbt.Text == "")
            {
                MessageBox.Show("Username and password fiels are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(passwordTbt.Text == conpasswordTbt.Text)
            {
                con.Open();
                string singin = "insert into login values ('" + userTbt.Text + "','" + passwordTbt.Text + "')";
                SqlCommand scm = new SqlCommand(singin, con);
                scm.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your account has beed succesfully created", "Sing in success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Password does not match, Please re-enter", "Sing in failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTbt.Text = "";
                conpasswordTbt.Text = "";
                passwordTbt.Focus();
            }

        }

    }
}
