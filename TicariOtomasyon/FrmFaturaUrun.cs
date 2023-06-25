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
	public partial class FrmFaturaUrun : Form
	{
		public FrmFaturaUrun()
		{
			InitializeComponent();
		}
		public string id;
		SqlBaglantisi baglanti = new SqlBaglantisi();
		void listele()
		{			
			SqlDataAdapter adapter = new SqlDataAdapter("select * from FATURADETAY where FATURAID='" + id +"'", baglanti.baglantim());
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			gridControl1.DataSource = dt;
		}
		private void FrmFaturaUrun_Load(object sender, EventArgs e)
		{
			listele();
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			FrmFaturaFetayEdit frm=new FrmFaturaFetayEdit();
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			if (dr != null)
			{
				frm.id = dr["FATURAURUNID"].ToString();
			}
			frm.Show();
		}

		private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
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
