using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Willeke;

namespace Verwaltungstool.Modelle.Ort
{
    public class Adresse
    {
        #region Felder
        #endregion

        #region Eigenschaften
        public int AdressID { get; private set; }
        public string Hausnummer { get; private set; }
        public string Straße { get; private set; }
        public int PLZ { get; private set; }
        public string Ort { get; private set; }
        #endregion

        public Adresse(int adressID, string hausnummer, string straße, int plz, string ort)
        {
            this.AdressID = adressID;
            this.Hausnummer = hausnummer;
            this.Straße = straße;
            this.PLZ = plz;
            this.Ort = ort;
        }

        public void Speichern()
        {
            MainForm.INSTANCE.AdressenHandler.AdresseZurDatenbank(this);
        }
    }
}
