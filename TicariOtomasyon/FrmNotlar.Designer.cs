namespace TicariOtomasyon
{
	partial class FrmNotlar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.txtSaat = new System.Windows.Forms.MaskedTextBox();
			this.txtTarih = new System.Windows.Forms.MaskedTextBox();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
			this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.txtDetay = new System.Windows.Forms.RichTextBox();
			this.txtBaslik = new DevExpress.XtraEditors.TextEdit();
			this.txtKime = new DevExpress.XtraEditors.TextEdit();
			this.txtOlusturan = new DevExpress.XtraEditors.TextEdit();
			this.txtID = new DevExpress.XtraEditors.TextEdit();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKime.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOlusturan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridView1
			// 
			this.gridView1.DetailHeight = 431;
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// gridControl1
			// 
			this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.gridControl1.Location = new System.Drawing.Point(-63, -1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1649, 754);
			this.gridControl1.TabIndex = 4;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// txtSaat
			// 
			this.txtSaat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSaat.Location = new System.Drawing.Point(120, 111);
			this.txtSaat.Margin = new System.Windows.Forms.Padding(4);
			this.txtSaat.Mask = "00:00";
			this.txtSaat.Name = "txtSaat";
			this.txtSaat.Size = new System.Drawing.Size(256, 30);
			this.txtSaat.TabIndex = 2;
			this.txtSaat.ValidatingType = typeof(System.DateTime);
			// 
			// txtTarih
			// 
			this.txtTarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTarih.Location = new System.Drawing.Point(120, 74);
			this.txtTarih.Margin = new System.Windows.Forms.Padding(4);
			this.txtTarih.Mask = "00/00/0000";
			this.txtTarih.Name = "txtTarih";
			this.txtTarih.Size = new System.Drawing.Size(256, 30);
			this.txtTarih.TabIndex = 1;
			this.txtTarih.ValidatingType = typeof(System.DateTime);
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.txtSaat);
			this.groupControl1.Controls.Add(this.txtTarih);
			this.groupControl1.Controls.Add(this.BtnGuncelle);
			this.groupControl1.Controls.Add(this.BtnSil);
			this.groupControl1.Controls.Add(this.BtnKaydet);
			this.groupControl1.Controls.Add(this.txtDetay);
			this.groupControl1.Controls.Add(this.txtBaslik);
			this.groupControl1.Controls.Add(this.txtKime);
			this.groupControl1.Controls.Add(this.txtOlusturan);
			this.groupControl1.Controls.Add(this.txtID);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.labelControl8);
			this.groupControl1.Controls.Add(this.labelControl6);
			this.groupControl1.Controls.Add(this.labelControl4);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Location = new System.Drawing.Point(1581, -1);
			this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(407, 754);
			this.groupControl1.TabIndex = 5;
			// 
			// BtnGuncelle
			// 
			this.BtnGuncelle.Appearance.BackColor = System.Drawing.Color.White;
			this.BtnGuncelle.Appearance.ForeColor = System.Drawing.Color.Black;
			this.BtnGuncelle.Appearance.Options.UseBackColor = true;
			this.BtnGuncelle.Appearance.Options.UseForeColor = true;
			this.BtnGuncelle.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.BtnGuncelle.AppearancePressed.Options.UseBackColor = true;
			this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
			this.BtnGuncelle.Location = new System.Drawing.Point(120, 584);
			this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(257, 28);
			this.BtnGuncelle.TabIndex = 21;
			this.BtnGuncelle.Text = "Güncelle";
			this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Appearance.BackColor = System.Drawing.Color.White;
			this.BtnSil.Appearance.ForeColor = System.Drawing.Color.Black;
			this.BtnSil.Appearance.Options.UseBackColor = true;
			this.BtnSil.Appearance.Options.UseForeColor = true;
			this.BtnSil.AppearancePressed.BackColor = System.Drawing.Color.Red;
			this.BtnSil.AppearancePressed.Options.UseBackColor = true;
			this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
			this.BtnSil.Location = new System.Drawing.Point(120, 532);
			this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(257, 31);
			this.BtnSil.TabIndex = 20;
			this.BtnSil.Text = "Sil";
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Appearance.BackColor = System.Drawing.Color.White;
			this.BtnKaydet.Appearance.ForeColor = System.Drawing.Color.Black;
			this.BtnKaydet.Appearance.Options.UseBackColor = true;
			this.BtnKaydet.Appearance.Options.UseForeColor = true;
			this.BtnKaydet.AppearancePressed.BackColor = System.Drawing.Color.Lime;
			this.BtnKaydet.AppearancePressed.Options.UseBackColor = true;
			this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
			this.BtnKaydet.Location = new System.Drawing.Point(120, 478);
			this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(257, 36);
			this.BtnKaydet.TabIndex = 18;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// txtDetay
			// 
			this.txtDetay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDetay.Location = new System.Drawing.Point(119, 263);
			this.txtDetay.Margin = new System.Windows.Forms.Padding(4);
			this.txtDetay.Name = "txtDetay";
			this.txtDetay.Size = new System.Drawing.Size(256, 186);
			this.txtDetay.TabIndex = 6;
			this.txtDetay.Text = "";
			// 
			// txtBaslik
			// 
			this.txtBaslik.Location = new System.Drawing.Point(119, 149);
			this.txtBaslik.Margin = new System.Windows.Forms.Padding(4);
			this.txtBaslik.Name = "txtBaslik";
			this.txtBaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBaslik.Properties.Appearance.Options.UseFont = true;
			this.txtBaslik.Size = new System.Drawing.Size(257, 30);
			this.txtBaslik.TabIndex = 3;
			// 
			// txtKime
			// 
			this.txtKime.Location = new System.Drawing.Point(119, 225);
			this.txtKime.Margin = new System.Windows.Forms.Padding(4);
			this.txtKime.Name = "txtKime";
			this.txtKime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKime.Properties.Appearance.Options.UseFont = true;
			this.txtKime.Size = new System.Drawing.Size(257, 30);
			this.txtKime.TabIndex = 5;
			// 
			// txtOlusturan
			// 
			this.txtOlusturan.Location = new System.Drawing.Point(119, 187);
			this.txtOlusturan.Margin = new System.Windows.Forms.Padding(4);
			this.txtOlusturan.Name = "txtOlusturan";
			this.txtOlusturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtOlusturan.Properties.Appearance.Options.UseFont = true;
			this.txtOlusturan.Size = new System.Drawing.Size(257, 30);
			this.txtOlusturan.TabIndex = 4;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(120, 41);
			this.txtID.Margin = new System.Windows.Forms.Padding(4);
			this.txtID.Name = "txtID";
			this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtID.Properties.Appearance.Options.UseFont = true;
			this.txtID.Size = new System.Drawing.Size(257, 30);
			this.txtID.TabIndex = 9;
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl9.Appearance.Options.UseFont = true;
			this.labelControl9.Location = new System.Drawing.Point(56, 263);
			this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(55, 23);
			this.labelControl9.TabIndex = 8;
			this.labelControl9.Text = "Detay:";
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(25, 194);
			this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(88, 23);
			this.labelControl8.TabIndex = 7;
			this.labelControl8.Text = "Oluşturan:";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(65, 232);
			this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(48, 23);
			this.labelControl6.TabIndex = 5;
			this.labelControl6.Text = "Kime:";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(60, 156);
			this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(53, 23);
			this.labelControl4.TabIndex = 3;
			this.labelControl4.Text = "Başlık:";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(67, 118);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(44, 23);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Saat:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(63, 81);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(50, 23);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Tarih:";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(84, 43);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(27, 23);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "ID:";
			// 
			// FrmNotlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 752);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmNotlar";
			this.Text = "Notlar";
			this.Load += new System.EventHandler(this.FrmNotlar_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBaslik.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKime.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOlusturan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private System.Windows.Forms.MaskedTextBox txtSaat;
		private System.Windows.Forms.MaskedTextBox txtTarih;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
		private DevExpress.XtraEditors.SimpleButton BtnSil;
		private DevExpress.XtraEditors.SimpleButton BtnKaydet;
		private System.Windows.Forms.RichTextBox txtDetay;
		private DevExpress.XtraEditors.TextEdit txtBaslik;
		private DevExpress.XtraEditors.TextEdit txtKime;
		private DevExpress.XtraEditors.TextEdit txtOlusturan;
		private DevExpress.XtraEditors.TextEdit txtID;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}