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
	public partial class FrmPersoneller : Form
	{
		public FrmPersoneller()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from PERSONELLER", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void sehirlerim()
		{
			SqlCommand komut = new SqlCommand("select * from ILLER", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				cmbIl.Properties.Items.Add(reader[1]);
			}
			baglanti.baglantim().Close();
		}
		private void FrmPersoneller_Load(object sender, EventArgs e)
		{
			listele();
			sehirlerim();
		}

		private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbIlce.Properties.Items.Clear();
			SqlCommand komut = new SqlCommand("select ILCE from ILCELER where IL=@p1", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				cmbIlce.Properties.Items.Add(reader[0]);
			}
			baglanti.baglantim().Close();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", txtTel1.Text);			
			komut.Parameters.AddWithValue("@p4", txtTc.Text);
			komut.Parameters.AddWithValue("@p5", txtMail.Text);
			komut.Parameters.AddWithValue("@p6", cmbIl.Text);
			komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
			komut.Parameters.AddWithValue("@p8", txtAdres.Text);
			komut.Parameters.AddWithValue("@p9", txtGorev.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Personel başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtAd.Text = dr["AD"].ToString();
			txtSoyad.Text = dr["SOYAD"].ToString();
			txtMail.Text = dr["MAIL"].ToString();
			txtTc.Text = dr["TC"].ToString();
			txtTel1.Text = dr["TELEFON"].ToString();	
			txtAdres.Text = dr["ADRES"].ToString();
			txtGorev.Text = dr["GOREV"].ToString();
			cmbIl.Text = dr["IL"].ToString();
			cmbIlce.Text = dr["ILCE"].ToString();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DialogResult alert = new DialogResult();
			alert = MessageBox.Show("Personel Kaydınızı Sileceksiniz. Emin Misiniz?", "Personel Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (alert == DialogResult.Yes)
			{
				SqlCommand komut = new SqlCommand("delete from PERSONELLER where ID=@p1", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtID.Text);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
				MessageBox.Show("Personel başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				listele();
			}
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand guncel = new SqlCommand("update PERSONELLER set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 where ID=@P10", baglanti.baglantim());
			guncel.Parameters.AddWithValue("@P1", txtAd.Text);
			guncel.Parameters.AddWithValue("@P2", txtSoyad.Text);
			guncel.Parameters.AddWithValue("@P3", txtTel1.Text);			
			guncel.Parameters.AddWithValue("@P4", txtTc.Text);
			guncel.Parameters.AddWithValue("@P5", txtMail.Text);
			guncel.Parameters.AddWithValue("@P6", cmbIl.Text);
			guncel.Parameters.AddWithValue("@P7", cmbIlce.Text);
			guncel.Parameters.AddWithValue("@P8", txtAdres.Text);
			guncel.Parameters.AddWithValue("@P9", txtGorev.Text);
			guncel.Parameters.AddWithValue("@P10", txtID.Text);
			guncel.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Personel bilgileri başarılı bir şekilde güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			listele();
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
	}
}
