using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class PulqueServices
    {
        public List<Pulques> ObtenerPulque()
        {
            var pulque1 = new Pulques()
            {
                Nombre = "Pulque1",
                Descripcion = "Frutos Rojos",
                Litros = 25,
                Caducidad = new DateTime(2023, 11, 5)
            };

            var pulque2 = new Pulques()
            {
                Nombre = "Pulque2",
                Descripcion = "Mango Piña",
                Litros = 23,
                Caducidad = new DateTime(2023, 12, 5)
            };

            return new List<Pulques> { pulque1, pulque2 };

        }
    }
}