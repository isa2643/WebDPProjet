using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignPatternProjet.Models
{
    public class VehiculeModel
    {
        public int id { get; set; }
        public string type { get; set; }
        public string marque { get; set; }
        public string modele { get; set; }
        public int nombreRoue { get; set; }
        public int nombreChevaux { get; set; }

        public string etat { get; set; }

        public VehiculeModel() { }

        public VehiculeModel(int id,string t, string ma, string mod, int roue, int chevaux )
        {
            this.id = id;
            this.type = t;
            this.marque = ma;
            this.modele = mod;
            this.nombreRoue = roue;
            this.nombreChevaux = chevaux;
        }
    }
}