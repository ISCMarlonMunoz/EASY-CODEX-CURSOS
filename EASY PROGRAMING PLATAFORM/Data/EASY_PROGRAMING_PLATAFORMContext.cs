using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EASY_PROGRAMING_PLATAFORM.Models;

namespace EASY_PROGRAMING_PLATAFORM.Models
{
    public class EASY_PROGRAMING_PLATAFORMContext : DbContext
    {
        public EASY_PROGRAMING_PLATAFORMContext (DbContextOptions<EASY_PROGRAMING_PLATAFORMContext> options)
            : base(options)
        {
        }

        public DbSet<EASY_PROGRAMING_PLATAFORM.Models.Profesores> Profesores { get; set; }

        public DbSet<EASY_PROGRAMING_PLATAFORM.Models.Alumnos> Alumnos { get; set; }

        public DbSet<EASY_PROGRAMING_PLATAFORM.Models.Cursos> Cursos { get; set; }

        public DbSet<EASY_PROGRAMING_PLATAFORM.Models.Etapas> Etapas { get; set; }
    }
}
