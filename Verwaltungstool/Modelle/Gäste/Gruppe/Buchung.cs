using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verwaltungstool.Modelle.Ort;
using Willeke;

namespace Verwaltungstool.Modelle.Gäste.Gruppe
{
    public class Buchung
    {
        #region Felder
        #endregion

        #region Eigenschaften
        public Gruppe Gruppe { get; private set; }
        public Zimmer Zimmer { get; set; }
        public bool PayTV { get; set; }
        public bool Babybett { get; set; }
        public bool Frühstück { get; set; }
        public DateTime Datum { get; private set; }
        #endregion

        public Buchung(Gruppe gruppe, Zimmer zimmer, bool payTV, bool babybett, bool frühstück, DateTime datum)
        {
            this.Gruppe = gruppe;
            this.Zimmer = zimmer;
            this.PayTV = payTV;
            this.Babybett = babybett;
            this.Frühstück = frühstück;
            this.Datum = datum;
        }
        public void Speicher()
        {
            MainForm.INSTANCE.BuchungHandler.BuchungZurDatenbank(this);
        }
    }
}
