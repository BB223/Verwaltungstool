using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Willeke;

namespace Verwaltungstool.Modelle.Ort
{
    public class ZimmerHandler
    {
        public Zimmer ZimmerAusDatenbank(int zimmerID)
        {
            bool fernseher = false;
            bool kühlschrank = false;
            bool hauptstraße = false;
            string zimmernummer = "";
            int gebäudeID = -1;
            string zimmerTyp = "";
            string terasseBalkon = "";

            int adressID = -1;
            string hausnummer = "";
            string straße = "";
            int plz = -1;
            string ort = "";

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT zimmer.Fernseher, zimmer.Kühlschrank, zimmer.Hauptstraße, zimmer.Zimmernummer, zimmer.GebäudeID, zimmer.ZimmerTyp, zimmer.TerasseBalkon, adresse.AdressID, adresse.Hausnummer, adresse.Straße, adresse.PLZ, plz.Ort FROM zimmer, gebäude, adresse, plz WHERE ZimmerID ='{zimmerID}' AND zimmer.GebäudeID = gebäude.GebäudeID AND gebäude.AdressID = adresse.AdressID AND adresse.PLZ = plz.PLZ");

            while (ergebnis.Read())
            {
                //Zimmer
                fernseher = ergebnis.GetBoolean("Fernseher");
                kühlschrank = ergebnis.GetBoolean("Kühlschrank");
                hauptstraße = ergebnis.GetBoolean("Hauptstraße");
                zimmernummer = ergebnis.GetString("Zimmernummer");
                gebäudeID = ergebnis.GetInt32("GebäudeID");
                zimmerTyp = ergebnis.GetString("ZimmerTyp");
                terasseBalkon = ergebnis.GetString("TerasseBalkon");

                //Adresse
                adressID = ergebnis.GetInt32("AdressID");
                hausnummer = ergebnis.GetString("Hausnummer");
                straße = ergebnis.GetString("Straße");
                plz = ergebnis.GetInt32("PLZ");
                ort = ergebnis.GetString("Ort");
            }
            ergebnis.Close();

            return new Zimmer(zimmerID, fernseher, kühlschrank, hauptstraße, zimmernummer, new Gebäude(gebäudeID, new Adresse(adressID, hausnummer, straße, plz, ort)), zimmerTyp, terasseBalkon);
        }

        //Schnittstelle für zukünftige Funktion
        public void ZimmerZurDatenbank(Zimmer zimmer)
        {
            zimmer.Gebäude.Speichern();

            if (ZimmerExistiert(zimmer))
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"UPDATE zimmer SET Fernseher = '{zimmer.Fernseher}', Kühlschrank = '{zimmer.Kühlschrank}', Hauptstraße = '{zimmer.Hauptstraße}', Zimmernummer = '{zimmer.Zimmernummer}', GebäudeID = '{zimmer.Gebäude.GebäudeID}', ZimmerTyp = '{zimmer.ZimmerTyp}', TerasseBalkon = '{zimmer.TerasseBalkon}' WHERE ZimmerID = '{zimmer.ZimmerID}'");
            }
            else
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"INSERT INTO zimmer (ZimmerID, Fernseher, Kühlschrank, Hauptstraße, Zimmernummer, GebäudeID, ZimmerTyp, TerasseBalkon) VALUES ('{zimmer.ZimmerID}', '{zimmer.Fernseher}', '{zimmer.Kühlschrank}', '{zimmer.Hauptstraße}', '{zimmer.Zimmernummer}', '{zimmer.Gebäude.GebäudeID}', '{zimmer.ZimmerTyp}', '{zimmer.TerasseBalkon}')");
            }
        }
        public bool ZimmerExistiert(Zimmer zimmer)
        {
            bool existiert = false;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM zimmer WHERE ZimmerID ='{zimmer.ZimmerID}'");

            if (ergebnis.Read()) 
                existiert = true;
            ergebnis.Close();

            return existiert;
        }
        public List<Zimmer> AlleZimmerAusDatenbank()
        {
            List<int> zimmerIDs = new List<int>();
            List<Zimmer> zimmer = new List<Zimmer>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM zimmer");

            while (ergebnis.Read())
            {
                zimmerIDs.Add(ergebnis.GetInt32("ZimmerID"));
            }
            ergebnis.Close();

            foreach (var ID in zimmerIDs)
            {
                zimmer.Add(ZimmerAusDatenbank(ID));
            }

            return zimmer;
        }
        public List<Zimmer> AlleZimmerMitFilterAusDatenbank(Gebäude gebäude)
        {
            List<int> zimmerIDs = new List<int>();
            List<Zimmer> zimmer = new List<Zimmer>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM zimmer WHERE GebäudeID = '{gebäude.GebäudeID}'");

            while (ergebnis.Read())
            {
                zimmerIDs.Add(ergebnis.GetInt32("ZimmerID"));
            }
            ergebnis.Close();

            foreach (var ID in zimmerIDs)
            {
                zimmer.Add(ZimmerAusDatenbank(ID));
            }

            return zimmer;
        }
        public List<Zimmer> AlleZimmerMitFilterAusDatenbank(Gebäude gebäude, int fernseher, int kühlschrank, int hauptstraße, string zimmerTyp, string terasseBalkon)
        {
            List<int> zimmerIDs = new List<int>();
            List<Zimmer> zimmer = new List<Zimmer>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM zimmer WHERE GebäudeID = {gebäude.GebäudeID} AND Fernseher = {fernseher} AND Kühlschrank = {kühlschrank} AND Hauptstraße = {hauptstraße} AND ZimmerTyp = '{zimmerTyp}' AND TerasseBalkon = '{terasseBalkon}'");

            while (ergebnis.Read())
            {
                zimmerIDs.Add(ergebnis.GetInt32("ZimmerID"));
            }
            ergebnis.Close();

            foreach (var ID in zimmerIDs)
            {
                zimmer.Add(ZimmerAusDatenbank(ID));
            }

            return zimmer;
        }
        public List<Zimmer> AlleZimmerMitFilterAusDatenbank(int fernseher, int kühlschrank, int hauptstraße, string zimmerTyp, string terasseBalkon)
        {
            List<int> zimmerIDs = new List<int>();
            List<Zimmer> zimmer = new List<Zimmer>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM zimmer WHERE Fernseher = {fernseher} AND Kühlschrank = {kühlschrank} AND Hauptstraße = {hauptstraße} AND ZimmerTyp = '{zimmerTyp}' AND TerasseBalkon = '{terasseBalkon}'");

            while (ergebnis.Read())
            {
                zimmerIDs.Add(ergebnis.GetInt32("ZimmerID"));
            }
            ergebnis.Close();

            foreach (var ID in zimmerIDs)
            {
                zimmer.Add(ZimmerAusDatenbank(ID));
            }

            return zimmer;
        }
        public bool ZimmerIstGebucht(Zimmer zimmer, DateTime datum)
        {
            bool gebucht = false;

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT GruppenID FROM buchung WHERE ZimmerID ='{zimmer.ZimmerID}' AND Datum='{datum:yyyy-MM-dd}'");
            if (ergebnis.Read()) 
                gebucht = true;
            ergebnis.Close();

            return gebucht;
        }
        public List<string> AlleZimmertypenAusDatenbank()
        {
            List<string> zimmertypen = new List<string>();
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT ZimmerTyp FROM zimmertyp");

            while (ergebnis.Read())
            {
                zimmertypen.Add(ergebnis.GetString("ZimmerTyp"));
            }
            ergebnis.Close();

            return zimmertypen;
        }
        public List<string> AlleTerasseBalkonAusDatenbank()
        {
            List<string> terasseBalkon = new List<string>();
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT TerasseBalkon FROM terassebalkon");

            while (ergebnis.Read())
            {
                terasseBalkon.Add(ergebnis.GetString("TerasseBalkon"));
            }
            ergebnis.Close();

            return terasseBalkon;
        }
        public List<Zimmer> AlleFreienZimmerAusDatenbank()
        {
            List<int> zimmerIDs = new List<int>();
            List<Zimmer> zimmer = new List<Zimmer>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT zimmer.ZimmerID FROM zimmer LEFT OUTER JOIN buchung ON zimmer.ZimmerID = buchung.ZimmerID WHERE NOT buchung.Datum = '{DateTime.Today:yyyy-MM-dd}' OR  buchung.Datum IS NULL GROUP BY zimmer.ZimmerID");

            while (ergebnis.Read())
            {
                zimmerIDs.Add(ergebnis.GetInt32("ZimmerID"));
            }
            ergebnis.Close();

            foreach (var ID in zimmerIDs)
            {
                zimmer.Add(ZimmerAusDatenbank(ID));
            }

            return zimmer;
        }
        public List<Zimmer> AlleFreienZimmerMitFilterAusDatenbank(int fernseher, int kühlschrank, int hauptstraße, string zimmerTyp, string terasseBalkon)
        {
            List<int> zimmerIDs = new List<int>();
            List<Zimmer> zimmer = new List<Zimmer>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT zimmer.ZimmerID FROM zimmer LEFT OUTER JOIN buchung ON zimmer.ZimmerID = buchung.ZimmerID WHERE Fernseher = {fernseher} AND Kühlschrank = {kühlschrank} AND Hauptstraße = {hauptstraße} AND ZimmerTyp = '{zimmerTyp}' AND TerasseBalkon = '{terasseBalkon}' AND (NOT buchung.Datum = '{DateTime.Today:yyyy-MM-dd}' OR buchung.Datum IS NULL) GROUP BY zimmer.ZimmerID");

            while (ergebnis.Read())
            {
                zimmerIDs.Add(ergebnis.GetInt32("ZimmerID"));
            }
            ergebnis.Close();

            foreach (var ID in zimmerIDs)
            {
                zimmer.Add(ZimmerAusDatenbank(ID));
            }

            return zimmer;
        }
    }
}
