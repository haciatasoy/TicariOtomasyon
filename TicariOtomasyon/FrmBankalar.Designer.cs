namespace TicariOtomasyon
{
	partial class FrmBankalar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
			this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
			this.txtTel = new System.Windows.Forms.MaskedTextBox();
			this.txtHesapNo = new System.Windows.Forms.MaskedTextBox();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.txtTarih = new System.Windows.Forms.MaskedTextBox();
			this.txtFirma = new DevExpress.XtraEditors.LookUpEdit();
			this.txtHesapTuru = new DevExpress.XtraEditors.TextEdit();
			this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
			this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.txtIban = new System.Windows.Forms.MaskedTextBox();
			this.txtSube = new DevExpress.XtraEditors.TextEdit();
			this.txtYetkili = new DevExpress.XtraEditors.TextEdit();
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
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			this.groupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFirma.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
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
			// labelControl11
			// 
			this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl11.Appearance.Options.UseFont = true;
			this.labelControl11.Location = new System.Drawing.Point(60, 411);
			this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(50, 23);
			this.labelControl11.TabIndex = 27;
			this.labelControl11.Text = "Tarih:";
			// 
			// labelControl10
			// 
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl10.Appearance.Options.UseFont = true;
			this.labelControl10.Location = new System.Drawing.Point(41, 373);
			this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(69, 23);
			this.labelControl10.TabIndex = 26;
			this.labelControl10.Text = "Telefon:";
			// 
			// cmbIlce
			// 
			this.cmbIlce.Location = new System.Drawing.Point(120, 158);
			this.cmbIlce.Margin = new System.Windows.Forms.Padding(4);
			this.cmbIlce.Name = "cmbIlce";
			this.cmbIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbIlce.Properties.Appearance.Options.UseFont = true;
			this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbIlce.Size = new System.Drawing.Size(257, 30);
			this.cmbIlce.TabIndex = 3;
			// 
			// cmbIl
			// 
			this.cmbIl.Location = new System.Drawing.Point(120, 114);
			this.cmbIl.Margin = new System.Windows.Forms.Padding(4);
			this.cmbIl.Name = "cmbIl";
			this.cmbIl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbIl.Properties.Appearance.Options.UseFont = true;
			this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbIl.Size = new System.Drawing.Size(257, 30);
			this.cmbIl.TabIndex = 2;
			this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
			// 
			// txtTel
			// 
			this.txtTel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTel.Location = new System.Drawing.Point(120, 366);
			this.txtTel.Margin = new System.Windows.Forms.Padding(4);
			this.txtTel.Mask = "(999) 000-0000";
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(256, 30);
			this.txtTel.TabIndex = 8;
			// 
			// txtHesapNo
			// 
			this.txtHesapNo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtHesapNo.Location = new System.Drawing.Point(120, 284);
			this.txtHesapNo.Margin = new System.Windows.Forms.Padding(4);
			this.txtHesapNo.Name = "txtHesapNo";
			this.txtHesapNo.Size = new System.Drawing.Size(256, 30);
			this.txtHesapNo.TabIndex = 6;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.txtTarih);
			this.groupControl1.Controls.Add(this.txtFirma);
			this.groupControl1.Controls.Add(this.txtHesapTuru);
			this.groupControl1.Controls.Add(this.labelControl12);
			this.groupControl1.Controls.Add(this.labelControl11);
			this.groupControl1.Controls.Add(this.labelControl10);
			this.groupControl1.Controls.Add(this.cmbIlce);
			this.groupControl1.Controls.Add(this.cmbIl);
			this.groupControl1.Controls.Add(this.txtTel);
			this.groupControl1.Controls.Add(this.txtHesapNo);
			this.groupControl1.Controls.Add(this.BtnGuncelle);
			this.groupControl1.Controls.Add(this.BtnSil);
			this.groupControl1.Controls.Add(this.BtnKaydet);
			this.groupControl1.Controls.Add(this.txtIban);
			this.groupControl1.Controls.Add(this.txtSube);
			this.groupControl1.Controls.Add(this.txtYetkili);
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
			this.groupControl1.Location = new System.Drawing.Point(1581, -1);
			this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(407, 754);
			this.groupControl1.TabIndex = 5;
			// 
			// txtTarih
			// 
			this.txtTarih.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTarih.Location = new System.Drawing.Point(120, 404);
			this.txtTarih.Margin = new System.Windows.Forms.Padding(4);
			this.txtTarih.Mask = "00/00/0000";
			this.txtTarih.Name = "txtTarih";
			this.txtTarih.Size = new System.Drawing.Size(256, 30);
			this.txtTarih.TabIndex = 9;
			this.txtTarih.ValidatingType = typeof(System.DateTime);
			// 
			// txtFirma
			// 
			this.txtFirma.Location = new System.Drawing.Point(120, 479);
			this.txtFirma.Name = "txtFirma";
			this.txtFirma.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtFirma.Properties.Appearance.Options.UseFont = true;
			this.txtFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.txtFirma.Properties.NullText = "Firma Seçiniz...";
			this.txtFirma.Size = new System.Drawing.Size(257, 28);
			this.txtFirma.TabIndex = 11;
			// 
			// txtHesapTuru
			// 
			this.txtHesapTuru.Location = new System.Drawing.Point(120, 442);
			this.txtHesapTuru.Margin = new System.Windows.Forms.Padding(4);
			this.txtHesapTuru.Name = "txtHesapTuru";
			this.txtHesapTuru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtHesapTuru.Properties.Appearance.Options.UseFont = true;
			this.txtHesapTuru.Size = new System.Drawing.Size(257, 30);
			this.txtHesapTuru.TabIndex = 10;
			// 
			// labelControl12
			// 
			this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl12.Appearance.Options.UseFont = true;
			this.labelControl12.Location = new System.Drawing.Point(56, 484);
			this.labelControl12.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl12.Name = "labelControl12";
			this.labelControl12.Size = new System.Drawing.Size(54, 23);
			this.labelControl12.TabIndex = 28;
			this.labelControl12.Text = "Firma:";
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
			this.BtnGuncelle.Location = new System.Drawing.Point(120, 646);
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
			this.BtnSil.Location = new System.Drawing.Point(120, 594);
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
			this.BtnKaydet.Location = new System.Drawing.Point(120, 540);
			this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(257, 36);
			this.BtnKaydet.TabIndex = 18;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// txtIban
			// 
			this.txtIban.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtIban.Location = new System.Drawing.Point(120, 238);
			this.txtIban.Margin = new System.Windows.Forms.Padding(4);
			this.txtIban.Name = "txtIban";
			this.txtIban.Size = new System.Drawing.Size(256, 30);
			this.txtIban.TabIndex = 5;
			this.txtIban.ValidatingType = typeof(int);
			// 
			// txtSube
			// 
			this.txtSube.Location = new System.Drawing.Point(120, 201);
			this.txtSube.Margin = new System.Windows.Forms.Padding(4);
			this.txtSube.Name = "txtSube";
			this.txtSube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSube.Properties.Appearance.Options.UseFont = true;
			this.txtSube.Size = new System.Drawing.Size(257, 30);
			this.txtSube.TabIndex = 4;
			// 
			// txtYetkili
			// 
			this.txtYetkili.Location = new System.Drawing.Point(120, 326);
			this.txtYetkili.Margin = new System.Windows.Forms.Padding(4);
			this.txtYetkili.Name = "txtYetkili";
			this.txtYetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtYetkili.Properties.Appearance.Options.UseFont = true;
			this.txtYetkili.Size = new System.Drawing.Size(257, 30);
			this.txtYetkili.TabIndex = 7;
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
			this.txtID.TabIndex = 15;
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl9.Appearance.Options.UseFont = true;
			this.labelControl9.Location = new System.Drawing.Point(6, 449);
			this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(105, 23);
			this.labelControl9.TabIndex = 8;
			this.labelControl9.Text = "Hesap Türü:";
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(62, 245);
			this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(49, 23);
			this.labelControl8.TabIndex = 7;
			this.labelControl8.Text = "IBAN:";
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(61, 208);
			this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(50, 23);
			this.labelControl7.TabIndex = 6;
			this.labelControl7.Text = "Şube:";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(23, 291);
			this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(88, 23);
			this.labelControl6.TabIndex = 5;
			this.labelControl6.Text = "Hesap No:";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(55, 333);
			this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(55, 23);
			this.labelControl5.TabIndex = 4;
			this.labelControl5.Text = "Yetkili:";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(73, 165);
			this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(37, 23);
			this.labelControl4.TabIndex = 3;
			this.labelControl4.Text = "İlçe:";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(92, 121);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(18, 23);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "İl:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(20, 87);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(90, 23);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Banka Adı:";
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
			// FrmBankalar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 752);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmBankalar";
			this.Text = "Bankalar";
			this.Load += new System.EventHandler(this.FrmBankalar_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFirma.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHesapTuru.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSube.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtYetkili.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraEditors.LabelControl labelControl11;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
		private DevExpress.XtraEditors.ComboBoxEdit cmbIl;
		private System.Windows.Forms.MaskedTextBox txtTel;
		private System.Windows.Forms.MaskedTextBox txtHesapNo;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
		private DevExpress.XtraEditors.SimpleButton BtnSil;
		private DevExpress.XtraEditors.SimpleButton BtnKaydet;
		private System.Windows.Forms.MaskedTextBox txtIban;
		private DevExpress.XtraEditors.TextEdit txtSube;
		private DevExpress.XtraEditors.TextEdit txtYetkili;
		private DevExpress.XtraEditors.TextEdit txtAd;
		private DevExpress.XtraEditors.TextEdit txtID;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl12;
		private DevExpress.XtraEditors.LookUpEdit txtFirma;
		private DevExpress.XtraEditors.TextEdit txtHesapTuru;
		private System.Windows.Forms.MaskedTextBox txtTarih;
	}
}