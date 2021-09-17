using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
namespace DövizOfisiUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-34G34T7\\SQLEXPRESS01;Initial Catalog=DovizOfisiDB;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://tcmb.gov.tr/kurlar/today.xml";
            var xmlDosya = new XmlDocument(); //var tüm değişkenleri üstüne alır.
            xmlDosya.Load(bugun);
            //Dolar Alış
            string dolarAlis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlisValue.Text = dolarAlis;
            //Dolar Satış
            string dolarSatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatisValue.Text = dolarSatis;
            //Euro Alış
            string euroAlis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlisValue.Text = euroAlis;
            //Euro Satış
            string euroSatis = xmlDosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatisValue.Text = euroSatis;
            //
            cmbSecenekler.SelectedIndex = 2;
        }

        

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            try
            {
                double kur, miktar, tutar;
                kur = Convert.ToDouble(txtKur.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = kur * miktar;
                txtTutar.Text = tutar.ToString();
                //SQL BAGLANTI
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Satis_Tablo (YapilanIslem,Kur,Miktar,Tutar) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", lblYapilanIslem.Text);
                komut.Parameters.AddWithValue("@p2", kur);
                komut.Parameters.AddWithValue("@p3", miktar);
                komut.Parameters.AddWithValue("@p4", tutar);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("Hatalı Giriş Yaptınız...");
            }
        }
        private void btnMiktarHesapla_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(txtKur.Text);
            int miktar = Convert.ToInt32(txtMiktar.Text);
            double tutar = Convert.ToDouble(miktar / kur);
            txtTutar.Text = (Math.Floor(tutar)).ToString();

            double kalan = miktar % kur;
            txtKalan.Text = kalan.ToString();

        }
        private void btnAlisYap_Click(object sender, EventArgs e)
        {
            try
            {
                double kur = Convert.ToDouble(txtKur.Text);
                int miktar = Convert.ToInt32(txtMiktar.Text);
                double tutar = Convert.ToDouble(miktar / kur);
                txtTutar.Text = (Math.Floor(tutar)).ToString();

                double kalan = miktar % kur;
                txtKalan.Text = kalan.ToString();
                //SQL BAGLANTI
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Alis_Tablo (YapilanIslem,Kur,Miktar,Tutar,Kalan) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", lblYapilanIslem.Text);
                komut.Parameters.AddWithValue("@p2", kur);
                komut.Parameters.AddWithValue("@p3", miktar);
                komut.Parameters.AddWithValue("@p4", tutar);
                komut.Parameters.AddWithValue("@p5", kalan);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch 
            {
                MessageBox.Show("Hatalı Giriş Yaptınız...");
            }
        }
        private void btnDolarAlis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarAlisValue.Text;
            lblYapilanIslem.Text = lblDolarAlis.Text;
        }
        private void btnDolarSatis_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarSatisValue.Text;
            lblYapilanIslem.Text = lblDolarSatis.Text;
        }

        private void btnEuroAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroAlisValue.Text;
            lblYapilanIslem.Text = lblEuroAlis.Text;
        }

        private void btnEuroSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroSatisValue.Text;
            lblYapilanIslem.Text = lblEuroSatis.Text;
        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".",",");
        }

        private void cmbSecenekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKur.Clear();
            txtMiktar.Clear();
            txtTutar.Clear();
            txtKalan.Clear();
            lblYapilanIslem.Text = "";
            if (cmbSecenekler.Text == "Satış Yap")
            {
                btnSatisYap.Visible = true;
                btnMiktarHesapla.Visible = false;
                btnAlisYap.Visible = false;
                groupBoxAlis.Visible = false;
                groupBoxSatis.Visible = true;
                groupBoxSatis.Location = new Point(12, 12);
            }
            else if(cmbSecenekler.Text == "Miktar Hesapla")
            {
                btnSatisYap.Visible = false;
                btnMiktarHesapla.Visible = true;
                btnAlisYap.Visible = false;
                groupBoxAlis.Visible = true;
                groupBoxSatis.Visible = true;
                groupBoxSatis.Location = new Point(15, 147);
            }
            else if (cmbSecenekler.Text =="Alış Yap")
            {
                btnSatisYap.Visible = false;
                btnMiktarHesapla.Visible = false;
                btnAlisYap.Visible = true;
                groupBoxAlis.Visible = true;
                groupBoxSatis.Visible = false;
                groupBoxSatis.Location = new Point(15, 147);
            }
            else
            {
                btnSatisYap.Visible = false;
                btnMiktarHesapla.Visible = false;
                btnAlisYap.Visible = false;
                groupBoxAlis.Visible = false;
                groupBoxSatis.Visible = false;
            }
        }

        private void txtKalan_TextChanged(object sender, EventArgs e)
        {
            txtKalan.Text = txtKalan.Text.Substring(0, 4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_Tables sqlTables = new SQL_Tables();
            sqlTables.Show();
        }
    }
}
