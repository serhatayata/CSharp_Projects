using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace KelimeOgrenAPP
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbSozluk.accdb");
        Random rnd = new Random();
        int sure = 90;
        int kelime = 0;
        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }
        void butonBaslaDur()
        {
            if (btnBasla.Text == "BAŞLA")
            {
                btnBasla.Text = "DUR";
                btnBasla.BackColor = Color.Yellow;
                timer1.Start();
                getir();
                btnSecenek1.Enabled = true;
                btnSecenek2.Enabled = true;
                btnSecenek3.Enabled = true;
            }
            else if (btnBasla.Text == "DUR")
            {
                btnBasla.Text = "BAŞLA";
                btnBasla.BackColor = Color.Green;
                timer1.Stop();
                btnSecenek1.Enabled = false;
                btnSecenek2.Enabled = false;
                btnSecenek3.Enabled = false;
            }
            else
            {
                MessageBox.Show("HATA");
            }
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            butonBaslaDur();
        }
        private void btnSecenek1_Click(object sender, EventArgs e)
        {
            secenekKontrol(btnSecenek1);
        }
        private void btnSecenek2_Click(object sender, EventArgs e)
        {
            secenekKontrol(btnSecenek2);
        }
        private void btnSecenek3_Click(object sender, EventArgs e)
        {
            secenekKontrol(btnSecenek3);
        }
        void secenekKontrol(Button btnSecenek)
        {
            if (lblTurkce.Text == btnSecenek.Text)
            {
                kelime++;
                lblKelimeValue.Text = kelime.ToString();
                getir();
            }
            else
            {
                getir();
            }
        }
        void getir()
        {
            int sayi1 = rnd.Next(1, 2490);
            int sayi2 = rnd.Next(1, 2490);
            int sayi3 = rnd.Next(1, 2490);
            int sayi4 = rnd.Next(0, 3);
            int sayi5 = rnd.Next(0, 3);
            int sayi6 = rnd.Next(0, 3);
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);
            OleDbCommand komut1 = new OleDbCommand("Select * from sozluk where id=@p2", baglanti);
            OleDbCommand komut2 = new OleDbCommand("Select * from sozluk where id=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi1);
            komut1.Parameters.AddWithValue("@p2", sayi2);
            komut2.Parameters.AddWithValue("@p3", sayi3);
            OleDbDataReader dr = komut.ExecuteReader();
            OleDbDataReader dr1 = komut1.ExecuteReader();
            OleDbDataReader dr2 = komut2.ExecuteReader();
            Button[] lst = new Button[3];
            lst[0]=btnSecenek1;
            lst[1]=btnSecenek2;
            lst[2] = btnSecenek3;
            lst[sayi4] = btnSecenek1;
            while (sayi4 == sayi5)
            {
                sayi5 = rnd.Next(0, 3);
            }
            lst[sayi5] = btnSecenek2;
            while (sayi5 == sayi6 || sayi4 ==sayi6)
            {
                sayi6 = rnd.Next(0, 3);
            }
            lst[sayi6] = btnSecenek3;
            //
            while (dr.Read())
            {
                txtIngilizce.Text = dr[1].ToString();
                lblTurkce.Text = dr[2].ToString();
                lst[0].Text = lblTurkce.Text;
            }
            while (dr1.Read())
            {
                lst[1].Text = dr1[2].ToString();
            }
            while (dr2.Read())
            {
                lst[2].Text = dr2[2].ToString();
            }
            baglanti.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSureValue.Text = sure.ToString();
            if (sure == 0)
            {
                txtIngilizce.Enabled = false;
                timer1.Stop();
                btnSecenek1.Enabled = false;
                btnSecenek2.Enabled = false;
                btnSecenek3.Enabled = false;
                lblSureValue.Text = "0";
                butonBaslaDur();
                sure = 90;
            }
            else
            {

            }
        }
       
    }
}
