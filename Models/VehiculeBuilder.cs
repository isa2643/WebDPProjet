using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignPatternProjet.Models
{
    public abstract class VehiculeBuilder
    {
        protected VehiculeModel _vehicle;

        public void CreationVehicule()
        {
            _vehicle = new VehiculeModel();
        }

        public void Operations()
        {
            this.Debut();
            this.AjoutChassis();
            this.AjoutMoteur();
            this.Fin();
            this.Assemblage();

        }

        protected virtual void Debut()
        {
            this._vehicle.etat = "Debut Assemblage";
            Console.WriteLine("Debut Assemblage");
        }
        protected abstract void AjoutChassis();

        protected abstract void AjoutMoteur();

        protected virtual void Fin()
        {
            this._vehicle.etat = "Fin Assemblage";
            Console.WriteLine("Fin Assemblage");
        }

        protected abstract void Assemblage();

        protected abstract void AjoutPortes();



    }
}