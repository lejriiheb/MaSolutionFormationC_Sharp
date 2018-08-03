using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Banking.BackOffice.Models;

namespace Banking.BackOffice.Controllers
{
    [EnableCors("*","*","*")]
    public class ComptesController : ApiController
    {
        private ModelBanque db = new ModelBanque();

        // GET: api/Comptes
        public IQueryable<Comptes> GetComptes()
        {
            return db.Comptes;
        }

        // GET: api/Comptes/5
        [ResponseType(typeof(Comptes))]
        public IHttpActionResult GetComptes(string id)
        {
            Comptes comptes = db.Comptes.Find(id);
            if (comptes == null)
            {
                return NotFound();
            }

            return Ok(comptes);
        }

        // PUT: api/Comptes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutComptes(string id, Comptes comptes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comptes.Numero)
            {
                return BadRequest();
            }

            db.Entry(comptes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComptesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Comptes
        [ResponseType(typeof(Comptes))]
        public IHttpActionResult PostComptes(Comptes comptes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Comptes.Add(comptes);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ComptesExists(comptes.Numero))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = comptes.Numero }, comptes);
        }

        // DELETE: api/Comptes/5
        [ResponseType(typeof(Comptes))]
        public IHttpActionResult DeleteComptes(string id)
        {
            Comptes comptes = db.Comptes.Find(id);
            if (comptes == null)
            {
                return NotFound();
            }

            db.Comptes.Remove(comptes);
            db.SaveChanges();

            return Ok(comptes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ComptesExists(string id)
        {
            return db.Comptes.Count(e => e.Numero == id) > 0;
        }
    }
}