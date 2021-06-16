using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Envio
    {
        public string NumeroEnvio { get; set; }
        public Destinatario Destinat { get; set; }
        public Repartidor Repartido { get; set; }
        public Estado Estado1 { get; set; }
        public DateTime EntregaEstimada { get; set; }
        public string Descripcion { get; set; }
        public static DateTime FechaEntrega { get; set; }



        public enum Estado
        {
            Pendiente,
            Asignado_Repartidor,
            En_camino,
            Entregado
        }

        public static bool ValidarActualizacion(string seguimientoAct)
        {
            if (this.Estado == seguimientoAct )
            {
                if (Estado == 3)
                {
                    Repartido.Comision = Repartido.CalcularComision();
                    FechaEntrega = DateTime.Today;
                    return true;
                }

            }
            return false;
        }
    }
}
