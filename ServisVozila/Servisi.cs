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
    
    public partial class Servisi : Form
    {
        private readonly string cnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""M:\alatcici\visual sstuidio dump\ServisVozila\Database1.mdf"";Integrated Security=True";

        public Servisi()
        {
          
            InitializeComponent();
        }

        private void Servisi_Load(object sender, EventArgs e)
        {
            try
            {
                LVtabela.Items.Clear();
                SqlConnection conn = new SqlConnection(cnn);
                SqlCommand cmd = new SqlCommand("select * from Servisi", conn);
                conn.Open();
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string[] servis = { $"{read[0]}", $"{read[1]}", $"{read[2]}", $"{read[3]}", $"{read[4]}", $"{read[5]}", $"{read[6]}" };
                    ListViewItem item = new ListViewItem(servis);
                    LVtabela.Items.Add(item);
                }
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show("Greska", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        void Reset()
        {
            tbIdServisa.Clear();
            tbIDvozila.Clear();
            tbDatum.Clear();
            tbOpisKvara.Clear();
            tbOpisUsluge.Clear();
            tbCena.Clear();
            tbKilometraza.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cnn);
                SqlCommand cmd = new SqlCommand("insert into Servisi(VoziloID, DatumServisa, OpisKvara, OpisUsluge, Cena, Kilometraza) values (@p2, @p3, @p4, @p5, @p6, @p7)", conn);
                //cmd.Parameters.AddWithValue("@p1", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@p2", tbIDvozila.Text.Trim());
                cmd.Parameters.Add("@p3", SqlDbType.DateTime).Value = DateTime.Parse(tbDatum.Text.Trim());
                cmd.Parameters.AddWithValue("@p4", tbOpisKvara.Text.Trim());
                cmd.Parameters.AddWithValue("@p5", tbOpisUsluge.Text.Trim());
                cmd.Parameters.AddWithValue("@p6", decimal.TryParse(tbCena.Text, out decimal cena) ? cena : 0);
                cmd.Parameters.Add("@p7", SqlDbType.Int).Value = int.Parse(tbKilometraza.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Servisi_Load(sender, e);
                Reset();
                MessageBox.Show("Uspesno ste uneli Servis u bazu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex) { MessageBox.Show("Greska", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVtabela.SelectedItems.Count != 0)
            {
                tbIdServisa.Text = LVtabela.SelectedItems[0].SubItems[0].Text;
                tbIDvozila.Text = LVtabela.SelectedItems[0].SubItems[1].Text;
                tbDatum.Text = LVtabela.SelectedItems[0].SubItems[2].Text;
                tbOpisKvara.Text = LVtabela.SelectedItems[0].SubItems[3].Text;
                tbOpisUsluge.Text = LVtabela.SelectedItems[0].SubItems[4].Text;
                tbCena.Text = LVtabela.SelectedItems[0].SubItems[5].Text;
                tbKilometraza.Text = LVtabela.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cnn);
                SqlCommand cmd = new SqlCommand("update Servisi set VoziloID = @p2, DatumServisa = @p3, OpisKvara = @p4, OpisUsluge = @p5, Cena = @p6, Kilometraza = @p7  where ServisID = @p1", conn);
                cmd.Parameters.AddWithValue("@p1", tbIdServisa.Text.Trim());
                cmd.Parameters.AddWithValue("@p2", tbIDvozila.Text.Trim());
                cmd.Parameters.Add("@p3", SqlDbType.DateTime).Value = DateTime.Parse(tbDatum.Text.Trim());
                cmd.Parameters.AddWithValue("@p4", tbOpisKvara.Text.Trim());
                cmd.Parameters.AddWithValue("@p5", tbOpisUsluge.Text.Trim());
                cmd.Parameters.AddWithValue("@p6", decimal.TryParse(tbCena.Text, out decimal cena) ? cena : 0);
                cmd.Parameters.Add("@p7", SqlDbType.Int).Value = int.Parse(tbKilometraza.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Servisi_Load(sender, e);
                Reset();
                MessageBox.Show("Uspesno ste promenili podatke Servisa u bazi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { MessageBox.Show("Greska", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LVtabela.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste selektovali Servis za brisanje!!!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(cnn);
                SqlCommand cmd = new SqlCommand("Delete from Servisi where ServisID = @p1", conn);
                cmd.Parameters.AddWithValue("@p1", tbIdServisa.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                Servisi_Load(sender, e);
                Reset();
                MessageBox.Show("Uspesno ste obrisali Servis iz baze", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
