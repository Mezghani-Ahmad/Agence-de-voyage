using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
		string numero;
		string nomVoyageur;
		string type;
        Vol vol;

		public Ticket(string numero, string nomVoyageur, string type, Vol vol)
		{
			this.numero = numero;
			this.nomVoyageur = nomVoyageur;
			this.type = type;
			this.vol = vol;
		}

		public string Numero { get => numero; set => numero = value; }
		public string NomVoyageur { get => nomVoyageur; set => nomVoyageur = value; }
		public string Type { get => type; set => type = value; }
		public Vol Vol { get => vol; set => vol = value; }

		public override bool Equals(object obj)
		{
			return obj is Ticket ticket &&
				   numero == ticket.numero;
		}

		public override string ToString()
		{
			return numero + "|" + nomVoyageur + "|" + type + "|" +  vol.Reference ;	
		}
	}
}
