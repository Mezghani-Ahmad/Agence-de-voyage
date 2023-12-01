using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOA
{
	public class VolDAO
	{
		public static bool Add(Vol vol)
		{
			int n = -1;
			SqlConnection cnx = ConnexionAgence.GetInstance();

			if (vol != null)
			{
				try
				{
					string strSQL = "INSERT INTO Vol VALUES (@reference, @datedepart, @nbremaxnor, @nbremaxcom, @nbreplacenor , @nbreplacecom)";
					SqlCommand cmd = new SqlCommand(strSQL, cnx);
					cmd.Parameters.AddWithValue("@reference", vol.Reference);
					cmd.Parameters.AddWithValue("@datedepart", vol.DateDepart);
					cmd.Parameters.AddWithValue("@nbremaxnor", vol.NbreMaxNor);
					cmd.Parameters.AddWithValue("@nbremaxcom", vol.NbreMaxCom);
					cmd.Parameters.AddWithValue("@nbreplacenor", vol.NbrePlaceNor);
					cmd.Parameters.AddWithValue("@nbreplacecom", vol.NbrePlaceCom);

					n = cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					ConnexionAgence.Close();
				}
			}

			return n > 0;
		}

		public static List<Vol> FindAll()
		{		
			List<Vol> vols = new List<Vol>();
			SqlConnection cnx = ConnexionAgence.GetInstance();

			try
			{
				SqlCommand cmd = new SqlCommand("select * from Vol", cnx);
				SqlDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					Vol m = new Vol(dr.GetString(0), dr.GetDateTime(1), dr.GetInt32(2), dr.GetInt32(3), dr.GetInt32(4), dr.GetInt32(5));
					vols.Add(m);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("DOA  " + ex.Message);
			}
			finally
			{
				ConnexionAgence.Close();
			}

			return vols;
		}

		public static bool Updatevol(Vol vol)
		{
			try
			{
				SqlConnection cnx = ConnexionAgence.GetInstance();
				SqlCommand cmd = new SqlCommand("update Vol set datedepart =  @datedepart, nbremaxnor = @nbremaxnor, nbremaxcom =  @nbremaxcom," +
				   " nbreplacenor = @nbreplacenor ,  nbreplacecom = @nbreplacecom" +
					" where reference=@reference ", cnx);
				cmd.Parameters.AddWithValue("@datedepart", vol.DateDepart);
				cmd.Parameters.AddWithValue("@nbremaxnor", vol.NbreMaxNor);
				cmd.Parameters.AddWithValue("@nbremaxcom", vol.NbreMaxCom);
				cmd.Parameters.AddWithValue("@nbreplacenor", vol.NbrePlaceNor);
				cmd.Parameters.AddWithValue("@nbreplacecom", vol.NbrePlaceCom);
				cmd.Parameters.AddWithValue("@reference", vol.Reference);
				int nb = cmd.ExecuteNonQuery();

				return (nb > 0);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				ConnexionAgence.Close();
			}

			return false;
		}
	}
}
