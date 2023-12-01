using DOA;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace Controleur
{
	public class TicketControleur
	{
		static List<string> VolTypes = new List<string>() { "Normal", "Commercial" };

		public static List<Ticket> GetTiketParVol(Vol v)
		{
			return TicketDAO.FindByVol(v);
		}

		public static string GenererNumTicket(string type, Vol vol)
		{
			string numTicket = string.Empty;

			if (VolTypes.Contains(type))
			{
				numTicket = "T" + type.ElementAt(0);
			}

			if (vol != null && !string.IsNullOrWhiteSpace(vol.Reference))
			{
				numTicket += vol.Reference;
			}

			if (vol != null)
			{
				int volTickets = GetTiketParVol(vol).Count();
				string ticketsCount = volTickets.ToString().PadLeft(2, '0');
				numTicket += "-" + ticketsCount;
			}

			return numTicket;
		}

		public static bool AjouterTicket(Ticket ticket)
		{
			bool result = false;

			if (ticket != null && ticket.Vol != null && !string.IsNullOrWhiteSpace(ticket.Type))
			{
				if (ticket.Type.Equals("Normal") && ticket.Vol.NbrePlaceNor < ticket.Vol.NbreMaxNor)
				{
					ticket.Vol.NbrePlaceNor++;
					ticket.Numero = GenererNumTicket(ticket.Type, ticket.Vol);

					result = TicketDAO.Add(ticket);
				}
				else if (ticket.Type.Equals("Commercial") && ticket.Vol.NbrePlaceCom < ticket.Vol.NbreMaxCom)
				{
					ticket.Vol.NbrePlaceCom++;
					ticket.Numero = GenererNumTicket(ticket.Type, ticket.Vol);

					result = TicketDAO.Add(ticket);
				}
			}

			return result;
		}
	}
}
