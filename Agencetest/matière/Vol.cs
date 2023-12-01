using System;

namespace Model
{
	public class Vol
	{
		string reference;
		DateTime dateDepart;
		int nbreMaxNor;
		int nbreMaxCom;
		int nbrePlaceNor;
		int nbrePlaceCom;

		public Vol(string reference, DateTime dateDepart, int nbreMaxNor, int nbreMaxCom, int nbrePlaceNor, int nbrePlaceCom)
		{
			this.reference = reference;
			this.dateDepart = dateDepart;
			this.nbreMaxNor = nbreMaxNor;
			this.nbreMaxCom = nbreMaxCom;
			this.nbrePlaceNor = nbrePlaceNor;
			this.nbrePlaceCom = nbrePlaceCom;
		}

		public string Reference { get => reference; set => reference = value; }
		public DateTime DateDepart { get => dateDepart; set => dateDepart = value; }
		public int NbreMaxNor { get => nbreMaxNor; set => nbreMaxNor = value; }
		public int NbreMaxCom { get => nbreMaxCom; set => nbreMaxCom = value; }
		public int NbrePlaceNor { get => nbrePlaceNor; set => nbrePlaceNor = value; }
		public int NbrePlaceCom { get => nbrePlaceCom; set => nbrePlaceCom = value; }

		public override bool Equals(object obj)
		{
			return obj is Vol vol &&
				   reference == vol.reference;
		}

		public override string ToString()
		{
			return  reference + "|" + dateDepart.ToString() + "|" + nbreMaxNor.ToString() + "|" + nbreMaxCom.ToString()	+ "|" + NbrePlaceNor.ToString()	 +  "|" + nbrePlaceCom.ToString();
		}
	}
}
