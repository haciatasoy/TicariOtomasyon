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
	public partial class FrmBankalar : Form
	{
		public FrmBankalar()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("Execute BankaBilgileri", baglanti.baglantim());
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
		void FirmaListe()
		{
			DataTable dt2 = new DataTable();
			SqlDataAdapter adapter2 = new SqlDataAdapter("select ID,FIRMA_ADI from FIRMALAR", baglanti.baglantim());
			adapter2.Fill(dt2);
			txtFirma.Properties.ValueMember = "ID";
			txtFirma.Properties.DisplayMember = "FIRMA_ADI";
			txtFirma.Properties.DataSource = dt2;
		}
		private void FrmBankalar_Load(object sender, EventArgs e)
		{
			listele();
			sehirlerim();
			FirmaListe();
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
			SqlCommand komut = new SqlCommand("insert into BANKALAR (BANKA_AD,IL,ILCE,SUBE,IBAN,HESAP_NO,YETKILI,TELEFON,TARIH,HESAP_TURU,FIRMA_ID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", cmbIl.Text);
			komut.Parameters.AddWithValue("@p3", cmbIlce.Text);
			komut.Parameters.AddWithValue("@p4", txtSube.Text);
			komut.Parameters.AddWithValue("@p5", txtIban.Text);
			komut.Parameters.AddWithValue("@p6", txtHesapNo.Text);
			komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
			komut.Parameters.AddWithValue("@p8", txtTel.Text);
			komut.Parameters.AddWithValue("@p9", txtTarih.Text);
			komut.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
			komut.Parameters.AddWithValue("@p11", txtFirma.EditValue);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Firma başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtAd.Text = dr["BANKA_AD"].ToString();
			cmbIl.Text = dr["IL"].ToString();
			cmbIlce.Text = dr["ILCE"].ToString();
			txtSube.Text = dr["SUBE"].ToString();
			txtIban.Text = dr["IBAN"].ToString();
			txtHesapNo.Text = dr["HESAP_NO"].ToString();
			txtYetkili.Text = dr["YETKILI"].ToString();
			txtTel.Text = dr["TELEFON"].ToString();
			txtTarih.Text = dr["TARIH"].ToString();
			txtHesapTuru.Text = dr["HESAP_TURU"].ToString();
			txtFirma.Text = dr["FIRMA_ADI"].ToString();

		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DialogResult alert = new DialogResult();
			alert = MessageBox.Show("Banka Kaydınızı Sileceksiniz. Emin Misiniz?", "Banka Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (alert == DialogResult.Yes)
			{
				SqlCommand komut = new SqlCommand("delete from BANKALAR where ID=@p1", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtID.Text);
				komut.ExecuteNonQuery();
				baglanti.baglantim().Close();
				MessageBox.Show("Banka kaydı başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				listele();
			}
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("update BANKALAR set BANKA_AD=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAP_NO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAP_TURU=@p10,FIRMA_ID=@p11 where ID=@p12", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtAd.Text);
			komut.Parameters.AddWithValue("@p2", cmbIl.Text);
			komut.Parameters.AddWithValue("@p3", cmbIlce.Text);
			komut.Parameters.AddWithValue("@p4", txtSube.Text);
			komut.Parameters.AddWithValue("@p5", txtIban.Text);
			komut.Parameters.AddWithValue("@p6", txtHesapNo.Text);
			komut.Parameters.AddWithValue("@p7", txtYetkili.Text);
			komut.Parameters.AddWithValue("@p8", txtTel.Text);
			komut.Parameters.AddWithValue("@p9", txtTarih.Text);
			komut.Parameters.AddWithValue("@p10", txtHesapTuru.Text);
			komut.Parameters.AddWithValue("@p11", txtFirma.EditValue);
			komut.Parameters.AddWithValue("@p12", txtID.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Firma başarılı bir şekilde güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();

		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.MediumOrchid;
				e.Appearance.BackColor2 = Color.MediumTurquoise;

				e.HighPriority = true;
			}
		}
	}
}
