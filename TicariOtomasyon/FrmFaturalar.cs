using DevExpress.XtraEditors;
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
	public partial class FrmFaturalar : Form
	{
		public FrmFaturalar()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti = new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from FATURALAR", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		void temizle()
		{
			txtID.Text = "";
			txtSeri.Text = "";
			txtFaturaNo.Text = "";
			txtTarih.Text = "";
			txtSaat.Text = "";
			txtVergi.Text = "";
			txtAlici.Text = "";
			txtKesen.Text = "";
			txtAlan.Text = "";

			txtUrunId.Properties.NullText="Ürün Seçiniz...";
			txtUrunAd.Text = "";
			txtAdet.Text = "";
			txtFiyat.Text = "";
			txtTutar.Text = "";
			txtFaturaId.Properties.NullText = "Fatura Seçiniz...";
			cmbCari.Text = "";
			txtPersonel.Properties.NullText = "Personel Seçiniz...";
			txtFirma.Properties.NullText = "Firma Seçiniz...";
			labelControl18.Text = "Firma";
		}
		private void FrmFaturalar_Load(object sender, EventArgs e)
		{
			listele();
			temizle();
			urunliste();
			personeller();
			FirmaListe();
			faturaliste();
			
		}
		private void BtnKaydet_Click_1(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into FATURALAR (SERI,SIRANO,TARIH,SAAT,VERGI_DAIRE,ALICI,TESLIM_EDEN,TESLIM_ALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtSeri.Text);
			komut.Parameters.AddWithValue("@p2", txtFaturaNo.Text);
			komut.Parameters.AddWithValue("@p3", txtTarih.Text);
			komut.Parameters.AddWithValue("@p4", txtSaat.Text);
			komut.Parameters.AddWithValue("@p5", txtVergi.Text);
			komut.Parameters.AddWithValue("@p6", txtAlici.Text);
			komut.Parameters.AddWithValue("@p7", txtKesen.Text);
			komut.Parameters.AddWithValue("@p8", txtAlan.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Fatura başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			
		}

		private void BtnUrunKaydet_Click(object sender, EventArgs e)
		{
			double adet, fiyat, tutar;
			adet = Convert.ToDouble(txtAdet.Text);
			fiyat = Convert.ToDouble(txtFiyat.Text);
			tutar = adet * fiyat;
			txtTutar.Text = tutar.ToString();

			if (cmbCari.Text == null)
			{
				XtraMessageBox.Show("Cari türü boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

			SqlCommand komut = new SqlCommand("insert into FATURADETAY (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
			komut.Parameters.AddWithValue("@p2",decimal.Parse(txtAdet.Text));
			komut.Parameters.AddWithValue("@p3",decimal.Parse(txtFiyat.Text));
			komut.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
			komut.Parameters.AddWithValue("@p5", txtFaturaId.EditValue);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			firmahareketkaydet();
			musterihareketkaydet();
			stoktandus();
			MessageBox.Show("Faturaya ait ürün başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			temizle();
		}
		void firmahareketkaydet()
		{
			if (cmbCari.Text == "Firma")
			{
				SqlCommand komut = new SqlCommand("insert into FIRMAHAREKETLER (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7)", baglanti.baglantim());
				komut.Parameters.AddWithValue("@h1", txtUrunId.EditValue);
				komut.Parameters.AddWithValue("@h2", txtAdet.Text);
				komut.Parameters.AddWithValue("@h3", txtPersonel.EditValue);
				komut.Parameters.AddWithValue("@h4", txtFirma.EditValue);
				komut.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
				komut.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
				komut.Parameters.AddWithValue("@h7", txtFaturaId.EditValue);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
			}
		}
		void musterihareketkaydet()
		{
			if(cmbCari.Text == "Müşteri")
			{
				SqlCommand komut = new SqlCommand("insert into MUSTERIHAREKETLER (URUNID,ADET,PERSONEL,MUSTERI,FIYAT,TOPLAM,FATURAID) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7)", baglanti.baglantim());
				komut.Parameters.AddWithValue("@h1", txtUrunId.EditValue);
				komut.Parameters.AddWithValue("@h2", txtAdet.Text);
				komut.Parameters.AddWithValue("@h3", txtPersonel.EditValue);
				komut.Parameters.AddWithValue("@h4", txtFirma.EditValue);
				komut.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
				komut.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
				komut.Parameters.AddWithValue("@h7", txtFaturaId.EditValue);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
			}
		}
		void stoktandus()
		{
			SqlCommand komut=new SqlCommand("update URUNLER set ADET=ADET-@s1 where ID=@s2",baglanti.baglantim());
			komut.Parameters.AddWithValue("@s1",txtAdet.Text);
			komut.Parameters.AddWithValue("@s2",txtUrunId.EditValue);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtSeri.Text = dr["SERI"].ToString();
			txtFaturaNo.Text = dr["SIRANO"].ToString();
			txtTarih.Text = dr["TARIH"].ToString();
			txtSaat.Text = dr["SAAT"].ToString();
			txtVergi.Text = dr["VERGI_DAIRE"].ToString();
			txtAlici.Text = dr["ALICI"].ToString();
			txtKesen.Text = dr["TESLIM_EDEN"].ToString();
			txtAlan.Text = dr["TESLIM_ALAN"].ToString();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DialogResult alert = new DialogResult();
			alert = MessageBox.Show("Fatura Kaydınızı Sileceksiniz. Emin Misiniz?", "Fatura Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (alert == DialogResult.Yes)
			{
				SqlCommand komut = new SqlCommand("delete from FATURALAR where ID=@p1", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtID.Text);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
				MessageBox.Show("Fatura başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				listele();
				temizle();
			}
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update FATURALAR set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGI_DAIRE=@P5,ALICI=@P6,TESLIM_EDEN=@P7,TESLIM_ALAN=@P8 WHERE ID=@P9", baglanti.baglantim());
			komut.Parameters.AddWithValue("@P1", txtSeri.Text);
			komut.Parameters.AddWithValue("@P2", txtFaturaNo.Text);
			komut.Parameters.AddWithValue("@P3", txtTarih.Text);
			komut.Parameters.AddWithValue("@P4", txtSaat.Text);
			komut.Parameters.AddWithValue("@P5", txtVergi.Text);
			komut.Parameters.AddWithValue("@P6", txtAlici.Text);
			komut.Parameters.AddWithValue("@P7", txtKesen.Text);
			komut.Parameters.AddWithValue("@P8", txtAlan.Text);
			komut.Parameters.AddWithValue("@P9", txtID.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Fatura başarılı bir şekilde güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
			temizle();
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmFaturaUrun frm=new FrmFaturaUrun();
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if (dr != null)
			{
				frm.id = dr["ID"].ToString();
			}
			frm.Show();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.Beige;
				e.Appearance.BackColor2 = Color.PaleVioletRed;

				e.HighPriority = true;
			}
		}
		void urunliste()
		{
			DataTable dt2 = new DataTable();
			SqlDataAdapter adapter2 = new SqlDataAdapter("select ID,URUNAD,MARKA from URUNLER", baglanti.baglantim());
			adapter2.Fill(dt2);
			txtUrunId.Properties.ValueMember = "ID";
			txtUrunId.Properties.DisplayMember = "URUNAD";		
			txtUrunId.Properties.DataSource = dt2;
			
		}
		void personeller()
		{
			DataTable dt2 = new DataTable();
			SqlDataAdapter adapter2 = new SqlDataAdapter("select ID,AD + ' ' + SOYAD AS AD_SOYAD from PERSONELLER", baglanti.baglantim());
			adapter2.Fill(dt2);
			txtPersonel.Properties.ValueMember = "ID";
			txtPersonel.Properties.DisplayMember = "AD_SOYAD";
			txtPersonel.Properties.DataSource = dt2;
		}
		void FirmaListe()
		{
			DataTable dt2 = new DataTable();
			SqlDataAdapter adapter2 = new SqlDataAdapter("select ID,FIRMA_ADI from FIRMALAR", baglanti.baglantim());
			adapter2.Fill(dt2);
			txtFirma.Properties.NullText = "Firma Seçiniz...";
			txtFirma.Properties.ValueMember = "ID";
			txtFirma.Properties.DisplayMember = "FIRMA_ADI";
			txtFirma.Properties.DataSource = dt2;
		}
		void MusteriListe()
		{
			DataTable dt2 = new DataTable();
			SqlDataAdapter adapter2 = new SqlDataAdapter("select ID,AD + ' ' + SOYAD AS MUSTERI from MUSTERILER", baglanti.baglantim());
			adapter2.Fill(dt2);
			txtFirma.Properties.NullText = "Müşteri Seçiniz...";
			txtFirma.Properties.ValueMember = "ID";
			txtFirma.Properties.DisplayMember = "MUSTERI";
			txtFirma.Properties.DataSource = dt2;
		}
		void faturaliste()
		{
			DataTable dt2 = new DataTable();
			SqlDataAdapter adapter2 = new SqlDataAdapter("select ID,SERI +''+ SIRANO as FATURA_NO from FATURALAR", baglanti.baglantim());
			adapter2.Fill(dt2);
			txtFaturaId.Properties.ValueMember = "ID";
			txtFaturaId.Properties.DisplayMember = "FATURA_NO";
			txtFaturaId.Properties.DataSource = dt2;
		}

		private void lookUpEdit4_EditValueChanged(object sender, EventArgs e)
		{
			if (txtUrunId.EditValue != null)
			{
				SqlCommand komut = new SqlCommand("select URUNAD,SATISFIYATI from URUNLER where ID=@p1", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1",txtUrunId.EditValue);
				SqlDataReader dr=komut.ExecuteReader();
				while (dr.Read())
				{
					txtUrunAd.Text = dr[0].ToString();
					txtFiyat.Text = dr[1].ToString();
				}
				baglanti.baglantim().Close();
			}
		}

		private void cmbCari_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbCari.Text == "Müşteri")
			{
				txtFirma.Properties.Columns.Clear();
				labelControl18.Text = "Müşteri:";
				MusteriListe();
			}			
			else
			{
				txtFirma.Properties.Columns.Clear();
				labelControl18.Text = "Firma:";
				FirmaListe();
			}
		}
	}
}
