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
using DevExpress.XtraCharts;
using DevExpress.XtraGrid.Views.Grid;

namespace TicariOtomasyon
{
	public partial class FrmStoklar : Form
	{
		public FrmStoklar()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select URUNAD,sum(ADET) as 'ADET' from URUNLER group by URUNAD", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void urunadetpie()
		{
			SqlCommand komut = new SqlCommand("select URUNAD,sum(ADET) as 'ADET' from URUNLER group by URUNAD", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(reader[0]), int.Parse(reader[1].ToString()));

			}
			baglanti.baglantim().Close();
		}
		void firmaurun()
		{
			SqlCommand komut = new SqlCommand("select IL,count(*) AS Firma_Sayisi from FIRMALAR group by IL", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(reader[0]), int.Parse(reader[1].ToString()));

			}
			baglanti.baglantim().Close();
		}
		void musteriurun()
		{
			SqlCommand komut = new SqlCommand("select IL,count(*) AS Müşteri_Sayisi from MUSTERILER group by IL", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				chartControl3.Series["Series 1"].Points.AddPoint(Convert.ToString(reader[0]), int.Parse(reader[1].ToString()));

			}
			baglanti.baglantim().Close();
		}
		private void FrmStoklar_Load(object sender, EventArgs e)
		{
			chartControl1.Series["Series 1"].LegendTextPattern = "{A}";
			chartControl2.Series["Series 1"].LegendTextPattern = "{A}";
			chartControl3.Series["Series 1"].LegendTextPattern = "{A}";
			listele();
			urunadetpie();
			firmaurun();
			musteriurun();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
					e.Appearance.BackColor = Color.Bisque;
					e.Appearance.BackColor2 = Color.LightPink;
					e.HighPriority = true;			
			}
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmStokDetay frm = new FrmStokDetay();
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if (dr != null)
			{
				frm.ad = dr["URUNAD"].ToString();
			}
			frm.Show();
		}
	}
}
