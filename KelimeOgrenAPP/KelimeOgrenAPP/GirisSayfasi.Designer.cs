
namespace KelimeOgrenAPP
{
    partial class GirisSayfasi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasi));
            this.lblingilizce = new System.Windows.Forms.Label();
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.btnSecenek1 = new System.Windows.Forms.Button();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblSureValue = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblKelimeValue = new System.Windows.Forms.Label();
            this.btnSecenek2 = new System.Windows.Forms.Button();
            this.btnSecenek3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblTurkce = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblingilizce
            // 
            this.lblingilizce.AutoSize = true;
            this.lblingilizce.Location = new System.Drawing.Point(12, 37);
            this.lblingilizce.Name = "lblingilizce";
            this.lblingilizce.Size = new System.Drawing.Size(85, 20);
            this.lblingilizce.TabIndex = 0;
            this.lblingilizce.Text = "İngilizce :";
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Enabled = false;
            this.txtIngilizce.Location = new System.Drawing.Point(120, 34);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.Size = new System.Drawing.Size(271, 26);
            this.txtIngilizce.TabIndex = 1;
            // 
            // btnSecenek1
            // 
            this.btnSecenek1.Location = new System.Drawing.Point(15, 133);
            this.btnSecenek1.Name = "btnSecenek1";
            this.btnSecenek1.Size = new System.Drawing.Size(177, 82);
            this.btnSecenek1.TabIndex = 2;
            this.btnSecenek1.UseVisualStyleBackColor = true;
            this.btnSecenek1.Click += new System.EventHandler(this.btnSecenek1_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(441, 34);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(62, 20);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "Süre : ";
            // 
            // lblSureValue
            // 
            this.lblSureValue.AutoSize = true;
            this.lblSureValue.Location = new System.Drawing.Point(521, 34);
            this.lblSureValue.Name = "lblSureValue";
            this.lblSureValue.Size = new System.Drawing.Size(29, 20);
            this.lblSureValue.TabIndex = 6;
            this.lblSureValue.Text = "90";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(441, 81);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(72, 20);
            this.lblKelime.TabIndex = 7;
            this.lblKelime.Text = "Kelime :";
            // 
            // lblKelimeValue
            // 
            this.lblKelimeValue.AutoSize = true;
            this.lblKelimeValue.Location = new System.Drawing.Point(521, 81);
            this.lblKelimeValue.Name = "lblKelimeValue";
            this.lblKelimeValue.Size = new System.Drawing.Size(19, 20);
            this.lblKelimeValue.TabIndex = 8;
            this.lblKelimeValue.Text = "0";
            // 
            // btnSecenek2
            // 
            this.btnSecenek2.Location = new System.Drawing.Point(216, 133);
            this.btnSecenek2.Name = "btnSecenek2";
            this.btnSecenek2.Size = new System.Drawing.Size(177, 82);
            this.btnSecenek2.TabIndex = 3;
            this.btnSecenek2.UseVisualStyleBackColor = true;
            this.btnSecenek2.Click += new System.EventHandler(this.btnSecenek2_Click);
            // 
            // btnSecenek3
            // 
            this.btnSecenek3.Location = new System.Drawing.Point(417, 133);
            this.btnSecenek3.Name = "btnSecenek3";
            this.btnSecenek3.Size = new System.Drawing.Size(177, 82);
            this.btnSecenek3.TabIndex = 4;
            this.btnSecenek3.UseVisualStyleBackColor = true;
            this.btnSecenek3.Click += new System.EventHandler(this.btnSecenek3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(207, 77);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(184, 35);
            this.btnBasla.TabIndex = 9;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblTurkce
            // 
            this.lblTurkce.AutoSize = true;
            this.lblTurkce.Location = new System.Drawing.Point(433, 110);
            this.lblTurkce.Name = "lblTurkce";
            this.lblTurkce.Size = new System.Drawing.Size(21, 20);
            this.lblTurkce.TabIndex = 10;
            this.lblTurkce.Text = "A";
            this.lblTurkce.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 227);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTurkce);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnSecenek3);
            this.Controls.Add(this.btnSecenek2);
            this.Controls.Add(this.lblKelimeValue);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.lblSureValue);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.btnSecenek1);
            this.Controls.Add(this.txtIngilizce);
            this.Controls.Add(this.lblingilizce);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GirisSayfasi";
            this.Text = "Kelime Öğren";
            this.Load += new System.EventHandler(this.GirisSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblingilizce;
        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.Button btnSecenek1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblSureValue;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblKelimeValue;
        private System.Windows.Forms.Button btnSecenek2;
        private System.Windows.Forms.Button btnSecenek3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblTurkce;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

