using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class PuntosController : Controller
    {
        // GET: Puntos
        public ActionResult Index(Puntos punt)
        {
            

            return View(punt);
        }

        public ActionResult Resultado(Puntos punt)
        {
            punt.CalcularDistancia();
            ViewBag.Distancia = punt.Distancia;

            return View(punt);
        }
    }
}