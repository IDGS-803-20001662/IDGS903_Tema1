using IDGS903_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_Tema1.Services
{
    public class DiccionarioService
    {
        public void GuardarPalabras(Diccionario palabras)
        {
            if (palabras.Ingles != null && palabras.Espanol != null)
            { 
                var ingles = palabras.Ingles;
                var espanol = palabras.Espanol;
                ingles = ingles.ToUpper();
                espanol = espanol.ToUpper();
            
                var diccionario = ingles + "," + espanol + Environment.NewLine;

                var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
                File.AppendAllText(archivo, diccionario);
            }
        }

        public Array LeerPalabras()
        {
            Array diccionario = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            if (File.Exists(archivo))
            {
                diccionario = File.ReadAllLines(archivo);
            }
            return diccionario;
        }

        public string Traducir(Diccionario palabra)
        {
            string traduccion = "La palabra no está en el diccionario actual";

            if (palabra.Palabra == null)
            {
                return "Ingresa una palabra";
            }

            string palabraMayus = palabra.Palabra.ToUpper();

            if (palabra.Idioma == null)
            {
                return "Ingresa un idioma";
            }


            Array diccionario = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            if (File.Exists(archivo))
            {
                diccionario = File.ReadAllLines(archivo);
            }

            foreach (string linea in diccionario)
            {
                if (linea.Contains(palabraMayus))
                {
                    string[] palabras = linea.Split(',');

                    if (palabra.Idioma == "Ing") //español a ingles
                    {
                        if (palabras[1] == palabraMayus)
                        {
                            return palabras[0];
                        }
                        else
                        {
                            return "La palabra no está en el diccionario actual";
                        }
                    }

                    else if (palabra.Idioma == "Esp") //ingles a español
                    {
                        if (palabras[0] == palabraMayus)
                        {
                            return palabras[1];
                        }
                        else
                        {
                            return "La palabra no está en el diccionario actual";
                        }
                    }
                }
            }
            return traduccion;
        }
    }
}