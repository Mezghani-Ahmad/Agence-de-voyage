using Controleur;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vues
{
	public partial class GestionTicket : Form
	{
		public GestionTicket()
		{
			InitializeComponent();
		}

		private void GestionTicket_Load(object sender, EventArgs e)
		{
			List<Vol> vols = VolControleur.GetVols();

			foreach (Vol element in vols)
			{
				cmbVols.Items.Add(element);
			}
		}

		private void cmbVols_SelectedIndexChanged(object sender, EventArgs e)
		{
			Vol vol = cmbVols.SelectedItem as Vol;

			if (vol != null)
			{
				this.txtNPNor.Text = vol.NbrePlaceNor.ToString();
				this.txtNPCom.Text = vol.NbrePlaceCom.ToString();

				this.dgvTichkets.DataSource = TicketControleur.GetTiketParVol(vol);
			}
		}

		private void btnGenerer_Click(object sender, EventArgs e)
		{
			Vol vol = cmbVols.SelectedItem as Vol;

			if (vol != null)
			{
				string type = string.Empty;
				bool isAvailable = false;

				if (rbNormal.Checked && vol.NbrePlaceNor < vol.NbreMaxNor)
				{
					isAvailable = true;
					type = "Normal";
				}
				else if (rbComercial.Checked && vol.NbrePlaceCom < vol.NbreMaxCom)
				{
					isAvailable = true;
					type = "Commercial";
				}

				if (cmbVols.SelectedIndex > -1 && (vol.DateDepart > DateTime.Now) && isAvailable)
				{
					txtNumero.Text = TicketControleur.GenererNumTicket(type, vol);
				}
			}
		}

		private void btnAjoute_Click(object sender, EventArgs e)
		{
			Vol vol = cmbVols.SelectedItem as Vol;
			string type = string.Empty;

			if (rbNormal.Checked && vol.NbrePlaceNor < vol.NbreMaxNor)
			{
				type = "Normal";
			}
			else if (rbComercial.Checked && vol.NbrePlaceCom < vol.NbreMaxCom)
			{
				type = "Commercial";
			}

			if (vol != null && !string.IsNullOrWhiteSpace(txtNumero.Text) && !string.IsNullOrWhiteSpace(this.txtNomVoyageur.Text) && !string.IsNullOrWhiteSpace(type))
			{
				Ticket ticket = new Ticket(txtNumero.Text, this.txtNomVoyageur.Text, type, vol);
				bool result = TicketControleur.AjouterTicket(ticket);

				if (result)
				{
					this.txtNPNor.Text = vol.NbrePlaceNor.ToString();
					this.txtNPCom.Text = vol.NbrePlaceCom.ToString();

					this.dgvTichkets.DataSource = TicketControleur.GetTiketParVol(vol);

					// Informer l'utilisateur
				}
			}
		}
	}
}
