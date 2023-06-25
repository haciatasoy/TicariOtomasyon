namespace TicariOtomasyon
{
	partial class FrmUrunler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
			this.txtAdet = new DevExpress.XtraEditors.TextEdit();
			this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.txtDetay = new System.Windows.Forms.RichTextBox();
			this.txtYil = new System.Windows.Forms.MaskedTextBox();
			this.txtSatis = new DevExpress.XtraEditors.TextEdit();
			this.txtAlis = new DevExpress.XtraEditors.TextEdit();
			this.txtModel = new DevExpress.XtraEditors.TextEdit();
			this.txtMarka = new DevExpress.XtraEditors.TextEdit();
			this.txtAd = new DevExpress.XtraEditors.TextEdit();
			this.txtID = new DevExpress.XtraEditors.TextEdit();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSatis.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlis.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1649, 754);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.BtnGuncelle);
			this.groupControl1.Controls.Add(this.BtnSil);
			this.groupControl1.Controls.Add(this.txtAdet);
			this.groupControl1.Controls.Add(this.BtnKaydet);
			this.groupControl1.Controls.Add(this.txtDetay);
			this.groupControl1.Controls.Add(this.txtYil);
			this.groupControl1.Controls.Add(this.txtSatis);
			this.groupControl1.Controls.Add(this.txtAlis);
			this.groupControl1.Controls.Add(this.txtModel);
			this.groupControl1.Controls.Add(this.txtMarka);
			this.groupControl1.Controls.Add(this.txtAd);
			this.groupControl1.Controls.Add(this.txtID);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.labelControl8);
			this.groupControl1.Controls.Add(this.labelControl7);
			this.groupControl1.Controls.Add(this.labelControl6);
			this.groupControl1.Controls.Add(this.labelControl5);
			this.groupControl1.Controls.Add(this.labelControl4);
			this.groupControl1.Controls.Add(this.labelControl3);
			this.groupControl1.Controls.Add(this.labelControl2);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Location = new System.Drawing.Point(1655, 0);
			this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(407, 754);
			this.groupControl1.TabIndex = 1;
			this.groupControl1.Text = "URUN KAYDET";
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
			this.BtnGuncelle.Location = new System.Drawing.Point(120, 601);
			this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
			this.BtnGuncelle.Name = "BtnGuncelle";
			this.BtnGuncelle.Size = new System.Drawing.Size(257, 52);
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
			this.BtnSil.Location = new System.Drawing.Point(120, 542);
			this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(257, 52);
			this.BtnSil.TabIndex = 20;
			this.BtnSil.Text = "Sil";
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// txtAdet
			// 
			this.txtAdet.Location = new System.Drawing.Point(120, 277);
			this.txtAdet.Margin = new System.Windows.Forms.Padding(4);
			this.txtAdet.Name = "txtAdet";
			this.txtAdet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdet.Properties.Appearance.Options.UseFont = true;
			this.txtAdet.Size = new System.Drawing.Size(257, 30);
			this.txtAdet.TabIndex = 6;
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
			this.BtnKaydet.Location = new System.Drawing.Point(120, 482);
			this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(257, 52);
			this.BtnKaydet.TabIndex = 18;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// txtDetay
			// 
			this.txtDetay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDetay.Location = new System.Drawing.Point(120, 356);
			this.txtDetay.Margin = new System.Windows.Forms.Padding(4);
			this.txtDetay.Name = "txtDetay";
			this.txtDetay.Size = new System.Drawing.Size(256, 117);
			this.txtDetay.TabIndex = 8;
			this.txtDetay.Text = "";
			// 
			// txtYil
			// 
			this.txtYil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtYil.Location = new System.Drawing.Point(120, 316);
			this.txtYil.Margin = new System.Windows.Forms.Padding(4);
			this.txtYil.Mask = "0000";
			this.txtYil.Name = "txtYil";
			this.txtYil.Size = new System.Drawing.Size(256, 30);
			this.txtYil.TabIndex = 7;
			this.txtYil.ValidatingType = typeof(int);
			// 
			// txtSatis
			// 
			this.txtSatis.Location = new System.Drawing.Point(120, 240);
			this.txtSatis.Margin = new System.Windows.Forms.Padding(4);
			this.txtSatis.Name = "txtSatis";
			this.txtSatis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSatis.Properties.Appearance.Options.UseFont = true;
			this.txtSatis.Size = new System.Drawing.Size(257, 30);
			this.txtSatis.TabIndex = 5;
			// 
			// txtAlis
			// 
			this.txtAlis.Location = new System.Drawing.Point(120, 201);
			this.txtAlis.Margin = new System.Windows.Forms.Padding(4);
			this.txtAlis.Name = "txtAlis";
			this.txtAlis.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAlis.Properties.Appearance.Options.UseFont = true;
			this.txtAlis.Size = new System.Drawing.Size(257, 30);
			this.txtAlis.TabIndex = 4;
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(120, 158);
			this.txtModel.Margin = new System.Windows.Forms.Padding(4);
			this.txtModel.Name = "txtModel";
			this.txtModel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtModel.Properties.Appearance.Options.UseFont = true;
			this.txtModel.Size = new System.Drawing.Size(257, 30);
			this.txtModel.TabIndex = 3;
			// 
			// txtMarka
			// 
			this.txtMarka.Location = new System.Drawing.Point(120, 114);
			this.txtMarka.Margin = new System.Windows.Forms.Padding(4);
			this.txtMarka.Name = "txtMarka";
			this.txtMarka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMarka.Properties.Appearance.Options.UseFont = true;
			this.txtMarka.Size = new System.Drawing.Size(257, 30);
			this.txtMarka.TabIndex = 2;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(120, 78);
			this.txtAd.Margin = new System.Windows.Forms.Padding(4);
			this.txtAd.Name = "txtAd";
			this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAd.Properties.Appearance.Options.UseFont = true;
			this.txtAd.Size = new System.Drawing.Size(257, 30);
			this.txtAd.TabIndex = 1;
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
			this.labelControl9.Location = new System.Drawing.Point(53, 356);
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
			this.labelControl8.Location = new System.Drawing.Point(15, 247);
			this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(95, 23);
			this.labelControl8.TabIndex = 7;
			this.labelControl8.Text = "Satış Fiyatı:";
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(28, 208);
			this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(83, 23);
			this.labelControl7.TabIndex = 6;
			this.labelControl7.Text = "Alış Fiyatı:";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(65, 284);
			this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(45, 23);
			this.labelControl6.TabIndex = 5;
			this.labelControl6.Text = "Adet:";
			this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(87, 326);
			this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(26, 23);
			this.labelControl5.TabIndex = 4;
			this.labelControl5.Text = "Yıl:";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(55, 161);
			this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(57, 23);
			this.labelControl4.TabIndex = 3;
			this.labelControl4.Text = "Model:";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(52, 118);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(58, 23);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Marka:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(83, 81);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(29, 23);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Ad:";
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
			this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
			// 
			// FrmUrunler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 752);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmUrunler";
			this.Text = "Ürünler";
			this.Load += new System.EventHandler(this.FrmUrunler_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSatis.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAlis.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtModel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMarka.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.RichTextBox txtDetay;
		private DevExpress.XtraEditors.TextEdit txtSatis;
		private DevExpress.XtraEditors.TextEdit txtAlis;
		private DevExpress.XtraEditors.TextEdit txtModel;
		private DevExpress.XtraEditors.TextEdit txtMarka;
		private DevExpress.XtraEditors.TextEdit txtAd;
		private DevExpress.XtraEditors.TextEdit txtID;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.SimpleButton BtnKaydet;
		private DevExpress.XtraEditors.TextEdit txtAdet;
		private System.Windows.Forms.MaskedTextBox txtYil;
		private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
		private DevExpress.XtraEditors.SimpleButton BtnSil;
	}
}