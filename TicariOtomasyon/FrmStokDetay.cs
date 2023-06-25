using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
	public partial class FrmStokDetay : Form
	{
		public FrmStokDetay()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti= new SqlBaglantisi();
		public string ad;
		void listele()
		{
			SqlDataAdapter adapter = new SqlDataAdapter("select * from URUNLER where URUNAD='" + ad + "'", baglanti.baglantim());
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		private void FrmStokDetay_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.Aqua;
				e.Appearance.BackColor2 = Color.AntiqueWhite;
				e.HighPriority = true;
			}
		}
	}
}
