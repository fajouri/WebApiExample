using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webApiExample.Context;
using webApiExample.Models;

namespace webApiExample.ApiControllers
{
    public class LocalidadProvincia : ApiController
    {
        private ApiContext context;

        public LocalidadProvincia()
        {
            context = new ApiContext();
        }

         // GET api/<controller>/5
        public IEnumerable<Localidad> Get(int id)
        {

            return context.Provincias.Find(x=>x.Id==id).Localidades;
        }

        // GET api/<controller>
        public string Get()
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}