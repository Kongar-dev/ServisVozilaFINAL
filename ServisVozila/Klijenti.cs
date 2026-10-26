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
    public partial class Klijenti : Form
    {
        SqlConnection conn = null;
        public Klijenti()
        {
            string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""M:\alatcici\visual sstuidio dump\ServisVozila\Database1.mdf"";Integrated Security=True";
            conn = new SqlConnection(connect);
            InitializeComponent();
        }
        void Reset()
        {
            tbIme.Clear();
            tbPrezime.Clear();
            tbTel.Clear();
            tbMail.Clear();
            tbAdress.Clear();
            tbID.Clear();
        }

        private void Klijenti_Load(object sender, EventArgs e)
        {

            try
            {

                conn.Open();
                string query = "select * from klijenti";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader sql = cmd.ExecuteReader();
                listView1.Items.Clear();
                while (sql.Read())
                {
                    listView1.Items.Add(new ListViewItem(new[] { sql[0].ToString(), sql[1].ToString(), sql[2].ToString(), sql[3].ToString(), sql[4].ToString(), sql[5].ToString() }));
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
                tbTel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                tbMail.Text = listView1.SelectedItems[0].SubItems[4].Text;
                tbAdress.Text = listView1.SelectedItems[0].SubItems[5].Text;
            }
            else { Reset(); }
        }
        bool Provera(string ime, string prezime, string telefon, string mail, string adresa)
        {

            if (String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(prezime) ||  String.IsNullOrEmpty(mail))
            {
                MessageBox.Show("Niste uneli sve podatke!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!telefon.All(char.IsDigit))
            {
                MessageBox.Show("broj telefona nije unet kako treba", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnUnos_Click(object sender, EventArgs e)
        {
            string ime = tbIme.Text.Trim();
            string prezime = tbPrezime.Text.Trim();
            string telefon = tbTel.Text.Trim();
            string mail = tbMail.Text.Trim();
            string adresa = tbAdress.Text.Trim();
            if (!Provera(ime,prezime, telefon, mail, adresa)) return;

            try
            {
                conn.Open();
                string query = "insert into klijenti Values(@p1,@p2,@p3,@p4,@p5)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@p1", ime);
                cmd.Parameters.AddWithValue("@p2", prezime);
                cmd.Parameters.AddWithValue("@p3", telefon);
                cmd.Parameters.AddWithValue("@p4", mail);
                cmd.Parameters.AddWithValue("@p5", adresa);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Uspesno ste uneli podatak u bazu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Klijenti_Load(sender, e);

                Reset();

            }
            catch (SqlException)
            {
                MessageBox.Show("Ovaj mejl je vec prijavljen kod nas","greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
            
        }

        private void btnIzmena_Click(object sender, EventArgs e)
        {
            string sifra = tbID.Text.Trim();
            string ime = tbIme.Text.Trim();
            string prezime = tbPrezime.Text.Trim();
            string telefon = tbTel.Text.Trim();
            string mail = tbMail.Text.Trim();
            string adresa = tbAdress.Text.Trim();
            if (String.IsNullOrEmpty(sifra))
            {
                MessageBox.Show("Niste selektovali red za izmenu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Provera(ime, prezime, telefon, mail, adresa)) return;
            try
            {
                conn.Open();
                string query = "update klijenti set ime=@p1,prezime=@p2,telefon=@p3,email=@p4,adresa=@p5 where klijentid=@p6";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@p1", ime);
                cmd.Parameters.AddWithValue("@p2", prezime);
                cmd.Parameters.AddWithValue("@p3", telefon);
                cmd.Parameters.AddWithValue("@p4", mail);
                cmd.Parameters.AddWithValue("@p5", adresa);
                cmd.Parameters.AddWithValue("@p6", sifra);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Uspesno ste uneli podatak u bazu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Klijenti_Load(sender, e);

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
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste selektovali klijenta za brisanje!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn.Open();
                string query = "delete from klijenti where klijentId=@p1";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@p1", tbID.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                Klijenti_Load(sender, e);
                Reset();
                MessageBox.Show("Uspesno ste obrisali klijenta iz baze", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
    }
    
}
