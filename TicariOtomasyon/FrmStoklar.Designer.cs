namespace TicariOtomasyon
{
	partial class FrmStoklar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStoklar));
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
			DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
			DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D2 = new DevExpress.XtraCharts.SimpleDiagram3D();
			DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.Doughnut3DSeriesView doughnut3DSeriesView1 = new DevExpress.XtraCharts.Doughnut3DSeriesView();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
			this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
			this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
			this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
			this.xtraTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
			this.xtraTabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Location = new System.Drawing.Point(0, 0);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(400, 740);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
			this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Location = new System.Drawing.Point(406, 0);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
			this.xtraTabControl1.Size = new System.Drawing.Size(1516, 740);
			this.xtraTabControl1.TabIndex = 1;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Controls.Add(this.chartControl1);
			this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new System.Drawing.Size(1514, 694);
			this.xtraTabPage1.Text = "ÜRÜN-ADET";
			// 
			// chartControl1
			// 
			this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartControl1.Location = new System.Drawing.Point(0, 0);
			this.chartControl1.Name = "chartControl1";
			series1.Name = "Series 1";
			series1.View = pieSeriesView1;
			this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
			this.chartControl1.Size = new System.Drawing.Size(1514, 694);
			this.chartControl1.TabIndex = 0;
			// 
			// xtraTabPage2
			// 
			this.xtraTabPage2.Controls.Add(this.chartControl2);
			this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(1514, 694);
			this.xtraTabPage2.Text = "FİRMA-ŞEHİR";
			// 
			// chartControl2
			// 
			simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
			this.chartControl2.Diagram = simpleDiagram3D1;
			this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartControl2.Location = new System.Drawing.Point(0, 0);
			this.chartControl2.Name = "chartControl2";
			series2.Name = "Series 1";
			series2.View = pie3DSeriesView1;
			this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
			this.chartControl2.Size = new System.Drawing.Size(1514, 694);
			this.chartControl2.TabIndex = 1;
			// 
			// xtraTabPage3
			// 
			this.xtraTabPage3.Controls.Add(this.chartControl3);
			this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
			this.xtraTabPage3.Name = "xtraTabPage3";
			this.xtraTabPage3.Size = new System.Drawing.Size(1514, 694);
			this.xtraTabPage3.Text = "ÜRÜN-MÜŞTERİ";
			// 
			// chartControl3
			// 
			simpleDiagram3D2.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
			this.chartControl3.Diagram = simpleDiagram3D2;
			this.chartControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chartControl3.Location = new System.Drawing.Point(0, 0);
			this.chartControl3.Name = "chartControl3";
			series3.Name = "Series 1";
			series3.View = doughnut3DSeriesView1;
			this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
			this.chartControl3.Size = new System.Drawing.Size(1514, 694);
			this.chartControl3.TabIndex = 2;
			// 
			// FrmStoklar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 752);
			this.Controls.Add(this.xtraTabControl1);
			this.Controls.Add(this.gridControl1);
			this.Name = "FrmStoklar";
			this.Text = "Stoklar";
			this.Load += new System.EventHandler(this.FrmStoklar_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.xtraTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
			this.xtraTabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
			this.xtraTabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(doughnut3DSeriesView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
		private DevExpress.XtraCharts.ChartControl chartControl1;
		private DevExpress.XtraCharts.ChartControl chartControl2;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
		private DevExpress.XtraCharts.ChartControl chartControl3;
	}
}