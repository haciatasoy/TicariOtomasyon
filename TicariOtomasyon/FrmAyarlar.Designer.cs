namespace TicariOtomasyon
{
	partial class FrmAyarlar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyarlar));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtUsername = new DevExpress.XtraEditors.TextEdit();
			this.txtParola = new DevExpress.XtraEditors.TextEdit();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(1, 1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(566, 210);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.Location = new System.Drawing.Point(12, 235);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(167, 31);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Kullanıcı Adı:";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.Location = new System.Drawing.Point(12, 329);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(88, 31);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Parola:";
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(12, 272);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUsername.Properties.Appearance.Options.UseFont = true;
			this.txtUsername.Size = new System.Drawing.Size(297, 30);
			this.txtUsername.TabIndex = 3;
			// 
			// txtParola
			// 
			this.txtParola.Location = new System.Drawing.Point(12, 366);
			this.txtParola.Name = "txtParola";
			this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtParola.Properties.Appearance.Options.UseFont = true;
			this.txtParola.Size = new System.Drawing.Size(297, 30);
			this.txtParola.TabIndex = 4;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.simpleButton1.Appearance.Options.UseFont = true;
			this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.simpleButton1.Location = new System.Drawing.Point(374, 253);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(170, 49);
			this.simpleButton1.TabIndex = 5;
			this.simpleButton1.Text = "Kaydet";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// BtnSil
			// 
			this.BtnSil.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnSil.Appearance.Options.UseFont = true;
			this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
			this.BtnSil.Location = new System.Drawing.Point(374, 347);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new System.Drawing.Size(170, 49);
			this.BtnSil.TabIndex = 7;
			this.BtnSil.Text = "Sil";
			this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
			// 
			// FrmAyarlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(566, 436);
			this.Controls.Add(this.BtnSil);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.txtParola);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmAyarlar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ayarlar";
			this.Load += new System.EventHandler(this.FrmAyarlar_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtUsername;
		private DevExpress.XtraEditors.TextEdit txtParola;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton BtnSil;
	}
}