using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Willeke;

namespace Verwaltungstool.Modelle.Gäste.Gruppe
{
    public class Gruppe
    {
        #region Felder
        #endregion

        #region Eigenschaften
        public int GruppenID { get; private set; }
        public List<Gast> Gäste { get; private set; }
        public Gast Bezahler { get; private set; }
        #endregion

        public Gruppe(int gruppenID, List<Gast> gäste, Gast bezahler)
        {
            this.GruppenID = gruppenID;
            this.Gäste = gäste;
            this.Bezahler = bezahler;
        }
        public void Speichern()
        {
            MainForm.INSTANCE.GruppenHandler.GruppeZurDatenbank(this);
        }
    }
}
