using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class GuardarService
    {
        public void GuardarArchivo(Maestros maes)
        {
            var mat = maes.Matricula;
            var nom = maes.Nombre;
            var apa = maes.Apaterno;
            var ama = maes.Amaterno;
            var email = maes.Email;
            var datos = mat + "," + nom + "," + apa + "," + ama + "," + email + Environment.NewLine; //ENVIRONMENT.NEWLINE es para el salto del linea

            //Crear archivo
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            //Guardar datos sobrescribiendo
            //File.WriteAllText(archivo, datos);

            //Escribir texto sin sobrescribir
            File.AppendAllText(archivo,datos);
        }
    }
}