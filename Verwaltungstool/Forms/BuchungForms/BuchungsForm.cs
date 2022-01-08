using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            if (!(this.Buchung.Datum.Date >= DateTime.Today.AddDays(-1).Date) || MainForm.INSTANCE.BuchungHandler.BuchungExistiert(this.Buchung.Gruppe, DateTime.Today))
            {
                this.buttonSpeichern.Visible = false;
            }
            if (this.Buchung.Datum.Date == DateTime.Today.AddDays(-1).Date)
            {
                this.buttonSpeichern.Text = "Für Heute buchen";
            }
            
            this.checkBoxFrühstück.Checked = this.Buchung.Frühstück;
            this.checkBoxBabybett.Checked = this.Buchung.Babybett;
            this.checkBoxPayTV.Checked = this.Buchung.PayTV;

            this.labelGebäude.Text = $"Gebäude: {this.Buchung.Zimmer.Gebäude.GebäudeID}";
            this.labelZimmernummer.Text = $"Zimmernummmer: {this.Buchung.Zimmer.Zimmernummer}";
            this.labelZimmerTyp.Text = this.Buchung.Zimmer.ZimmerTyp.Equals("EZ") ? "Einzelzimmer" : this.Buchung.Zimmer.ZimmerTyp.Equals("DZ") ? "Doppelzimmer" : this.Buchung.Zimmer.ZimmerTyp;

            this.listBoxGruppe.Items.Add(this.Buchung.Gruppe.Bezahler);
            this.listBoxGruppe.Items.AddRange(this.Buchung.Gruppe.Gäste.ToArray());

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
            if (this.Buchung.Datum.Date != DateTime.Today.AddDays(-1).Date || MainForm.INSTANCE.BuchungHandler.BuchungExistiert(this.Buchung.Gruppe, DateTime.Today))
            {
                this.groupBoxZimmer.Visible = false;
            }

            if (this.listBoxZimmer.Items.Count < 1)
            {
                this.buttonSpeichern.Enabled = false; 
            }
        }

        private void buttonZurück_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.OpenChildForm(new ZimmerForm(this.Sender.Zimmer, this.Sender.Datum));
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            if (((Zimmer)this.listBoxZimmer.SelectedItem).ZimmerID != this.Buchung.Zimmer.ZimmerID)
            {
                var result = MessageBox.Show("Möchten Sie das Zimmer wirklich ändern", "Zimmer ändern?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            foreach (CheckBox checkbox in this.groupBoxLeistungen.Controls)
            {
                checkbox.Enabled = false;
            }

            if (this.Buchung.Datum.Date == DateTime.Today.Date)
            {
                this.Buchung.Babybett = this.checkBoxBabybett.Checked;
                this.Buchung.Frühstück = this.checkBoxFrühstück.Checked;
                this.Buchung.PayTV = this.checkBoxPayTV.Checked;
            }
            else
            {
                this.Buchung = new Buchung(this.Buchung.Gruppe, (Zimmer)this.listBoxZimmer.SelectedItem, this.checkBoxPayTV.Checked, this.checkBoxBabybett.Checked, this.checkBoxFrühstück.Checked, DateTime.Today);
            }

            this.Buchung.Speicher();

            MainForm.INSTANCE.OpenChildForm(new ZimmerForm(this.Buchung.Zimmer, this.Buchung.Datum));
        }

        private void listBoxZimmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Buchung.Datum.Date != DateTime.Today.Date)
            {
                this.labelGebäude.Text = $"Gebäude: {((Zimmer)this.listBoxZimmer.SelectedItem).Gebäude.GebäudeID}";
                this.labelZimmernummer.Text = $"Zimmernummmer: {((Zimmer)this.listBoxZimmer.SelectedItem).Zimmernummer}";
                this.labelZimmerTyp.Text = ((Zimmer)this.listBoxZimmer.SelectedItem).ZimmerTyp.Equals("EZ") ? "Einzelzimmer" : ((Zimmer)this.listBoxZimmer.SelectedItem).ZimmerTyp.Equals("DZ") ? "Doppelzimmer" : ((Zimmer)this.listBoxZimmer.SelectedItem).ZimmerTyp;
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
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

        private void listBoxGruppe_DoubleClick(object sender, EventArgs e)
        {
            if (this.listBoxGruppe.SelectedItem is null) return;

            MainForm.INSTANCE.OpenChildForm(new GastForm(this, (Gast)this.listBoxGruppe.SelectedItem));
        }
    }
}
