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
            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gast");

            while (result.Read())
            {
                if (gastID < (tmp = result.GetInt32("GastID")))
                {
                    gastID = tmp;
                }
            }
            result.Close();

            return gastID + 1;
        }
        public int GastAusDatenbank(string name, string nachname, string email)
        {
            int gastID = -1;

            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT GastID FROM gast WHERE Name ='{name}' && Nachname ='{nachname}' && Email ='{email}'");

            while (result.Read())
            {
                gastID = result.GetInt32("GastID"); ;
            }
            result.Close();

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

            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT gast.Name, gast.Nachname, gast.Email, gast.AdressID, adresse.Hausnummer, adresse.Straße, adresse.PLZ, plz.Ort FROM gast, adresse, plz WHERE GastID ='{gastID}' AND gast.AdressID = adresse.AdressID AND adresse.PLZ = plz.PLZ");

            while (result.Read())
            {
                name = result.GetString("Name");
                nachname = result.GetString("Nachname");
                email = result.GetString("Email");
                adressID = result.GetInt32("AdressID");

                hausnummer = result.GetString("Hausnummer");
                straße = result.GetString("Straße");
                plz = result.GetInt32("PLZ");

                ort = result.GetString("Ort");
            }
            result.Close();

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
            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gast WHERE GastID ='{gast.GastID}'");

            if (result.Read()) existiert = true;
            result.Close();

            return existiert;
        }
        public List<Gast> AlleGästeAusDatenbank()
        {
            List<int> gästeIDs = new List<int>();
            List<Gast> gäste = new List<Gast>();

            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gast");

            while (result.Read())
            {
                gästeIDs.Add(result.GetInt32("GastID"));
            }
            result.Close();

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

            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM gruppegast WHERE GruppenID = '{gruppenID}' AND Bezahlt = '0'");

            while (result.Read())
            {
                gästeIDs.Add(result.GetInt32("GastID"));
            }
            result.Close();

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

            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT gast.GastID, gast.Name, gast.Nachname, gast.Email, gast.AdressID, adresse.Hausnummer, adresse.Straße, adresse.PLZ, plz.Ort FROM gast, gruppegast, adresse, plz WHERE gast.GastID = gruppegast.GastID AND GruppenID = '{gruppenID}' AND Bezahlt = '1' AND gast.AdressID = adresse.AdressID AND adresse.PLZ = plz.PLZ");

            while (result.Read())
            {
                gastID = result.GetInt32("GastID");
                name = result.GetString("Name");
                nachname = result.GetString("Nachname");
                email = result.GetString("Email");
                adressID = result.GetInt32("AdressID");

                hausnummer = result.GetString("Hausnummer");
                straße = result.GetString("Straße");
                plz = result.GetInt32("PLZ");

                ort = result.GetString("Ort");
            }
            result.Close();

            return new Gast(gastID, name, nachname, email, new Adresse(adressID, hausnummer, straße, plz, ort));
        }
    }
}
