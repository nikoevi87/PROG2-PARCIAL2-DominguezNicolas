using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Logica;

namespace WebApplicationParcial.Models
{
    public class EnvioRequest
    {
        public Destinatario Dest { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Descripcion { get; set; }


        public void OBtenerDestinatario(string dni)
        {
           
            Dest = Logica.Aplicaion.ObtenerDestinatario(dni);
        }



        
    }
}