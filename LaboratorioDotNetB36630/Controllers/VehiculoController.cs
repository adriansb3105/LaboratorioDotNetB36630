using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LaboratorioDotNetB36630.Models;
using LaboratorioDotNetB36630.Services;
using System.Web.Http.Cors;

namespace LaboratorioDotNetB36630.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VehiculoController : ApiController
    {
        private VehiculoRepository _repo;

        public VehiculoController()
        {
            _repo = new VehiculoRepository();
        }

        // GET: api/Vehiculo
        public IEnumerable<Vehiculo> Get()
        {
            return this._repo.ObtenerTodos();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Vehiculo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Vehiculo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Vehiculo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vehiculo/5
        public void Delete(int id)
        {
        }
    }
}
