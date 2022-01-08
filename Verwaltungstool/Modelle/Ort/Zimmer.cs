using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Willeke;

namespace Verwaltungstool.Modelle.Ort
{
    public class Zimmer
    {
        #region Felder
        #endregion

        #region Eigenschaften
        public int ZimmerID { get; private set; }
        public bool Fernseher { get; private set; }
        public bool Kühlschrank { get; private set; }
        public bool Hauptstraße { get; private set; }
        public string Zimmernummer { get; private set; }
        public Gebäude Gebäude { get; private set; }
        public string ZimmerTyp { get; private set; }
        public string TerasseBalkon { get; private set; }
        #endregion

        public Zimmer(int zimmerID, bool fernseher, bool kühlschrank, bool hauptstraße, string zimmernummer, Gebäude gebäude, string zimmerTyp, string terasseBalkon)
        {
            this.ZimmerID = zimmerID;
            this.Fernseher = fernseher;
            this.Kühlschrank = kühlschrank;
            this.Hauptstraße = hauptstraße;
            this.Zimmernummer = zimmernummer;
            this.Gebäude = gebäude;
            this.ZimmerTyp = zimmerTyp;
            this.TerasseBalkon = terasseBalkon;
        }
        public bool IstGebucht(DateTime datum)
        {
            return MainForm.INSTANCE.ZimmerHandler.ZimmerIstGebucht(this, datum);
        }
        public override string ToString()
        {
            return $"{this.Zimmernummer} {this.ZimmerTyp} Gebäude: {this.Gebäude.GebäudeID}";
        }
    }
}
