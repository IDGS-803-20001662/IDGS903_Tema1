using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class DiccionarioController : Controller
    {
        // GET: Diccionario
        public ActionResult RegistrarPalabras()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarPalabras(Diccionario diccionario)
        {
            var op = new DiccionarioService();
            op.GuardarPalabras(diccionario);
            ViewBag.Diccionario = op.LeerPalabras();
            return View();
        }

        public ActionResult MostrarTabla()
        {
            var diccionario = new DiccionarioService();
            var datosTabla = diccionario.LeerPalabras();

            return Json(datosTabla, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Traducir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Traducir(Diccionario diccionario)
        {
            var op = new DiccionarioService();
            diccionario.Traduccion = op.Traducir(diccionario);

            var model = new Diccionario();
            model.Traduccion = diccionario.Traduccion;
            return View(diccionario);
        }

    }
}