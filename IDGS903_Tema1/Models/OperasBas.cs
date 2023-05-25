using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace IDGS903_Tema1.Models
{
    public class OperasBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public float Res { get; set; }
        public String Operacion { get; set; }

        public void Sumar()
        {
            this.Res = this.Num1 + this.Num2;
        }

        public void Restar()
        {
            this.Res = this.Num1 - this.Num2;
        }

        public void Multiplicar()
        {
            this.Res = this.Num1 * this.Num2;
        }

        public void Dividir()
        {
            this.Res = this.Num1 / this.Num2;
        }

        public void Operaciones()
        {
            switch (this.Operacion)
            {
                case "1":
                    Sumar();
                    break;
                case "2":
                    Restar();
                    break;
                case "3":
                    Multiplicar();
                    break;
                case "4":
                    Dividir();
                    break;
                default:
                    this.Res = 0;
                    break;

            }
        }
    }
}