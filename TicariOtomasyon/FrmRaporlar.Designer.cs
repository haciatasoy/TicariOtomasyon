namespace TicariOtomasyon
{
	partial class FrmRaporlar
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaporlar));
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.URUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.TicariOtomasyonDataSet = new TicariOtomasyon.TicariOtomasyonDataSet();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
			this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
			this.URUNLERTableAdapter = new TicariOtomasyon.TicariOtomasyonDataSetTableAdapters.URUNLERTableAdapter();
			this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.TicariOtomasyonDataSet1 = new TicariOtomasyon.TicariOtomasyonDataSet1();
			this.FIRMALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.FIRMALARTableAdapter = new TicariOtomasyon.TicariOtomasyonDataSet1TableAdapters.FIRMALARTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.URUNLERBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPage1.SuspendLayout();
			this.xtraTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FIRMALARBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// URUNLERBindingSource
			// 
			this.URUNLERBindingSource.DataMember = "URUNLER";
			this.URUNLERBindingSource.DataSource = this.TicariOtomasyonDataSet;
			// 
			// TicariOtomasyonDataSet
			// 
			this.TicariOtomasyonDataSet.DataSetName = "TicariOtomasyonDataSet";
			this.TicariOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
			this.xtraTabControl1.Size = new System.Drawing.Size(1924, 752);
			this.xtraTabControl1.TabIndex = 0;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Controls.Add(this.reportViewer1);
			this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new System.Drawing.Size(1922, 706);
			this.xtraTabPage1.Text = "Ürünler Raporu";
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.URUNLERBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.Report1.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1922, 706);
			this.reportViewer1.TabIndex = 0;
			// 
			// xtraTabPage2
			// 
			this.xtraTabPage2.Controls.Add(this.reportViewer2);
			this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(1922, 706);
			this.xtraTabPage2.Text = "Firmalar Raporu";
			// 
			// xtraTabPage3
			// 
			this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
			this.xtraTabPage3.Name = "xtraTabPage3";
			this.xtraTabPage3.Size = new System.Drawing.Size(1922, 706);
			this.xtraTabPage3.Text = "Giderler Raporu";
			// 
			// xtraTabPage4
			// 
			this.xtraTabPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage4.ImageOptions.Image")));
			this.xtraTabPage4.Name = "xtraTabPage4";
			this.xtraTabPage4.Size = new System.Drawing.Size(1922, 706);
			this.xtraTabPage4.Text = "Firmalar Raporu";
			// 
			// URUNLERTableAdapter
			// 
			this.URUNLERTableAdapter.ClearBeforeFill = true;
			// 
			// reportViewer2
			// 
			this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource2.Name = "DataSet2";
			reportDataSource2.Value = this.FIRMALARBindingSource;
			this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
			this.reportViewer2.LocalReport.ReportEmbeddedResource = "TicariOtomasyon.Report2.rdlc";
			this.reportViewer2.Location = new System.Drawing.Point(0, 0);
			this.reportViewer2.Name = "reportViewer2";
			this.reportViewer2.ServerReport.BearerToken = null;
			this.reportViewer2.Size = new System.Drawing.Size(1922, 706);
			this.reportViewer2.TabIndex = 0;
			// 
			// TicariOtomasyonDataSet1
			// 
			this.TicariOtomasyonDataSet1.DataSetName = "TicariOtomasyonDataSet1";
			this.TicariOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// FIRMALARBindingSource
			// 
			this.FIRMALARBindingSource.DataMember = "FIRMALAR";
			this.FIRMALARBindingSource.DataSource = this.TicariOtomasyonDataSet1;
			// 
			// FIRMALARTableAdapter
			// 
			this.FIRMALARTableAdapter.ClearBeforeFill = true;
			// 
			// FrmRaporlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 752);
			this.Controls.Add(this.xtraTabControl1);
			this.Name = "FrmRaporlar";
			this.Text = "Raporlar";
			this.Load += new System.EventHandler(this.FrmRaporlar_Load);
			((System.ComponentModel.ISupportInitialize)(this.URUNLERBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.xtraTabPage1.ResumeLayout(false);
			this.xtraTabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.TicariOtomasyonDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FIRMALARBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource URUNLERBindingSource;
		private TicariOtomasyonDataSet TicariOtomasyonDataSet;
		private TicariOtomasyonDataSetTableAdapters.URUNLERTableAdapter URUNLERTableAdapter;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
		private System.Windows.Forms.BindingSource FIRMALARBindingSource;
		private TicariOtomasyonDataSet1 TicariOtomasyonDataSet1;
		private TicariOtomasyonDataSet1TableAdapters.FIRMALARTableAdapter FIRMALARTableAdapter;
	}
}