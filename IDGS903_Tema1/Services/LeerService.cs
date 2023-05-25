using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class LeerService
    {
        public Array LeerArchivo()
        {
            Array maestrosData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
            if (File.Exists(archivo))
            {
                //Se crea el arreglo de lineas
                maestrosData = File.ReadAllLines(archivo);
            }
            return maestrosData;
        }
    }
}