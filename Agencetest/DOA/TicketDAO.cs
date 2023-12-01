using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DOA
{
	public class TicketDAO
	{
		public static bool Add(Ticket ticket)
		{
			int n = -1;
			SqlConnection cnx = ConnexionAgence.GetInstance();
			if (ticket != null)
			{
				try
				{
					string strSQL = "INSERT INTO Ticket VALUES (@numero, @nomvoyageur, @type, @vol)";
					SqlCommand cmd = new SqlCommand(strSQL, cnx);
					cmd.Parameters.AddWithValue("@numero", ticket.Numero);
					cmd.Parameters.AddWithValue("@nomvoyageur", ticket.NomVoyageur);
					cmd.Parameters.AddWithValue("@type", ticket.Type);
					cmd.Parameters.AddWithValue("@vol", ticket.Vol.Reference);

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

		//public static List<Ticket> FindAll()
		//{
		//	List<Ticket> tickets = new List<Ticket>();
		//	SqlConnection cnx = ConnexionAgence.GetInstance();

		//	try
		//	{
		//		SqlCommand cmd = new SqlCommand("select * from Ticket ", cnx);
		//		List<Vol> vols = VolDAO.FindAll();
		//		SqlDataReader dr = cmd.ExecuteReader();
		//		while (dr.Read())
		//		{
		//			foreach (Vol vol in vols)
		//			{
		//				if (vol.Reference.Equals(dr.GetString(3)))
		//				{
		//					Ticket ticket = new Ticket(dr.GetString(0), dr.GetString(1), dr.GetString(2), vol);
		//					tickets.Add(ticket);
		//				}
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show("DOA  " + ex.Message);
		//	}
		//	finally
		//	{
		//		ConnexionAgence.Close();
		//	}

		//	return tickets;
		//}

		public static List<Ticket> FindByVol(Vol vol)
		{
			List<Ticket> tickets = new List<Ticket>();
			SqlConnection cnx = ConnexionAgence.GetInstance();

			if (vol != null)
			{
				try
				{
					SqlCommand cmd = new SqlCommand("select * from Ticket where vol = @VolReference", cnx);
					cmd.Parameters.AddWithValue("@VolReference", vol.Reference);

					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						Ticket ticket = new Ticket(dr.GetString(0), dr.GetString(1), dr.GetString(2), vol);
						tickets.Add(ticket);
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
			}

			return tickets;
		}

		//public static int Countticket(string type)
		//{
		//	SqlConnection cnx = ConnexionAgence.GetInstance();

		//	SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM  Ticket  where type=@type", cnx);
		//	command.Parameters.AddWithValue("@type", type);
		//	int commandCount = (int)command.ExecuteScalar();
		//	return commandCount;
		//}
	}
}
