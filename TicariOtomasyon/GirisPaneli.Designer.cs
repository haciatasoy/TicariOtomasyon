namespace TicariOtomasyon
{
	partial class GirisPaneli
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisPaneli));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.BtnGiris = new DevExpress.XtraEditors.SimpleButton();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(242, 213);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(179, 34);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Kullanıcı Adı:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(316, 266);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(105, 40);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Parola:";
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUsername.Location = new System.Drawing.Point(452, 217);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(204, 30);
			this.txtUsername.TabIndex = 1;
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSifre.Location = new System.Drawing.Point(452, 278);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(204, 28);
			this.txtSifre.TabIndex = 2;
			this.txtSifre.UseSystemPasswordChar = true;
			this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
			// 
			// BtnGiris
			// 
			this.BtnGiris.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.BtnGiris.Appearance.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGiris.Appearance.Options.UseBackColor = true;
			this.BtnGiris.Appearance.Options.UseFont = true;
			this.BtnGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.BtnGiris.Location = new System.Drawing.Point(452, 339);
			this.BtnGiris.Name = "BtnGiris";
			this.BtnGiris.Size = new System.Drawing.Size(204, 72);
			this.BtnGiris.TabIndex = 3;
			this.BtnGiris.Text = "Giris Yap";
			this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
			this.BtnGiris.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnGiris_KeyDown);
			this.BtnGiris.MouseLeave += new System.EventHandler(this.BtnGiris_MouseLeave);
			this.BtnGiris.MouseHover += new System.EventHandler(this.BtnGiris_MouseHover);
			// 
			// GirisPaneli
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(800, 530);
			this.Controls.Add(this.BtnGiris);
			this.Controls.Add(this.txtSifre);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GirisPaneli";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giriş Paneli";
			this.Load += new System.EventHandler(this.GirisPaneli_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtSifre;
		private DevExpress.XtraEditors.SimpleButton BtnGiris;
	}
}