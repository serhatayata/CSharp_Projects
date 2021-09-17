
namespace Hareket_SorgulamaAPP
{
    partial class Hareket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSatisGerceklestir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUrunAlisFiyat = new System.Windows.Forms.Label();
            this.lblUrunSatisFiyati = new System.Windows.Forms.Label();
            this.lblUrunSatisFiyatiValue = new System.Windows.Forms.Label();
            this.lblUrunAlisFiyatiValue = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnHareketSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(398, 48);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(178, 28);
            this.cmbPersonel.TabIndex = 7;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(205, 48);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(178, 28);
            this.cmbMusteri.TabIndex = 6;
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(12, 48);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(178, 28);
            this.cmbUrun.TabIndex = 5;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 213);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnSatisGerceklestir
            // 
            this.btnSatisGerceklestir.Location = new System.Drawing.Point(315, 106);
            this.btnSatisGerceklestir.Name = "btnSatisGerceklestir";
            this.btnSatisGerceklestir.Size = new System.Drawing.Size(178, 42);
            this.btnSatisGerceklestir.TabIndex = 10;
            this.btnSatisGerceklestir.Text = "Satışı Gerçekleştir";
            this.btnSatisGerceklestir.UseVisualStyleBackColor = true;
            this.btnSatisGerceklestir.Click += new System.EventHandler(this.btnSatisGerceklestir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ÜRÜN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "MÜŞTERİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "PERSONEL";
            // 
            // lblUrunAlisFiyat
            // 
            this.lblUrunAlisFiyat.AutoSize = true;
            this.lblUrunAlisFiyat.Location = new System.Drawing.Point(12, 101);
            this.lblUrunAlisFiyat.Name = "lblUrunAlisFiyat";
            this.lblUrunAlisFiyat.Size = new System.Drawing.Size(96, 20);
            this.lblUrunAlisFiyat.TabIndex = 14;
            this.lblUrunAlisFiyat.Text = "Alış Fiyatı :";
            // 
            // lblUrunSatisFiyati
            // 
            this.lblUrunSatisFiyati.AutoSize = true;
            this.lblUrunSatisFiyati.Location = new System.Drawing.Point(12, 139);
            this.lblUrunSatisFiyati.Name = "lblUrunSatisFiyati";
            this.lblUrunSatisFiyati.Size = new System.Drawing.Size(108, 20);
            this.lblUrunSatisFiyati.TabIndex = 15;
            this.lblUrunSatisFiyati.Text = "Satış Fiyatı :";
            // 
            // lblUrunSatisFiyatiValue
            // 
            this.lblUrunSatisFiyatiValue.AutoSize = true;
            this.lblUrunSatisFiyatiValue.Location = new System.Drawing.Point(126, 139);
            this.lblUrunSatisFiyatiValue.Name = "lblUrunSatisFiyatiValue";
            this.lblUrunSatisFiyatiValue.Size = new System.Drawing.Size(29, 20);
            this.lblUrunSatisFiyatiValue.TabIndex = 17;
            this.lblUrunSatisFiyatiValue.Text = "00";
            // 
            // lblUrunAlisFiyatiValue
            // 
            this.lblUrunAlisFiyatiValue.AutoSize = true;
            this.lblUrunAlisFiyatiValue.Location = new System.Drawing.Point(126, 101);
            this.lblUrunAlisFiyatiValue.Name = "lblUrunAlisFiyatiValue";
            this.lblUrunAlisFiyatiValue.Size = new System.Drawing.Size(29, 20);
            this.lblUrunAlisFiyatiValue.TabIndex = 16;
            this.lblUrunAlisFiyatiValue.Text = "00";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(591, 48);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(178, 26);
            this.txtSatisFiyati.TabIndex = 18;
            this.txtSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatisFiyati_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(618, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "SATIŞ FİYATI";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(774, -1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(59, 31);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnHareketSil
            // 
            this.btnHareketSil.BackColor = System.Drawing.Color.Yellow;
            this.btnHareketSil.Location = new System.Drawing.Point(642, 134);
            this.btnHareketSil.Name = "btnHareketSil";
            this.btnHareketSil.Size = new System.Drawing.Size(178, 42);
            this.btnHareketSil.TabIndex = 21;
            this.btnHareketSil.Text = "Hareketleri Temizle";
            this.btnHareketSil.UseVisualStyleBackColor = false;
            this.btnHareketSil.Click += new System.EventHandler(this.btnHareketSil_Click);
            // 
            // Hareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(832, 395);
            this.Controls.Add(this.btnHareketSil);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.lblUrunSatisFiyatiValue);
            this.Controls.Add(this.lblUrunAlisFiyatiValue);
            this.Controls.Add(this.lblUrunSatisFiyati);
            this.Controls.Add(this.lblUrunAlisFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSatisGerceklestir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.cmbUrun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Hareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hareket Ekle";
            this.Load += new System.EventHandler(this.Hareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatisGerceklestir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUrunAlisFiyat;
        private System.Windows.Forms.Label lblUrunSatisFiyati;
        private System.Windows.Forms.Label lblUrunSatisFiyatiValue;
        private System.Windows.Forms.Label lblUrunAlisFiyatiValue;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnHareketSil;
    }
}