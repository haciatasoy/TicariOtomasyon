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
using System.Xml;

namespace TicariOtomasyon
{
	public partial class FrmAnasayfa : Form
	{
		public FrmAnasayfa()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=new SqlBaglantisi();
		void azalanstoklistele()
		{
			
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select URUNAD,sum(ADET) as 'ADET' from URUNLER group by URUNAD having sum(ADET)<=50 order by sum(ADET)", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void enfazlastok()
		{

			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select URUNAD,sum(ADET) as 'ADET' from URUNLER group by URUNAD order by sum(Adet) desc", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl4.DataSource = dt;
		}
		void markaurun()
		{

			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select MARKA,URUNAD,ADET from URUNLER order by MARKA", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl2.DataSource = dt;
		}
		void haberler()
		{
			XmlTextReader oku = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
			while(oku.Read())
			{
				if (oku.Name == "title")
				{
					listBox1.Items.Add(oku.ReadString());
				}
			}
		}
		void satilanurunler()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select URUNAD,MIKTAR,FIYAT,TUTAR,f.SIRANO as FATURANO from FATURADETAY fd inner join FATURALAR f\r\nON fd.FATURAID=f.ID", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl3.DataSource = dt;
		}
		private void FrmAnasayfa_Load(object sender, EventArgs e)
		{
			azalanstoklistele();
			webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
			haberler();
			satilanurunler();
			markaurun();
			enfazlastok();
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

		private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.Bisque;
				e.Appearance.BackColor2 = Color.CornflowerBlue;
				e.HighPriority = true;
			}
		}

		private void gridView3_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.Beige;
				e.Appearance.BackColor2 = Color.Thistle;
				e.HighPriority = true;
			}
		}

		private void gridView4_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.DarkTurquoise;
				e.Appearance.BackColor2 = Color.Salmon;
				e.HighPriority = true;
			}
		}
	}
}
