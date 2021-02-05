using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UZahlenraten
{
	public partial class Form1 : Form
	{
		// Zufallszahlengenerator initialisieren, vgl. Buch S. 100
		private readonly Random r = new Random();

		// Globale Variable, in der die Zufallszahl gespeichert wird
		private int zufallszahl = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnErzeugen_Click(object sender, EventArgs e)
		{
			// Neue Zufallszahl erzeugen
			zufallszahl = r.Next(1, 100);
		}

		private void btnPrüfen_Click(object sender, EventArgs e)
		{
			// Eingabe aus dem Textfeld auslesen, konvertieren und in einer
			// Variable eines passenden Datentyps speichern
			int eingabe = Convert.ToInt32(txtEingabe.Text);

			// Prüfen, ob Zahl erraten wurde => Ausgabe Erfolgsmeldung
			if (eingabe == zufallszahl) lblAusgabe.Text = "Zahl erraten!";

			// Prüfen, ob Zahl kleiner als Zufallszahl ist => Hinweis ausgeben
			if (eingabe < zufallszahl) lblAusgabe.Text = "Eingegebene Zahl " + eingabe + " ist zu klein!";

			// Prüfen, ob Zahl größer als Zufallszahl ist => Hinweis ausgeben
			if (eingabe > zufallszahl) lblAusgabe.Text = "Eingegebene Zahl " + eingabe + " ist zu groß!";
		}
	}
}
