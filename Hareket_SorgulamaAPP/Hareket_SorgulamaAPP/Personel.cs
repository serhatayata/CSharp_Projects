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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-34G34T7\\SQLEXPRESS01;Initial Catalog=HareketSorguDB;Integrated Security=True");
        private void Personel_Load(object sender, EventArgs e)
        {
            dataYaz();
        }
        void dataYaz()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Execute Personel_PROC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into PERSONEL_TABLO (AD) values (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataYaz();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"update PERSONEL_TABLO set AD=@p1 where AD='{txtAdSoyad.Text}'", baglanti);
            komut.Parameters.AddWithValue("@p1", txtGuncelle.Text);
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
