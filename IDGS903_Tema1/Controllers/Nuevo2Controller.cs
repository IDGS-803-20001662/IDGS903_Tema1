using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_Tema1.Controllers
{
    public class Nuevo2Controller : Controller
    {
        // GET: Nuevo2
        public ActionResult Ventana2(OperasBas op)
        {
            op.Operaciones();
            var model = new OperasBas();
            model.Res = op.Res;

            return View(model);
        }

        public ActionResult Calculos(string n1, string n2, string operacion)
        {
            int num1= Convert.ToInt32(n1);
            int num2= Convert.ToInt32(n2);
            //int res= Convert.ToInt32(n1)+Convert.ToInt32(n2);
            float res=0;
            string resultado = "";
            switch (operacion)
            {
                case "1":
                    res= num1 + num2;
                    resultado = res.ToString();
                    break;
                case "2":
                    res = num1 - num2;
                    resultado = res.ToString();
                    break;
                case "3":
                    res = num1 * num2;
                    resultado = res.ToString();
                    break;
                case "4":
                    res = num1 / num2;
                    resultado = res.ToString();
                    break;
                default:
                     resultado = "Elija una opcion valida";
                    break;

            }

            ViewBag.Resultado= resultado;

            return View();
        }

    }
}