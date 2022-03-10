using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioWeb
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal areacuadrado(decimal n1)
        {
            Ejercicio c =new Ejercicio();
            c.dato1 = n1;
            return c.areacuadrado();
        }

        [WebMethod]
        public decimal areatriangulo(decimal n1, decimal n2)
        {
            Ejercicio c = new Ejercicio();
            c.dato1 = n1;
            c.dato2 = n2;
            return c.areatriangulo();
        }

        [WebMethod]

        public decimal areacirculo(decimal n1)
        {
            Ejercicio c = new Ejercicio();
            c.dato1 = n1;
            return c.areacirculo();
        }
    }
}
