using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using System.Web.Http.OData;
using Tapeando.Data.Models;
using Tapeando.Servicies.UoW;

namespace Tapeando.Api.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]
    [Authorize]
    public class PlacesController : ApiController
    {
        ApplicationUnit unit = new ApplicationUnit();

        // GET api/<controller>
        [EnableQuery()]
        [ResponseType(typeof(Place))]
        public IHttpActionResult Get()
        {
            try
            {
                var placesRepo = this.unit.Place;
                return Ok(placesRepo.GetAll().AsQueryable());
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        // GET api/<controller>/5
        [ResponseType(typeof(Place))]
        public IHttpActionResult Get(int id)
        {
            Place place;
            var placeRepo = this.unit.Place;
            if (id > 0)
            {
                place = placeRepo.GetById(id);
                if (place == null)
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest("id has to be a number higher than 0");
            }
            return Ok(place);
        }

        // POST api/<controller>
        [ResponseType(typeof(Place))]
        public IHttpActionResult Post([FromBody]Place place)
        {
            if (place == null)
            {
                return BadRequest("Place cannot be null");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var placesRepo = this.unit.Place;
            var newPlace = placesRepo.Add(place);
            if (newPlace == null)
            {
                return Conflict();
            }
            return Created<Place>(Request.RequestUri + newPlace.Id.ToString(), newPlace);
        }

        // PUT api/<controller>/5
        [ResponseType(typeof(Place))]
        public IHttpActionResult Put(int id, [FromBody]Place place)
        {
            if (place == null)
            {
                return BadRequest("Place cannot be null");
            }
            var placesRepo = this.unit.Place;
            var updatePlace = placesRepo.Update(place);
            if (updatePlace == null)
            {
                return NotFound();
            }
            return Ok();
        }

        // DELETE api/<controller>/5
        [ResponseType(typeof(Place))]
        public IHttpActionResult Delete(int id)
        {
            Place place;
            var placeRepo = this.unit.Place;
            if (id > 0)
            {

                place = placeRepo.GetById(id);
                if (place == null)
                {
                    return NotFound();
                }
                placeRepo.Delete(id);
            }
            else
            {
                return BadRequest("Place ID has to be bigger than 0");
            }
            return Ok(place);
        }
    }
}