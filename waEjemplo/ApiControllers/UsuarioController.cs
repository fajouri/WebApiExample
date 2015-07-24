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
    public class UsuarioController : ApiController
    {
         private ApiContext context;

         public UsuarioController()
        {
            context = new ApiContext();
        }

        // GET api/<controller>
        public IEnumerable<Usuario> Get()
        {
            return context.Usuarios;
        }

        // GET api/<controller>/5
        public Usuario Get(int id)
        {
            return context.Usuarios.Find(x => x.Id == id);
        }

        // POST api/<controller>
        public void Post([FromBody]Usuario value)
        {
            context.Usuarios.Add(value);
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