
using System;
using System.ComponentModel.DataAnnotations;

namespace CampusTech.Models
{
    public class Reservations
    {
        [Required]
        [MinLength(3)]
        public string NombreProfesor { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@campus\.edu$", ErrorMessage = "Debe ser correo institucional @campus.edu")]
        public string Correo { get; set; }

        [Required]
        [RegularExpression(@"^(Lab-01|Lab-02|Lab-03|Lab-Redes|Lab-IA)$")]
        public string Laboratorio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaReserva { get; set; }

        [Required]
        public string HoraInicio { get; set; }

        [Required]
        public string HoraFin { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string Motivo { get; set; }

        [Required]
        [RegularExpression(@"^RES-\d{3}$")]
        public string CodigoReserva { get; set; }
    }
}
