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
	public partial class FrmGiderler : Form
	{
		public FrmGiderler()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti = new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from GIDERLER", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void temizle()
		{
			txtID.Text = "";
			txtElektrik.Text = "";
			txtSu.Text = "";
			txtDogalgaz.Text = "";
			txtInternet.Text = "";
			txtMaaslar.Text = "";
			txtDiger.Text = "";
			txtNotlar.Text = "";
			cmbAy.Text = "";
			cmbYil.Text = "";
		}
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into GIDERLER (ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,DIGER,NOTLAR,AY,YIL) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", decimal.Parse(txtElektrik.Text));
			komut.Parameters.AddWithValue("@p2", decimal.Parse(txtSu.Text));
			komut.Parameters.AddWithValue("@p3", decimal.Parse(txtDogalgaz.Text));
			komut.Parameters.AddWithValue("@p4", decimal.Parse(txtInternet.Text));
			komut.Parameters.AddWithValue("@p5", decimal.Parse(txtMaaslar.Text));
			komut.Parameters.AddWithValue("@p6", decimal.Parse(txtDiger.Text));
			komut.Parameters.AddWithValue("@p7", txtNotlar.Text);
			komut.Parameters.AddWithValue("@p8", cmbAy.Text);
			komut.Parameters.AddWithValue("@p9", cmbYil.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Gider kaydı başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			temizle();
		}

		private void FrmGiderler_Load(object sender, EventArgs e)
		{
			listele();
			temizle();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DialogResult alert = new DialogResult();
			alert = MessageBox.Show("Gider Kaydınızı Sileceksiniz. Emin Misiniz?", "Gider Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (alert == DialogResult.Yes)
			{
				SqlCommand komut = new SqlCommand("delete from GIDERLER where ID=@p1", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtID.Text);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
				MessageBox.Show("Gider kaydı başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				listele();
				temizle();
			}
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtElektrik.Text = dr["ELEKTRIK"].ToString();
			txtSu.Text = dr["SU"].ToString();
			txtDogalgaz.Text = dr["DOGALGAZ"].ToString();
			txtInternet.Text = dr["INTERNET"].ToString();
			txtMaaslar.Text = dr["MAASLAR"].ToString();
			txtDiger.Text = dr["DIGER"].ToString();
			txtNotlar.Text = dr["NOTLAR"].ToString();
			cmbAy.Text = dr["AY"].ToString();
			cmbYil.Text = dr["YIL"].ToString();
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update GIDERLER set ELEKTRIK=@P1,SU=@P2,DOGALGAZ=@P3,INTERNET=@P4,MAASLAR=@P5,DIGER=@P6,NOTLAR=@P7,AY=@P8,YIL=@P9 where ID=@P10", baglanti.baglantim());
			komut.Parameters.AddWithValue("@P1", decimal.Parse(txtElektrik.Text));
			komut.Parameters.AddWithValue("@P2", decimal.Parse(txtSu.Text));
			komut.Parameters.AddWithValue("@P3", decimal.Parse(txtDogalgaz.Text));
			komut.Parameters.AddWithValue("@P4", decimal.Parse(txtInternet.Text));
			komut.Parameters.AddWithValue("@P5", decimal.Parse(txtMaaslar.Text));
			komut.Parameters.AddWithValue("@P6", decimal.Parse(txtDiger.Text));
			komut.Parameters.AddWithValue("@P7", txtNotlar.Text);
			komut.Parameters.AddWithValue("@P8", cmbAy.Text);
			komut.Parameters.AddWithValue("@P9", cmbYil.Text);
			komut.Parameters.AddWithValue("@P10", txtID.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Gider kaydı başarılı bir şekilde güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			temizle();

		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.LightPink;
				e.Appearance.BackColor2 = Color.Bisque;
				e.HighPriority = true;
			}
		}
	}
}
