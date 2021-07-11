using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignPatternProjet.Models
{
    public class Voiture : VehiculeBuilder
    {
        protected override void AjoutMoteur()
        {

            Console.WriteLine("Ajout du moteur pour voiture");

        }

        protected override void Assemblage()
        {
            Console.WriteLine("Assemblage des voitures");
        }

        protected override void Fin()
        {
            Console.WriteLine("Fin de l'assemblage des voitures");
        }

        protected override void AjoutChassis()
        {
            Console.WriteLine("Ajout de chassis pour voiture");
        }

        protected override void AjoutPortes()
        {
            Console.WriteLine("Ajout de portes pour voiture");
        }
    }
}