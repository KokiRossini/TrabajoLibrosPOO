using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoLibrosPOO.Entidades
{
    public class Libro:ICloneable
    {
        public string Nombre { get; set; }
        public Editoriales Editorial { get; set; }
        public Temas Tema { get; set; }
        public int Paginas { get; set; }
        public int ISBN { get; set; }
        public string Autor { get; set; }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is Libro))
            {
                return false;
            }
            return this.ISBN == ((Libro)obj).ISBN;
        }

        public override int GetHashCode()
        {
            return ISBN.GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Libro()
        {

        }
    }
}
