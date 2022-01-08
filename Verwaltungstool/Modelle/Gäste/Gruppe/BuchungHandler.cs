﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Willeke;

namespace Verwaltungstool.Modelle.Gäste.Gruppe
{
    public class BuchungHandler
    {
        public Buchung BuchungAusDatenbank(int zimmerID, DateTime datum)
        {
            int gruppenID = -1;
            bool payTV = false;
            bool babybett = false;
            bool frühstück = false;

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

            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT buchung.GruppenID, buchung.PayTV, buchung.Babybett, buchung.Frühstück, zimmer.Fernseher, zimmer.Kühlschrank, zimmer.Hauptstraße, zimmer.Zimmernummer, zimmer.GebäudeID, zimmer.ZimmerTyp, zimmer.TerasseBalkon, adresse.AdressID, adresse.Hausnummer, adresse.Straße, adresse.PLZ, plz.Ort FROM buchung, zimmer, gebäude, adresse, plz WHERE buchung.ZimmerID ='{zimmerID}' AND buchung.Datum = '{datum:yyyy-MM-dd}' AND buchung.ZimmerID = zimmer.ZimmerID AND zimmer.GebäudeID = gebäude.GebäudeID AND gebäude.AdressID = adresse.AdressID AND adresse.PLZ = plz.PLZ");

            while (result.Read())
            {
                gruppenID = result.GetInt32("GruppenID");
                payTV = result.GetBoolean("PayTV");
                babybett = result.GetBoolean("Babybett");
                frühstück = result.GetBoolean("Frühstück");

                fernseher = result.GetBoolean("Fernseher");
                kühlschrank = result.GetBoolean("Kühlschrank");
                hauptstraße = result.GetBoolean("Hauptstraße");
                zimmernummer = result.GetString("Zimmernummer");
                gebäudeID = result.GetInt32("GebäudeID");
                zimmerTyp = result.GetString("ZimmerTyp");
                terasseBalkon = result.GetString("TerasseBalkon");

                adressID = result.GetInt32("AdressID");
                hausnummer = result.GetString("Hausnummer");
                straße = result.GetString("Straße");
                plz = result.GetInt32("PLZ");
                ort = result.GetString("Ort");
            }
            result.Close();

            return new Buchung(MainForm.INSTANCE.GruppenHandler.GruppeAusDatenbank(gruppenID),new Ort.Zimmer(zimmerID,fernseher,kühlschrank,hauptstraße,zimmernummer,new Ort.Gebäude(gebäudeID,new Ort.Adresse(adressID,hausnummer,straße,plz,ort)),zimmerTyp,terasseBalkon), payTV, babybett, frühstück, datum);
        }
        public void BuchungZurDatenbank(Buchung buchung)
        {
            if (!BuchungExistiert(buchung))
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"INSERT INTO buchung (GruppenID, ZimmerID, PayTV, Babybett, Frühstück, Datum) VALUES ('{buchung.Gruppe.GruppenID}','{buchung.Zimmer.ZimmerID}', '{(buchung.PayTV ? '1' : '0')}','{(buchung.Babybett ? '1' : '0')}','{(buchung.Frühstück ? '1' : '0')}','{buchung.Datum:yyy-MM-dd}')");
            }
            else
            {
                MainForm.INSTANCE.SQLDatabase.Schreiben($"UPDATE buchung SET GruppenID = '{buchung.Gruppe.GruppenID}', PayTV = '{(buchung.PayTV ? '1':'0')}', Babybett = '{(buchung.Babybett ? '1':'0')}', Frühstück = '{(buchung.Frühstück ? '1':'0')}' WHERE Datum = '{buchung.Datum:yyy-MM-dd}' AND ZimmerID = '{buchung.Zimmer.ZimmerID}'");
            }
        }
        public bool BuchungExistiert(Buchung buchung)
        {
            bool existiert = false;
            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM buchung WHERE ZimmerID ='{buchung.Zimmer.ZimmerID}' AND Datum = '{buchung.Datum:yyyy-MM-dd}'");

            if (result.Read()) existiert = true;
            result.Close();

            return existiert;
        }
        public bool BuchungExistiert(Gruppe gruppe, DateTime datum)
        {
            bool existiert = false;
            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM buchung WHERE GruppenID ='{gruppe.GruppenID}' AND Datum = '{datum:yyyy-MM-dd}'");

            if (result.Read()) existiert = true;
            result.Close();

            return existiert;
        }
        public List<Buchung> AlleAktuelleBuchungAusDatenbank()
        {
            List<(int, DateTime)> buchungIDs = new List<(int, DateTime)>();
            List<Buchung> buchungen = new List<Buchung>();
            List<Buchung> zuEntfernen = new List<Buchung>();

            var result = MainForm.INSTANCE.SQLDatabase.Lesen($"SELECT * FROM buchung WHERE Datum = '{DateTime.Today:yyyy-MM-dd}' OR Datum = '{DateTime.Today.AddDays(-1):yyyy-MM-dd}'");

            while (result.Read())
            {
                buchungIDs.Add((result.GetInt32("ZimmerID"), result.GetDateTime("Datum")));
            }
            result.Close();

            foreach (var ID in buchungIDs)
            {
                buchungen.Add(BuchungAusDatenbank(ID.Item1,ID.Item2));
            }

            Buchung tmp = buchungen[0];
            foreach (var buchung in buchungen)
            {
                if (tmp.Equals(buchung)) continue;

                if (tmp.Gruppe.GruppenID == buchung.Gruppe.GruppenID)
                {
                    if (tmp.Datum > buchung.Datum)
                    {
                        zuEntfernen.Add(buchung);
                    }
                    else
                    {
                        zuEntfernen.Add(tmp);
                    }
                }
                tmp = buchung;
            }

            foreach (var buchung in zuEntfernen)
            {
                buchungen.Remove(buchung);
            }

            return buchungen;
        }
    }
}
