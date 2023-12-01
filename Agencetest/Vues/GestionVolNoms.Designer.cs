namespace Vues
{
	partial class GestionVolNoms
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnReference = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpdatededepart = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtnbremaxnormal = new System.Windows.Forms.TextBox();
			this.txtnbremaxcommercial = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.CmbAnnees = new System.Windows.Forms.ComboBox();
			this.dgvGestionVol = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvGestionVol)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Reference";
			// 
			// btnReference
			// 
			this.btnReference.Location = new System.Drawing.Point(138, 70);
			this.btnReference.Name = "btnReference";
			this.btnReference.ReadOnly = true;
			this.btnReference.Size = new System.Drawing.Size(100, 22);
			this.btnReference.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Date de depart ";
			// 
			// dtpdatededepart
			// 
			this.dtpdatededepart.Location = new System.Drawing.Point(181, 121);
			this.dtpdatededepart.Name = "dtpdatededepart";
			this.dtpdatededepart.Size = new System.Drawing.Size(200, 22);
			this.dtpdatededepart.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(60, 162);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Nbre max Normals";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(60, 198);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 16);
			this.label5.TabIndex = 7;
			this.label5.Text = "Nbre max Commercials";
			// 
			// txtnbremaxnormal
			// 
			this.txtnbremaxnormal.Location = new System.Drawing.Point(213, 159);
			this.txtnbremaxnormal.Name = "txtnbremaxnormal";
			this.txtnbremaxnormal.Size = new System.Drawing.Size(67, 22);
			this.txtnbremaxnormal.TabIndex = 8;
			this.txtnbremaxnormal.Text = "00";
			// 
			// txtnbremaxcommercial
			// 
			this.txtnbremaxcommercial.Location = new System.Drawing.Point(213, 195);
			this.txtnbremaxcommercial.Name = "txtnbremaxcommercial";
			this.txtnbremaxcommercial.Size = new System.Drawing.Size(67, 22);
			this.txtnbremaxcommercial.TabIndex = 9;
			this.txtnbremaxcommercial.Text = "00";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(164, 282);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 36);
			this.button1.TabIndex = 10;
			this.button1.Text = "Ajouter";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(543, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "Annee";
			// 
			// CmbAnnees
			// 
			this.CmbAnnees.FormattingEnabled = true;
			this.CmbAnnees.Location = new System.Drawing.Point(609, 67);
			this.CmbAnnees.Name = "CmbAnnees";
			this.CmbAnnees.Size = new System.Drawing.Size(121, 24);
			this.CmbAnnees.TabIndex = 13;
			this.CmbAnnees.SelectedIndexChanged += new System.EventHandler(this.CmbAnnees_SelectedIndexChanged);
			// 
			// dgvGestionVol
			// 
			this.dgvGestionVol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGestionVol.Location = new System.Drawing.Point(470, 130);
			this.dgvGestionVol.Name = "dgvGestionVol";
			this.dgvGestionVol.RowHeadersWidth = 51;
			this.dgvGestionVol.RowTemplate.Height = 24;
			this.dgvGestionVol.Size = new System.Drawing.Size(729, 238);
			this.dgvGestionVol.TabIndex = 14;
			// 
			// GestionVolNoms
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1233, 450);
			this.Controls.Add(this.dgvGestionVol);
			this.Controls.Add(this.CmbAnnees);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtnbremaxcommercial);
			this.Controls.Add(this.txtnbremaxnormal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpdatededepart);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnReference);
			this.Controls.Add(this.label1);
			this.Name = "GestionVolNoms";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvGestionVol)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox btnReference;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtnbremaxnormal;
		private System.Windows.Forms.TextBox txtnbremaxcommercial;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox CmbAnnees;
		private System.Windows.Forms.DataGridView dgvGestionVol;
		private System.Windows.Forms.DateTimePicker dtpdatededepart;
	}
}

