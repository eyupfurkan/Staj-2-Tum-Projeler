namespace ParaMiktarlarim.cs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTamsayi = new System.Windows.Forms.TextBox();
            this.TxtOndalik = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtParaMiktariid = new System.Windows.Forms.TextBox();
            this.BtnGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamsayi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ondalik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(93, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Para Miktarı";
            // 
            // TxtTamsayi
            // 
            this.TxtTamsayi.Location = new System.Drawing.Point(27, 98);
            this.TxtTamsayi.Name = "TxtTamsayi";
            this.TxtTamsayi.Size = new System.Drawing.Size(111, 20);
            this.TxtTamsayi.TabIndex = 1;
            this.TxtTamsayi.TextChanged += new System.EventHandler(this.TxtTamsayi_TextChanged);
            this.TxtTamsayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTamsayi_KeyPress);
            this.TxtTamsayi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTamsayi_KeyUp);
            // 
            // TxtOndalik
            // 
            this.TxtOndalik.Location = new System.Drawing.Point(154, 98);
            this.TxtOndalik.MaxLength = 3;
            this.TxtOndalik.Name = "TxtOndalik";
            this.TxtOndalik.Size = new System.Drawing.Size(111, 20);
            this.TxtOndalik.TabIndex = 2;
            this.TxtOndalik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOndalik_KeyPress);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(27, 143);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(111, 42);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Para Miktarı id";
            // 
            // TxtParaMiktariid
            // 
            this.TxtParaMiktariid.Location = new System.Drawing.Point(280, 41);
            this.TxtParaMiktariid.Name = "TxtParaMiktariid";
            this.TxtParaMiktariid.Size = new System.Drawing.Size(111, 20);
            this.TxtParaMiktariid.TabIndex = 8;
            // 
            // BtnGetir
            // 
            this.BtnGetir.Location = new System.Drawing.Point(154, 143);
            this.BtnGetir.Name = "BtnGetir";
            this.BtnGetir.Size = new System.Drawing.Size(111, 42);
            this.BtnGetir.TabIndex = 9;
            this.BtnGetir.Text = "Getir";
            this.BtnGetir.UseVisualStyleBackColor = true;
            this.BtnGetir.Click += new System.EventHandler(this.BtnGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(280, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 193);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Para Mitarları Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGetir);
            this.Controls.Add(this.TxtParaMiktariid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtOndalik);
            this.Controls.Add(this.TxtTamsayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTamsayi;
        private System.Windows.Forms.TextBox TxtOndalik;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtParaMiktariid;
        private System.Windows.Forms.Button BtnGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

