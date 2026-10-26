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
    public partial class Vozila : Form
    {
        
        SqlConnection conn=null;
        public Vozila()
        {
            string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""M:\alatcici\visual sstuidio dump\ServisVozila\Database1.mdf"";Integrated Security=True";
            conn = new SqlConnection(connect);
            InitializeComponent();
        }
        void Reset()
        {
            tbIme.Clear();
            tbMarka.Clear();
            tbModel.Clear();
            tbGodiste.Clear();
            tbReg.Clear();
            tbIDvozila.Clear();
        }
        bool Provera(string ime, string marka, string model, string godiste, string registracija)
        {

            if (String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(marka) || String.IsNullOrEmpty(model) || String.IsNullOrEmpty(godiste) || string.IsNullOrEmpty(registracija))
            {
                MessageBox.Show("Niste uneli sve podatke!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!godiste.All(char.IsDigit))
            {
                MessageBox.Show("broj telefona nije unet kako treba", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void Vozila_Load(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                string query = @"SELECT Vozila.VoziloID, Klijenti.KlijentID, Klijenti.Ime, Vozila.Marka, Vozila.Model, Vozila.Godiste, Vozila.Registracija 
                FROM Klijenti
                INNER JOIN Vozila 
                ON Klijenti.KlijentID = Vozila.KlijentID";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader sql = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (sql.Read())
                {
                    listView1.Items.Add(new ListViewItem(new[] { sql[0].ToString(), sql[1].ToString(), sql[2].ToString(), sql[3].ToString(), sql[4].ToString(), sql[5].ToString(), sql[6].ToString() }));
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
                tbIDvozila.Text = listView1.SelectedItems[0].SubItems[0].Text;
                tbIme.Text = listView1.SelectedItems[0].SubItems[2].Text;
                tbMarka.Text = listView1.SelectedItems[0].SubItems[3].Text;
                tbModel.Text = listView1.SelectedItems[0].SubItems[4].Text;
                tbGodiste.Text = listView1.SelectedItems[0].SubItems[5].Text;
                tbReg.Text = listView1.SelectedItems[0].SubItems[6].Text;
            }
            else { Reset(); }
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            UnosKola unosKola = new UnosKola();
           // unosKola.ShowDialog();
            if (unosKola.ShowDialog() == DialogResult.OK)
            {
                Vozila_Load(sender,e);
            }
        }

        private void rbKlijenti_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            string sifra = tbIDvozila.Text.Trim();
            string ime = tbIme.Text.Trim();
            string marka = tbMarka.Text.Trim();
            string model = tbModel.Text.Trim();
            string godiste = tbGodiste.Text.Trim();
            string registracija = tbReg.Text.Trim();
            if (String.IsNullOrEmpty(sifra))
            {
                MessageBox.Show("Niste selektovali red za izmenu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Provera(ime, marka, model, godiste, registracija)) return;
            try
            {
                conn.Open();
                string query = @"UPDATE Vozila SET KlijentID = (SELECT KlijentID FROM Klijenti WHERE Ime = @p1), Marka = @p2, Model = @p3, Godiste = @p4, Registracija = @p5 WHERE VoziloID = @p6";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@p1", ime);
                cmd.Parameters.AddWithValue("@p2", marka);
                cmd.Parameters.AddWithValue("@p3", model);
                cmd.Parameters.AddWithValue("@p4", godiste);
                cmd.Parameters.AddWithValue("@p5", registracija);
                cmd.Parameters.AddWithValue("@p6", sifra);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Uspesno ste uneli podatak u bazu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Vozila_Load(sender, e);

                Reset();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            string sifra = tbIDvozila.Text.Trim();
            string ime = tbIme.Text.Trim();
            string marka = tbMarka.Text.Trim();
            string model = tbModel.Text.Trim();
            string godiste = tbGodiste.Text.Trim();
            string registracija = tbReg.Text.Trim();
            if (String.IsNullOrEmpty(sifra))
            {
                MessageBox.Show("Niste selektovali red za izmenu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                conn.Open();
                string query = "DELETE FROM Vozila WHERE VoziloID = @p6";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@p6", sifra);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Uspesno ste uneli podatak u bazu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Vozila_Load(sender, e);

                Reset();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
}
