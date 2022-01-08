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
using Verwaltungstool.Forms.ZimmerForms;
using Verwaltungstool.Modelle.Gäste;
using Willeke;

namespace Verwaltungstool.Forms.GästeForms
{
    public partial class GastForm : Form
    {
        #region Felder
        Gast _gast;
        Form _sender;
        #endregion

        #region Eigenschaften
        #endregion
        public GastForm(Form sender, Gast gast)
        {
            InitializeComponent();

            this._gast = gast;
            this._sender = sender;

            //Die Daten des Gastes werden angezeigt
            this.labelLangerName.Text = this._gast.ToString();

            this.labelName.Text = this._gast.Name;
            this.labelNachname.Text = this._gast.Nachname;
            this.labelEmail.Text = this._gast.Email;

            this.labelStraßeHr.Text = $"{this._gast.Adresse.Straße}, {this._gast.Adresse.Hausnummer}";
            this.labelPLZ.Text = this._gast.Adresse.PLZ.ToString();
            this.labelOrt.Text = this._gast.Adresse.Ort;
        }

        private void ButtonZurück_Click(object sender, EventArgs e)
        {
            //Man kommt zu dem Form zurück woher man gekommen ist
            if (this._sender is ZimmerForm zimmerForm)
            {
                MainForm.INSTANCE.OpenChildForm(new ZimmerForm(zimmerForm.Zimmer, zimmerForm.Datum));
            }
            if (this._sender is BuchungsForm buchungsForm)
            {
                MainForm.INSTANCE.OpenChildForm(new BuchungsForm(buchungsForm.Sender, buchungsForm.Buchung));
            }
        }
    }
}