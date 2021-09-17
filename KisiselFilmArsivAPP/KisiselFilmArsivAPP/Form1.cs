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
namespace KisiselFilmArsivAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-34G34T7\\SQLEXPRESS01;Initial Catalog=FilmArsiviDB;Integrated Security=True");
        private void filmler()
        {
            SqlDataAdapter da = new  SqlDataAdapter("Select * from Film_Table",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
            btnNormalEkran.Hide();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilmAdi.Text != "" && txtKategori.Text != "" && txtLink.Text != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into Film_Table (AD,KATEGORI,LINK)  values (@p1,@p2,@p3)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtFilmAdi.Text);
                    komut.Parameters.AddWithValue("@p2", txtKategori.Text);
                    komut.Parameters.AddWithValue("@p3", txtLink.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Film listenize eklendi.", "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filmler();
                }
                else
                {
                    MessageBox.Show("Boşlukları doldurunuz...");
                }
            }
            catch
            {
                MessageBox.Show("Hatalı Giriş Yaptınız...");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Serhat Ayata tarafından hazırlanmıştır.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int deger = rnd.Next(0,7);
            switch (deger)
            {
                case 0: this.BackColor = Color.Blue; break;
                case 1: this.BackColor = Color.Black; break;
                case 2: this.BackColor = Color.Red; break;
                case 3: this.BackColor = Color.White; break;
                case 4: this.BackColor = Color.Gray; break;
                case 5: this.BackColor = Color.Yellow; break;
                case 6: this.BackColor = Color.Pink; break;
            }
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            groupBoxYeniFilm.Hide();
            groupBoxFilmListesi.Hide();
            groupBoxEkran.Dock = DockStyle.Fill;
            btnNormalEkran.Show();
        }

        private void btnNormalEkran_Click(object sender, EventArgs e)
        {
            btnNormalEkran.Hide();
            groupBoxYeniFilm.Show();
            groupBoxFilmListesi.Show();
            groupBoxEkran.Dock = DockStyle.None;
        }

      
    }
}
