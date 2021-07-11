using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDesignPatternProjet.Models;

namespace WebDesignPatternProjet.ViewModels
{
    public class VehiculeVM
    {
        public List<VehiculeModel> ListVehicules { get; set; } = new List<VehiculeModel>();

        public string etat{ get; set; }

    }
}