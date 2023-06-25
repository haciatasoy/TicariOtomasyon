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
using DevExpress.Charts;
using DevExpress.XtraGrid.Views.Grid;

namespace TicariOtomasyon
{
	public partial class FrmKasa : Form
	{
		public FrmKasa()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=new SqlBaglantisi();
		void FirmaHareketler()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("Exec FirmaHareket", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void MüşteriHareketler()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("Exec MusteriHareket", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl3.DataSource = dt;
		}
		void toplamtutar()
		{
			SqlCommand komut=new SqlCommand("select sum(TUTAR) FROM FATURADETAY",baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				lblToplamTutar.Text = reader[0].ToString() + " TL";
			}
			baglanti.baglantim().Close();
		}
		void sonaygider()
		{
			SqlCommand komut = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ+INTERNET+DIGER) from GIDERLER order by ID asc", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				lblOdemeler.Text = reader[0].ToString() + " TL";
			}
			baglanti.baglantim().Close();
		}
		void personelmaas()
		{
			SqlCommand komut = new SqlCommand("select MAASLAR from GIDERLER order by ID asc", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				lblPerMaas.Text = reader[0].ToString() + " TL";
			}
			baglanti.baglantim().Close();
		}
		void musterisayisi()
		{
			SqlCommand komut = new SqlCommand("select count(*) from MUSTERILER", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				lblMusteri.Text = reader[0].ToString();
			}
			baglanti.baglantim().Close();
		}
		void firmasayisi()
		{
			SqlCommand komut = new SqlCommand("select count(*) from FIRMALAR", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				lblFirma.Text = reader[0].ToString();
			}
			baglanti.baglantim().Close();
		}
		void musterisehirsayisi()
		{
			SqlCommand komut = new SqlCommand("select count(distinct(IL)) from MUSTERILER", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				lblMusteriSehir.Text = reader[0].ToString();
			}
			baglanti.baglantim().Close();
		}
		void firmasehirsayisi()
		{
			SqlCommand komut = new SqlCommand("select count(distinct(IL)) from FIRMALAR", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				lblFirmaSehir.Text = reader[0].ToString();
			}
			baglanti.baglantim().Close();
		}
		void personelsayisi()
		{
			SqlCommand komut = new SqlCommand("select count(*) from PERSONELLER", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				lblPersonel.Text = reader[0].ToString();
			}
			baglanti.baglantim().Close();
		}
		void stoksayisi()
		{
			SqlCommand komut = new SqlCommand("select sum(ADET) from URUNLER", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				lblStok.Text = reader[0].ToString();
			}
			baglanti.baglantim().Close();
		}
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from GIDERLER", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl2.DataSource = dt;
		}
		public string ad;
		private void FrmKasa_Load(object sender, EventArgs e)
		{
			lblKullanici.Text = ad;
			listele();
			FirmaHareketler();
			MüşteriHareketler();
			toplamtutar();
			sonaygider();
			personelmaas();
			musterisayisi();
			firmasayisi();
			musterisehirsayisi();
			firmasehirsayisi();
			personelsayisi();
			stoksayisi();
		}
		
		int sayac = 0;
		void sayacilk()
		{
			if (sayac > 0 && sayac <= 5)
			{
				groupControl10.Text = "Elektrik";
				chartControl1.Series["Aylar"].Points.Clear();
				SqlCommand komut = new SqlCommand("select top 4 AY,ELEKTRIK from GIDERLER order by ID desc", baglanti.baglantim());
				SqlDataReader reader = komut.ExecuteReader();
				while (reader.Read())
				{
					chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
					
				}
				baglanti.baglantim().Close();

				groupControl11.Text = "Su";
				chartControl2.Series["Aylar"].Points.Clear();
				SqlCommand komut2 = new SqlCommand("select top 4 AY,SU from GIDERLER order by ID desc", baglanti.baglantim());
				SqlDataReader reader2 = komut2.ExecuteReader();
				while (reader2.Read())
				{
					chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader2[0], reader2[1]));
					
				}
				baglanti.baglantim().Close();
			}
		}
		void sayaciki()
		{
			if (sayac > 5 && sayac <= 10)
			{
				groupControl10.Text = "Doğalgaz";
				chartControl1.Series["Aylar"].Points.Clear();
				
				SqlCommand komut = new SqlCommand("select top 4 AY,DOGALGAZ from GIDERLER order by ID desc", baglanti.baglantim());
				SqlDataReader reader = komut.ExecuteReader();
				while (reader.Read())
				{
					chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
					
				}
				baglanti.baglantim().Close();

				groupControl11.Text = "İnternet";
				chartControl2.Series["Aylar"].Points.Clear();
				SqlCommand komut2 = new SqlCommand("select top 4 AY,INTERNET from GIDERLER order by ID desc", baglanti.baglantim());
				SqlDataReader reader2 = komut2.ExecuteReader();
				while (reader2.Read())
				{
					chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader2[0], reader2[1]));
				}
				baglanti.baglantim().Close();
			}
		}
		void sayacuc()
		{
			if (sayac > 10 && sayac <= 15)
			{
				groupControl10.Text = "Diğer";
				chartControl1.Series["Aylar"].Points.Clear();

				SqlCommand komut = new SqlCommand("select top 4 AY,DIGER from GIDERLER order by ID desc", baglanti.baglantim());
				SqlDataReader reader = komut.ExecuteReader();
				while (reader.Read())
				{
					chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader[0], reader[1]));
					
				}
				baglanti.baglantim().Close();

				groupControl11.Text = "Maaşlar";
				chartControl2.Series["Aylar"].Points.Clear();
				SqlCommand komut2 = new SqlCommand("select top 4 AY,MAASLAR from GIDERLER order by ID desc", baglanti.baglantim());
				SqlDataReader reader2 = komut2.ExecuteReader();
				while (reader2.Read())
				{
					chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(reader2[0], reader2[1]));
				}
				baglanti.baglantim().Close();
			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			sayac++;
			sayacilk();
			sayaciki();
			sayacuc();
			if (sayac == 16)
			{
				sayac = 0;
			}

		}

		private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
					e.Appearance.BackColor = Color.LightYellow;
					e.Appearance.BackColor2 = Color.OrangeRed;
					e.HighPriority = true;	
			}
		}

		private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{		
					e.Appearance.BackColor = Color.Aquamarine;
					e.Appearance.BackColor2 = Color.LightGreen;

					e.HighPriority = true;
			}
		}

		private void gridView3_RowStyle(object sender, RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
					e.Appearance.BackColor = Color.BlanchedAlmond;
					e.Appearance.BackColor2 = Color.BurlyWood;
					e.HighPriority = true;	
			}
		}
	}
}
