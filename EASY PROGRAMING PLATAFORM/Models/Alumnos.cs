using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EASY_PROGRAMING_PLATAFORM.Models
{
    public class Alumnos
    {
        [Key]
        public int Id_alumno { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string correo_electronico { get; set; }

    }
}
