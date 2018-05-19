using RegistroLibro.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroLibro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Libros> Libro { get; set; }
        public Contexto(): base("ConStr")
        {    }
    }
}
