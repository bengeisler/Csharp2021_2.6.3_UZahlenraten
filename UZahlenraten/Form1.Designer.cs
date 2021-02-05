
namespace UZahlenraten
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnErzeugen = new System.Windows.Forms.Button();
			this.btnPrüfen = new System.Windows.Forms.Button();
			this.lblAusgabe = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEingabe = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnErzeugen
			// 
			this.btnErzeugen.Location = new System.Drawing.Point(235, 4);
			this.btnErzeugen.Name = "btnErzeugen";
			this.btnErzeugen.Size = new System.Drawing.Size(75, 23);
			this.btnErzeugen.TabIndex = 0;
			this.btnErzeugen.Text = "Erzeugen";
			this.btnErzeugen.UseVisualStyleBackColor = true;
			this.btnErzeugen.Click += new System.EventHandler(this.btnErzeugen_Click);
			// 
			// btnPrüfen
			// 
			this.btnPrüfen.Location = new System.Drawing.Point(235, 33);
			this.btnPrüfen.Name = "btnPrüfen";
			this.btnPrüfen.Size = new System.Drawing.Size(75, 23);
			this.btnPrüfen.TabIndex = 1;
			this.btnPrüfen.Text = "Prüfen";
			this.btnPrüfen.UseVisualStyleBackColor = true;
			this.btnPrüfen.Click += new System.EventHandler(this.btnPrüfen_Click);
			// 
			// lblAusgabe
			// 
			this.lblAusgabe.AutoSize = true;
			this.lblAusgabe.Location = new System.Drawing.Point(16, 70);
			this.lblAusgabe.Name = "lblAusgabe";
			this.lblAusgabe.Size = new System.Drawing.Size(35, 13);
			this.lblAusgabe.TabIndex = 2;
			this.lblAusgabe.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Eingabe:";
			// 
			// txtEingabe
			// 
			this.txtEingabe.Location = new System.Drawing.Point(108, 35);
			this.txtEingabe.Name = "txtEingabe";
			this.txtEingabe.Size = new System.Drawing.Size(100, 20);
			this.txtEingabe.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 100);
			this.Controls.Add(this.txtEingabe);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblAusgabe);
			this.Controls.Add(this.btnPrüfen);
			this.Controls.Add(this.btnErzeugen);
			this.Name = "Form1";
			this.Text = "Zahl zwischen 1 und 100";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnErzeugen;
		private System.Windows.Forms.Button btnPrüfen;
		private System.Windows.Forms.Label lblAusgabe;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEingabe;
	}
}

