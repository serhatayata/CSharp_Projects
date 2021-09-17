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
    public partial class Hareket : Form
    {
        public Hareket()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-34G34T7\\SQLEXPRESS01;Initial Catalog=HareketSorguDB;Integrated Security=True");
        int formYuklemeBitti = 0;
        private void Hareket_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Execute HareketSorguPROC", baglanti);
            SqlDataAdapter db = new SqlDataAdapter("Execute Urunler_PROC", baglanti);
            SqlDataAdapter dc = new SqlDataAdapter("Execute Musteriler_PROC", baglanti);
            SqlDataAdapter dd = new SqlDataAdapter("Execute Personel_PROC", baglanti);
            DataTable dt = new DataTable();
            DataTable dy = new DataTable();
            DataTable dv = new DataTable();
            DataTable dz = new DataTable();
            da.Fill(dt);
            db.Fill(dy);
            dc.Fill(dv);
            dd.Fill(dz);
            dataGridView1.DataSource = dt;
            cmbUrun.DataSource = dy;
            cmbUrun.DisplayMember = "AD";
            cmbUrun.ValueMember = "ID";
            cmbMusteri.DataSource = dv;
            cmbMusteri.DisplayMember = "ADSOYAD";
            cmbMusteri.ValueMember = "ID";
            cmbPersonel.DataSource = dz;
            cmbPersonel.DisplayMember = "AD";
            cmbPersonel.ValueMember = "ID";
            baglanti.Close();
            cmbUrun.SelectedIndex = 0;
            cmbPersonel.SelectedIndex = 0;
            cmbMusteri.SelectedIndex = 0;
            formYuklemeBitti = 1;
            AlisSatisFiyat();
        }
        void dataYaz()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Execute HareketSorguPROC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        void AlisSatisFiyat()
        {
            if (formYuklemeBitti == 1)
            {
                string cmbUrunDeger = cmbUrun.Text;
                if (baglanti.State.ToString() == "Closed")
                {
                    baglanti.Open();
                }
                else
                {

                }
                try
                {
                    SqlCommand verioku = new SqlCommand($"select ALISFIYAT,SATISFIYAT from URUNLER_TABLO where AD='{cmbUrunDeger}'", baglanti);
                    verioku.ExecuteNonQuery();
                    SqlDataReader oku;
                    oku = verioku.ExecuteReader();
                    while (oku.Read())
                    {
                        lblUrunAlisFiyatiValue.Text = oku["ALISFIYAT"].ToString();
                        lblUrunSatisFiyatiValue.Text = oku["SATISFIYAT"].ToString();
                    }
                    oku.Close();
                    baglanti.Close();
                }
                catch
                {
                    MessageBox.Show("HATA!!");
                }
            }
        }
        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlisSatisFiyat();
        }
        private void btnSatisGerceklestir_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into HAREKETLER_TABLO (URUN,MUSTERI,PERSONEL,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", cmbUrun.SelectedIndex+1);
                MessageBox.Show((cmbUrun.SelectedIndex+1).ToString());
                komut.Parameters.AddWithValue("@p2", cmbMusteri.SelectedIndex+1);
                MessageBox.Show((cmbMusteri.SelectedIndex+1).ToString());
                komut.Parameters.AddWithValue("@p3", cmbPersonel.SelectedIndex+1);
                MessageBox.Show((cmbPersonel.SelectedIndex+1).ToString());
                komut.Parameters.AddWithValue("@p4", Convert.ToInt16(txtSatisFiyati.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtSatisFiyati.Clear();
                dataYaz();
            }
            catch
            {
                MessageBox.Show("HATA!!");

            }
            cmbMusteri.SelectedIndex = -1;
            cmbPersonel.SelectedIndex = -1;
            cmbUrun.SelectedIndex = -1;
            
        }
        private void txtSatisFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaEkran frm = new AnaEkran();
            frm.Show();
        }

        private void btnHareketSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Hareketlerin hepsi silinecek emin misiniz?", "VERİLERİ SİL", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Execute Delete_Hareket_Tablo_PROC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
                dataYaz();
            }
            else
            {
               
            }
           
        }
    }
}
