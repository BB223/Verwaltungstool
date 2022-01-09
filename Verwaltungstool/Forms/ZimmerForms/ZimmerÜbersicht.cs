using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verwaltungstool.Modelle.Ort;
using Willeke;

namespace Verwaltungstool.Forms.ZimmerForms
{
    public partial class ZimmerÜbersicht : Form
    {
        #region Felder
        List<Zimmer> _zimmer;
        readonly List<Gebäude> _gebäude;
        bool _filter = false;
        #endregion

        #region Eigenschaften
        #endregion

        public ZimmerÜbersicht()
        {
            InitializeComponent();

            this._gebäude = MainForm.INSTANCE.GebäudeHandler.AlleGebäudeAusDatenbank();

            //Der Gebäudefilter wir aufgefüllt
            this.comboBoxGebäude.Items.Add("");
            foreach (var gebäude in this._gebäude)
            {
                this.comboBoxGebäude.Items.Add(gebäude);
            }
            this.comboBoxGebäude.SelectedIndex = 0;

            //Der TerasseBalkonfilter wir aufgefüllt
            foreach (var terassebalkon in MainForm.INSTANCE.ZimmerHandler.AlleTerasseBalkonAusDatenbank())
            {
                this.comboBoxTerrasseBalkon.Items.Add(terassebalkon);
            }
            this.comboBoxTerrasseBalkon.SelectedIndex = 0;

            //Der Zimmertypfilter wir aufgefüllt
            foreach (var zimmertyp in MainForm.INSTANCE.ZimmerHandler.AlleZimmertypenAusDatenbank())
            {
                this.comboBoxZimmerTyp.Items.Add(zimmertyp);
            }
            this.comboBoxZimmerTyp.SelectedIndex = 0;
        }
        private void ZimmerÜbersicht_Load(object sender, EventArgs e)
        {
            AktualisiereZimmer();
        }
        private void AktualisiereZimmer()
        {
            if (!this._filter)
            {
                if (this.comboBoxGebäude.SelectedItem.GetType() != typeof(Gebäude))
                {
                    this._zimmer = MainForm.INSTANCE.ZimmerHandler.AlleZimmerAusDatenbank();
                }
                else
                {
                    this._zimmer = MainForm.INSTANCE.ZimmerHandler.AlleZimmerMitFilterAusDatenbank((Gebäude)this.comboBoxGebäude.SelectedItem);
                }

            }
            else
            {
                if (this.comboBoxGebäude.SelectedItem.GetType() != typeof(Gebäude))
                {
                    this._zimmer = MainForm.INSTANCE.ZimmerHandler.AlleZimmerMitFilterAusDatenbank(this.checkBoxFernseher.Checked ? 1 : 0, this.checkBoxKühlschrank.Checked ? 1 : 0, this.checkBoxHauptrasse.Checked ? 1 : 0, this.comboBoxZimmerTyp.SelectedItem.ToString(), this.comboBoxTerrasseBalkon.SelectedItem.ToString());
                }
                else
                {
                    this._zimmer = MainForm.INSTANCE.ZimmerHandler.AlleZimmerMitFilterAusDatenbank((Gebäude)this.comboBoxGebäude.SelectedItem, this.checkBoxFernseher.Checked ? 1 : 0, this.checkBoxKühlschrank.Checked ? 1 : 0, this.checkBoxHauptrasse.Checked ? 1 : 0, this.comboBoxZimmerTyp.SelectedItem.ToString(), this.comboBoxTerrasseBalkon.SelectedItem.ToString());
                }

            }

            this.flowLayoutPanelZimmer.Controls.Clear();

            //Die Zimmer werden in Form von Knöpfen angezeigt
            foreach (var zimmer in this._zimmer)
            {
                this.flowLayoutPanelZimmer.Controls.Add(new Button { Tag = zimmer, FlatStyle = FlatStyle.Flat, Text = $"{zimmer.Zimmernummer}\n{zimmer.ZimmerTyp}\nGebäude: {zimmer.Gebäude.GebäudeID}", AutoSize = true, Dock = DockStyle.Top, BackColor = zimmer.IstGebucht(this.dateTimePickerDatum.Value) ? Color.Red : Color.Green });
            }

            foreach (Button button in this.flowLayoutPanelZimmer.Controls)
            {
                //Jedem Knopf wird das Clickeregniss hinzugefügt
                button.Click += Button_Click;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.OpenChildForm(new ZimmerForm((Zimmer)(sender as Button).Tag, this.dateTimePickerDatum.Value));
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AktualisiereZimmer();
        }
        private void ButtonZurücksetzen_Click(object sender, EventArgs e)
        {
            //Die Filter werden zurückgesetzt
            this.dateTimePickerDatum.Value = DateTime.Now;
            this.comboBoxGebäude.SelectedIndex = 0;
            this._filter = false;
            this.comboBoxTerrasseBalkon.Visible = false;
            this.comboBoxZimmerTyp.Visible = false;
            this.checkBoxFernseher.Visible = false;
            this.checkBoxHauptrasse.Visible = false;
            this.checkBoxKühlschrank.Visible = false;

            AktualisiereZimmer();
        }
        private void DateTimePickerDatum_ValueChanged(object sender, EventArgs e)
        {
            bool istGebucht;
            foreach (Button button in this.flowLayoutPanelZimmer.Controls)
            {
                istGebucht = ((Zimmer)button.Tag).IstGebucht(this.dateTimePickerDatum.Value);
                button.BackColor = !istGebucht ? this.dateTimePickerDatum.Value.Date < DateTime.Today.Date ? Color.Gray : Color.Green : Color.Red;
                button.Enabled = this.dateTimePickerDatum.Value >= DateTime.Today.Date || istGebucht;
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            //Die Filteroptionen werden angezeigt oder nicht
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
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AktualisiereZimmer();
        }
    }
}
