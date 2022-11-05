using Back_endEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back_endEjemplo1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            ViewBag.Nombre = "Carlos";
            ViewBag.Correo = "Carlos@hotmail.com";
            ViewBag.Fecha = new DateTime(200, 5, 5);
            return View();
        }

        public ActionResult Index2()
        {
            ViewData["Nombre"] = "Carlos";
            ViewData["Correo"]= "Carlos@hotmail.com";
            ViewData["Fecha"] = new DateTime(200, 5, 5);
            return View();
        }

        public ActionResult Vista()
        {
            var persona = new Persona()
            {
                Nombre = "Carlos",
                Edad = 25,
                Empleado = true,
                Nacimiento = new DateTime(1998, 5, 6)
            };
            ViewBag.Propiedad = persona;
            return View();
        }
    }
}