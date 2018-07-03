namespace LaboratorioDotNetB36630.Migrations
{
    using LaboratorioDotNetB36630.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LaboratorioDotNetB36630.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LaboratorioDotNetB36630.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /*Vehiculo vehiculo = new Vehiculo();
            vehiculo.NumPlaca = "12345";
            vehiculo.Color = "Negro";
            vehiculo.Marca = "Sedane";
            vehiculo.Estilo = "Convertible";
            vehiculo.Anio = new DateTime(2010, 01, 01);
            vehiculo.Potencia = 500;
            vehiculo.Cilindraje = 1500;
            vehiculo.Capacidad = 4;
            vehiculo.Peso = 1200;
            vehiculo.NumChasis = 345;
            vehiculo.NumMotor = 1234;
            vehiculo.Observaciones = "Vehiculo en buenas condiciones";

            Vehiculo vehiculo2 = new Vehiculo();
            vehiculo2.NumPlaca = "23476";
            vehiculo2.Color = "Negro";
            vehiculo2.Marca = "Susuky";
            vehiculo2.Estilo = "4x4";
            vehiculo2.Anio = new DateTime(2000, 01, 01);
            vehiculo2.Potencia = 400;
            vehiculo2.Cilindraje = 2500;
            vehiculo2.Capacidad = 5;
            vehiculo2.Peso = 1320;
            vehiculo2.NumChasis = 2349;
            vehiculo2.NumMotor = 2134;
            vehiculo2.Observaciones = "Vehiculo en buenas condiciones";

            context.Vehiculos.AddOrUpdate(x => x.NumPlaca, vehiculo);
            context.Vehiculos.AddOrUpdate(x => x.NumPlaca, vehiculo2);*/
        }
    }
}
