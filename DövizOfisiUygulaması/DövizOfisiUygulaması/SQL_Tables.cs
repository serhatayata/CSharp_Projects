using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DövizOfisiUygulaması
{
    public partial class SQL_Tables : Form
    {
        public SQL_Tables()
        {
            InitializeComponent();
        }

        private void SQL_Tables_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dovizOfisiDBDataSet4.Alis_Tablo' table. You can move, or remove it, as needed.
            this.alis_TabloTableAdapter1.Fill(this.dovizOfisiDBDataSet4.Alis_Tablo);
            // TODO: This line of code loads data into the 'dovizOfisiDBDataSet31.Satis_Tablo' table. You can move, or remove it, as needed.
            this.satis_TabloTableAdapter2.Fill(this.dovizOfisiDBDataSet31.Satis_Tablo);



        }


    }
}
