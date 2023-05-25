using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            var alumno1 = new Alumnos()
            {
                Nombre = "Antonio",
                Edad = 20,
                Activo = true,
                Inscrito = new DateTime(2023, 01, 15)
            };
            ViewBag.Alumnos = alumno1;

            return View();
        }

        public ActionResult Registrar(Alumnos alum)
        {
            var alumno1 = new Alumnos()
            {
                Nombre = "Antonio",
                Edad = 20,
                Activo = true,
                Inscrito = new DateTime(2023, 01, 15)
            };

            alum = alumno1;
            return View(alum);
        }

        public ActionResult Registrar2(Alumnos alum)
        {
            return View(alum);
        }
    }
}