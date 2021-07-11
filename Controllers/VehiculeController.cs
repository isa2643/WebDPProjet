using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDesignPatternProjet.Models;
using WebDesignPatternProjet.ViewModels;

namespace WebDesignPatternProjet.Controllers
{
    public class VehiculeController : Controller
    {
        //public List<VEHICULE> VehiculeVM { get; private set; }

        // GET: Vehicule
        public ActionResult Index()
        {
            var vm = new VehiculeVM()
            {
                ListVehicules = SingletonDB.Instance.VEHICULEs.Where(x => x.type.Equals("voiture")).Select(
                    n => new VehiculeModel()
                    {
                        id = n.Id,
                        type = n.type,
                        marque = n.marque,
                        modele = n.modele,
                        nombreRoue = n.nombre_roue,
                        nombreChevaux = n.nombre_chevaux
                    }).ToList()
            };

            return View(vm);
        }

        public ActionResult AssemblageVoiture()
        {
            var vm = new VehiculeVM();
            
            VehiculeCreator vehicleCreator = new VehiculeCreator(new Voiture());
            vehicleCreator.CreateVehicle();

            return View(vm);
        }

        public ActionResult AssemblageMoto()
        {
            var vm = new VehiculeVM();

            VehiculeCreator vehicleCreator = new VehiculeCreator(new Voiture());
            vehicleCreator.CreateVehicle();

            return View(vm);
        }

        public ActionResult AssemblageCamion()
        {
            var vm = new VehiculeVM();

            VehiculeCreator vehicleCreator = new VehiculeCreator(new Voiture());
            vehicleCreator.CreateVehicle();

            return View(vm);
        }

        public ActionResult Voir()
        {
            var vm = new VehiculeVM()
            {
                ListVehicules = SingletonDB.Instance.VEHICULEs.Select(
                    n => new VehiculeModel()
                    {
                        id = n.Id,
                        type = n.type,
                        marque = n.marque,
                        modele = n.modele,
                        nombreRoue = n.nombre_roue,
                        nombreChevaux = n.nombre_chevaux
                    }).ToList()
            };

            return View(vm);

        }
    }
}