using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Willeke;

namespace Verwaltungstool.Modelle.Ort
{
    public class GebäudeHandler
    {
        public void GebäudeZurDatenbank(Gebäude gebäude)
        {
            gebäude.Adresse.Speichern();

            if (GebäudeExistiert(gebäude))
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"UPDATE gebäude SET AdressID = '{gebäude.Adresse.AdressID}' WHERE GebäudeID = '{gebäude.GebäudeID}'");
            }
            else
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"INSERT INTO gebäude (GebäudeID, AdressID) VALUES ('{gebäude.GebäudeID}', '{gebäude.Adresse.AdressID}')");
            }
        }
        public bool GebäudeExistiert(Gebäude gebäude)
        {
            bool existiert = false;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gebäude WHERE GebäudeID ='{gebäude.GebäudeID}'");

            if (ergebnis.Read()) existiert = true;
            ergebnis.Close();

            return existiert;
        }
        public Gebäude GebäudeAusDatenbank(int gebäudeID)
        {
            int adressID = -1;

            string hausnummer = "";
            string straße = "";
            int plz = -1;
            string ort = "";

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT adresse.AdressID, adresse.Hausnummer, adresse.Straße, adresse.PLZ, plz.Ort FROM gebäude, adresse, plz WHERE GebäudeID ='{gebäudeID}' AND gebäude.AdressID = adresse.AdressID AND adresse.PLZ = plz.PLZ");

            while (ergebnis.Read())
            {
                adressID = ergebnis.GetInt32("AdressID");

                hausnummer = ergebnis.GetString("Hausnummer");
                straße = ergebnis.GetString("Straße");
                plz = ergebnis.GetInt32("PLZ");
                ort = ergebnis.GetString("Ort");
            }
            ergebnis.Close();

            return new Gebäude(gebäudeID, new Adresse(adressID, hausnummer, straße, plz, ort));
        }
        public List<Gebäude> AlleGebäudeAusDatenbank()
        {
            List<int> gebäudeIDs = new List<int>();
            List<Gebäude> gebäude = new List<Gebäude>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gebäude ORDER BY GebäudeID ASC");

            while (ergebnis.Read())
            {
                gebäudeIDs.Add(ergebnis.GetInt32("GebäudeID"));
            }
            ergebnis.Close();

            foreach (var ID in gebäudeIDs)
            {
                gebäude.Add(GebäudeAusDatenbank(ID));
            }

            return gebäude;
        }
    }
}
