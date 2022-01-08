using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Willeke;

namespace Verwaltungstool.Modelle.Ort
{
    public class Gebäude
    {
        #region Felder
        #endregion

        #region Eigenschaften
        public int GebäudeID { get; private set; }
        public Adresse Adresse { get; private set; }
        #endregion

        public Gebäude(int gebäudeID, Adresse adresse)
        {
            this.GebäudeID = gebäudeID;
            this.Adresse = adresse;
        }
        public void Speichern()
        {
            MainForm.INSTANCE.GebäudeHandler.GebäudeZurDatenbank(this);
        }
        public override string ToString()
        {
            return $"Gebäude {this.GebäudeID}";
        }
    }
}
