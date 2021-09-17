using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hareket_SorgulamaAPP
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-34G34T7\\SQLEXPRESS01;Initial Catalog=HareketSorguDB;Integrated Security=True");
        private void Musteri_Load(object sender, EventArgs e)
        {
            dataYaz();
        }
        void dataYaz()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Execute Musteriler_PROC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MUSTERILER_TABLO (ADSOYAD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataYaz();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"update MUSTERILER_TABLO set ADSOYAD=@p1 where ADSOYAD = '{txtAdSoyad.Text}'", baglanti);
            komut.Parameters.AddWithValue("@p1", txtGuncelleAdSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataYaz();
        }
        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran frm = new AnaEkran();
            frm.Show();
        }


    }
}
