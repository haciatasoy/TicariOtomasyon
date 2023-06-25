using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TicariOtomasyon
{
	public class SqlBaglantisi
	{
		public SqlConnection baglantim()
		{
			SqlConnection baglanti = new SqlConnection(@"db");
			baglanti.Open();
			return baglanti;
		}
	}
}
