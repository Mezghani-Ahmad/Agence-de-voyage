using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOA
{
	public class ConnexionAgence
	{
		static string chaineCnx = "Server=localhost\\SQLEXPRESS;Database=BDAgenceTest;Trusted_Connection=True;";
		
		static SqlConnection cnx = new SqlConnection(chaineCnx);

		public static SqlConnection GetInstance()
		{
			try
			{
				if (cnx.State != System.Data.ConnectionState.Open)
					cnx.Open();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Vente: Pb de connexion\n " + ex.Message);
			}

			return cnx;
		}

		public static void Close()
		{
			try
			{
				if (cnx != null && cnx.State != System.Data.ConnectionState.Closed)
					cnx.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Vente: Pb de connexion\n " + ex.Message);
			}
		}
	}
}
