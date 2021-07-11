using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignPatternProjet.Models
{
    public class VehiculeCreator
    {
        private readonly VehiculeBuilder _veh;

        public VehiculeCreator(VehiculeBuilder v)
        {
            _veh = v;
        }

        public void CreateVehicle()
        {
            _veh.CreationVehicule();
            Process.Assemblage(_veh);

        }
    }
}