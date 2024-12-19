namespace CSharpEgitimKampi301.PresentationLayer
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnIdGetir = new System.Windows.Forms.Button();
            this.rdbAktif = new System.Windows.Forms.RadioButton();
            this.rdbPasif = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(103, 9);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 426);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListele.Location = new System.Drawing.Point(103, 102);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 23);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori Adı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(103, 38);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori Durumu:";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEkle.Location = new System.Drawing.Point(103, 131);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSil.Location = new System.Drawing.Point(103, 160);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuncelle.Location = new System.Drawing.Point(103, 189);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGuncelle.TabIndex = 10;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnIdGetir
            // 
            this.btnIdGetir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIdGetir.Location = new System.Drawing.Point(103, 218);
            this.btnIdGetir.Name = "btnIdGetir";
            this.btnIdGetir.Size = new System.Drawing.Size(100, 23);
            this.btnIdGetir.TabIndex = 11;
            this.btnIdGetir.Text = "ID\'ye Göre Getir";
            this.btnIdGetir.UseVisualStyleBackColor = false;
            // 
            // rdbAktif
            // 
            this.rdbAktif.AutoSize = true;
            this.rdbAktif.Location = new System.Drawing.Point(107, 70);
            this.rdbAktif.Name = "rdbAktif";
            this.rdbAktif.Size = new System.Drawing.Size(46, 17);
            this.rdbAktif.TabIndex = 12;
            this.rdbAktif.TabStop = true;
            this.rdbAktif.Text = "Aktif";
            this.rdbAktif.UseVisualStyleBackColor = true;
            // 
            // rdbPasif
            // 
            this.rdbPasif.AutoSize = true;
            this.rdbPasif.Location = new System.Drawing.Point(155, 70);
            this.rdbPasif.Name = "rdbPasif";
            this.rdbPasif.Size = new System.Drawing.Size(48, 17);
            this.rdbPasif.TabIndex = 13;
            this.rdbPasif.TabStop = true;
            this.rdbPasif.Text = "Pasif";
            this.rdbPasif.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbPasif);
            this.Controls.Add(this.rdbAktif);
            this.Controls.Add(this.btnIdGetir);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnIdGetir;
        private System.Windows.Forms.RadioButton rdbAktif;
        private System.Windows.Forms.RadioButton rdbPasif;
    }
}

