using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Models
{
    public class Puntos
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public double Distancia { get; set; }

        public void CalcularDistancia()
        {
            this.Distancia = Math.Sqrt(Math.Pow((this.X2-this.X1), 2) 
                + Math.Pow((this.Y2 - this.Y1), 2));
        }

    }
}