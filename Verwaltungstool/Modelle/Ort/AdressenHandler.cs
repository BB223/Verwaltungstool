using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Willeke;

namespace Verwaltungstool.Modelle.Ort
{
    public class AdressenHandler
    {
        public int HoleNächsteFreieID()
        {
            int adressID = -1;
            int tmp;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM adresse");

            while (ergebnis.Read())
            {
                if (adressID < (tmp = ergebnis.GetInt32("AdressID")))
                {
                    adressID = tmp;
                }
            }
            ergebnis.Close();

            return adressID + 1;
        }
        public int AdresseAusDatenbank(string straße, string hausnummer, int plz, string ort)
        {
            int adressID = -1;

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT AdressID FROM adresse, plz WHERE adresse.Straße ='{straße}' AND adresse.Hausnummer ='{hausnummer}' AND adresse.PLZ ='{plz}' AND plz.Ort ='{ort}' AND adresse.PLZ = plz.PLZ");

            while (ergebnis.Read())
            {
                adressID = ergebnis.GetInt32("AdressID");
            }
            ergebnis.Close();

            return adressID;
        }
        public Adresse AdresseAusDatenbank(int adressID)
        {
            string hausnummer = "";
            string straße = "";
            int plz = -1;
            string ort = "";

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT adresse.Hausnummer, adresse.Straße, adresse.PLZ, plz.Ort FROM adresse, plz WHERE AdressID ='{adressID}' AND adresse.PLZ = plz.PLZ");

            while (ergebnis.Read())
            {
                hausnummer = ergebnis.GetString("Hausnummer");
                straße = ergebnis.GetString("Straße");
                plz = ergebnis.GetInt32("PLZ");

                ort = ergebnis.GetString("Ort");
            }
            ergebnis.Close();

            return new Adresse(adressID, hausnummer, straße, plz, ort);
        }
        public void AdresseZurDatenbank(Adresse Adresse)
        {
            OrtZurDatenbank(Adresse);

            if (!AdresseExistiert(Adresse))
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"INSERT INTO adresse (AdressID, Hausnummer, Straße, PLZ) VALUES ('{Adresse.AdressID}', '{Adresse.Hausnummer}', '{Adresse.Straße}', '{Adresse.PLZ}')");
            }
        }
        public bool AdresseExistiert(Adresse adresse)
        {
            bool existiert = false;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM adresse WHERE AdressID ='{adresse.AdressID}'");

            if(ergebnis.Read()) existiert = true;
            ergebnis.Close();

            return existiert;
        }
        private void OrtZurDatenbank(Adresse adresse)
        {
            if (!OrtExistiert(adresse))
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"INSERT INTO plz (PLZ, Ort) VALUES ('{adresse.PLZ}', '{adresse.Ort}')");
            }
        }
        private bool OrtExistiert(Adresse adresse)
        {
            bool existiert = false;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM plz WHERE PLZ ='{adresse.PLZ}'");

            if (ergebnis.Read()) existiert = true;
            ergebnis.Close();

            return existiert;
        }
        public string OrtAusDatenbank(int plz)
        {
            string ort = "";

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT Ort FROM plz WHERE plz ='{plz}'");

            while (ergebnis.Read())
            {
                ort = ergebnis.GetString("Ort");
            }
            ergebnis.Close();

            return ort;
        }
    }
}
