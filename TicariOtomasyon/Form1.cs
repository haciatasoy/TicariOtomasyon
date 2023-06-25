using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		FrmUrunler frm;
		private void BTNURUNLER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frm == null || frm.IsDisposed)
			{
				frm = new FrmUrunler();
				frm.MdiParent = this;
				frm.Show();
			}
		}
		FrmMusteriler frmMusteriler;
		private void BTNMUSTERILER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmMusteriler == null || frmMusteriler.IsDisposed){
				frmMusteriler = new FrmMusteriler();
				frmMusteriler.MdiParent = this;
				frmMusteriler.Show();
			}
		}
		FrmFirmalar frmFirmalar;

		private void BTNFIRMALAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (frmFirmalar == null || frmFirmalar.IsDisposed)
			{
				frmFirmalar = new FrmFirmalar();
				frmFirmalar.MdiParent = this;
				frmFirmalar.Show();
			}
		}
		FrmPersoneller FrmPersoneller;
		private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(FrmPersoneller == null || FrmPersoneller.IsDisposed)
			{
				FrmPersoneller=new FrmPersoneller();
				FrmPersoneller.MdiParent = this;
				FrmPersoneller.Show();
			}
		}
		FrmRehber frmRehber;
		private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmRehber == null || frmRehber.IsDisposed)
			{
				frmRehber= new FrmRehber();
				frmRehber.MdiParent = this;
				frmRehber.Show();
			}
		}
		FrmGiderler frmGiderler;
		private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if( frmGiderler == null || frmGiderler.IsDisposed)
			{
				frmGiderler= new FrmGiderler();
				frmGiderler.MdiParent = this;
				frmGiderler.Show();
			}
		}
		FrmNotlar frmNotlar;
		private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmNotlar == null || frmNotlar.IsDisposed)
			{
				frmNotlar= new FrmNotlar();
				frmNotlar.MdiParent = this;
				frmNotlar.Show();
			}
		}
		FrmBankalar frmBankalar;
		private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmBankalar == null || frmBankalar.IsDisposed)
			{
				frmBankalar= new FrmBankalar();
				frmBankalar.MdiParent = this;
				frmBankalar.Show();
			}
		}
		FrmFaturalar frmFaturalar;
		private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmFaturalar==null || frmFaturalar.IsDisposed)
			{
				frmFaturalar= new FrmFaturalar();
				frmFaturalar.MdiParent= this;
				frmFaturalar.Show();
			}
		}
		FrmHareketler frmHareketler;
		private void BtnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmHareketler==null || frmHareketler.IsDisposed)
			{
				frmHareketler= new FrmHareketler();
				frmHareketler.MdiParent = this;
				frmHareketler.Show();
			}
		}
		FrmRaporlar frmRaporlar;
		private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmRaporlar==null|| frmRaporlar.IsDisposed)
			{
				frmRaporlar= new FrmRaporlar();
				frmRaporlar .MdiParent = this;
				frmRaporlar .Show();
			}
		}
		FrmAyarlar ayarlar;
		private void BtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(ayarlar==null || ayarlar.IsDisposed)
			{
				ayarlar= new FrmAyarlar();
				ayarlar.Show();
			}
		}
		FrmKasa frmKasa;
		private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmKasa==null || frmKasa.IsDisposed)
			{
				frmKasa = new FrmKasa();
				frmKasa.ad = kullanici;
				frmKasa.MdiParent = this;
				frmKasa.Show();
			}
		}
		public string kullanici;
		FrmAnasayfa frmAnasayfa;
		private void BtnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmAnasayfa==null || frmAnasayfa.IsDisposed)
			{
				frmAnasayfa = new FrmAnasayfa();
				frmAnasayfa.MdiParent= this;
				frmAnasayfa.Show();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if (frmAnasayfa == null || frmAnasayfa.IsDisposed)
			{
				frmAnasayfa = new FrmAnasayfa();
				frmAnasayfa.MdiParent = this;
				frmAnasayfa.Show();
			}
		}
		FrmStoklar frmStoklar;
		private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if(frmStoklar==null || frmStoklar.IsDisposed)
			{
				frmStoklar = new FrmStoklar();
				frmStoklar .MdiParent = this;
				frmStoklar.Show();
			}
		}
	}
}
