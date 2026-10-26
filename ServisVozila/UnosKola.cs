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

namespace ServisVozila
{
    public partial class UnosKola : Form
    {
        SqlConnection conn = null;
        public UnosKola()
        {
            string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""M:\alatcici\visual sstuidio dump\ServisVozila\Database1.mdf"";Integrated Security=True";
            conn = new SqlConnection(connect);
            InitializeComponent();
        }
        void Reset()
        {
            tbIme.Clear();
            tbPrezime.Clear();
            tbMail.Clear();
        }


        private void UnosKola_Load(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                string query = "select klijentid,ime,prezime,email from klijenti";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader sql = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (sql.Read())
                {
                    listView1.Items.Add(new ListViewItem(new[] { sql[0].ToString(), sql[1].ToString(), sql[2].ToString(), sql[3].ToString() }));
                }


                conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                tbID.Text = listView1.SelectedItems[0].SubItems[0].Text;
                tbIme.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbPrezime.Text = listView1.SelectedItems[0].SubItems[2].Text;
                tbMail.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
            else { Reset(); }
        }
        bool Provera(string ime, string marka, string model, string godiste, string registracija)
        {

            if (String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(marka) || String.IsNullOrEmpty(model) || String.IsNullOrEmpty(godiste) || string.IsNullOrEmpty(registracija))
            {
                MessageBox.Show("Niste uneli sve podatke!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!godiste.All(char.IsDigit)||!(int.Parse(godiste)<2030))
            {
                MessageBox.Show("godiste nije uneto kako treba", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnUnos_Click(object sender, EventArgs e)
        {
            string klijentID = tbID.Text.Trim();
            string marka = tbMarka.Text.Trim();
            string model = tbModel.Text.Trim();
            string god = tbGodiste.Text.Trim();
            string reg = tbReg.Text.Trim();
            if (!Provera(klijentID, marka, model, god, reg)) return;

            try
            {
                conn.Open();
                string query = "INSERT INTO Vozila VALUES (@p1, @p2, @p3, @p4, @p5);";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@p1", int.Parse(klijentID));
                cmd.Parameters.AddWithValue("@p2", marka);
                cmd.Parameters.AddWithValue("@p3", model);
                cmd.Parameters.AddWithValue("@p4", int.Parse(god));
                cmd.Parameters.AddWithValue("@p5", reg);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Uspesno ste uneli podatak u bazu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UnosKola_Load(sender, e);

                Reset();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void UnosKola_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void UnosKola_FormClosed(object sender, FormClosedEventArgs e)
        {
           DialogResult = DialogResult.OK;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
