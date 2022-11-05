using Back_endEjemplo1.Models;
using Back_endEjemplo1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endEjemplo1.Controllers
{
    public class CalculosController : Controller
    {
        // GET: Calculos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma(string n1, string n2)
        {
            int res = 0;
            res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.res = res;

            return View();
        }

        public ActionResult Calculacion()
        {
            OperasBas op = new OperasBas();
            return View(op);
        }

        [HttpPost]
        public ActionResult Calculacion(OperasBas op)
        {
            op.Suma();
            return View(op);
        }
        public ActionResult Resta(OperasBas op)
        {
            op.Resta();
            return View(op);
        }
        public ActionResult MuestraPeliculas()
        {
            var peliculaservice = new PeliculaService();
            var model = peliculaservice.ObtenerPeliculas();
            return View(model);
        }
        public ActionResult MuestraPeliculas2()
        {
            var peliculaservice = new PeliculaService();
            var model = peliculaservice.ObtenerPeliculas();
            return View(model);
        }
        public RedirectToRouteResult temporal() 
        {
            return RedirectToAction("About","Home");

        }
    }
}