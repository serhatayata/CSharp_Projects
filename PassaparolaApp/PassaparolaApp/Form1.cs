using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaparolaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
        int soruNo = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    //Cevap1
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            buttonA.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap2
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            buttonB.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            buttonC.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap4
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            buttonD.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            buttonE.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            buttonF.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            buttonG.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap9
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            buttonI.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap10
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            buttonii.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonii.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap11
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            buttonJ.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap12
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            buttonK.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap13
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            buttonL.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap14
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            buttonM.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            buttonN.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap16
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            buttonO.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap17
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            buttonP.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap18
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            buttonR.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            buttonS.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap20
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            buttonT.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap21
                    case 21:
                        if (textBox1.Text == "tarkan")
                        {
                            buttonT.BackColor = Color.Green;
                            dogru++;
                            labelDogruValue.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlis++;
                            labelYanlisValue.Text = yanlis.ToString();
                        }
                        break;


                }
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruNo++;
            this.Text = soruNo.ToString();
            switch (soruNo)
            {
                case 1: richTextBox1.Text = "Ülkemizin Güney kısmındaki kıyı bölgesi?";  buttonA.BackColor = Color.Yellow; break;
                case 2: richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz?"; buttonB.BackColor = Color.Yellow; break;
                case 3: richTextBox1.Text = "Müslümanların kutsal günü?"; buttonC.BackColor = Color.Yellow; break;
                case 4: richTextBox1.Text = "Karpuzuyla ünlü ilimiz?"; buttonD.BackColor = Color.Yellow; break;
                case 5: richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?"; buttonE.BackColor = Color.Yellow; break;
                case 6: richTextBox1.Text = "Padişahın emirlerinin yazılı hali?"; buttonF.BackColor = Color.Yellow; break;
                case 7: richTextBox1.Text = "Dünyanın ısı kaynağı?"; buttonG.BackColor = Color.Yellow; break;
                case 9: richTextBox1.Text = "Gülüyle ünlü ilimiz?"; buttonI.BackColor = Color.Yellow; break;
                case 10: richTextBox1.Text = "Mersinin diğer ismi?"; buttonii.BackColor = Color.Yellow; break;
                case 11: richTextBox1.Text = "Askeri bir topluluk?"; buttonJ.BackColor = Color.Yellow; break;
                case 12: richTextBox1.Text = "Malatyanın meşhur meyvesi?"; buttonK.BackColor = Color.Yellow; break;
                case 13: richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?"; buttonL.BackColor = Color.Yellow; break;
                case 14: richTextBox1.Text = "Yılın 3. ayı?"; buttonM.BackColor = Color.Yellow; break;
                case 15: richTextBox1.Text = "Üflemeli bir müzik aleti?"; buttonN.BackColor = Color.Yellow; break;
                case 16: richTextBox1.Text = "Halk şairi?"; buttonO.BackColor = Color.Yellow; break;
                case 17: richTextBox1.Text = "Çocukların sevmediği pirin havuç gibi şeylerle yapılan yemek?"; buttonP.BackColor = Color.Yellow; break;
                case 18: richTextBox1.Text = "11 Ayın Sultanı?"; buttonR.BackColor = Color.Yellow; break;
                case 19: richTextBox1.Text = "İngilizcede yılan?"; buttonS.BackColor = Color.Yellow; break;
                case 20: richTextBox1.Text = "Türkiyenin megastarı?"; buttonT.BackColor = Color.Yellow; break;
                case 21: richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?"; buttonU.BackColor = Color.Yellow; break;
                case 22: richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?"; buttonV.BackColor = Color.Yellow; break;
                case 23: richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?"; buttonY.BackColor = Color.Yellow; break;
                case 24: richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan ve yağıda bulunan bir kahvaltı besini?"; buttonZ.BackColor = Color.Yellow; break;

                default:
                    break;
            }
        }
    }
}
