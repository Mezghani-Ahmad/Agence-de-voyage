namespace Vues
{
	partial class GestionTicket
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNPCom = new System.Windows.Forms.TextBox();
			this.txtNPNor = new System.Windows.Forms.TextBox();
			this.dgvTichkets = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbVols = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtNomVoyageur = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rbComercial = new System.Windows.Forms.RadioButton();
			this.rbNormal = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.btnGenerer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAjoute = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTichkets)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtNPCom);
			this.panel1.Controls.Add(this.txtNPNor);
			this.panel1.Controls.Add(this.dgvTichkets);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new System.Drawing.Point(647, 125);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(696, 395);
			this.panel1.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(244, 116);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(205, 25);
			this.label8.TabIndex = 10;
			this.label8.Text = "Les Tichkets du vol ";
			// 
			// txtNPCom
			// 
			this.txtNPCom.Location = new System.Drawing.Point(228, 66);
			this.txtNPCom.Name = "txtNPCom";
			this.txtNPCom.Size = new System.Drawing.Size(100, 22);
			this.txtNPCom.TabIndex = 7;
			// 
			// txtNPNor
			// 
			this.txtNPNor.Location = new System.Drawing.Point(216, 23);
			this.txtNPNor.Name = "txtNPNor";
			this.txtNPNor.Size = new System.Drawing.Size(100, 22);
			this.txtNPNor.TabIndex = 6;
			// 
			// dgvTichkets
			// 
			this.dgvTichkets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTichkets.Location = new System.Drawing.Point(72, 145);
			this.dgvTichkets.Name = "dgvTichkets";
			this.dgvTichkets.RowHeadersWidth = 51;
			this.dgvTichkets.RowTemplate.Height = 24;
			this.dgvTichkets.Size = new System.Drawing.Size(532, 216);
			this.dgvTichkets.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(34, 66);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(187, 16);
			this.label7.TabIndex = 4;
			this.label7.Text = "Nbre de palcesCommerciales";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(162, 16);
			this.label6.TabIndex = 3;
			this.label6.Text = "Nbre de palces Normales";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(827, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Vol";
			// 
			// cmbVols
			// 
			this.cmbVols.FormattingEnabled = true;
			this.cmbVols.Location = new System.Drawing.Point(913, 63);
			this.cmbVols.Name = "cmbVols";
			this.cmbVols.Size = new System.Drawing.Size(257, 24);
			this.cmbVols.TabIndex = 10;
			this.cmbVols.SelectedIndexChanged += new System.EventHandler(this.cmbVols_SelectedIndexChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
			this.tableLayoutPanel1.Controls.Add(this.txtNomVoyageur, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.rbComercial, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.rbNormal, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtNumero, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnGenerer, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(69, 125);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 173);
			this.tableLayoutPanel1.TabIndex = 13;
			// 
			// txtNomVoyageur
			// 
			this.txtNomVoyageur.Location = new System.Drawing.Point(166, 64);
			this.txtNomVoyageur.Name = "txtNomVoyageur";
			this.txtNomVoyageur.Size = new System.Drawing.Size(100, 22);
			this.txtNomVoyageur.TabIndex = 23;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "Nom du voyageur";
			// 
			// rbComercial
			// 
			this.rbComercial.AutoSize = true;
			this.rbComercial.Location = new System.Drawing.Point(329, 125);
			this.rbComercial.Name = "rbComercial";
			this.rbComercial.Size = new System.Drawing.Size(100, 20);
			this.rbComercial.TabIndex = 18;
			this.rbComercial.TabStop = true;
			this.rbComercial.Text = "Commercial";
			this.rbComercial.UseVisualStyleBackColor = true;
			// 
			// rbNormal
			// 
			this.rbNormal.AutoSize = true;
			this.rbNormal.Location = new System.Drawing.Point(166, 125);
			this.rbNormal.Name = "rbNormal";
			this.rbNormal.Size = new System.Drawing.Size(72, 20);
			this.rbNormal.TabIndex = 19;
			this.rbNormal.TabStop = true;
			this.rbNormal.Text = "Normal";
			this.rbNormal.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Type de Place";
			// 
			// txtNumero
			// 
			this.txtNumero.Location = new System.Drawing.Point(166, 3);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.ReadOnly = true;
			this.txtNumero.Size = new System.Drawing.Size(100, 22);
			this.txtNumero.TabIndex = 22;
			// 
			// btnGenerer
			// 
			this.btnGenerer.Location = new System.Drawing.Point(329, 3);
			this.btnGenerer.Name = "btnGenerer";
			this.btnGenerer.Size = new System.Drawing.Size(75, 23);
			this.btnGenerer.TabIndex = 17;
			this.btnGenerer.Text = "Generer";
			this.btnGenerer.UseVisualStyleBackColor = true;
			this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 16);
			this.label1.TabIndex = 14;
			this.label1.Text = "Numero";
			// 
			// btnAjoute
			// 
			this.btnAjoute.Location = new System.Drawing.Point(242, 330);
			this.btnAjoute.Name = "btnAjoute";
			this.btnAjoute.Size = new System.Drawing.Size(164, 44);
			this.btnAjoute.TabIndex = 21;
			this.btnAjoute.Text = "Ajoute";
			this.btnAjoute.UseVisualStyleBackColor = true;
			this.btnAjoute.Click += new System.EventHandler(this.btnAjoute_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(572, 407);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 16);
			this.label4.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(214, 82);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(163, 25);
			this.label9.TabIndex = 22;
			this.label9.Text = "Nouveau Ticket";
			// 
			// GestionTicket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1519, 689);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnAjoute);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.cmbVols);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel1);
			this.Name = "GestionTicket";
			this.Text = "GestionTicket";
			this.Load += new System.EventHandler(this.GestionTicket_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTichkets)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNPCom;
		private System.Windows.Forms.TextBox txtNPNor;
		private System.Windows.Forms.DataGridView dgvTichkets;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbVols;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNomVoyageur;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Button btnAjoute;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rbNormal;
		private System.Windows.Forms.RadioButton rbComercial;
		private System.Windows.Forms.Button btnGenerer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
	}
}