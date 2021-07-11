using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignPatternProjet.Models
{
    public class Process
    {
        public static void Assemblage(VehiculeBuilder classeAbstraite)
        {
            classeAbstraite.Operations();
        }
    }
}