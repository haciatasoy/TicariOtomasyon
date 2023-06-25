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
	public partial class FrmRehber : Form
	{
		public FrmRehber()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti=	new SqlBaglantisi();
		private void FrmRehber_Load(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter("select AD,SOYAD,TELEFON,TELEFON2,MAIL from MUSTERILER", baglanti.baglantim());
			adapter.Fill(dt);
			gridControl1.DataSource = dt;

			DataTable dt2 = new DataTable();
			SqlDataAdapter adapter2 = new SqlDataAdapter("select FIRMA_ADI,YETKILI_AD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from FIRMALAR", baglanti.baglantim());
			adapter2.Fill(dt2);
			gridControl2.DataSource = dt2;
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmMail frmMail = new FrmMail();
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if (dr != null)
			{
				frmMail.Mail = dr["MAIL"].ToString();
			}
			frmMail.Show();
		}

		private void gridView2_DoubleClick(object sender, EventArgs e)
		{
			FrmMail frmMail = new FrmMail();
			DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
			if (dr != null)
			{
				frmMail.Mail = dr["MAIL"].ToString();
			}
			frmMail.Show();
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

		private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
		{
			GridView View = sender as GridView;
			if (e.RowHandle >= 0)
			{
				e.Appearance.BackColor = Color.Aqua;
				e.Appearance.BackColor2 = Color.AntiqueWhite;
				e.HighPriority = true;
			}
		}
	}
}
