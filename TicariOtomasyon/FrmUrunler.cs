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
	public partial class FrmUrunler : Form
	{
		public FrmUrunler()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti = new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select * from URUNLER", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;

		}
		
		private void labelControl1_Click(object sender, EventArgs e)
		{

		}

		private void FrmUrunler_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("insert into URUNLER (URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYATI,SATISFIYATI,DETAY) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti.baglantim());
			command.Parameters.AddWithValue("@p1", txtAd.Text);
			command.Parameters.AddWithValue("@p2",txtMarka.Text);
			command.Parameters.AddWithValue("@p3", txtModel.Text);
			command.Parameters.AddWithValue("@p4", txtYil.Text);
			command.Parameters.AddWithValue("@p5", txtAdet.Text);
			command.Parameters.AddWithValue("@p6", decimal.Parse(txtAlis.Text));
			command.Parameters.AddWithValue("@p7", decimal.Parse(txtSatis.Text));
			command.Parameters.AddWithValue("@p8", txtDetay.Text);
			command.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Ürün başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
		}

		private void labelControl6_Click(object sender, EventArgs e)
		{

		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			DialogResult alert = new DialogResult();
			alert = MessageBox.Show("Ürün Kaydınızı Sileceksiniz. Emin Misiniz?", "Ürün Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (alert == DialogResult.Yes)
			{
				SqlCommand sil = new SqlCommand("delete from URUNLER where ID=@p1", baglanti.baglantim());
				sil.Parameters.AddWithValue("@p1", txtID.Text);
				sil.ExecuteNonQuery();
				baglanti.baglantim().Close();
				MessageBox.Show("Ürün başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Error);
				listele();
			}
			
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtID.Text = dr["ID"].ToString();
			txtAd.Text = dr["URUNAD"].ToString();
			txtMarka.Text = dr["MARKA"].ToString();
			txtModel.Text = dr["MODEL"].ToString();
			txtYil.Text = dr["YIL"].ToString();
			txtAdet.Text = dr["ADET"].ToString();
			txtAlis.Text = dr["ALISFIYATI"].ToString();
			txtSatis.Text = dr["SATISFIYATI"].ToString();
			txtDetay.Text = dr["DETAY"].ToString();
			
		}

		private void BtnGuncelle_Click(object sender, EventArgs e)
		{
			SqlCommand guncel = new SqlCommand("update URUNLER set URUNAD=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,ALISFIYATI=@P6,SATISFIYATI=@P7,DETAY=@P8 where ID=@P9", baglanti.baglantim());
			guncel.Parameters.AddWithValue("@P1", txtAd.Text);
			guncel.Parameters.AddWithValue("@P2", txtMarka.Text);
			guncel.Parameters.AddWithValue("@P3", txtModel.Text);
			guncel.Parameters.AddWithValue("@P4", txtYil.Text);
			guncel.Parameters.AddWithValue("@P5", txtAdet.Text);
			guncel.Parameters.AddWithValue("@P6", decimal.Parse(txtAlis.Text));
			guncel.Parameters.AddWithValue("@P7", decimal.Parse(txtSatis.Text));
			guncel.Parameters.AddWithValue("@P8", txtDetay.Text);
			guncel.Parameters.AddWithValue("@P9",txtID.Text);
			guncel.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Ürün başarılı bir şekilde güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			listele();

		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["URUNAD"]);
				if (category != null)
				{
					e.Appearance.BackColor = Color.LightPink;
					e.Appearance.BackColor2 = Color.MediumPurple;
					
					e.HighPriority = true;
				}
			}
		}
	}
}
