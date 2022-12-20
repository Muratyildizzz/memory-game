namespace hafıza
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDikey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYatay = new System.Windows.Forms.TextBox();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.süre = new System.Windows.Forms.Label();
            this.lbl_Hatasayisi = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_Hatasayisi);
            this.groupBox2.Controls.Add(this.süre);
            this.groupBox2.Controls.Add(this.txtDikey);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtYatay);
            this.groupBox2.Controls.Add(this.btnBitir);
            this.groupBox2.Controls.Add(this.btnBaslat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(827, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 803);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MENÜ";
            // 
            // txtDikey
            // 
            this.txtDikey.Location = new System.Drawing.Point(67, 658);
            this.txtDikey.Name = "txtDikey";
            this.txtDikey.Size = new System.Drawing.Size(136, 22);
            this.txtDikey.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 661);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "DİKEY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "YATAY";
            // 
            // txtYatay
            // 
            this.txtYatay.Location = new System.Drawing.Point(67, 619);
            this.txtYatay.Name = "txtYatay";
            this.txtYatay.Size = new System.Drawing.Size(136, 22);
            this.txtYatay.TabIndex = 2;
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(0, 750);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(203, 60);
            this.btnBitir.TabIndex = 1;
            this.btnBitir.Text = "TEMİZLE";
            this.btnBitir.UseVisualStyleBackColor = true;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(6, 686);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(203, 58);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 810);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "hafıza oyunu";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // süre
            // 
            this.süre.AutoSize = true;
            this.süre.Location = new System.Drawing.Point(64, 51);
            this.süre.Name = "süre";
            this.süre.Size = new System.Drawing.Size(0, 16);
            this.süre.TabIndex = 8;
            // 
            // lbl_Hatasayisi
            // 
            this.lbl_Hatasayisi.AutoSize = true;
            this.lbl_Hatasayisi.Location = new System.Drawing.Point(64, 104);
            this.lbl_Hatasayisi.Name = "lbl_Hatasayisi";
            this.lbl_Hatasayisi.Size = new System.Drawing.Size(44, 16);
            this.lbl_Hatasayisi.TabIndex = 9;
            this.lbl_Hatasayisi.Text = "label3";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBaslat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 803);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hafıza Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYatay;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.TextBox txtDikey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label süre;
        private System.Windows.Forms.Label lbl_Hatasayisi;
    }
}

