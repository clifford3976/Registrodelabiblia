using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace RegistroLibro.Entidades
{
    public class Libros
    {
        [Key]
        public int TipoId { get; set; }
        public int LibroId { get; set; }
        public string Descripcion { get; set; }
        public string Siglas { get; set; }

        public Libros()
        {
            TipoId = 0;
            LibroId = 0;
            Descripcion = string.Empty;
            Siglas = string.Empty;
        }
    }
}
