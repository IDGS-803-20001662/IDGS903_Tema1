using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Diccionario
    {
        public string Ingles { get; set; }
        public string Espanol { get; set; }

        // FORMULARIO TRADUCCION
        public string Palabra { get; set; }
        public string Idioma { get; set; }
        public string Traduccion { get; set; }
    }
}