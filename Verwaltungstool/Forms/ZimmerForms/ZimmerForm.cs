using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verwaltungstool.Forms.BuchungForms;
using Verwaltungstool.Forms.GästeForms;
using Verwaltungstool.Modelle.Gäste;
using Verwaltungstool.Modelle.Gäste.Gruppe;
using Verwaltungstool.Modelle.Ort;
using Willeke;

namespace Verwaltungstool.Forms.ZimmerForms
{
    public partial class ZimmerForm : Form
    {
        #region Felder
        #endregion

        #region Eigenschaften
        public Buchung Buchung { get; set; }
        public Zimmer Zimmer { get; private set; }
        public DateTime Datum { get; private set; }
        #endregion

        public ZimmerForm(Zimmer zimmer, DateTime datum)
        {
            InitializeComponent();


            this.Zimmer = zimmer;
            this.Datum = datum;

            //Die Zimmernummer die Gebäudenummer und der Zimmertyp wir angezeigt
            this.labelGebäude.Text = $"Gebäude: {this.Zimmer.Gebäude.GebäudeID}";
            this.labelZimmernummer.Text = $"Zimmernummmer: {this.Zimmer.Zimmernummer}";
            this.labelZimmerTyp.Text = this.Zimmer.ZimmerTyp.Equals("EZ") ? "Einzelzimmer" : this.Zimmer.ZimmerTyp.Equals("DZ") ? "Doppelzimmer" : this.Zimmer.ZimmerTyp;

            //Die Zimmereigenschaften werden angezeigt
            _ = this.Zimmer.Fernseher ? this.labelFernseher.Visible = true : this.labelFernseher.Visible = false;
            _ = this.Zimmer.Kühlschrank ? this.labelKühlschrank.Visible = true : this.labelKühlschrank.Visible = false;
            _ = this.Zimmer.Hauptstraße ? this.labelHauptstrasse.Visible = true : this.labelHauptstrasse.Visible = false;

            //Der TerasseBalkonstatus wird angegeben
            switch (this.Zimmer.TerasseBalkon)
            {
                case "Groß":
                    this.labelTerasseBalkon.Text = "Großer Balkon";
                    break;
                case "Klein":
                    this.labelTerasseBalkon.Text = "Kleiner Balkon";
                    break;
                case "Terasse":
                    this.labelTerasseBalkon.Text = "Terasse";
                    break;
                case "Nein":
                    this.labelTerasseBalkon.Visible = false;
                    break;
                default:
                    this.labelTerasseBalkon.Text = "Terasse oder Balkon nicht definiert";
                    break;
            }

            this.Buchung = MainForm.INSTANCE.BuchungHandler.BuchungAusDatenbank(this.Zimmer.ZimmerID, this.Datum);        

            AktualisiereForm();
        }
        private void AktualisiereForm()
        { 
            //Die Zusatzleistungen werden angezeigt
            _ = this.Buchung.PayTV ? this.labelPayTV.Visible = true : this.labelPayTV.Visible = false;
            _ = this.Buchung.Babybett ? this.labelBabybett.Visible = true : this.labelBabybett.Visible = false;
            _ = this.Buchung.Frühstück ? this.labelFruehstueck.Visible = true : this.labelFruehstueck.Visible = false;

            //Die Gruppe wird angezeigt
            if (this.Zimmer.IstGebucht(this.Datum))
            {
                Gruppe gruppe = MainForm.INSTANCE.GruppenHandler.GruppeAusDatenbank(this.Zimmer, this.Datum);
                this.listBoxGruppe.Items.Add(gruppe.Bezahler);
                this.listBoxGruppe.Items.AddRange(gruppe.Gäste.ToArray());
                this.buttonBuchen.Visible = false;
                this.buttonZurBuchung.Location = this.buttonBuchen.Location;
                this.buttonZurBuchung.Visible = true;
                this.pictureBoxBezahler.Visible = true;
            }

            if (this.Datum.Date < DateTime.Today.Date)
            {
                this.buttonBuchen.Enabled = false;
            }
        }
        private void ButtonZurück_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.OpenChildForm(new ZimmerÜbersicht());
        }
        private void ButtonBuchen_Click(object sender, EventArgs e)
        {
            //Das BuchenForm wird als Dialog angezeigt
            BuchenForms buchen = new BuchenForms(this.Zimmer, this.Datum);
            var ergebnis = buchen.ShowDialog();
            if (ergebnis == DialogResult.OK)
            {
                //Die Buchung wird als aktuelle Buchung übernommen
                this.Buchung = buchen.Buchung;
                AktualisiereForm();
            }
        }
        private void ButtonZurBuchung_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.OpenChildForm(new BuchungsForm(this, this.Buchung));
        }

        private void ListBoxGruppe_DoubleClick(object sender, EventArgs e)
        {
            if (this.listBoxGruppe.SelectedItem is null) return;

            //Der Gast wird angezeigt
            MainForm.INSTANCE.OpenChildForm(new GastForm(this, (Gast)this.listBoxGruppe.SelectedItem));
        }
    }
}
