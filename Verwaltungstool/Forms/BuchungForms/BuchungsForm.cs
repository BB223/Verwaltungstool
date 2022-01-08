using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verwaltungstool.Forms.GästeForms;
using Verwaltungstool.Forms.ZimmerForms;
using Verwaltungstool.Modelle.Gäste;
using Verwaltungstool.Modelle.Gäste.Gruppe;
using Verwaltungstool.Modelle.Ort;
using Willeke;

namespace Verwaltungstool.Forms.BuchungForms
{
    public partial class BuchungsForm : Form
    {
        #region Felder
        private bool _filter;
        #endregion

        #region Eigenschaften
        public ZimmerForm Sender { get; private set; }
        public Buchung Buchung { get; private set; }
        #endregion

        public BuchungsForm(ZimmerForm sender, Buchung buchung)
        {
            InitializeComponent();

            this.Buchung = buchung;
            this.Sender = sender;

            //Zimmerinformation werden dargestellt
            this.labelGebäude.Text = $"Gebäude: {this.Buchung.Zimmer.Gebäude.GebäudeID}";
            this.labelZimmernummer.Text = $"Zimmernummmer: {this.Buchung.Zimmer.Zimmernummer}";
            this.labelZimmerTyp.Text = this.Buchung.Zimmer.ZimmerTyp.Equals("EZ") ? "Einzelzimmer" : this.Buchung.Zimmer.ZimmerTyp.Equals("DZ") ? "Doppelzimmer" : this.Buchung.Zimmer.ZimmerTyp;

            //Zusatzleistung der Buchung werden dargestellt
            this.checkBoxFrühstück.Checked = this.Buchung.Frühstück;
            this.checkBoxBabybett.Checked = this.Buchung.Babybett;
            this.checkBoxPayTV.Checked = this.Buchung.PayTV;

            //Die Gruppe wird dargestellt
            this.listBoxGruppe.Items.Add(this.Buchung.Gruppe.Bezahler);
            this.listBoxGruppe.Items.AddRange(this.Buchung.Gruppe.Gäste.ToArray());
          
            //Filteroptionen werden hinzugefügt
            foreach (var terassebalkon in MainForm.INSTANCE.ZimmerHandler.AlleTerasseBalkonAusDatenbank())
            {
                this.comboBoxTerrasseBalkon.Items.Add(terassebalkon);
            }
            this.comboBoxTerrasseBalkon.SelectedIndex = 0;

            foreach (var zimmertyp in MainForm.INSTANCE.ZimmerHandler.AlleZimmertypenAusDatenbank())
            {
                this.comboBoxZimmerTyp.Items.Add(zimmertyp);
            }
            this.comboBoxZimmerTyp.SelectedIndex = 0;

            //Das gebuchte Zimmer wird ausgewählt
            this.listBoxZimmer.Items.AddRange(MainForm.INSTANCE.ZimmerHandler.AlleFreienZimmerAusDatenbank().ToArray());
            this.listBoxZimmer.SelectedIndex = 0;
            foreach (Zimmer zimmer in this.listBoxZimmer.Items)
            {
                if (zimmer.ZimmerID == this.Buchung.Zimmer.ZimmerID)
                {
                    this.listBoxZimmer.SelectedItem = zimmer;
                    break;
                }
            }

            //Wenn die Buchung älter als gesten ist oder schon eine Folgebuchung gemacht wurde kann man diese Buchung nicht mehr ändern
            if (!(this.Buchung.Datum.Date >= DateTime.Today.AddDays(-1).Date) /*|| MainForm.INSTANCE.BuchungHandler.BuchungExistiert(this.Buchung.Gruppe, DateTime.Today)*/)
            {
                this.buttonSpeichern.Visible = false;
            }
            //Wenn die Buchung von gestern ist kann man für Heute buchen
            if (this.Buchung.Datum.Date == DateTime.Today.AddDays(-1).Date)
            {
                this.buttonSpeichern.Text = "Für Heute buchen";
            }
            
            //Nicht gebuchte Leistungen können dazu gebucht werden
            if (this.Buchung.Datum.Date == DateTime.Today.Date)
            {
                foreach (CheckBox checkbox in this.groupBoxLeistungen.Controls)
                {
                    if (checkbox.Checked)
                    {
                        checkbox.Enabled = false;
                    }
                }
            }

            //Zimmer und Filter werden verstckt wenn die Buchung nicht von gestern ist oder schon eine Folgebuchung gemacht wurde
            if (this.Buchung.Datum.Date != DateTime.Today.AddDays(-1).Date || MainForm.INSTANCE.BuchungHandler.BuchungExistiert(this.Buchung.Gruppe, DateTime.Today))
            {
                this.groupBoxZimmer.Visible = false;
                this.buttonFilter.Visible = false;
            }

            //Wenn das Hotel voll ist kann man nicht mehr buchen
            if (this.listBoxZimmer.Items.Count < 1)
            {
                this.buttonSpeichern.Enabled = false; 
            }
        }

        private void ButtonZurück_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.OpenChildForm(new ZimmerForm(this.Sender.Zimmer, this.Sender.Datum));
        }

        private void ButtonSpeichern_Click(object sender, EventArgs e)
        {
            //Wenn das Zimmer geändert wurde wir man gefragt ob man wirklich das Zimmer ändern wollte
            if (!(this.Buchung.Datum.Date == DateTime.Today.Date))
            {
                if (((Zimmer)this.listBoxZimmer.SelectedItem).ZimmerID != this.Buchung.Zimmer.ZimmerID)
                {
                    var ergebnis = MessageBox.Show("Möchten Sie das Zimmer wirklich ändern", "Zimmer ändern?", MessageBoxButtons.YesNo);
                    if (ergebnis == DialogResult.No)
                    {
                        return;
                    }
                }
            }           
            
            //Die Buchung wird aktualisiert
            if (this.Buchung.Datum.Date == DateTime.Today.Date)
            {
                this.Buchung.Babybett = this.checkBoxBabybett.Checked;
                this.Buchung.Frühstück = this.checkBoxFrühstück.Checked;
                this.Buchung.PayTV = this.checkBoxPayTV.Checked;
            }
            //Eine neue Buchung wird erstellt
            else
            {
                this.Buchung = new Buchung(this.Buchung.Gruppe, (Zimmer)this.listBoxZimmer.SelectedItem, this.checkBoxPayTV.Checked, this.checkBoxBabybett.Checked, this.checkBoxFrühstück.Checked, DateTime.Today);
            }

            this.Buchung.Speicher();

            MainForm.INSTANCE.OpenChildForm(new ZimmerForm(this.Buchung.Zimmer, this.Buchung.Datum));
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            //Filter optionen werden ein und aus geblendet
            this._filter = !this._filter;
            if (!this._filter)
            {
                this.comboBoxTerrasseBalkon.Visible = false;
                this.comboBoxZimmerTyp.Visible = false;
                this.checkBoxFernseher.Visible = false;
                this.checkBoxHauptrasse.Visible = false;
                this.checkBoxKühlschrank.Visible = false;
            }
            else
            {
                this.comboBoxTerrasseBalkon.Visible = true;
                this.comboBoxZimmerTyp.Visible = true;
                this.checkBoxFernseher.Visible = true;
                this.checkBoxHauptrasse.Visible = true;
                this.checkBoxKühlschrank.Visible = true;
            }

            AktualisiereZimmer();
        }
        private void AktualisiereZimmer()
        {
            //Anhant der Filter werden die Zimmer angezeigt
            this.listBoxZimmer.Items.Clear();
            if (!this._filter)
            {
                this.listBoxZimmer.Items.AddRange(MainForm.INSTANCE.ZimmerHandler.AlleFreienZimmerAusDatenbank().ToArray());
            }
            else
            {
                this.listBoxZimmer.Items.AddRange(MainForm.INSTANCE.ZimmerHandler.AlleFreienZimmerMitFilterAusDatenbank(this.checkBoxFernseher.Checked ? 1 : 0, this.checkBoxKühlschrank.Checked ? 1 : 0, this.checkBoxHauptrasse.Checked ? 1 : 0, this.comboBoxZimmerTyp.SelectedItem.ToString(), this.comboBoxTerrasseBalkon.SelectedItem.ToString()).ToArray());
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktualisiereZimmer();
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AktualisiereZimmer();
        }

        private void ListBoxGruppe_DoubleClick(object sender, EventArgs e)
        {
            if (this.listBoxGruppe.SelectedItem is null) return;

            MainForm.INSTANCE.OpenChildForm(new GastForm(this, (Gast)this.listBoxGruppe.SelectedItem));
        }
    }
}
