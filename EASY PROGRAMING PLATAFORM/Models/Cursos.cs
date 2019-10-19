using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EASY_PROGRAMING_PLATAFORM.Models
{
    public class Cursos
{
        [Key]
        public int Id_curso { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string lenguaje_programacion { get; set; }
    }
}
