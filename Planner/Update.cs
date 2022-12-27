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

namespace Planner
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlannerDB;Integrated Security=True");

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            String num, obl, time, start, end;
            num = numberTxt.Text;
            obl = obligationTxt.Text;
            time = timeTxt.Text;
            start = startDateTxt.Text;
            end = endDateTxt.Text;

            con.Open();
            SqlCommand command = new SqlCommand("UPDATE Obaveze SET Obligation= @o,Time = @t, StartDate = @s, EndDate = @e WHERE Number = @n", con);
            command.Parameters.Add("@n", SqlDbType.Int).Value = num;
            command.Parameters.Add("@o", SqlDbType.NVarChar).Value = obl;
            command.Parameters.Add("@t", SqlDbType.Time).Value = time;
            command.Parameters.Add("@s", SqlDbType.Date).Value = start;
            command.Parameters.Add("@e", SqlDbType.Date).Value = end;
            command.ExecuteNonQuery();

            PlannerMain planner = new PlannerMain();

            planner.Show();
            this.Hide();
            con.Close();

        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PlannerMain planner = new PlannerMain();
            planner.Show();
            this.Hide();
        }
    }
}
