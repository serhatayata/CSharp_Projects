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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-34G34T7\\SQLEXPRESS01;Initial Catalog=HareketSorguDB;Integrated Security=True");
        public void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Execute HareketSorguPROC", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void btnHareketEkle_Click(object sender, EventArgs e)
        {
            Hareket frmHareket = new Hareket();
            frmHareket.Show();
            this.Hide();
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Urun frmUrun = new Urun();
            frmUrun.Show();
            this.Hide();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri frmMusteri = new Musteri();
            frmMusteri.Show();
            this.Hide();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            Personel frmPersonel = new Personel();
            frmPersonel.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
