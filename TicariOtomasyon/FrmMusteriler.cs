using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace TicariOtomasyon
{
	public partial class FrmMusteriler : Form
	{
		public FrmMusteriler()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from MUSTERILER", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void sehirlerim()
		{
			SqlCommand komut=new SqlCommand("select * from ILLER",baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while(reader.Read())
			{
				cmbIl.Properties.Items.Add(reader[1]);
			}
			baglanti.baglantim().Close();
		}

		private void FrmMusteriler_Load(object sender, EventArgs e)
		{
			listele();
			sehirlerim();
		}

		private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbIlce.Properties.Items.Clear();
			SqlCommand komut = new SqlCommand("select ILCE from ILCELER where IL=@p1", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex+1);
			SqlDataReader reader = komut.ExecuteReader();
			while(reader.Read())
			{
				cmbIlce.Properties.Items.Add(reader[0]);
			}
			baglanti.baglantim().Close();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", txtTel1.Text);
			komut.Parameters.AddWithValue("@p4", txtTel2.Text);
			komut.Parameters.AddWithValue("@p5", txtTc.Text);
			komut.Parameters.AddWithValue("@p6", txtMail.Text);
			komut.Parameters.AddWithValue("@p7", cmbIl.Text);
			komut.Parameters.AddWithValue("@p8", cmbIlce.Text);
			komut.Parameters.AddWithValue("@p9", txtAdres.Text);
			komut.Parameters.AddWithValue("@p10", txtVergi.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Müşteri başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			txtTel2.Text = dr["TELEFON2"].ToString();
			txtAdres.Text = dr["ADRES"].ToString();
			txtVergi.Text = dr["VERGIDAIRE"].ToString();
			cmbIl.Text = dr["IL"].ToString();
			cmbIlce.Text = dr["ILCE"].ToString();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DialogResult alert=new DialogResult();
			alert = MessageBox.Show("Müşteri Kaydınızı Sileceksiniz. Emin Misiniz?", "Müşteri Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(alert == DialogResult.Yes)
			{
				SqlCommand komut = new SqlCommand("delete from MUSTERILER where ID=@p1", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtID.Text);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
				MessageBox.Show("Müşteri başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				listele();
			}
			
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand guncel = new SqlCommand("update MUSTERILER set AD=@P1,SOYAD=@P2,TELEFON=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,ADRES=@P9,VERGIDAIRE=@P10 where ID=@P11", baglanti.baglantim());
			guncel.Parameters.AddWithValue("@P1", txtAd.Text);
			guncel.Parameters.AddWithValue("@P2", txtSoyad.Text);
			guncel.Parameters.AddWithValue("@P3", txtTel1.Text);
			guncel.Parameters.AddWithValue("@P4", txtTel2.Text);
			guncel.Parameters.AddWithValue("@P5", txtTc.Text);
			guncel.Parameters.AddWithValue("@P6", txtMail.Text);
			guncel.Parameters.AddWithValue("@P7", cmbIl.Text);
			guncel.Parameters.AddWithValue("@P8", cmbIlce.Text);
			guncel.Parameters.AddWithValue("@P9", txtAdres.Text);
			guncel.Parameters.AddWithValue("@P10", txtVergi.Text);
			guncel.Parameters.AddWithValue("@P11", txtID.Text);
			guncel.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Müşteri bilgileri başarılı bir şekilde güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			listele();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.AntiqueWhite;
				e.Appearance.BackColor2 = Color.LightGreen;
				e.HighPriority = true;
			}
		}
	}
}
