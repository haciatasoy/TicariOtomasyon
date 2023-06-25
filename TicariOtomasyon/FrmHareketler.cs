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
	public partial class FrmHareketler : Form
	{
		public FrmHareketler()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti = new SqlBaglantisi();
		void Firmalistele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("Exec FirmaHareket", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl2.DataSource = dt;
		}
		
			void Musterilistele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("Exec MusteriHareket", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			
		}

		private void gridView2_DoubleClick(object sender, EventArgs e)
		{

		}

		private void FrmHareketler_Load(object sender, EventArgs e)
		{
			Firmalistele();
			Musterilistele();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.Aquamarine;
				e.Appearance.BackColor2 = Color.LightGreen;

				e.HighPriority = true;
			}
		}

		private void gridView2_RowStyle(object sender, RowStyleEventArgs e)
		{
			
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.LightYellow;
				e.Appearance.BackColor2 = Color.OrangeRed;
				e.HighPriority = true;
			}
		}
	}
}
