using IDGS903_Tema1.Models;
using IDGS903_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult FormularioTriangulos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormularioTriangulos(Triangulos triangulos)
        {
            var op = new TriangulosService();
            var model = op.ClasificarTriangulo(triangulos);

            return View(model);
        }
    }
}