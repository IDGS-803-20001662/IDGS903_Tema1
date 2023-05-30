using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Triangulos
    {
        [RegularExpression(@"^-?[0-9]+(\.[0-9]+)?$", ErrorMessage = "Ingrese solo números.")]
        public float AX { get; set; }
        [RegularExpression(@"^-?[0-9]+(\.[0-9]+)?$", ErrorMessage = "Ingrese solo números.")]
        public float AY { get; set; }
        [RegularExpression(@"^-?[0-9]+(\.[0-9]+)?$", ErrorMessage = "Ingrese solo números.")]
        public float BX { get; set; }
        [RegularExpression(@"^-?[0-9]+(\.[0-9]+)?$", ErrorMessage = "Ingrese solo números.")]
        public float BY { get; set; }
        [RegularExpression(@"^-?[0-9]+(\.[0-9]+)?$", ErrorMessage = "Ingrese solo números.")]
        public float CX { get; set; }
        [RegularExpression(@"^-?[0-9]+(\.[0-9]+)?$", ErrorMessage = "Ingrese solo números.")]
        public float CY { get; set; }

        public string Triangulo { get; set; }
        public double Area { get; set; }


    }
}