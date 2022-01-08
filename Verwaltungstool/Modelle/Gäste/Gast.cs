using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verwaltungstool.Modelle.Ort;
using Willeke;

namespace Verwaltungstool.Modelle.Gäste
{
    public class Gast
    {
        #region Felder
        #endregion

        #region Eigenschaften
        public int GastID { get; private set; }
        public string Name { get; set; }
        public string Nachname { get; set; }
        public string Email { get; private set; }
        public Adresse Adresse { get; set; }
        #endregion

        public Gast(int gastID, string name, string nachname, string email, Adresse adresse)
        {
            this.GastID = gastID;
            this.Name = name;
            this.Nachname = nachname;
            this.Email = email;
            this.Adresse = adresse;
        }
        public void Speichern()
        {
            MainForm.INSTANCE.GastHandler.GastZurDatenbank(this);
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Nachname}";
        }
    }
}
