
namespace SecimIstatistikApp
{
    partial class Grafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEValue = new System.Windows.Forms.Label();
            this.lblDValue = new System.Windows.Forms.Label();
            this.lblCValue = new System.Windows.Forms.Label();
            this.lblBValue = new System.Windows.Forms.Label();
            this.lblAValue = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.lblE = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.lblD = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.lblC = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.lblB = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblA = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 22);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Partiler";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(771, 211);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEValue);
            this.groupBox2.Controls.Add(this.lblDValue);
            this.groupBox2.Controls.Add(this.lblCValue);
            this.groupBox2.Controls.Add(this.lblBValue);
            this.groupBox2.Controls.Add(this.lblAValue);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.lblE);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.lblD);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.lblC);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.lblB);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lblA);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 318);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // lblEValue
            // 
            this.lblEValue.AutoSize = true;
            this.lblEValue.Location = new System.Drawing.Point(672, 274);
            this.lblEValue.Name = "lblEValue";
            this.lblEValue.Size = new System.Drawing.Size(28, 18);
            this.lblEValue.TabIndex = 17;
            this.lblEValue.Text = "00";
            // 
            // lblDValue
            // 
            this.lblDValue.AutoSize = true;
            this.lblDValue.Location = new System.Drawing.Point(671, 230);
            this.lblDValue.Name = "lblDValue";
            this.lblDValue.Size = new System.Drawing.Size(28, 18);
            this.lblDValue.TabIndex = 16;
            this.lblDValue.Text = "00";
            // 
            // lblCValue
            // 
            this.lblCValue.AutoSize = true;
            this.lblCValue.Location = new System.Drawing.Point(672, 183);
            this.lblCValue.Name = "lblCValue";
            this.lblCValue.Size = new System.Drawing.Size(28, 18);
            this.lblCValue.TabIndex = 15;
            this.lblCValue.Text = "00";
            // 
            // lblBValue
            // 
            this.lblBValue.AutoSize = true;
            this.lblBValue.Location = new System.Drawing.Point(672, 136);
            this.lblBValue.Name = "lblBValue";
            this.lblBValue.Size = new System.Drawing.Size(28, 18);
            this.lblBValue.TabIndex = 14;
            this.lblBValue.Text = "00";
            // 
            // lblAValue
            // 
            this.lblAValue.AutoSize = true;
            this.lblAValue.Location = new System.Drawing.Point(672, 90);
            this.lblAValue.Name = "lblAValue";
            this.lblAValue.Size = new System.Drawing.Size(28, 18);
            this.lblAValue.TabIndex = 13;
            this.lblAValue.Text = "00";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(156, 269);
            this.progressBar5.Maximum = 200;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(499, 31);
            this.progressBar5.TabIndex = 12;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(26, 274);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(78, 18);
            this.lblE.TabIndex = 11;
            this.lblE.Text = "E PARTİ";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(156, 223);
            this.progressBar4.Maximum = 200;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(499, 31);
            this.progressBar4.TabIndex = 10;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(25, 230);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(79, 18);
            this.lblD.TabIndex = 9;
            this.lblD.Text = "D PARTİ";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(157, 177);
            this.progressBar3.Maximum = 200;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(498, 31);
            this.progressBar3.TabIndex = 8;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(26, 183);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(78, 18);
            this.lblC.TabIndex = 7;
            this.lblC.Text = "C PARTİ";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(157, 131);
            this.progressBar2.Maximum = 200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(498, 31);
            this.progressBar2.TabIndex = 6;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(26, 136);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(78, 18);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "B PARTİ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(157, 85);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(498, 31);
            this.progressBar1.TabIndex = 4;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(26, 90);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(79, 18);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "A PARTİ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçiniz :";
            // 
            // Grafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(777, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Grafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veritabanı Grafik Sistemi";
            this.Load += new System.EventHandler(this.Grafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEValue;
        private System.Windows.Forms.Label lblDValue;
        private System.Windows.Forms.Label lblCValue;
        private System.Windows.Forms.Label lblBValue;
        private System.Windows.Forms.Label lblAValue;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}