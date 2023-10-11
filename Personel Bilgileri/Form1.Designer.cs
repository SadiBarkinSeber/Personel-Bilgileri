namespace Personel_Bilgileri
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
            this.gBPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.pBResim = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.dtpIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lVList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gBPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBResim)).BeginInit();
            this.SuspendLayout();
            // 
            // gBPersonelBilgileri
            // 
            this.gBPersonelBilgileri.Controls.Add(this.txtAdres);
            this.gBPersonelBilgileri.Controls.Add(this.dtpDogumTarihi);
            this.gBPersonelBilgileri.Controls.Add(this.mtbTelefon);
            this.gBPersonelBilgileri.Controls.Add(this.pBResim);
            this.gBPersonelBilgileri.Controls.Add(this.btnSil);
            this.gBPersonelBilgileri.Controls.Add(this.btnGuncelle);
            this.gBPersonelBilgileri.Controls.Add(this.btnKaydet);
            this.gBPersonelBilgileri.Controls.Add(this.btnResimSec);
            this.gBPersonelBilgileri.Controls.Add(this.dtpIseGirisTarihi);
            this.gBPersonelBilgileri.Controls.Add(this.label8);
            this.gBPersonelBilgileri.Controls.Add(this.label7);
            this.gBPersonelBilgileri.Controls.Add(this.textBox6);
            this.gBPersonelBilgileri.Controls.Add(this.textBox3);
            this.gBPersonelBilgileri.Controls.Add(this.textBox2);
            this.gBPersonelBilgileri.Controls.Add(this.textBox1);
            this.gBPersonelBilgileri.Controls.Add(this.label6);
            this.gBPersonelBilgileri.Controls.Add(this.label5);
            this.gBPersonelBilgileri.Controls.Add(this.label4);
            this.gBPersonelBilgileri.Controls.Add(this.label3);
            this.gBPersonelBilgileri.Controls.Add(this.label2);
            this.gBPersonelBilgileri.Controls.Add(this.label1);
            this.gBPersonelBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBPersonelBilgileri.Location = new System.Drawing.Point(13, 13);
            this.gBPersonelBilgileri.Name = "gBPersonelBilgileri";
            this.gBPersonelBilgileri.Size = new System.Drawing.Size(750, 338);
            this.gBPersonelBilgileri.TabIndex = 0;
            this.gBPersonelBilgileri.TabStop = false;
            this.gBPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdres.Location = new System.Drawing.Point(463, 40);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(253, 105);
            this.txtAdres.TabIndex = 24;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(148, 163);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(201, 26);
            this.dtpDogumTarihi.TabIndex = 23;
            this.dtpDogumTarihi.ValueChanged += new System.EventHandler(this.dtpDogumTarihi_ValueChanged);
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Location = new System.Drawing.Point(148, 202);
            this.mtbTelefon.Mask = "(999) 000-0000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(201, 26);
            this.mtbTelefon.TabIndex = 22;
            // 
            // pBResim
            // 
            this.pBResim.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pBResim.Image = global::Personel_Bilgileri.Properties.Resources.istockphoto_1083280462_612x612;
            this.pBResim.Location = new System.Drawing.Point(410, 158);
            this.pBResim.Name = "pBResim";
            this.pBResim.Size = new System.Drawing.Size(181, 174);
            this.pBResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBResim.TabIndex = 21;
            this.pBResim.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(611, 296);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(105, 34);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(611, 251);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(105, 34);
            this.btnGuncelle.TabIndex = 19;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(611, 206);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 34);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(611, 161);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(105, 34);
            this.btnResimSec.TabIndex = 17;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // dtpIseGirisTarihi
            // 
            this.dtpIseGirisTarihi.Location = new System.Drawing.Point(148, 286);
            this.dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            this.dtpIseGirisTarihi.Size = new System.Drawing.Size(201, 26);
            this.dtpIseGirisTarihi.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "İşe Giriş Tarihi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adres :";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point(148, 242);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(201, 26);
            this.textBox6.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 26);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID :";
            // 
            // lVList
            // 
            this.lVList.BackColor = System.Drawing.SystemColors.Window;
            this.lVList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader7});
            this.lVList.FullRowSelect = true;
            this.lVList.GridLines = true;
            this.lVList.HideSelection = false;
            this.lVList.Location = new System.Drawing.Point(12, 357);
            this.lVList.Name = "lVList";
            this.lVList.Size = new System.Drawing.Size(751, 180);
            this.lVList.TabIndex = 1;
            this.lVList.UseCompatibleStateImageBehavior = false;
            this.lVList.View = System.Windows.Forms.View.Details;
            this.lVList.SelectedIndexChanged += new System.EventHandler(this.lVList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Personel ID";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doğum Tarihi";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 95;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Email";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 95;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "İşe Giriş Tarihi";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 95;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adres";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 95;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(773, 549);
            this.Controls.Add(this.lVList);
            this.Controls.Add(this.gBPersonelBilgileri);
            this.Name = "Form1";
            this.Text = "Personel Bilgileri";
            this.gBPersonelBilgileri.ResumeLayout(false);
            this.gBPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBResim)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gBPersonelBilgileri;
		private System.Windows.Forms.PictureBox pBResim;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnResimSec;
		private System.Windows.Forms.DateTimePicker dtpIseGirisTarihi;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lVList;
		private System.Windows.Forms.MaskedTextBox mtbTelefon;
		private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TextBox txtAdres;
    }
}

