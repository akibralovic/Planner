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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PlannerDB;Integrated Security=True");


        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            String obl, time, start, end;
            
            obl = this.obligationTxt.Text;
            time = this.timeTxt.Text;
            start = this.startDateTxt.Text;
            end = this.endDateTxt.Text;


            try
            {//OTVARANJE KONEKCIJE SA BAZOM
                con.Open();
                if (obl != "" && time != "" && start != "" && end != "")
                {//POSTAVLJANJE UPITA BAZI ZA UBACIVANJE VREDNOSTI SPECIFICIRANIH U TEXTBOX KONTOLAMA U TABELU Artikli

                    SqlCommand command = new SqlCommand("INSERT INTO Obaveze (Obligation, Time, StartDate, EndDate) values (@o, @t, @s, @e)", con);

                    command.Parameters.Add("@o", SqlDbType.NVarChar, 50).Value = obl;
                    command.Parameters.Add("@t", SqlDbType.Time, 7).Value = time;
                    command.Parameters.Add("@s", SqlDbType.Date).Value = start;
                    command.Parameters.Add("@e", SqlDbType.Date).Value = end;
                    int i = command.ExecuteNonQuery();
                    if (i >= 1)
                        MessageBox.Show("Uspesno unete !");
                    else
                        MessageBox.Show("Neuspesno izmenjen artikal!");
                }
                else if (obl == "" || time == "" || start == "" || end == "")
                {
                    MessageBox.Show("Morate uneti sve podatke o obavezi!");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Unos podataka o obavezi nije uspeo, pokusajte ponovo!");
            }
            finally
            {
                con.Close();
            }
        }

        private void bkBtn_Click(object sender, EventArgs e)
        {
            PlannerMain planner = new PlannerMain();
            planner.Show();
            this.Close();
        }
    }
}

