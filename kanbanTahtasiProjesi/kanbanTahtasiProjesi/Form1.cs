using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanbanTahtasiProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNotBasligi_TextChanged(object sender, EventArgs e)
        {
            this.Text = txtNotBasligi.Text;
            lblKalanKarakter.Text = Convert.ToString(txtNotBasligi.MaxLength - txtNotBasligi.Text.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNotBasligi.MaxLength = 140;
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.Text == "Ödev")
                this.BackColor = Color.Yellow;
            else if(cmbKategori.Text == "Sınav")
                this.BackColor = Color.DeepSkyBlue;
            else if(cmbKategori.Text == "Proje")
                this.BackColor = Color.Green;
            else
                this.BackColor = Color.DeepPink;
        }
    }
}
