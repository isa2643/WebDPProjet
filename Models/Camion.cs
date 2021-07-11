using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignPatternProjet.Models
{
    public class Camion : VehiculeBuilder
    {
        protected override void AjoutMoteur()
        {
            Console.WriteLine("Ajout du moteur pour camion");
        }

        protected override void Assemblage()
        {
            Console.WriteLine("Assemblage des camions");
        }

        protected override void Fin()
        {
            Console.WriteLine("Fin de l'assemblage des camions");
        }

        protected override void AjoutChassis()
        {
            Console.WriteLine("Ajout de chassis pour camion");
        }

        protected override void AjoutPortes()
        {
            Console.WriteLine("Ajout de portes pour camion");
        }
    }
}