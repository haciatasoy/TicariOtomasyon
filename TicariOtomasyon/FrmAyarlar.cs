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
	public partial class FrmAyarlar : Form
	{
		public FrmAyarlar()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=new SqlBaglantisi();
		void listele()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("Select * from ADMIN", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		private void FrmAyarlar_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			txtUsername.Text = dr["Username"].ToString();
			txtParola.Text = dr["Parola"].ToString();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("insert into ADMIN values(@p1,@p2)", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtUsername.Text);
			komut.Parameters.AddWithValue("@p2", txtParola.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Admin başarılı bir şekilde kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("delete from ADMIN where Username=@p1 and Parola=@p2", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1", txtUsername.Text);
			komut.Parameters.AddWithValue("@p2", txtParola.Text);
			komut.ExecuteNonQuery();
			baglanti.baglantim().Close();
			MessageBox.Show("Admin başarılı bir şekilde silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
			listele();
		}
	}
}
