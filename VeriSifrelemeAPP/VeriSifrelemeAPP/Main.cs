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

namespace VeriSifrelemeAPP
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Main(object sender, EventArgs e)
        {
            girisListele();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-34G34T7\SQLEXPRESS01;Initial Catalog=TEST;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            byte[] adDizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adSifre = Convert.ToBase64String(adDizi);

            string soyad = txtSoyad.Text;
            byte[] soyadDizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadSifre = Convert.ToBase64String(soyadDizi);

            string mail = txtMail.Text;
            byte[] mailDizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailSifre = Convert.ToBase64String(mailDizi);

            string sifre = txtSifre.Text;
            byte[] sifreDizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreSifre = Convert.ToBase64String(sifreDizi);

            string hesapNo = txtHesapNo.Text;
            byte[] hesapNoDizi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string hesapNoSifre = Convert.ToBase64String(hesapNoDizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_VERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adSifre);
            komut.Parameters.AddWithValue("@p2", soyadSifre);
            komut.Parameters.AddWithValue("@p3", mailSifre);
            komut.Parameters.AddWithValue("@p4", sifreSifre);
            komut.Parameters.AddWithValue("@p5", hesapNoSifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Listele();
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select AD,SOYAD,MAIL,HESAPNO from TBL_VERILER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void girisListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select AD,SOYAD,MAIL,HESAPNO from TBL_VERILER", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                row["AD"] = Coz(row["AD"] as string);
                row["SOYAD"] = Coz(row["SOYAD"] as string);
                row["MAIL"] = Coz(row["MAIL"] as string);
                row["HESAPNO"] = Coz(row["HESAPNO"] as string);
            }
            dataGridView1.DataSource = ds.Tables[0];
        }
        private object Coz(string v1)
        {
            byte[] cozumDizi = Convert.FromBase64String(v1);
            string adVerisi = ASCIIEncoding.ASCII.GetString(cozumDizi);
            return adVerisi;
        }
        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtMail.Clear();
            txtHesapNo.Clear();
            txtSifre.Clear();
        }
        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            string adCozum = txtAd.Text;
            byte[] adCozumDizi = Convert.FromBase64String(adCozum);
            string adVerisi = ASCIIEncoding.ASCII.GetString(adCozumDizi);
            lblSifreliVeri.Text = adVerisi;
        }
    }
}
