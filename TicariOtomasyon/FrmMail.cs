using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TicariOtomasyon
{
	public partial class FrmMail : Form
	{
		public FrmMail()
		{
			InitializeComponent();
		}

		private void labelControl2_Click(object sender, EventArgs e)
		{

		}
		public string Mail;
		private void FrmMail_Load(object sender, EventArgs e)
		{
			txtMailAdresi.Text= Mail;
		}

		private void BtnGonder_Click(object sender, EventArgs e)
		{
			MailMessage mailMessage = new MailMessage();
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Credentials = new NetworkCredential("mailadresim", "parola");
			smtpClient.EnableSsl = true;
			smtpClient.Port = 587;
			smtpClient.Host = "smpt.gmail.com";
			mailMessage.To.Add(txtMesaj.Text);
			mailMessage.From=new MailAddress("mailadresi");
			mailMessage.Subject=txtKonu.Text;
			mailMessage.Body=txtMesaj.Text;
			smtpClient.Send(mailMessage);
		}
	}
}
