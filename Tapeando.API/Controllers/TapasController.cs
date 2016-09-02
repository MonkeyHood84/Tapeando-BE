using Tapeando.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tapeando.Servicies.UoW;

namespace Tapeando.API.Controllers
{
    public class TapasController : ApiController
    {
        // GET api/<controller>
        public IQueryable<Tapa> Get()
        {
            ApplicationUnit unit = new ApplicationUnit();            
            return unit.Tapa.GetAll();
        }

        // GET api/<controller>/5
        public string Get(int id)
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