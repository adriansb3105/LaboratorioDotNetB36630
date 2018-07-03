using LaboratorioDotNetB36630.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaboratorioDotNetB36630.Services
{
    public class VehiculoRepository
    {
        public List<Vehiculo> ObtenerTodos()
        {
            using (var db = new ApplicationDbContext())
            {
                //return db.Vehiculos.Include(x => x.Comentarios).ToList();
                return db.Vehiculos.ToList();
            }
        }

        public void Crear(Vehiculo vehiculo)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Vehiculos.Add(vehiculo);
                db.SaveChanges();
            }
        }

        public void Actualizar(String id, Vehiculo vehiculo)
        {
            using (var db = new ApplicationDbContext())
            {
                Vehiculo v = db.Vehiculos.Find(id);
                db.Vehiculos.Remove(v);
                db.Vehiculos.Add(vehiculo);
                db.SaveChanges();
            }
        }
    }
}