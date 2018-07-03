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
            vehiculo.NumPlaca = "29920";
            vehiculo.Color = "Rojo";
            vehiculo.Marca = "Toyota";
            vehiculo.Estilo = "Land Rover";
            vehiculo.Anio = new DateTime(1987, 01, 01);
            vehiculo.Potencia = 500;
            vehiculo.Cilindraje = 1500;
            vehiculo.Capacidad = 4;
            vehiculo.Peso = 1200;
            vehiculo.NumChasis = 345;
            vehiculo.NumMotor = 1234;
            vehiculo.Observaciones = "Vehiculo en buenas condiciones";

            Vehiculo vehiculo2 = new Vehiculo();
            vehiculo2.NumPlaca = "48648";
            vehiculo2.Color = "Plateado";
            vehiculo2.Marca = "Mitsubishi";
            vehiculo2.Estilo = "Automovil";
            vehiculo2.Anio = new DateTime(2005, 01, 01);
            vehiculo2.Potencia = 400;
            vehiculo2.Cilindraje = 2500;
            vehiculo2.Capacidad = 5;
            vehiculo2.Peso = 1320;
            vehiculo2.NumChasis = 2349;
            vehiculo2.NumMotor = 2134;
            vehiculo2.Observaciones = "Vehiculo en buenas condiciones";

            Vehiculo vehiculo3 = new Vehiculo();
            vehiculo3.NumPlaca = "75654";
            vehiculo3.Color = "Rojo";
            vehiculo3.Marca = "Toyota";
            vehiculo3.Estilo = "Jeep";
            vehiculo3.Anio = new DateTime(2005, 01, 01);
            vehiculo3.Potencia = 400;
            vehiculo3.Cilindraje = 2500;
            vehiculo3.Capacidad = 5;
            vehiculo3.Peso = 1320;
            vehiculo3.NumChasis = 2349;
            vehiculo3.NumMotor = 2134;
            vehiculo3.Observaciones = "Vehiculo en buenas condiciones";

            Vehiculo vehiculo4 = new Vehiculo();
            vehiculo4.NumPlaca = "9574734";
            vehiculo4.Color = "Amarillo";
            vehiculo4.Marca = "Nisaan";
            vehiculo4.Estilo = "Centra";
            vehiculo4.Anio = new DateTime(2005, 01, 01);
            vehiculo4.Potencia = 400;
            vehiculo4.Cilindraje = 2500;
            vehiculo4.Capacidad = 5;
            vehiculo4.Peso = 1320;
            vehiculo4.NumChasis = 2349;
            vehiculo4.NumMotor = 2134;
            vehiculo4.Observaciones = "Vehiculo en buenas condiciones";

            context.Vehiculos.AddOrUpdate(x => x.NumPlaca, vehiculo);
            context.Vehiculos.AddOrUpdate(x => x.NumPlaca, vehiculo2);
            context.Vehiculos.AddOrUpdate(x => x.NumPlaca, vehiculo3);
            context.Vehiculos.AddOrUpdate(x => x.NumPlaca, vehiculo4);*/
        }
    }
}
