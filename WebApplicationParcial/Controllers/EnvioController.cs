using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Logica;

namespace WebApplicationParcial.Controllers
{
    public class EnvioController : ApiController
    {
        // GET: api/Envio
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Envio/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Envio
        public IHttpActionResult Post([FromBody]string value)
        {
            if ("Error" != value)
            {
                return Created("Se creo correctamente", value);

            }
            return BadRequest();
        }

        // PUT: api/Envio/5
        public IHttpActionResult Put(string seguimiento, [FromBody]Envio EnvioActualizar)
        {
            bool resultado = Logica.Envio.ValidarActualizacion(seguimiento);
            if (resultado == true)
            {
                return Ok();

            }
            return BadRequest();
            
        }

       

        // DELETE: api/Envio/5
        public void Delete(int id)
        {
        }
    }
}
