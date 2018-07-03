using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LaboratorioDotNetB36630.Models
{
    public class Vehiculo
    {
        public Vehiculo()
        {
        }

        [Key]
        public string NumPlaca { get; set; }

        [Required]
        [StringLength(200)]
        public string Color { get; set; }

        [Required]
        [StringLength(200)]
        public string Marca { get; set; }

        [Required]
        [StringLength(200)]
        public string Estilo { get; set; }

        [Required]
        public DateTime Anio { get; set; }

        [Required]
        public int Potencia { get; set; }

        [Required]
        public int Cilindraje { get; set; }

        [Required]
        public int Capacidad { get; set; }

        [Required]
        public int Peso { get; set; }

        [Required]
        public int NumChasis { get; set; }

        [Required]
        public int NumMotor { get; set; }

        public string Observaciones { get; set; }


        //En Marca
        //public List<Vehiculo> Vehiculos;
        //
        //En Vehiculo
        //public int MarcaId { get; set; }
        //[ForeignKey("MarcaId")]
        //public Marca Marca { get; set; }
    }
}