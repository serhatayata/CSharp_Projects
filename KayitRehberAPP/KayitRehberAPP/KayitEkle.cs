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
    public partial class KayitEkle : Form
    {
        public KayitEkle()
        {
            InitializeComponent();
        }
        KISILER kayit = new KISILER();

        private void KayitEkle_Load(object sender, EventArgs e)
        {

        }
        void Temizle()
        {
            txtAD.Clear();
            txtSoyad.Clear();
            txtMail.Clear();
            mskTextTEL.Clear();
            txtAD.Focus();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAD.Text.Trim() == "")
            {
                MessageBox.Show("Ad Giriniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (txtSoyad.Text.Trim() == "")
            {
                MessageBox.Show("Soyad Giriniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMail.Text == "")
            {
                MessageBox.Show("Mail adresi giriniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mskTextTEL.Text == "")
            {
                MessageBox.Show("Telefon numarası giriniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    KISILER kayitt = new KISILER();
                    kayitt.AD = txtAD.Text;
                    kayitt.SOYAD = txtSoyad.Text;
                    kayitt.MAIL = txtMail.Text;
                    kayitt.TELEFON = mskTextTEL.Text;
                    KayitBLL.KayitEkle(kayitt);
                    MessageBox.Show("Maaş Eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Temizle();
                    this.Close();
                }
                else
                {

                }

            }
        }
    }
}
