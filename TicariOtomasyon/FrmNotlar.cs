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
	public partial class FrmNotlar : Form
	{
		public FrmNotlar()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from NOTLAR", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void temizle()
		{
			txtID.Text = "";
			txtTarih.Text = "";
			txtSaat.Text = "";
			txtOlusturan.Text = "";
			txtDetay.Text = "";
			txtBaslik.Text = "";
			txtKime.Text = "";
		}
		private void FrmNotlar_Load(object sender, EventArgs e)
		{
			listele();
			temizle();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into NOTLAR (TARIH,SAAT,NOT_BASLIK,NOT_ICERIK,NOT_OLUSTURAN,NOTHITAP) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtTarih.Text);
			komut.Parameters.AddWithValue("@p2", txtSaat.Text);
			komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
			komut.Parameters.AddWithValue("@p4", txtDetay.Text);
			komut.Parameters.AddWithValue("@p5", txtOlusturan.Text);
			komut.Parameters.AddWithValue("@p6", txtKime.Text);			
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Not başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			temizle();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtTarih.Text = dr["TARIH"].ToString();
			txtSaat.Text = dr["SAAT"].ToString();
			txtBaslik.Text = dr["NOT_BASLIK"].ToString();
			txtOlusturan.Text = dr["NOT_OLUSTURAN"].ToString();
			txtKime.Text = dr["NOTHITAP"].ToString();			
			txtDetay.Text = dr["NOT_ICERIK"].ToString();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DialogResult alert = new DialogResult();
			alert = MessageBox.Show("Not Kaydınızı Sileceksiniz. Emin Misiniz?", "Not Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (alert == DialogResult.Yes)
			{
				SqlCommand komut = new SqlCommand("delete from NOTLAR where ID=@p1", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtID.Text);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
				MessageBox.Show("Not başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				listele();
				temizle();
			}
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update NOTLAR set TARIH=@p1,SAAT=@p2,NOT_BASLIK=@p3,NOT_ICERIK=@p4,NOT_OLUSTURAN=@p5,NOTHITAP=@p6 where ID=@p7", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtTarih.Text);
			komut.Parameters.AddWithValue("@p2", txtSaat.Text);
			komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
			komut.Parameters.AddWithValue("@p4", txtDetay.Text);
			komut.Parameters.AddWithValue("@p5", txtOlusturan.Text);
			komut.Parameters.AddWithValue("@p6", txtKime.Text);
			komut.Parameters.AddWithValue("@p7", txtID.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Not başarılı bir şekilde güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			temizle();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.LightSeaGreen;
				e.Appearance.BackColor2 = Color.BurlyWood;

				e.HighPriority = true;
			}
		}
	}
}
