using DOA;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace Controleur
{
	public class VolControleur
	{
		private static List<Vol> LesVols;

		public static List<Vol> GetVols()
		{
			LesVols = VolDAO.FindAll();
			return LesVols;
		}

		public static List<Vol> ChercheParAnnee(int annee)
		{
			List<Vol> filteredVols = new List<Vol>();
			if (annee > 0)
			{
				VolControleur.GetVols();
				filteredVols = LesVols.Where(a => a.DateDepart.Year == annee).ToList();
			}

			return filteredVols;
		}

		public static string GenererReference(int annee)
		{
			int commandCount = LesVols.Count(a => a.DateDepart.Year == annee);
			string newReference = string.Empty;
			if (annee > 0)
			{
				newReference = "V" + annee.ToString() + "-" + (commandCount + 1).ToString().PadLeft(2, '0');
			}

			return newReference;
		}

		public static bool AjouteVol(Vol vol)
		{
			bool insertion = false;
			if (vol != null)
			{
				bool isVolExist = LesVols.Any(element => element.DateDepart.Date == vol.DateDepart.Date);
				if (!isVolExist)
				{
					vol.Reference = GenererReference(vol.DateDepart.Year);
					insertion = VolDAO.Add(vol);

					if (insertion)
					{
						LesVols.Add(vol);
					}
				}
			}

			return insertion;
		}
	}
}
