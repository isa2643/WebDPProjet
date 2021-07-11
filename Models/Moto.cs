using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignPatternProjet.Models
{
    public class Moto : VehiculeBuilder
    {
        protected override void AjoutMoteur()
        {
            Console.WriteLine("Ajout du moteur pour moto");
        }

        protected override void Assemblage()
        {
            Console.WriteLine("Assemblage des motos");
        }

        protected override void Fin()
        {
            Console.WriteLine("Fin de l'assemblage des motos");
        }

        protected override void AjoutChassis()
        {
            Console.WriteLine("Ajout de chassis pour moto");
        }

        protected override void AjoutPortes()
        {
            Console.WriteLine("Pas besoin de portes pour les motos");
        }
    }
}