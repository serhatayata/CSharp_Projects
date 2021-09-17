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
namespace MiniSQL_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-34G34T7\SQLEXPRESS01;Initial Catalog=Northwind;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] databases = {"Northwind","PersonelTakipDB","FilmArsiviDB"};
            cmbDatabase.Items.AddRange(databases);
            cmbDatabase.SelectedIndex = 0;
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            string sorgu = rtxtQuery.Text;
            try
            {
                baglanti.Open();

                SqlDataAdapter da = new SqlDataAdapter(sorgu,baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı sorgu giriş yaptınız !","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void cmbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDatabase.SelectedIndex)
            {
                case 0:
                    baglanti = new SqlConnection(@"Data Source=DESKTOP-34G34T7\SQLEXPRESS01;Initial Catalog=Northwind;Integrated Security=True"); break;
                case 1:
                    baglanti = new SqlConnection(@"Data Source=DESKTOP-34G34T7\SQLEXPRESS01;Initial Catalog=PersonelTakipDB;Integrated Security=True"); break;
                case 2: 
                    baglanti = new SqlConnection(@"Data Source=DESKTOP-34G34T7\SQLEXPRESS01;Initial Catalog=FilmArsiviDB;Integrated Security=True"); break;
                default:
                    break;
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            rtxtQuery.Clear();
        }
    }
}
