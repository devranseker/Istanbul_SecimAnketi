namespace Istanbul_Secim
{
    partial class FrmGrafikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblOyOraniE = new System.Windows.Forms.Label();
            this.LblOyOraniD = new System.Windows.Forms.Label();
            this.LblOyOraniC = new System.Windows.Forms.Label();
            this.LblOyOraniB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblOyOraniA = new System.Windows.Forms.Label();
            this.progressBar5EParti = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar4DParti = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar3CParti = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar2BParti = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1AParti = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbIlceler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 22);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Partiler";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(747, 236);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.LblOyOraniE);
            this.groupBox2.Controls.Add(this.LblOyOraniD);
            this.groupBox2.Controls.Add(this.LblOyOraniC);
            this.groupBox2.Controls.Add(this.LblOyOraniB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LblOyOraniA);
            this.groupBox2.Controls.Add(this.progressBar5EParti);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBar4DParti);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressBar3CParti);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBar2BParti);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar1AParti);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CmbIlceler);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // LblOyOraniE
            // 
            this.LblOyOraniE.AutoSize = true;
            this.LblOyOraniE.Location = new System.Drawing.Point(554, 205);
            this.LblOyOraniE.Name = "LblOyOraniE";
            this.LblOyOraniE.Size = new System.Drawing.Size(20, 18);
            this.LblOyOraniE.TabIndex = 17;
            this.LblOyOraniE.Text = "O";
            // 
            // LblOyOraniD
            // 
            this.LblOyOraniD.AutoSize = true;
            this.LblOyOraniD.Location = new System.Drawing.Point(554, 176);
            this.LblOyOraniD.Name = "LblOyOraniD";
            this.LblOyOraniD.Size = new System.Drawing.Size(20, 18);
            this.LblOyOraniD.TabIndex = 16;
            this.LblOyOraniD.Text = "O";
            // 
            // LblOyOraniC
            // 
            this.LblOyOraniC.AutoSize = true;
            this.LblOyOraniC.Location = new System.Drawing.Point(554, 140);
            this.LblOyOraniC.Name = "LblOyOraniC";
            this.LblOyOraniC.Size = new System.Drawing.Size(20, 18);
            this.LblOyOraniC.TabIndex = 15;
            this.LblOyOraniC.Text = "O";
            // 
            // LblOyOraniB
            // 
            this.LblOyOraniB.AutoSize = true;
            this.LblOyOraniB.Location = new System.Drawing.Point(554, 97);
            this.LblOyOraniB.Name = "LblOyOraniB";
            this.LblOyOraniB.Size = new System.Drawing.Size(20, 18);
            this.LblOyOraniB.TabIndex = 14;
            this.LblOyOraniB.Text = "O";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Toplam Oy Oranları:";
            // 
            // LblOyOraniA
            // 
            this.LblOyOraniA.AutoSize = true;
            this.LblOyOraniA.Location = new System.Drawing.Point(554, 61);
            this.LblOyOraniA.Name = "LblOyOraniA";
            this.LblOyOraniA.Size = new System.Drawing.Size(20, 18);
            this.LblOyOraniA.TabIndex = 12;
            this.LblOyOraniA.Text = "O";
            // 
            // progressBar5EParti
            // 
            this.progressBar5EParti.Location = new System.Drawing.Point(132, 200);
            this.progressBar5EParti.Maximum = 200;
            this.progressBar5EParti.Name = "progressBar5EParti";
            this.progressBar5EParti.Size = new System.Drawing.Size(382, 30);
            this.progressBar5EParti.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ :";
            // 
            // progressBar4DParti
            // 
            this.progressBar4DParti.Location = new System.Drawing.Point(132, 164);
            this.progressBar4DParti.Maximum = 200;
            this.progressBar4DParti.Name = "progressBar4DParti";
            this.progressBar4DParti.Size = new System.Drawing.Size(382, 30);
            this.progressBar4DParti.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ :";
            // 
            // progressBar3CParti
            // 
            this.progressBar3CParti.Location = new System.Drawing.Point(132, 128);
            this.progressBar3CParti.Maximum = 200;
            this.progressBar3CParti.Name = "progressBar3CParti";
            this.progressBar3CParti.Size = new System.Drawing.Size(382, 30);
            this.progressBar3CParti.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ :";
            // 
            // progressBar2BParti
            // 
            this.progressBar2BParti.Location = new System.Drawing.Point(132, 92);
            this.progressBar2BParti.Maximum = 200;
            this.progressBar2BParti.Name = "progressBar2BParti";
            this.progressBar2BParti.Size = new System.Drawing.Size(382, 30);
            this.progressBar2BParti.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ :";
            // 
            // progressBar1AParti
            // 
            this.progressBar1AParti.Location = new System.Drawing.Point(132, 56);
            this.progressBar1AParti.Maximum = 200;
            this.progressBar1AParti.Name = "progressBar1AParti";
            this.progressBar1AParti.Size = new System.Drawing.Size(382, 30);
            this.progressBar1AParti.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ :";
            // 
            // CmbIlceler
            // 
            this.CmbIlceler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIlceler.FormattingEnabled = true;
            this.CmbIlceler.Location = new System.Drawing.Point(132, 23);
            this.CmbIlceler.Name = "CmbIlceler";
            this.CmbIlceler.Size = new System.Drawing.Size(215, 26);
            this.CmbIlceler.TabIndex = 1;
            this.CmbIlceler.SelectedIndexChanged += new System.EventHandler(this.CmbIlceler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin :";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(927, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGrafikler";
            this.Text = "Veri Tabanı Grafik Seçim Sistemi";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
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
        private System.Windows.Forms.ComboBox CmbIlceler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar5EParti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar4DParti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3CParti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar2BParti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1AParti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblOyOraniE;
        private System.Windows.Forms.Label LblOyOraniD;
        private System.Windows.Forms.Label LblOyOraniC;
        private System.Windows.Forms.Label LblOyOraniB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblOyOraniA;
    }
}