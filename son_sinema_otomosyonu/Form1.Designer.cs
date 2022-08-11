namespace son_sinema_otomosyonu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yonetmenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinema_verileri = new son_sinema_otomosyonu.sinema_verileri();
            this.turBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yonetmenTableAdapter = new son_sinema_otomosyonu.sinema_verileriTableAdapters.yonetmenTableAdapter();
            this.turTableAdapter = new son_sinema_otomosyonu.sinema_verileriTableAdapters.turTableAdapter();
            this.sinema_otomasyonuDataSet = new son_sinema_otomosyonu.Sinema_otomasyonuDataSet();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new son_sinema_otomosyonu.Sinema_otomasyonuDataSetTableAdapters.filmTableAdapter();
            this.salonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonTableAdapter = new son_sinema_otomosyonu.Sinema_otomasyonuDataSetTableAdapters.salonTableAdapter();
            this.seansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansTableAdapter = new son_sinema_otomosyonu.Sinema_otomasyonuDataSetTableAdapters.seansTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yonetmenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinema_verileri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinema_otomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yonetmenBindingSource
            // 
            this.yonetmenBindingSource.DataMember = "yonetmen";
            this.yonetmenBindingSource.DataSource = this.sinema_verileri;
            // 
            // sinema_verileri
            // 
            this.sinema_verileri.DataSetName = "sinema_verileri";
            this.sinema_verileri.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turBindingSource
            // 
            this.turBindingSource.DataMember = "tur";
            this.turBindingSource.DataSource = this.sinema_verileri;
            // 
            // yonetmenTableAdapter
            // 
            this.yonetmenTableAdapter.ClearBeforeFill = true;
            // 
            // turTableAdapter
            // 
            this.turTableAdapter.ClearBeforeFill = true;
            // 
            // sinema_otomasyonuDataSet
            // 
            this.sinema_otomasyonuDataSet.DataSetName = "Sinema_otomasyonuDataSet";
            this.sinema_otomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "film";
            this.filmBindingSource.DataSource = this.sinema_otomasyonuDataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // salonBindingSource
            // 
            this.salonBindingSource.DataMember = "salon";
            this.salonBindingSource.DataSource = this.sinema_otomasyonuDataSet;
            // 
            // salonTableAdapter
            // 
            this.salonTableAdapter.ClearBeforeFill = true;
            // 
            // seansBindingSource
            // 
            this.seansBindingSource.DataMember = "seans";
            this.seansBindingSource.DataSource = this.sinema_otomasyonuDataSet;
            // 
            // seansTableAdapter
            // 
            this.seansTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(-55, -250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 1055);
            this.label1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(-12, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(409, 583);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(875, 10);
            this.label6.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(409, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(875, 10);
            this.label5.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(879, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Personel ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(430, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Yönetici";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(869, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(404, 313);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(421, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 313);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1397, 801);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yonetmenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinema_verileri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinema_otomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private sinema_verileri sinema_verileri;
        private System.Windows.Forms.BindingSource yonetmenBindingSource;
        private sinema_verileriTableAdapters.yonetmenTableAdapter yonetmenTableAdapter;
        private System.Windows.Forms.BindingSource turBindingSource;
        private sinema_verileriTableAdapters.turTableAdapter turTableAdapter;
        private Sinema_otomasyonuDataSet sinema_otomasyonuDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private Sinema_otomasyonuDataSetTableAdapters.filmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource salonBindingSource;
        private Sinema_otomasyonuDataSetTableAdapters.salonTableAdapter salonTableAdapter;
        private System.Windows.Forms.BindingSource seansBindingSource;
        private Sinema_otomasyonuDataSetTableAdapters.seansTableAdapter seansTableAdapter;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

