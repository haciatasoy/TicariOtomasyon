﻿using System;
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
	public partial class FrmRaporlar : Form
	{
		public FrmRaporlar()
		{
			InitializeComponent();
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{

		}

		private void gridView2_DoubleClick(object sender, EventArgs e)
		{

		}

		private void FrmRaporlar_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'TicariOtomasyonDataSet1.FIRMALAR' table. You can move, or remove it, as needed.
			this.FIRMALARTableAdapter.Fill(this.TicariOtomasyonDataSet1.FIRMALAR);
			// TODO: This line of code loads data into the 'TicariOtomasyonDataSet.URUNLER' table. You can move, or remove it, as needed.
			this.URUNLERTableAdapter.Fill(this.TicariOtomasyonDataSet.URUNLER);


			this.reportViewer1.RefreshReport();
			this.reportViewer2.RefreshReport();
		}
	}
}
