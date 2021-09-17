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
    public partial class Urun : Form
    {
        public Urun()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-34G34T7\\SQLEXPRESS01;Initial Catalog=HareketSorguDB;Integrated Security=True");
        private void Urun_Load(object sender, EventArgs e)
        {
            dataYaz();
        }
        void dataYaz()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Execute Urunler_PROC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into URUNLER_TABLO (AD,STOK,ALISFIYAT,SATISFIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtStok.Text);
            komut.Parameters.AddWithValue("@p3", txtAlisFiyati.Text);
            komut.Parameters.AddWithValue("@p4", txtSatisFiyati.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            dataYaz();
        }
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand($"update URUNLER_TABLO set AD=@p1,STOK=@p2,ALISFIYAT=@p3,SATISFIYAT=@p4 where AD = '{txtUrunAdi.Text}'", baglanti);
                komut.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtStok.Text);
                komut.Parameters.AddWithValue("@p3", txtAlisFiyati.Text);
                komut.Parameters.AddWithValue("@p4", txtSatisFiyati.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataYaz();
            }
            catch 
            {
                MessageBox.Show("HATALI GİRİŞ...");
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran frm = new AnaEkran();
            frm.Show();
        }


    }
}
