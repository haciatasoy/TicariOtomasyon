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
	public partial class FrmFirmalar : Form
	{
		public FrmFirmalar()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from FIRMALAR", baglanti.baglantim());
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
		void ozelkodlar()
		{
			SqlCommand komut = new SqlCommand("select * from KODLAR", baglanti.baglantim());
			SqlDataReader reader = komut.ExecuteReader();
			while (reader.Read())
			{
				txtKod1Anlam.Text = reader[0].ToString();
			}
			baglanti.baglantim().Close();
		}
		void temizle()
		{
			txtID.Text = "";
			txtAd.Text = "";
			txtGorev.Text = "";
			txtYetkili.Text = "";
			txtTel1.Text = "";
			txtTel2.Text = "";
			txtTel3.Text = "";
			txtMail.Text = "";
			txtFax.Text = "";
			cmbIl.Text = "";
			cmbIlce.Text = "";
			txtAdres.Text = "";
			txtVergi.Text = "";
			txtSektör.Text = "";
			txtKod1.Text = "";
			txtKod2.Text = "";
			txtKod3.Text = "";
		}

		private void FrmFirmalar_Load(object sender, EventArgs e)
		{
			txtAd.Focus();
			listele();
			sehirlerim();
			ozelkodlar();
			temizle();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtAd.Text = dr["FIRMA_ADI"].ToString();
			txtGorev.Text = dr["YETKILI_STATU"].ToString();
			txtYetkili.Text = dr["YETKILI_AD"].ToString();
			txtTel1.Text = dr["TELEFON1"].ToString();
			txtTel2.Text = dr["TELEFON2"].ToString();
			txtTel3.Text = dr["TELEFON3"].ToString();
			txtMail.Text = dr["MAIL"].ToString();
			txtFax.Text = dr["FAX"].ToString();
			cmbIl.Text = dr["IL"].ToString();
			cmbIlce.Text = dr["ILCE"].ToString();
			txtAdres.Text = dr["ADRES"].ToString();
			txtVergi.Text = dr["VERGI_DAIRE"].ToString();
			txtSektör.Text = dr["SEKTOR"].ToString();
			txtKod1.Text = dr["OZELKOD1"].ToString();
			txtKod2.Text = dr["OZELKOD2"].ToString();
			txtKod3.Text = dr["OZELKOD3"].ToString();

		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into FIRMALAR (FIRMA_ADI,YETKILI_STATU,YETKILI_AD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,ADRES,VERGI_DAIRE,SEKTOR,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16)", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", txtGorev.Text);
			komut.Parameters.AddWithValue("@p3", txtYetkili.Text);
			komut.Parameters.AddWithValue("@p4", txtTel1.Text);
			komut.Parameters.AddWithValue("@p5", txtTel2.Text);
			komut.Parameters.AddWithValue("@p6", txtTel3.Text);
			komut.Parameters.AddWithValue("@p7", txtMail.Text);
			komut.Parameters.AddWithValue("@p8", txtFax.Text);
			komut.Parameters.AddWithValue("@p9", cmbIl.Text);
			komut.Parameters.AddWithValue("@p10", cmbIlce.Text);
			komut.Parameters.AddWithValue("@p11", txtAdres.Text);
			komut.Parameters.AddWithValue("@p12", txtVergi.Text);
			komut.Parameters.AddWithValue("@p13", txtSektör.Text);
			komut.Parameters.AddWithValue("@p14", txtKod1.Text);
			komut.Parameters.AddWithValue("@p15", txtKod2.Text);
			komut.Parameters.AddWithValue("@p16", txtKod3.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Firma başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			temizle();
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

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DialogResult alert = new DialogResult();
			alert = MessageBox.Show("Firma Kaydınızı Sileceksiniz. Emin Misiniz?", "Firma Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (alert == DialogResult.Yes)
			{
				SqlCommand komut = new SqlCommand("delete from FIRMALAR where ID=@p1", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtID.Text);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
				MessageBox.Show("Firma başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				listele();
				temizle();
			}
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update FIRMALAR set FIRMA_ADI=@P1,YETKILI_STATU=@P2,YETKILI_AD=@P3,TELEFON1=@P4,TELEFON2=@P5,TELEFON3=@P6,MAIL=@P7,FAX=@P8,IL=@P9,ILCE=@P10,ADRES=@P11,VERGI_DAIRE=@P12,SEKTOR=@P13,OZELKOD1=@P14,OZELKOD2=@P15,OZELKOD3=@P16 WHERE ID=@P17", baglanti.baglantim());
			komut.Parameters.AddWithValue("@P1", txtAd.Text);
			komut.Parameters.AddWithValue("@P2", txtGorev.Text);
			komut.Parameters.AddWithValue("@P3", txtYetkili.Text);
			komut.Parameters.AddWithValue("@P4", txtTel1.Text);
			komut.Parameters.AddWithValue("@P5", txtTel2.Text);
			komut.Parameters.AddWithValue("@P6", txtTel3.Text);
			komut.Parameters.AddWithValue("@P7", txtMail.Text);
			komut.Parameters.AddWithValue("@P8", txtFax.Text);
			komut.Parameters.AddWithValue("@P9", cmbIl.Text);
			komut.Parameters.AddWithValue("@P10", cmbIlce.Text);
			komut.Parameters.AddWithValue("@P11", txtAdres.Text);
			komut.Parameters.AddWithValue("@P12", txtVergi.Text);
			komut.Parameters.AddWithValue("@P13", txtSektör.Text);
			komut.Parameters.AddWithValue("@P14", txtKod1.Text);
			komut.Parameters.AddWithValue("@P15", txtKod2.Text);
			komut.Parameters.AddWithValue("@P16", txtKod3.Text);
			komut.Parameters.AddWithValue("@P17", txtID.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Firma başarılı bir şekilde güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			temizle();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.LightGreen;
				e.Appearance.BackColor2 = Color.PeachPuff;
				e.HighPriority = true;
			}
		}
	}
}
