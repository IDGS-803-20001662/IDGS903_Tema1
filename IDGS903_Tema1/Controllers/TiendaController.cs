using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS903_Tema1.Models;

namespace IDGS903_Tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult MuestraPulques()
        {
            var pulquesVenta = new PulqueServices();
            var model = pulquesVenta.ObtenerPulque();

            TempData["Nombres"] = "Juana Citlalli";

            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            var pulquesVenta = new PulqueServices();
            var model = pulquesVenta.ObtenerPulque();

            return View(model);
        }

        public ActionResult Index()
        {
            return Content("Hi, I'm Juana Citlalli Martínez Medina from ASP.NET");
            //Devuelve el texto en el body del html
        }

        public ViewResult Index2()
        {
            return View();
            //Devuelve una vista
        }

        public JsonResult Index3()
        {
            var pulque1 = new Pulques() { Nombre = "PulqueMango", Descripcion = "Maguito", Litros = 4 };
            return Json(pulque1, JsonRequestBehavior.AllowGet);
            //Devuelve JSON
        }

        public RedirectResult Index4()
        {
            return Redirect("https://google.com.mx");
            //Redirige a un link cuando se abre la vista
        }

        public RedirectToRouteResult Index5()
        {
            return RedirectToAction("MuestraPulques2");
            //Dirige a una accion del controlador que se está usando
        }

        public ActionResult Index6()
        {
            ViewBag.saludo = "Hola mundo";
            ViewBag.fecha = new DateTime(2023, 11, 2);

            ViewData["Nombre"] = "Citlalli";

            String Nombres = "";
            if(TempData.ContainsKey("Nombre"))
            {
                Nombres = TempData["Nombres"] as String;
            }
            ViewBag.nombreNuevo = Nombres;

            return View();
        }

        public ActionResult Index7()
        {
            var pulque1 = new Pulques() 
            { Nombre = "PulqueMango", Descripcion = "Maguito", Litros = 4, Caducidad= new DateTime(2023,12,4)};
            ViewBag.pulques = pulque1;
            return View();
        }


    }
}
