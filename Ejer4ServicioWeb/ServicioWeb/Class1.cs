using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWeb
{
    public class Ejercicio
    {
        public decimal dato1 { get; set; }
        public decimal dato2 { get; set; }

        public decimal areacuadrado()
        {
            return dato1 * dato1;
        }

        public decimal areatriangulo()
        {
            return dato1 * dato2 / 2;

        }

        public decimal areacirculo()
        {
            var pi = Convert.ToDecimal(3.1416);
            var radio = dato1 * dato1;
            var resultado = pi * radio;
            return Convert.ToDecimal(resultado);

        }

    }
}