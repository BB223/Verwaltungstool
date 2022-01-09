using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verwaltungstool.Modelle.Ort;
using Willeke;

namespace Verwaltungstool.Modelle.Gäste
{
    public class GastHandler
    {
        public int HoleNächsteFreieID()
        {
            int gastID = -1;
            int tmp;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gast");

            while (ergebnis.Read())
            {
                if (gastID < (tmp = ergebnis.GetInt32("GastID")))
                {
                    gastID = tmp;
                }
            }
            ergebnis.Close();

            return gastID + 1;
        }
        public int GastAusDatenbank(string name, string nachname, string email)
        {
            int gastID = -1;

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT GastID FROM gast WHERE Name ='{name}' && Nachname ='{nachname}' && Email ='{email}'");

            while (ergebnis.Read())
            {
                gastID = ergebnis.GetInt32("GastID"); ;
            }
            ergebnis.Close();

            return gastID;
        }
        public Gast GastAusDatenbank(int gastID)
        {
            string name = "";
            string nachname = "";
            string email = "";
            int adressID = -1;

            string hausnummer = "";
            string straße = "";
            int plz = -1;
            string ort = "";

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT gast.Name, gast.Nachname, gast.Email, gast.AdressID, adresse.Hausnummer, adresse.Straße, adresse.PLZ, plz.Ort FROM gast, adresse, plz WHERE GastID ='{gastID}' AND gast.AdressID = adresse.AdressID AND adresse.PLZ = plz.PLZ");

            while (ergebnis.Read())
            {
                name = ergebnis.GetString("Name");
                nachname = ergebnis.GetString("Nachname");
                email = ergebnis.GetString("Email");
                adressID = ergebnis.GetInt32("AdressID");

                hausnummer = ergebnis.GetString("Hausnummer");
                straße = ergebnis.GetString("Straße");
                plz = ergebnis.GetInt32("PLZ");

                ort = ergebnis.GetString("Ort");
            }
            ergebnis.Close();

            return new Gast(gastID, name, nachname, email, new Adresse(adressID, hausnummer, straße, plz, ort));
        }
        public void GastZurDatenbank(Gast gast)
        {
            gast.Adresse.Speichern();

            if (!GastExistiert(gast))
            {      
                MainForm.INSTANCE.SQLDatabase.Schreiben($"INSERT INTO gast (GastID, Name, Nachname, Email, AdressID) VALUES ('{gast.GastID}', '{gast.Name}', '{gast.Nachname}', '{gast.Email}', '{gast.Adresse.AdressID}')");
            }
            else
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"UPDATE gast SET AdressID = '{gast.Adresse.AdressID}' WHERE GastID = '{gast.GastID}'");
            }
        }
        public bool GastExistiert(Gast gast)
        {
            bool existiert = false;
            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gast WHERE GastID ='{gast.GastID}'");

            if (ergebnis.Read()) existiert = true;
            ergebnis.Close();

            return existiert;
        }

        //Veraltet
        [Obsolete]
        public List<Gast> AlleGästeAusDatenbank()
        {
            List<int> gästeIDs = new List<int>();
            List<Gast> gäste = new List<Gast>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gast ORDER BY gast.GastID ASC");

            while (ergebnis.Read())
            {
                gästeIDs.Add(ergebnis.GetInt32("GastID"));
            }
            ergebnis.Close();

            foreach (var ID in gästeIDs)
            {
                gäste.Add(GastAusDatenbank(ID));
            }

            return gäste;
        }
        public List<Gast> AlleGästeVonGruppeAusDatenbank(int gruppenID)
        {
            List<int> gästeIDs = new List<int>();
            List<Gast> gäste = new List<Gast>();

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gruppegast WHERE GruppenID = '{gruppenID}' AND Bezahlt = '0' ORDER BY GastID ASC");

            while (ergebnis.Read())
            {
                gästeIDs.Add(ergebnis.GetInt32("GastID"));
            }
            ergebnis.Close();

            foreach (var ID in gästeIDs)
            {
                gäste.Add(GastAusDatenbank(ID));
            }

            return gäste;
        }
        public Gast BezahlerVonGruppeAusDatenbank(int gruppenID)
        {
            int gastID = -1;
            string name = "";
            string nachname = "";
            string email = "";
            int adressID = -1;

            string hausnummer = "";
            string straße = "";
            int plz = -1;
            string ort = "";

            var ergebnis = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT gast.GastID, gast.Name, gast.Nachname, gast.Email, gast.AdressID, adresse.Hausnummer, adresse.Straße, adresse.PLZ, plz.Ort FROM gast, gruppegast, adresse, plz WHERE gast.GastID = gruppegast.GastID AND GruppenID = '{gruppenID}' AND Bezahlt = '1' AND gast.AdressID = adresse.AdressID AND adresse.PLZ = plz.PLZ");

            while (ergebnis.Read())
            {
                //Gast
                gastID = ergebnis.GetInt32("GastID");
                name = ergebnis.GetString("Name");
                nachname = ergebnis.GetString("Nachname");
                email = ergebnis.GetString("Email");
                adressID = ergebnis.GetInt32("AdressID");

                //Adresse
                hausnummer = ergebnis.GetString("Hausnummer");
                straße = ergebnis.GetString("Straße");
                plz = ergebnis.GetInt32("PLZ");

                ort = ergebnis.GetString("Ort");
            }
            ergebnis.Close();

            return new Gast(gastID, name, nachname, email, new Adresse(adressID, hausnummer, straße, plz, ort));
        }
    }
}
