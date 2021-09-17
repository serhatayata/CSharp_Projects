using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;
using DAL.DTO;
namespace MesajlasmaSistemiAPP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        KisilerDTO dto = new KisilerDTO();
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text.Trim() == "")
            {
                MessageBox.Show("Şifre alanı boş.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mskNumara.Text.Trim() == "")
            {
                MessageBox.Show("Numara alanı boş.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<TBL_KISILER> list = KisilerBLL.KisilerGetir(mskNumara.Text,txtSifre.Text);
                if (list.Count <= 0)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    TBL_KISILER tbl = list.First();
                    UserStatic.Numara = tbl.NUMARA;
                    MesajEkrani frm = new MesajEkrani();
                    frm.numara = tbl.NUMARA;
                    frm.ad = tbl.AD;
                    frm.soyad = tbl.SOYAD;
                    this.Hide();
                    frm.ShowDialog();
                }
            }
        }
    }
}
