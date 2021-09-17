
namespace MesajlasmaSistemiAPP
{
    partial class MesajEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesajEkrani));
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblNumaraValue = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblAdSoyadValue = new System.Windows.Forms.Label();
            this.dataGridView1Gelen = new System.Windows.Forms.DataGridView();
            this.grpGelenKutusu = new System.Windows.Forms.GroupBox();
            this.grpGidenKutusu = new System.Windows.Forms.GroupBox();
            this.dataGridView2Giden = new System.Windows.Forms.DataGridView();
            this.grpMesaj = new System.Windows.Forms.GroupBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.rtxtMesaj = new System.Windows.Forms.RichTextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.mskAliciNumaraValue = new System.Windows.Forms.MaskedTextBox();
            this.lblAliciNumara = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Gelen)).BeginInit();
            this.grpGelenKutusu.SuspendLayout();
            this.grpGidenKutusu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2Giden)).BeginInit();
            this.grpMesaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.BackColor = System.Drawing.Color.Transparent;
            this.lblNumara.ForeColor = System.Drawing.Color.Red;
            this.lblNumara.Location = new System.Drawing.Point(15, 27);
            this.lblNumara.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(81, 20);
            this.lblNumara.TabIndex = 0;
            this.lblNumara.Text = "Numara :";
            // 
            // lblNumaraValue
            // 
            this.lblNumaraValue.AutoSize = true;
            this.lblNumaraValue.BackColor = System.Drawing.Color.Transparent;
            this.lblNumaraValue.ForeColor = System.Drawing.Color.White;
            this.lblNumaraValue.Location = new System.Drawing.Point(97, 27);
            this.lblNumaraValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNumaraValue.Name = "lblNumaraValue";
            this.lblNumaraValue.Size = new System.Drawing.Size(49, 20);
            this.lblNumaraValue.TabIndex = 1;
            this.lblNumaraValue.Text = "0000";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblAdSoyad.Location = new System.Drawing.Point(189, 27);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(96, 20);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad Soyad :";
            // 
            // lblAdSoyadValue
            // 
            this.lblAdSoyadValue.AutoSize = true;
            this.lblAdSoyadValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyadValue.ForeColor = System.Drawing.Color.White;
            this.lblAdSoyadValue.Location = new System.Drawing.Point(286, 27);
            this.lblAdSoyadValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdSoyadValue.Name = "lblAdSoyadValue";
            this.lblAdSoyadValue.Size = new System.Drawing.Size(74, 20);
            this.lblAdSoyadValue.TabIndex = 3;
            this.lblAdSoyadValue.Text = "Null Null";
            // 
            // dataGridView1Gelen
            // 
            this.dataGridView1Gelen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1Gelen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Gelen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1Gelen.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1Gelen.Name = "dataGridView1Gelen";
            this.dataGridView1Gelen.Size = new System.Drawing.Size(469, 261);
            this.dataGridView1Gelen.TabIndex = 4;
            // 
            // grpGelenKutusu
            // 
            this.grpGelenKutusu.BackColor = System.Drawing.Color.Black;
            this.grpGelenKutusu.Controls.Add(this.dataGridView1Gelen);
            this.grpGelenKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGelenKutusu.ForeColor = System.Drawing.Color.Red;
            this.grpGelenKutusu.Location = new System.Drawing.Point(14, 62);
            this.grpGelenKutusu.Name = "grpGelenKutusu";
            this.grpGelenKutusu.Size = new System.Drawing.Size(475, 281);
            this.grpGelenKutusu.TabIndex = 4;
            this.grpGelenKutusu.TabStop = false;
            this.grpGelenKutusu.Text = "Gelen Kutusu";
            // 
            // grpGidenKutusu
            // 
            this.grpGidenKutusu.BackColor = System.Drawing.Color.Black;
            this.grpGidenKutusu.Controls.Add(this.dataGridView2Giden);
            this.grpGidenKutusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGidenKutusu.ForeColor = System.Drawing.Color.Red;
            this.grpGidenKutusu.Location = new System.Drawing.Point(492, 62);
            this.grpGidenKutusu.Name = "grpGidenKutusu";
            this.grpGidenKutusu.Size = new System.Drawing.Size(475, 281);
            this.grpGidenKutusu.TabIndex = 5;
            this.grpGidenKutusu.TabStop = false;
            this.grpGidenKutusu.Text = "Giden Kutusu";
            // 
            // dataGridView2Giden
            // 
            this.dataGridView2Giden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2Giden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2Giden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2Giden.Location = new System.Drawing.Point(3, 17);
            this.dataGridView2Giden.Name = "dataGridView2Giden";
            this.dataGridView2Giden.Size = new System.Drawing.Size(469, 261);
            this.dataGridView2Giden.TabIndex = 4;
            // 
            // grpMesaj
            // 
            this.grpMesaj.Controls.Add(this.lblMesaj);
            this.grpMesaj.Controls.Add(this.lblBaslik);
            this.grpMesaj.Controls.Add(this.btnGonder);
            this.grpMesaj.Controls.Add(this.rtxtMesaj);
            this.grpMesaj.Controls.Add(this.txtBaslik);
            this.grpMesaj.Controls.Add(this.mskAliciNumaraValue);
            this.grpMesaj.Controls.Add(this.lblAliciNumara);
            this.grpMesaj.Location = new System.Drawing.Point(19, 349);
            this.grpMesaj.Name = "grpMesaj";
            this.grpMesaj.Size = new System.Drawing.Size(948, 140);
            this.grpMesaj.TabIndex = 8;
            this.grpMesaj.TabStop = false;
            this.grpMesaj.Text = "Mesaj Paneli";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(289, 43);
            this.lblMesaj.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(66, 20);
            this.lblMesaj.TabIndex = 6;
            this.lblMesaj.Text = "Mesaj :";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(10, 96);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(67, 20);
            this.lblBaslik.TabIndex = 5;
            this.lblBaslik.Text = "Başlık :";
            // 
            // btnGonder
            // 
            this.btnGonder.BackColor = System.Drawing.Color.DimGray;
            this.btnGonder.ForeColor = System.Drawing.Color.White;
            this.btnGonder.Location = new System.Drawing.Point(855, 40);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(87, 79);
            this.btnGonder.TabIndex = 3;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = false;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // rtxtMesaj
            // 
            this.rtxtMesaj.Location = new System.Drawing.Point(363, 40);
            this.rtxtMesaj.Name = "rtxtMesaj";
            this.rtxtMesaj.Size = new System.Drawing.Size(486, 81);
            this.rtxtMesaj.TabIndex = 2;
            this.rtxtMesaj.Text = "";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(135, 93);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(111, 26);
            this.txtBaslik.TabIndex = 1;
            // 
            // mskAliciNumaraValue
            // 
            this.mskAliciNumaraValue.Location = new System.Drawing.Point(135, 40);
            this.mskAliciNumaraValue.Mask = "0000";
            this.mskAliciNumaraValue.Name = "mskAliciNumaraValue";
            this.mskAliciNumaraValue.Size = new System.Drawing.Size(111, 26);
            this.mskAliciNumaraValue.TabIndex = 0;
            this.mskAliciNumaraValue.ValidatingType = typeof(int);
            // 
            // lblAliciNumara
            // 
            this.lblAliciNumara.AutoSize = true;
            this.lblAliciNumara.Location = new System.Drawing.Point(8, 43);
            this.lblAliciNumara.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAliciNumara.Name = "lblAliciNumara";
            this.lblAliciNumara.Size = new System.Drawing.Size(119, 20);
            this.lblAliciNumara.TabIndex = 4;
            this.lblAliciNumara.Text = "Alıcı Numara :";
            // 
            // MesajEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 501);
            this.Controls.Add(this.grpMesaj);
            this.Controls.Add(this.grpGidenKutusu);
            this.Controls.Add(this.grpGelenKutusu);
            this.Controls.Add(this.lblAdSoyadValue);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblNumaraValue);
            this.Controls.Add(this.lblNumara);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MesajEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MesajlaşmaAPP";
            this.Load += new System.EventHandler(this.MesajEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Gelen)).EndInit();
            this.grpGelenKutusu.ResumeLayout(false);
            this.grpGidenKutusu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2Giden)).EndInit();
            this.grpMesaj.ResumeLayout(false);
            this.grpMesaj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblNumaraValue;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblAdSoyadValue;
        private System.Windows.Forms.DataGridView dataGridView1Gelen;
        private System.Windows.Forms.GroupBox grpGelenKutusu;
        private System.Windows.Forms.GroupBox grpGidenKutusu;
        private System.Windows.Forms.DataGridView dataGridView2Giden;
        private System.Windows.Forms.GroupBox grpMesaj;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.RichTextBox rtxtMesaj;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.MaskedTextBox mskAliciNumaraValue;
        private System.Windows.Forms.Label lblAliciNumara;
    }
}