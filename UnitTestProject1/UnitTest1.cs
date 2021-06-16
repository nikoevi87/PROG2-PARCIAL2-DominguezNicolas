using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AsignarRepartidor_FechasDesdeHasta_RepartidorAsignado()
        {
            Aplicaion Aplicacion = new Aplicaion();
            DateTime diadesde = DateTime.Today;
            var date1 = new DateTime(2008, 5, 1);
            var date2 = new DateTime(2008, 5, 1);

            Envio envioParaCoincidirEnvioYRepartidorCercano = new Envio();

            //poner dato envio

            Repartidor repartidorCreadoConEnvioCercano = new Repartidor();

            //poner repartidor

            Repartidor resultado = Aplicacion.AsignarRepartidor(envioParaCoincidirEnvioYRepartidorCercano);

            



            Assert.AreEqual(repartidorCreadoConEnvioCercano,resultado);


        }
    }
}
