using MySQL_Datenbanken;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verwaltungstool.Forms.ZimmerForms;
using Verwaltungstool.Modelle.Gäste;
using Verwaltungstool.Modelle.Gäste.Gruppe;
using Verwaltungstool.Modelle.Ort;

namespace Willeke
{
    public partial class MainForm : Form
    {
        #region Felder
        private Form _activeForm;
        #endregion

        #region Eigenschaften
        public static MainForm INSTANCE { get; private set; }       
        public SQLDatabase SQLDatabase { get; private set; }
        public AdressenHandler AdressenHandler { get; private set; }
        public GastHandler GastHandler { get; private set; }
        public GebäudeHandler GebäudeHandler { get; private set; }
        public GruppenHandler GruppenHandler { get; private set; }
        public ZimmerHandler ZimmerHandler { get; private set; }
        public BuchungHandler BuchungHandler { get; private set; }
        #endregion

        public MainForm()
        {
            INSTANCE = this;

            InitializeComponent();

            this.AdressenHandler = new AdressenHandler();
            this.GastHandler = new GastHandler();
            this.GebäudeHandler = new GebäudeHandler();
            this.GruppenHandler = new GruppenHandler();
            this.ZimmerHandler = new ZimmerHandler();
            this.BuchungHandler = new BuchungHandler();

            //Die Verbindung zur Datenbank wird hergestellt
            this.SQLDatabase = new SQLDatabase("localhost", "root", "", "hotel_willeke");
            this.SQLDatabase.Verbinden();
        }
        //Quelle: https://github.com/PlaySkyHD/Lernhelfer-Client/blob/master/Lehrnhelfer-Client/Forms/MainForm.cs
        public void OpenChildForm(Form childForm)
        {
            if (this._activeForm != null) this._activeForm.Close();
            this._activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Width = this.templatepanel.Width;
            childForm.Height = this.templatepanel.Height;
            this.templatepanel.Controls.Add(childForm);
            this.templatepanel.Tag = childForm;
            this.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Die Zimmerübersicht wird als erstes angezeigt
            this.OpenChildForm(new ZimmerÜbersicht());
        }
    }
}
