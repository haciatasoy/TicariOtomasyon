using DevExpress.XtraEditors;
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
	public partial class GirisPaneli : Form
	{
		public GirisPaneli()
		{
			InitializeComponent();
		}
		SqlBaglantisi baglanti= new SqlBaglantisi();
		private void BtnGiris_MouseHover(object sender, EventArgs e)
		{
			BtnGiris.BackColor = Color.LightGreen;
		}

		private void BtnGiris_MouseLeave(object sender, EventArgs e)
		{
			BtnGiris.BackColor = Color.LightGreen;
			
		}

		private void BtnGiris_Click(object sender, EventArgs e)
		{
			SqlCommand komut = new SqlCommand("select * from ADMIN where Username=@p1 and Parola=@p2", baglanti.baglantim());
			komut.Parameters.AddWithValue("@p1",txtUsername.Text);
			komut.Parameters.AddWithValue("@p2", txtSifre.Text);
			SqlDataReader dr= komut.ExecuteReader();
			if(dr.Read())
			{
				this.Hide();
				Form1 frm = new Form1();
				frm.kullanici = txtUsername.Text;
				frm.ShowDialog();
				this.Close();
			}
			else
			{
				XtraMessageBox.Show("Kullanıcı Adı Veya Parola yanlış!","Giriş Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void BtnGiris_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				SqlCommand komut = new SqlCommand("select * from ADMIN where Username=@p1 and Parola=@p2", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtUsername.Text);
				komut.Parameters.AddWithValue("@p2", txtSifre.Text);
				SqlDataReader dr = komut.ExecuteReader();
				if (dr.Read())
				{
					this.Hide();
					Form1 frm = new Form1();
					frm.kullanici = txtUsername.Text;
					frm.ShowDialog();
					this.Close();
				}
				else
				{
					XtraMessageBox.Show("Kullanıcı Adı Veya Parola yanlış!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void GirisPaneli_Load(object sender, EventArgs e)
		{
			txtUsername.Focus();
		}

		private void txtSifre_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SqlCommand komut = new SqlCommand("select * from ADMIN where Username=@p1 and Parola=@p2", baglanti.baglantim());
				komut.Parameters.AddWithValue("@p1", txtUsername.Text);
				komut.Parameters.AddWithValue("@p2", txtSifre.Text);
				SqlDataReader dr = komut.ExecuteReader();
				if (dr.Read())
				{
					this.Hide();
					Form1 frm = new Form1();
					frm.kullanici = txtUsername.Text;
					frm.ShowDialog();
					this.Close();
					
				}
				else
				{
					XtraMessageBox.Show("Kullanıcı Adı Veya Parola yanlış!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
