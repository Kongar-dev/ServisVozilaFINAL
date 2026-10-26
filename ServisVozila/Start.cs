using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisVozila
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            Klijenti klijenti = new Klijenti();
            klijenti.ShowDialog();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            Vozila vozila = new Vozila();
            vozila.ShowDialog();
        }

        private void btnServisi_Click(object sender, EventArgs e)
        {
            Servisi servisi = new Servisi();
            servisi.ShowDialog();   
        }
    }
}
