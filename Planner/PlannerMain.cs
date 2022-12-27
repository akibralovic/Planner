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
    public partial class PlannerMain : Form
    {
        public PlannerMain()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlannerDB;Integrated Security=True");

        private void PlannerMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plannerDBDataSet.Obaveze' table. You can move, or remove it, as needed.
            this.obavezeTableAdapter.Fill(this.plannerDBDataSet.Obaveze);
            // TODO: This line of code loads data into the 'plannerDBDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.plannerDBDataSet.login);

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            this.Hide();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter dp = new SqlDataAdapter("SELECT * FROM Obaveze", con);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Update upd = new Update();
            upd.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Delete del = new Delete();
            del.Show();
            this.Hide();
        }
    }
}
