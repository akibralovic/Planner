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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlannerDB;Integrated Security=True");
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            String num;
            num = numberTxt.Text;
      
            try
            {
                con.Open();
                if (num != "") {
                    //POSTAVLJANJE UPITA BAZI ZA UBACIVANJE VREDNOSTI 
                    //SPECIFICIRANIH U TEXTBOX KONTOLAMA U TABELU obaveze

                    SqlCommand command = new SqlCommand("DELETE FROM Obaveze WHERE Number = @n", con);

                    command.Parameters.Add("@n", SqlDbType.Int).Value = num;

                    command.ExecuteNonQuery(); 
                }
                    

                else if (num == "")
                {
                    MessageBox.Show("Morate uneti ID artikla, cije podatke zelite da brisete!"); 
                }
                else 
                { 
                    throw new Exception(); 
                }

            }
            catch
            {
                MessageBox.Show("Unos podataka o novim obavezama nije uspeo, pokusajte ponovo!");
            }
            finally
            {
                con.Close();
                PlannerMain planner = new PlannerMain();

                planner.Show();
                this.Hide();


            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PlannerMain planner = new PlannerMain();
            planner.Show();
            this.Hide();
        }

        private void Delete_Load(object sender, EventArgs e)
        {

        }
    }
}
