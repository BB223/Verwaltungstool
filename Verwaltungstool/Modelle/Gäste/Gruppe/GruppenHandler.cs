using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verwaltungstool.Modelle.Ort;
using Willeke;

namespace Verwaltungstool.Modelle.Gäste.Gruppe
{
    public class GruppenHandler
    {
        public int HoleNächsteFreieID()
        {
            int gruppenID = 0;
            int tmp;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gruppe");

            while (ergebnis.Read())
            {
                if (gruppenID < (tmp = ergebnis.GetInt32("GruppenID")))
                {
                    gruppenID = tmp;
                }
            }
            ergebnis.Close();

            return gruppenID + 1;
        }
        public Gruppe GruppeAusDatenbank(int gruppenID)
        {
            return new Gruppe(gruppenID, MainForm.INSTANCE.GastHandler.AlleGästeVonGruppeAusDatenbank(gruppenID), MainForm.INSTANCE.GastHandler.BezahlerVonGruppeAusDatenbank(gruppenID));
        }
        public void GruppeZurDatenbank(Gruppe Gruppe)
        {
            if (!GruppeExistiert(Gruppe))
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"INSERT INTO gruppe (GruppenID) VALUES ('{Gruppe.GruppenID}')");
                MainForm.INSTANCE.SQLDatabase.Schreiben($"INSERT INTO gruppegast (GruppenID, GastID, Bezahlt) VALUES ('{Gruppe.GruppenID}','{Gruppe.Bezahler.GastID}','1')");
                foreach (var gast in Gruppe.Gäste)
                {
                    if (GruppeGastExistiert(Gruppe, gast)) continue;
                    MainForm.INSTANCE.SQLDatabase.Schreiben($"INSERT INTO gruppegast (GruppenID, GastID, Bezahlt) VALUES ('{Gruppe.GruppenID}','{gast.GastID}','0')");
                }
            } 
        }
        public bool GruppeGastExistiert(Gruppe gruppe, Gast gast)
        {
            bool existiert = false;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gruppegast WHERE GruppenID ='{gruppe.GruppenID}' AND GastID = '{gast.GastID}'");

            if (ergebnis.Read()) existiert = true;
            ergebnis.Close();

            return existiert;
        }
        public bool GruppeExistiert(Gruppe gruppe)
        {
            bool existiert = false;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gruppe WHERE GruppenID ='{gruppe.GruppenID}'");

            if (ergebnis.Read()) existiert = true;
            ergebnis.Close();

            return existiert;
        }

        //Veraltet
        [Obsolete]
        public List<Gruppe> AlleGruppenAusDatenbank()
        {
            List<int> gruppenIDs = new List<int>();
            List<Gruppe> gruppen = new List<Gruppe>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gruppe");

            while (ergebnis.Read())
            {
                gruppenIDs.Add(ergebnis.GetInt32("GruppenID"));
            }
            ergebnis.Close();

            foreach (var ID in gruppenIDs)
            {
                gruppen.Add(GruppeAusDatenbank(ID));
            }

            return gruppen;
        }
        public Gruppe GruppeAusDatenbank(Zimmer zimmer, DateTime datum)
        {
            int gruppenID = -1;

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT GruppenID FROM buchung WHERE ZimmerID ='{zimmer.ZimmerID}' AND Datum='{datum:yyyy-MM-dd}'");
            while (ergebnis.Read())
            {
                gruppenID = ergebnis.GetInt32("GruppenID");
            }
            ergebnis.Close();

            return this.GruppeAusDatenbank(gruppenID);
        }

    }
}
