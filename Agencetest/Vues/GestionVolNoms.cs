using Controleur;
using Model;
using System;
using System.Windows.Forms;

namespace Vues
{
	public partial class GestionVolNoms : Form
	{
		public GestionVolNoms()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			int currentYear = DateTime.Now.Year;
			CmbAnnees.Items.Add(currentYear);
			CmbAnnees.Items.Add(currentYear + 1);

			if (CmbAnnees.SelectedItem != null)
			{
				dgvGestionVol.DataSource = VolControleur.ChercheParAnnee(int.Parse(CmbAnnees.SelectedItem.ToString()));
				btnReference.Text = VolControleur.GenererReference(int.Parse(CmbAnnees.SelectedItem.ToString()));
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Vol vol = new Vol(string.Empty, this.dtpdatededepart.Value, int.Parse(this.txtnbremaxnormal.Text), int.Parse(this.txtnbremaxcommercial.Text), 0, 0);
			bool result = VolControleur.AjouteVol(vol);

			if (result)
			{
				dgvGestionVol.DataSource = VolControleur.GetVols();

				this.txtnbremaxnormal.Text = "00";
				this.txtnbremaxcommercial.Text = "00";

				dgvGestionVol.DataSource = VolControleur.ChercheParAnnee(int.Parse(CmbAnnees.SelectedItem.ToString()));
				btnReference.Text = VolControleur.GenererReference(int.Parse(CmbAnnees.SelectedItem.ToString()));

				// Informer l'utilisateur que l'ajout est OK
			}
			else
			{
				// informer l'utilisateur de modifier la date
			}
		}

		private void CmbAnnees_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgvGestionVol.DataSource = VolControleur.ChercheParAnnee(int.Parse(CmbAnnees.SelectedItem.ToString()));

			btnReference.Text = VolControleur.GenererReference(int.Parse(CmbAnnees.SelectedItem.ToString()));
		}
	}
}
