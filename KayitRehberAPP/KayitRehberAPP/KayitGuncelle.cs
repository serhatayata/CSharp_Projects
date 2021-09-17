using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Kayit;
using DAL_Kayit;
using DAL_Kayit.DAO;
using DAL_Kayit.DTO;
namespace KayitRehberAPP
{
    public partial class KayitGuncelle : Form
    {
        public KayitGuncelle()
        {
            InitializeComponent();
        }
        public int degisecekID;
        private void KayitGuncelle_Load(object sender, EventArgs e)
        {
            txtID.Text = degisecekID.ToString();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                KayitDetayDTO kayit = new KayitDetayDTO();
                kayit.Kayit_ID = degisecekID;
                kayit.Kayit_Ad = txtAD.Text;
                kayit.Kayit_Soyad = txtSoyad.Text;
                kayit.Kayit_Mail = txtMail.Text;
                kayit.Kayit_Telefon = mskTextTEL.Text;
                KayitBLL.KayitGuncelle(kayit);
                MessageBox.Show("Kayıt güncellendi...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }

       
    }
}
