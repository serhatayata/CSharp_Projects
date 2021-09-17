using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DAL.DAO;
using DAL.DTO;
using BLL;
namespace MesajlasmaSistemiAPP
{
    public partial class MesajEkrani : Form
    {
        public MesajEkrani()
        {
            InitializeComponent();
        }
        KisilerDTO dto = new KisilerDTO();
        MesajlarDTO mdto = new MesajlarDTO();
        MesajlarDTO gidto = new MesajlarDTO();
        public string numara;
        public string ad,soyad;
        private void MesajEkrani_Load(object sender, EventArgs e)
        {
            gelenKutusu();
            gidenKutusu();
            lblAdSoyadValue.Text = ad+" "+soyad;
            lblNumaraValue.Text = numara;
        }
        void Temizle()
        {
            txtBaslik.Clear();
            rtxtMesaj.Clear();
            mskAliciNumaraValue.Clear();
        }
        void gelenKutusu()
        {
            mdto = MesajBLL.gelenKutusuGetir();
            dataGridView1Gelen.DataSource = mdto.Mesajlar;
            dataGridView1Gelen.Columns[0].HeaderText = "ID";
            dataGridView1Gelen.Columns[1].HeaderText = "Gönderen";
            dataGridView1Gelen.Columns[2].HeaderText = "Alıcı";
            dataGridView1Gelen.Columns[3].HeaderText = "Başlık";
            dataGridView1Gelen.Columns[4].HeaderText = "İçerik";
        }
        void gidenKutusu()
        {
            gidto = MesajBLL.gidenKutusuGetir();
            dataGridView2Giden.DataSource = gidto.Mesajlar;
            dataGridView2Giden.Columns[0].HeaderText = "ID";
            dataGridView2Giden.Columns[1].HeaderText = "Gönderen";
            dataGridView2Giden.Columns[2].HeaderText = "Alıcı";
            dataGridView2Giden.Columns[3].HeaderText = "Başlık";
            dataGridView2Giden.Columns[4].HeaderText = "İçerik";
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            TBL_MESAJLAR tb = new TBL_MESAJLAR();
            tb.GONDEREN = UserStatic.Numara;
            tb.ALICI = mskAliciNumaraValue.Text;
            tb.BASLIK = txtBaslik.Text;
            tb.ICERIK = rtxtMesaj.Text;
            if (lblNumaraValue.Text == numara)
            {
                MessageBox.Show("Lütfen kendi numaranızdan farklı bir değer giriniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBaslik.Clear();
                rtxtMesaj.Clear();
                mskAliciNumaraValue.Clear();
            }
            else
            {
                MesajBLL.MesajEkle(tb);
                MessageBox.Show("Ekleme işlemi gerçekleştirildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBaslik.Clear();
                rtxtMesaj.Clear();
                mskAliciNumaraValue.Clear();
                gelenKutusu();
                gidenKutusu();
            }
        }
    }
}
