using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_Kayit;
using DAL_Kayit;
using DAL_Kayit.DAO;
using DAL_Kayit.DTO;

using System.Windows.Forms;
namespace KayitRehberAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KayitDTO dto = new KayitDTO();
        public bool isUpdate = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        public void Doldur()
        {
            dto = KayitBLL.GetAll();
            dataGridView1.DataSource = dto.Kisiler;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "TELEFON";
            dataGridView1.Columns[4].HeaderText = "MAIL";
        }
        public void Temizle()
        {
            txtID.Clear();
            txtAD.Clear();
            txtSoyad.Clear();
            txtMail.Clear();
            mskTextTEL.Clear();
            txtAD.Focus();
        }
        KISILER kayit = new KISILER();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            KayitEkle frm = new KayitEkle();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            Doldur();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        int gidecekID;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            gidecekID = Convert.ToInt32(txtID.Text);
            txtAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            mskTextTEL.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            KayitGuncelle frm = new KayitGuncelle();
            this.Hide();
            frm.degisecekID = gidecekID;
            frm.ShowDialog();
            this.Visible = true;
            Doldur();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Veri silinecek emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                KayitDetayDTO kayit = new KayitDetayDTO();
                kayit.Kayit_ID = Convert.ToInt32(txtID.Text);
                kayit.Kayit_Ad = txtAD.Text;
                kayit.Kayit_Soyad = txtSoyad.Text;
                kayit.Kayit_Mail = txtMail.Text;
                kayit.Kayit_Telefon = mskTextTEL.Text;
                KayitBLL.KayitSil(kayit);
                MessageBox.Show("Kayıt Silindi...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Doldur();
                Temizle();
            }
            else
            {

            }
        }
    }
}
