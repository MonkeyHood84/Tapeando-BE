using Tapeando.Data.Models;
using Tapeando.Servicies.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Tapeando.API.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        public IQueryable<TempTest> Get()
        {
            ApplicationUnit unit = new ApplicationUnit();

            return unit.GetAllTestActives().Where(w=> w.IsActive); //unit.Tests.GetAll();
        }

        // GET: api/Test/5
        public TempTest Get(int id)
        {
            ApplicationUnit unit = new ApplicationUnit();

            return unit.Tests.GetById(id);
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
