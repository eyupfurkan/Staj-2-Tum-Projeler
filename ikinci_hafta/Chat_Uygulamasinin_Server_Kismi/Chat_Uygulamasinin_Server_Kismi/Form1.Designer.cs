namespace Chat_Uygulamasinin_Server_Kismi
{
    partial class Form1
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
            this.Gonder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TxtServerIP = new System.Windows.Forms.TextBox();
            this.TxtServerPort = new System.Windows.Forms.TextBox();
            this.TxtMusteriIP = new System.Windows.Forms.TextBox();
            this.TxtMusteriPort = new System.Windows.Forms.TextBox();
            this.SunucuyuBaslat = new System.Windows.Forms.Button();
            this.ServeraBaglan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Gonder
            // 
            this.Gonder.Location = new System.Drawing.Point(554, 352);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(95, 34);
            this.Gonder.TabIndex = 0;
            this.Gonder.Text = "Gönder";
            this.Gonder.UseVisualStyleBackColor = true;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 333);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 77);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 188);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(625, 139);
            this.textBox2.TabIndex = 2;
            // 
            // TxtServerIP
            // 
            this.TxtServerIP.Location = new System.Drawing.Point(201, 60);
            this.TxtServerIP.Name = "TxtServerIP";
            this.TxtServerIP.Size = new System.Drawing.Size(112, 20);
            this.TxtServerIP.TabIndex = 3;
            // 
            // TxtServerPort
            // 
            this.TxtServerPort.Location = new System.Drawing.Point(360, 60);
            this.TxtServerPort.Name = "TxtServerPort";
            this.TxtServerPort.Size = new System.Drawing.Size(133, 20);
            this.TxtServerPort.TabIndex = 4;
            // 
            // TxtMusteriIP
            // 
            this.TxtMusteriIP.Location = new System.Drawing.Point(201, 125);
            this.TxtMusteriIP.Name = "TxtMusteriIP";
            this.TxtMusteriIP.Size = new System.Drawing.Size(112, 20);
            this.TxtMusteriIP.TabIndex = 5;
            // 
            // TxtMusteriPort
            // 
            this.TxtMusteriPort.Location = new System.Drawing.Point(360, 125);
            this.TxtMusteriPort.Name = "TxtMusteriPort";
            this.TxtMusteriPort.Size = new System.Drawing.Size(133, 20);
            this.TxtMusteriPort.TabIndex = 6;
            // 
            // SunucuyuBaslat
            // 
            this.SunucuyuBaslat.Location = new System.Drawing.Point(40, 92);
            this.SunucuyuBaslat.Name = "SunucuyuBaslat";
            this.SunucuyuBaslat.Size = new System.Drawing.Size(625, 23);
            this.SunucuyuBaslat.TabIndex = 7;
            this.SunucuyuBaslat.Text = "Sunucuyu Başlat";
            this.SunucuyuBaslat.UseVisualStyleBackColor = true;
            this.SunucuyuBaslat.Click += new System.EventHandler(this.SunucuyuBaslat_Click);
            // 
            // ServeraBaglan
            // 
            this.ServeraBaglan.Location = new System.Drawing.Point(40, 151);
            this.ServeraBaglan.Name = "ServeraBaglan";
            this.ServeraBaglan.Size = new System.Drawing.Size(622, 31);
            this.ServeraBaglan.TabIndex = 8;
            this.ServeraBaglan.Text = "Bağlantı";
            this.ServeraBaglan.UseVisualStyleBackColor = true;
            this.ServeraBaglan.Click += new System.EventHandler(this.ServeraBaglan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sunucu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "IP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Port:";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServeraBaglan);
            this.Controls.Add(this.SunucuyuBaslat);
            this.Controls.Add(this.TxtMusteriPort);
            this.Controls.Add(this.TxtMusteriIP);
            this.Controls.Add(this.TxtServerPort);
            this.Controls.Add(this.TxtServerIP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Gonder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gonder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TxtServerIP;
        private System.Windows.Forms.TextBox TxtServerPort;
        private System.Windows.Forms.TextBox TxtMusteriIP;
        private System.Windows.Forms.TextBox TxtMusteriPort;
        private System.Windows.Forms.Button SunucuyuBaslat;
        private System.Windows.Forms.Button ServeraBaglan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

