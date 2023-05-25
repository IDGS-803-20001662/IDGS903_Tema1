using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc.Routing.Constraints;

namespace IDGS903_Tema1.Services
{
    public class TriangulosService
    {
        public Triangulos ClasificarTriangulo(Triangulos triangulos)
        {
            double distanciaAB = Math.Sqrt(Math.Pow((triangulos.BX - triangulos.AX), 2)
                + Math.Pow((triangulos.BY - triangulos.AY), 2));

            double distanciaBC = Math.Sqrt(Math.Pow((triangulos.BX - triangulos.CX), 2)
                + Math.Pow((triangulos.BY - triangulos.CY), 2));

            double distanciaCA = Math.Sqrt(Math.Pow((triangulos.AX - triangulos.CX), 2)
                + Math.Pow((triangulos.AY - triangulos.CY), 2));

            //distanciaAB mayor
            if (distanciaAB >= distanciaBC && distanciaAB >= distanciaCA && distanciaAB < (distanciaBC + distanciaCA))
            {
                triangulos.Triangulo = EscogerTipo(distanciaAB, distanciaBC, distanciaCA);
                triangulos.Area = CalcularArea(distanciaAB, distanciaBC, distanciaCA);

            }

            //distanciaBC mayor
            else if (distanciaBC >= distanciaAB && distanciaBC >= distanciaCA && distanciaBC < (distanciaAB + distanciaCA))
            {
                triangulos.Triangulo = EscogerTipo(distanciaAB, distanciaBC, distanciaCA);
                triangulos.Area = CalcularArea(distanciaAB, distanciaBC, distanciaCA);
            }

            //distanciaCA mayor
            else if (distanciaCA >= distanciaAB && distanciaCA >= distanciaBC && distanciaCA < (distanciaAB + distanciaBC))
            {
                triangulos.Triangulo = EscogerTipo(distanciaAB, distanciaBC, distanciaCA);
                triangulos.Area = CalcularArea(distanciaAB, distanciaBC, distanciaCA);
            }

            else
            {
                triangulos.Triangulo = "Los puntos ingresados no forman un triángulo";
                triangulos.Area = 0;
            }

            return triangulos;
        }

        private string EscogerTipo(double AB, double BC, double CA)
        {
            string tipo = "Ninguno";

            if (AB == BC && BC == CA)
            {
                tipo = "Equilatero";
            }

            if (AB != BC && BC != CA && CA != AB)
            {
                tipo = "Escaleno";
            }

            if (AB == CA && CA != BC)
            {
                tipo = "Isóceles";
            }

            if (AB == BC && BC != CA)
            {
                tipo = "Isóceles";
            }

            if (CA == BC && BC != AB)
            {
                tipo = "Isóceles";
            }

            return tipo;
        }

        private double CalcularArea(double AB, double BC, double CA)
        {
            double area = 0;
            double s = (AB + BC + CA)/2;
            
            area = Math.Sqrt(s*(s-AB)*(s-BC)*(s-CA));

            return Math.Round(area,5);
        }
    }
}