using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Aplicaion
    {
        public List<Envio> Envios { get; set; }
        public List<Destinatario> Destinatarios { get; set; }
        public List<Repartidor> Repartidors { get; set; }

        //PODRIA RECIBIR UN OBJETO COMPLETO Y NO PARAMETROS SUELTOS
        public string NuevoEnvio(string dni, DateTime fechaEstim, string descripcion)
        {
            //NO SE ENTIENDE EL IF, AL CREAR ENVIO NO HAY REPARTIDORES
            if (Repartidors.Exists(x => x.Documento == dni )!= true)
            {
                Destinatario destinatarioEncondo = Destinatarios.Find(x => x.Documento == dni);
                if (destinatarioEncondo.Telefono == null)
                {
                    return "Error";
                }
                Envio nuevoEnvio = new Envio();
                Random numero = new Random();
                nuevoEnvio.NumeroEnvio = Convert.ToString(numero); //MAL USADO RANDOM, ES numero.Next().ToString()
                nuevoEnvio.Destinat = destinatarioEncondo;
                nuevoEnvio.Descripcion = descripcion;


                return nuevoEnvio.NumeroEnvio;

            }
            return "Error";
            
        }

        //NO COMPILA
        public Destinatario Destinatario ObtenerDestinatario(string dni)
        {
            Destinatario encontrado = Destinatarios.Find(x => x.Documento == dni;);
            return encontrado ;
        }

        //BIEN RESUELTO
        public Repartidor AsignarRepartidor(Envio envioAsignado)
        {
            double mayor = 0;
            Repartidor mayorRep = new Repartidor();
            foreach (var item in Repartidors)
            {
                double resultado = Extension.CalcularDistancia(item, envioAsignado.Destinat);

                if (resultado> mayor)
                {
                    mayor = resultado;
                    mayorRep = item;
                }
                
            }
            return mayorRep;

        }

        public List<RepartidoresListaPorFecha> ObtenerRepartidoresEntreFechas(DateTime desde, DateTime hasta)
        {
            List<RepartidoresListaPorFecha> ListaGenerada = new List<RepartidoresListaPorFecha>();
            foreach (var item in Envios)
            {
                if (item.EntregaEstimada>desde & item.EntregaEstimada< hasta)
                {
                    RepartidoresListaPorFecha rep = ListaGenerada.Find(x => x.NombreAp == item.Repartido);
                    if (rep!=null)
                    {
                        rep.ComisionGanada += item.Repartido.Comision;
                        rep.CantidadEnvios += 1;

                    }
                    else
                    {
                        rep.NombreAp = item.Repartido;
                        rep.CantidadEnvios = 1;
                        rep.ComisionGanada = item.Repartido.Comision;
                        ListaGenerada.Add(rep);
                    }

                }

            }
            return ListaGenerada;

        }



    }
}
