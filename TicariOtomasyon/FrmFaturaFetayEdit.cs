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
	public partial class FrmFaturaFetayEdit : Form
	{
		public FrmFaturaFetayEdit()
		{
			InitializeComponent();
		}
		public string id;
		SqlBaglantisi baglanti=new SqlBaglantisi();
		
		private void FrmFaturaFetayEdit_Load(object sender, EventArgs e)
		{
			txtID.Text = id;

			SqlCommand komut = new SqlCommand("select * from FATURADETAY where FATURAURUNID=@p1", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", id);
			SqlDataReader dr = komut.ExecuteReader();
			while (dr.Read())
			{
				txtUrunAd.Text = dr[1].ToString();
				txtMiktar.Text = dr[2].ToString();
				txtFiyat.Text = dr[3].ToString();
				txtTutar.Text = dr[4].ToString();
				txtFaturaId.Text = dr[5].ToString();

				baglanti.baglantim().Close();
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update FATURADETAY set URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4,FATURAID=@P5 WHERE FATURAURUNID=@P6", baglanti.baglantim());
			komut.Parameters.AddWithValue("@P1", txtUrunAd.Text);
			komut.Parameters.AddWithValue("@P2", txtMiktar.Text);
			komut.Parameters.AddWithValue("@P3",decimal.Parse(txtFiyat.Text));
			komut.Parameters.AddWithValue("@P4",decimal.Parse(txtTutar.Text));
			komut.Parameters.AddWithValue("@P5", txtFaturaId.Text);			
			komut.Parameters.AddWithValue("@P6", txtID.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Kayıt başarılı bir şekilde güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DialogResult alert = new DialogResult();
			alert = MessageBox.Show("Kaydınızı Sileceksiniz. Emin Misiniz?", "Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (alert == DialogResult.Yes)
			{
				SqlCommand komut = new SqlCommand("delete from FATURADETAY where FATURAURUNID=@p1", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtID.Text);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
				MessageBox.Show("Kayıt başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				this.Hide();
				
			}
		}

		private void BtnHesapla_Click(object sender, EventArgs e)
		{
			double adet, fiyat, tutar;
			adet = Convert.ToDouble(txtMiktar.Text);
			fiyat = Convert.ToDouble(txtFiyat.Text);
			tutar = adet * fiyat;
			txtTutar.Text = tutar.ToString();
			MessageBox.Show("Yeniden hesaplama yapıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

		}
	}
}
