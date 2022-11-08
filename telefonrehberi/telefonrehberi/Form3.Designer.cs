namespace telefonrehberi
{
    partial class Form3
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
            this.dataGridRehber = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Kaydet = new System.Windows.Forms.Button();
            this.kayitlar = new System.Windows.Forms.Button();
            this.Ara = new System.Windows.Forms.Button();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRehber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRehber
            // 
            this.dataGridRehber.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRehber.Location = new System.Drawing.Point(22, 289);
            this.dataGridRehber.Name = "dataGridRehber";
            this.dataGridRehber.RowHeadersWidth = 51;
            this.dataGridRehber.RowTemplate.Height = 24;
            this.dataGridRehber.Size = new System.Drawing.Size(771, 229);
            this.dataGridRehber.TabIndex = 0;
            this.dataGridRehber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRehber_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone";
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.White;
            this.Kaydet.Location = new System.Drawing.Point(481, 40);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(94, 78);
            this.Kaydet.TabIndex = 4;
            this.Kaydet.Text = "kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // kayitlar
            // 
            this.kayitlar.BackColor = System.Drawing.Color.White;
            this.kayitlar.Location = new System.Drawing.Point(481, 132);
            this.kayitlar.Name = "kayitlar";
            this.kayitlar.Size = new System.Drawing.Size(94, 84);
            this.kayitlar.TabIndex = 5;
            this.kayitlar.Text = "kayıt getir";
            this.kayitlar.UseVisualStyleBackColor = false;
            this.kayitlar.Click += new System.EventHandler(this.kayitlar_Click);
            // 
            // Ara
            // 
            this.Ara.BackColor = System.Drawing.Color.White;
            this.Ara.Location = new System.Drawing.Point(634, 260);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(159, 23);
            this.Ara.TabIndex = 6;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = false;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(132, 63);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(119, 22);
            this.txtAD.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(132, 112);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(119, 22);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(132, 159);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(119, 22);
            this.txtPhone.TabIndex = 9;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(22, 261);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(606, 22);
            this.txtAra.TabIndex = 10;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(617, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 84);
            this.button2.TabIndex = 12;
            this.button2.Text = "csv getir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(73, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(132, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(119, 22);
            this.txtId.TabIndex = 14;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(617, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 78);
            this.button1.TabIndex = 11;
            this.button1.Text = "sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.CalendarMonthBackground = System.Drawing.Color.White;
            this.txtTarih.Location = new System.Drawing.Point(145, 196);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(200, 22);
            this.txtTarih.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kayıt Tarih:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(270, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 60);
            this.button3.TabIndex = 17;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(723, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 78);
            this.button4.TabIndex = 18;
            this.button4.Text = "güncelle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(870, 565);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.kayitlar);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridRehber);
            this.Name = "Form3";
            this.Text = "Rehberim";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRehber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRehber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button kayitlar;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}