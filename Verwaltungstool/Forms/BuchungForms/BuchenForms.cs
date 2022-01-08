using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verwaltungstool.Modelle.Gäste;
using Verwaltungstool.Modelle.Gäste.Gruppe;
using Verwaltungstool.Modelle.Ort;
using Willeke;

namespace Verwaltungstool.Forms.BuchungForms
{
    public partial class BuchenForms : Form
    {
        #region Felder
        Zimmer _zimmer;
        DateTime _datum;
        Gruppe _gruppe;
        List<Gast> _gäste;
        Gast _bezahler;
        #endregion

        #region Eigenschaften
        public Buchung Buchung { get; private set; }
        #endregion

        public BuchenForms(Zimmer zimmer, DateTime datum)
        {
            InitializeComponent();

            this._zimmer = zimmer;
            this._datum = datum;
            this._gäste = new List<Gast>();
        }

        private void ButtonAbbruch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this._gruppe = new Gruppe(MainForm.INSTANCE.GruppenHandler.HoleNächsteFreieID(), this._gäste, this._bezahler);
            this._gruppe.Speichern();

            this.Buchung = new Buchung(this._gruppe, this._zimmer, this.checkBoxPayTV.Checked, this.checkBoxBabybett.Checked, this.checkBoxFrühstück.Checked, this._datum);
            this.Buchung.Speicher();

            this.Close();
        }

        private void ButtonHinzufügen_Click(object sender, EventArgs e)
        {
            if (!this.SindDatenKorregt()) return;
            Gast gast;
            int gastID;
            if ((gastID = MainForm.INSTANCE.GastHandler.GastAusDatenbank(this.textBoxName.Text, this.textBoxNachname.Text, this.textBoxEmail.Text.ToLower())) != -1)
            {
                gast = MainForm.INSTANCE.GastHandler.GastAusDatenbank(gastID);
            }
            else
            {
                gast = new Gast(MainForm.INSTANCE.GastHandler.HoleNächsteFreieID(), this.textBoxName.Text, this.textBoxNachname.Text, this.textBoxEmail.Text.ToLower(), null);
            }
            Adresse adresse;
            int adressID;
            if ((adressID = MainForm.INSTANCE.AdressenHandler.AdresseAusDatenbank(this.textBoxStraße.Text, this.textBoxHausnummer.Text, int.Parse(this.textBoxPLZ.Text), this.textBoxOrt.Text)) != -1)
            {
                adresse = MainForm.INSTANCE.AdressenHandler.AdresseAusDatenbank(adressID);
            }
            else
            {
                adresse = new Adresse(MainForm.INSTANCE.AdressenHandler.HoleNächsteFreieID(), this.textBoxHausnummer.Text, this.textBoxStraße.Text, int.Parse(this.textBoxPLZ.Text), this.textBoxOrt.Text);
            }

            gast.Adresse = adresse;
            gast.Speichern();

            if (this._bezahler == null)
            {
                this._bezahler = gast;
            }
            else
            {
                this._gäste.Add(gast);
            }

            this.listBoxGruppe.Items.Add(gast);

            foreach (Control textbox in this.groupBoxGastHinzufügen.Controls)
            {
                if (textbox is TextBox)
                {
                    textbox.Text = "";
                }
            }

            this.buttonOK.Enabled = true;
        }

        private void TextBoxPLZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool SindDatenKorregt()
        {
            bool korregt = true;
            foreach (Control textbox in this.groupBoxGastHinzufügen.Controls)
            {

                if (textbox is TextBox)
                {
                    ((Label)textbox.Tag).ForeColor = SystemColors.ControlText;
                    if (string.IsNullOrEmpty(textbox.Text))
                    {
                        ((Label)textbox.Tag).ForeColor = Color.Red;
                        korregt = false;
                    }
                }
            }

            if (this.textBoxPLZ.Text.Length != 5)
            {
                ((Label)this.textBoxPLZ.Tag).ForeColor = Color.Red;
                korregt = false;
            }
            return korregt;
        }

        private void listBoxGruppe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBoxGruppe.Items.Count > 0)
            {
                this.buttonEntfernen.Enabled = true;
            }
            else
            {
                this.buttonEntfernen.Enabled = false;
            }
        }

        private void buttonEntfernen_Click(object sender, EventArgs e)
        {
            if (((Gast)this.listBoxGruppe.SelectedItem).Equals(this._bezahler))
            {
                this._bezahler = this._gäste[0];
                this._gäste.Remove(this._bezahler);
            }
            else
            {
                this._gäste.Remove((Gast)this.listBoxGruppe.SelectedItem);
            }

            this.listBoxGruppe.Items.RemoveAt(this.listBoxGruppe.SelectedIndex);
            if (!(this.listBoxGruppe.Items.Count > 0))
            {
                this.buttonOK.Enabled = false;
            }
        }

        private void textBoxPLZ_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxPLZ.Text))
            {
                string ort = MainForm.INSTANCE.AdressenHandler.OrtAusDatenbank(int.Parse(this.textBoxPLZ.Text));
                this.textBoxOrt.Text = ort;
            }      
        }
    }
}
