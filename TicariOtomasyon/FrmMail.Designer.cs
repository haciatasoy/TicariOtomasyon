namespace TicariOtomasyon
{
	partial class FrmMail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtMailAdresi = new DevExpress.XtraEditors.TextEdit();
			this.txtKonu = new DevExpress.XtraEditors.TextEdit();
			this.txtMesaj = new System.Windows.Forms.RichTextBox();
			this.BtnGonder = new DevExpress.XtraEditors.SimpleButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(24, 189);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(117, 28);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Mail Adresi:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(81, 235);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(60, 28);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Konu:";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(75, 279);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(66, 28);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Mesaj:";
			// 
			// txtMailAdresi
			// 
			this.txtMailAdresi.Location = new System.Drawing.Point(163, 186);
			this.txtMailAdresi.Name = "txtMailAdresi";
			this.txtMailAdresi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMailAdresi.Properties.Appearance.Options.UseFont = true;
			this.txtMailAdresi.Size = new System.Drawing.Size(338, 30);
			this.txtMailAdresi.TabIndex = 3;
			// 
			// txtKonu
			// 
			this.txtKonu.Location = new System.Drawing.Point(163, 232);
			this.txtKonu.Name = "txtKonu";
			this.txtKonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKonu.Properties.Appearance.Options.UseFont = true;
			this.txtKonu.Size = new System.Drawing.Size(338, 30);
			this.txtKonu.TabIndex = 4;
			// 
			// txtMesaj
			// 
			this.txtMesaj.Location = new System.Drawing.Point(163, 279);
			this.txtMesaj.Name = "txtMesaj";
			this.txtMesaj.Size = new System.Drawing.Size(338, 159);
			this.txtMesaj.TabIndex = 5;
			this.txtMesaj.Text = "";
			// 
			// BtnGonder
			// 
			this.BtnGonder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnGonder.Appearance.Options.UseFont = true;
			this.BtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.BtnGonder.Location = new System.Drawing.Point(213, 454);
			this.BtnGonder.Name = "BtnGonder";
			this.BtnGonder.Size = new System.Drawing.Size(252, 57);
			this.BtnGonder.TabIndex = 6;
			this.BtnGonder.Text = "Gönder";
			this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.labelControl4);
			this.panel1.Location = new System.Drawing.Point(0, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(654, 156);
			this.panel1.TabIndex = 7;
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Appearance.Options.UseForeColor = true;
			this.labelControl4.Location = new System.Drawing.Point(66, 24);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(399, 72);
			this.labelControl4.TabIndex = 1;
			this.labelControl4.Text = "Mail Gönderme";
			// 
			// FrmMail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 536);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.BtnGonder);
			this.Controls.Add(this.txtMesaj);
			this.Controls.Add(this.txtKonu);
			this.Controls.Add(this.txtMailAdresi);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "FrmMail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmMail";
			this.Load += new System.EventHandler(this.FrmMail_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.TextEdit txtMailAdresi;
		private DevExpress.XtraEditors.TextEdit txtKonu;
		private System.Windows.Forms.RichTextBox txtMesaj;
		private DevExpress.XtraEditors.SimpleButton BtnGonder;
		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.LabelControl labelControl4;
	}
}