using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DNesneAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 30;
        }
        bool asagiYukariValue, yukariSagValue, yukariAsagiValue, asagiSolValue;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (asagiYukariValue)
            {
                if (pcBoxBall.Top <= 12)
                {
                    asagiYukariValue = false;
                    yukariSagValue = true;
                }
                pcBoxBall.Top -= 5;
            }
            if (yukariSagValue)
            {
                if (pcBoxBall.Left >= 730)
                {
                    yukariSagValue = false;
                    yukariAsagiValue = true;
                }
                pcBoxBall.Left += 5;
            }
            if (yukariAsagiValue)
            {
                if (pcBoxBall.Top >= 440)
                {
                    yukariAsagiValue = false;
                    asagiSolValue = true;
                }
                pcBoxBall.Top += 5;
            }
            if (asagiSolValue)
            {
                if (pcBoxBall.Left <= 32)
                {
                    asagiSolValue = false;
                    asagiYukariValue = true;
                }
                pcBoxBall.Left -= 5;
            }

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            asagiYukariValue = true;
        }
    }
}
