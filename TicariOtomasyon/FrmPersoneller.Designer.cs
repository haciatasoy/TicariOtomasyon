namespace TicariOtomasyon
{
	partial class FrmPersoneller
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersoneller));
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
			this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
			this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
			this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
			this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
			this.txtAdres = new System.Windows.Forms.RichTextBox();
			this.txtTc = new System.Windows.Forms.MaskedTextBox();
			this.txtGorev = new DevExpress.XtraEditors.TextEdit();
			this.txtMail = new DevExpress.XtraEditors.TextEdit();
			this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
			this.txtAd = new DevExpress.XtraEditors.TextEdit();
			this.txtID = new DevExpress.XtraEditors.TextEdit();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
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
			((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridView1
			// 
			this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
			this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.gridView1.Appearance.Preview.Options.UseBackColor = true;
			this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
			this.labelControl11.Location = new System.Drawing.Point(75, 376);
			this.labelControl11.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(37, 23);
			this.labelControl11.TabIndex = 27;
			this.labelControl11.Text = "İlçe:";
			// 
			// labelControl10
			// 
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl10.Appearance.Options.UseFont = true;
			this.labelControl10.Location = new System.Drawing.Point(93, 338);
			this.labelControl10.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(18, 23);
			this.labelControl10.TabIndex = 26;
			this.labelControl10.Text = "İl:";
			// 
			// cmbIlce
			// 
			this.cmbIlce.Location = new System.Drawing.Point(120, 369);
			this.cmbIlce.Margin = new System.Windows.Forms.Padding(4);
			this.cmbIlce.Name = "cmbIlce";
			this.cmbIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbIlce.Properties.Appearance.Options.UseFont = true;
			this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbIlce.Size = new System.Drawing.Size(257, 30);
			this.cmbIlce.TabIndex = 8;
			// 
			// cmbIl
			// 
			this.cmbIl.Location = new System.Drawing.Point(120, 331);
			this.cmbIl.Margin = new System.Windows.Forms.Padding(4);
			this.cmbIl.Name = "cmbIl";
			this.cmbIl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbIl.Properties.Appearance.Options.UseFont = true;
			this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.cmbIl.Size = new System.Drawing.Size(257, 30);
			this.cmbIl.TabIndex = 7;
			this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
			// 
			// txtTel1
			// 
			this.txtTel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTel1.Location = new System.Drawing.Point(120, 284);
			this.txtTel1.Margin = new System.Windows.Forms.Padding(4);
			this.txtTel1.Mask = "(999) 000-0000";
			this.txtTel1.Name = "txtTel1";
			this.txtTel1.Size = new System.Drawing.Size(256, 30);
			this.txtTel1.TabIndex = 6;
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.labelControl11);
			this.groupControl1.Controls.Add(this.labelControl10);
			this.groupControl1.Controls.Add(this.cmbIlce);
			this.groupControl1.Controls.Add(this.cmbIl);
			this.groupControl1.Controls.Add(this.txtTel1);
			this.groupControl1.Controls.Add(this.BtnGuncelle);
			this.groupControl1.Controls.Add(this.BtnSil);
			this.groupControl1.Controls.Add(this.BtnKaydet);
			this.groupControl1.Controls.Add(this.txtAdres);
			this.groupControl1.Controls.Add(this.txtTc);
			this.groupControl1.Controls.Add(this.txtGorev);
			this.groupControl1.Controls.Add(this.txtMail);
			this.groupControl1.Controls.Add(this.txtSoyad);
			this.groupControl1.Controls.Add(this.txtAd);
			this.groupControl1.Controls.Add(this.txtID);
			this.groupControl1.Controls.Add(this.labelControl9);
			this.groupControl1.Controls.Add(this.labelControl8);
			this.groupControl1.Controls.Add(this.labelControl7);
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
			this.BtnGuncelle.Location = new System.Drawing.Point(119, 668);
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
			this.BtnSil.Location = new System.Drawing.Point(120, 613);
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
			this.BtnKaydet.Location = new System.Drawing.Point(120, 551);
			this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(257, 36);
			this.BtnKaydet.TabIndex = 18;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// txtAdres
			// 
			this.txtAdres.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdres.Location = new System.Drawing.Point(118, 407);
			this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(256, 117);
			this.txtAdres.TabIndex = 9;
			this.txtAdres.Text = "";
			// 
			// txtTc
			// 
			this.txtTc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtTc.Location = new System.Drawing.Point(120, 238);
			this.txtTc.Margin = new System.Windows.Forms.Padding(4);
			this.txtTc.Mask = "00000000000";
			this.txtTc.Name = "txtTc";
			this.txtTc.Size = new System.Drawing.Size(256, 30);
			this.txtTc.TabIndex = 5;
			this.txtTc.ValidatingType = typeof(int);
			// 
			// txtGorev
			// 
			this.txtGorev.Location = new System.Drawing.Point(120, 201);
			this.txtGorev.Margin = new System.Windows.Forms.Padding(4);
			this.txtGorev.Name = "txtGorev";
			this.txtGorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtGorev.Properties.Appearance.Options.UseFont = true;
			this.txtGorev.Size = new System.Drawing.Size(257, 30);
			this.txtGorev.TabIndex = 4;
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(120, 158);
			this.txtMail.Margin = new System.Windows.Forms.Padding(4);
			this.txtMail.Name = "txtMail";
			this.txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMail.Properties.Appearance.Options.UseFont = true;
			this.txtMail.Size = new System.Drawing.Size(257, 30);
			this.txtMail.TabIndex = 3;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(120, 114);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyad.Properties.Appearance.Options.UseFont = true;
			this.txtSoyad.Size = new System.Drawing.Size(257, 30);
			this.txtSoyad.TabIndex = 2;
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
			this.txtID.TabIndex = 10;
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl9.Appearance.Options.UseFont = true;
			this.labelControl9.Location = new System.Drawing.Point(59, 407);
			this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(54, 23);
			this.labelControl9.TabIndex = 8;
			this.labelControl9.Text = "Adres:";
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(80, 247);
			this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(29, 23);
			this.labelControl8.TabIndex = 7;
			this.labelControl8.Text = "TC:";
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(55, 208);
			this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(56, 23);
			this.labelControl7.TabIndex = 6;
			this.labelControl7.Text = "Görev:";
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(68, 294);
			this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(32, 23);
			this.labelControl6.TabIndex = 5;
			this.labelControl6.Text = "Tel:";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(73, 161);
			this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(40, 23);
			this.labelControl4.TabIndex = 3;
			this.labelControl4.Text = "Mail:";
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
			this.labelControl3.Text = "Soyad:";
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
			// 
			// FrmPersoneller
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 752);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmPersoneller";
			this.Text = "Personeller";
			this.Load += new System.EventHandler(this.FrmPersoneller_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtGorev.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
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
		private System.Windows.Forms.MaskedTextBox txtTel1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
		private DevExpress.XtraEditors.SimpleButton BtnSil;
		private DevExpress.XtraEditors.SimpleButton BtnKaydet;
		private System.Windows.Forms.RichTextBox txtAdres;
		private System.Windows.Forms.MaskedTextBox txtTc;
		private DevExpress.XtraEditors.TextEdit txtGorev;
		private DevExpress.XtraEditors.TextEdit txtMail;
		private DevExpress.XtraEditors.TextEdit txtSoyad;
		private DevExpress.XtraEditors.TextEdit txtAd;
		private DevExpress.XtraEditors.TextEdit txtID;
		private DevExpress.XtraEditors.LabelControl labelControl9;
		private DevExpress.XtraEditors.LabelControl labelControl8;
		private DevExpress.XtraEditors.LabelControl labelControl7;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}