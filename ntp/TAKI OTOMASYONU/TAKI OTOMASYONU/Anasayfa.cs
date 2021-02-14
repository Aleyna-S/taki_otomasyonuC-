using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAKI_OTOMASYONU
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbn_sifre_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiGiris yonet = new YoneticiGiris();
            this.Hide();
            yonet.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uyeol uye = new uyeol(); this.Hide(); uye.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜyeGiris üye = new ÜyeGiris();
            this.Hide();
            üye.ShowDialog();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
