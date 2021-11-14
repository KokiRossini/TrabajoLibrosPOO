using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoLibrosPOO.Entidades;

namespace TrabajoLibrosPOO.Datos
{
    public class RepositorioDeLibros
    {
        private List<Libro> ListaDeLibros;
        private readonly string _Archivo = Environment.CurrentDirectory + @"\Libros.txt";
        private readonly string _ArchivoBak = Environment.CurrentDirectory + @"\Libros.bak";

        public RepositorioDeLibros()
        {
            ListaDeLibros = new List<Libro>();
            LeerDatosDelArchivo();
        }

        private void LeerDatosDelArchivo()
        {
            if (File.Exists(_Archivo))
            {
                StreamReader lector = new StreamReader(_Archivo, true);
                while (!lector.EndOfStream)
                {
                    var linea = lector.ReadLine();
                    Libro l = ConstruirLibro(linea);
                    ListaDeLibros.Add(l);
                }
                lector.Close();
            }
        }

        private Libro ConstruirLibro(string linea)
        {
            var campos = linea.Split('|');
            return new Libro
            {
                Nombre = campos[0],
                Editorial = (Editoriales)int.Parse(campos[1]),
                Tema = (Temas)int.Parse(campos[2]),
                Paginas = int.Parse(campos[3]),
                ISBN = int.Parse(campos[4]),
                Autor = campos[5]
            };
        }

        public int GetCantidad()
        {
            return ListaDeLibros.Count;
        }

        public List<Libro> GetLista()
        {
            return ListaDeLibros;
        }

        public bool Existe(Libro libro)
        {
            return ListaDeLibros.Contains(libro);
        }

        public void Agregar(Libro libro)
        {
            ListaDeLibros.Add(libro);
            AgregarEnArchivo(libro);
        }

        private void AgregarEnArchivo(Libro libro)
        {
            StreamWriter escritor = new StreamWriter(_Archivo, true);
            var linea = ConstruirLinea(libro);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(Libro libro)
        {
            return $"{libro.Nombre}|{libro.Editorial.GetHashCode()}|{libro.Tema.GetHashCode()}|{libro.Paginas}|{libro.ISBN}|{libro.Autor}";
        }

        public void Borrar(Libro libro)
        {
            ListaDeLibros.Remove(libro);
            BorrarDatoDelArchivo(libro);
        }

        private void BorrarDatoDelArchivo(Libro libro)
        {
            StreamReader lector = new StreamReader(_Archivo);
            StreamWriter escrtitor = new StreamWriter(_ArchivoBak);
            while (!lector.EndOfStream)
            {
                var linea = lector.ReadLine();
                Libro libroEnArchivo = ConstruirLibro(linea);
                if (!libroEnArchivo.Equals(libro))
                {
                    escrtitor.WriteLine(linea);
                }
            }
            escrtitor.Close();
            lector.Close();
            File.Delete(_Archivo);
            File.Move(_ArchivoBak, _Archivo);
        }

        public void Editar(Libro libroBuscado, Libro libroModificado)
        {
            StreamReader lector = new StreamReader(_Archivo);
            StreamWriter escritor = new StreamWriter(_ArchivoBak);
            while (!lector.EndOfStream) 
            {
                var linea = lector.ReadLine();
                var libroEnArchivo = ConstruirLibro(linea);
                if (libroEnArchivo.Equals(libroBuscado))
                {
                    linea = ConstruirLinea(libroModificado);
                }
                escritor.WriteLine(linea);
            }
            escritor.Close();
            lector.Close();
            File.Delete(_Archivo);
            File.Move(_ArchivoBak, _Archivo);
        }

        public List<Libro> GetListaFiltrada(Func<Libro, bool> predicado)
        {
            return ListaDeLibros.Where(predicado).ToList();
        }

        public List<Libro> GetListaPaginasAsc()
        {
            return ListaDeLibros.OrderBy(p => p.Paginas).ToList();
        }

        public List<Libro> GetListaPaginasDesc()
        {
            return ListaDeLibros.OrderByDescending(p => p.Paginas).ToList();
        }

    }
}
