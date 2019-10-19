using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EASY_PROGRAMING_PLATAFORM.Models
{
    public class Etapas
{
        [Key]
        public int Id_etapa { get; set; }
        [Required]
        public string nivel { get; set; }
}
}
