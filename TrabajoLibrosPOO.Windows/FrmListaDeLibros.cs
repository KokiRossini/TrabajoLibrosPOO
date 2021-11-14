using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoLibrosPOO.Datos;
using TrabajoLibrosPOO.Entidades;

namespace TrabajoLibrosPOO.Windows
{
    public partial class FrmListaDeLibros : Form
    {
        public FrmListaDeLibros()
        {
            InitializeComponent();
        }
        private RepositorioDeLibros repositorio;
        private void SalirToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NuevoToolStripButton_Click(object sender, EventArgs e)
        {
            FrmEditListaDeLibros frm = new FrmEditListaDeLibros();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Libro libro = frm.GetLibro();
                if (!repositorio.Existe(libro))
                {
                    repositorio.Agregar(libro);
                    DataGridViewRow r = CrearFila();
                    SetearFilas(r, libro);
                    AgregarFila(r);

                    MessageBox.Show("Registro Agregado", "mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarCantidadDeRegistros();
                }
                else
                {
                    MessageBox.Show("libro repetido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
        private void AgregarFila(DataGridViewRow r)
        {
            DatosDataGridView.Rows.Add(r);
        }

        private void SetearFilas(DataGridViewRow r, Libro libro)
        {
            r.Cells[colNombre.Index].Value = libro.Nombre;
            r.Cells[colEditorial.Index].Value = libro.Editorial;
            r.Cells[colTema.Index].Value = libro.Tema;
            r.Cells[colPaginas.Index].Value = libro.Paginas;
            r.Cells[colIsbn.Index].Value = libro.ISBN;
            r.Cells[colAutor.Index].Value = libro.Autor;

            r.Tag = libro;
        }

        private DataGridViewRow CrearFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(DatosDataGridView);
            return r;
        }

        private void FrmListaDeLibros_Load(object sender, EventArgs e)
        {
            repositorio = new RepositorioDeLibros();
            repositorio.GetCantidad();
            if (repositorio.GetCantidad() > 0)
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros();
            }
        }

        private void ActualizarCantidadDeRegistros()
        {
            var contador = repositorio.GetCantidad();

            ContadorRegistrosLabel.Text = contador.ToString();
        }


        private List<Libro> lista;



        private void MostrarDatosEnGrilla()
        {
            DatosDataGridView.Rows.Clear();
            foreach (var libro in lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(DatosDataGridView);
                SetearFilas(r, libro);
                AgregarFila(r);
            }
        }

        private void BorrarToolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count>0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                Libro libro = (Libro)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea Borrar el Registro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr==DialogResult.No)
                {
                    return;
                }
                repositorio.Borrar(libro);
                DatosDataGridView.Rows.Remove(r);
                MessageBox.Show("Registro borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarCantidadDeRegistros();
            }
        }

        private void EditarToolStripButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            Libro libro = (Libro)r.Tag;
            Libro librocopia = (Libro)libro.Clone();
            FrmEditListaDeLibros frm = new FrmEditListaDeLibros() { Text = "Editar" };
            frm.SetLibro(librocopia);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.OK)
            {
                librocopia = frm.GetLibro();
                if (repositorio.Existe(librocopia))
                {
                    SetearFilas(r, libro);
                    MessageBox.Show("esfera repetida", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                repositorio.Editar(libro, librocopia);
                SetearFilas(r, librocopia);
                MessageBox.Show("Regisrto editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void alicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Editorial == Editoriales.Alicion;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }


        private void empersandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Editorial == Editoriales.Empersand;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }

        private void atlantidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Editorial == Editoriales.Atlantida;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }

        private void ayarmanotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Editorial == Editoriales.Ayarmanot;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }

        private void corregidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Editorial == Editoriales.Corregidor;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }

        private void dunkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Editorial == Editoriales.Dunken;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }

        private void filosofiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Tema == Temas.Filosofia;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }

        private void cienciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Tema == Temas.Ciencias;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }

        private void economiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Tema == Temas.Economia;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }

        private void informaticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Tema == Temas.Informatica;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
        }

        private void literaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Libro, bool> predicado = p => p.Tema == Temas.Literatura;
            lista = repositorio.GetListaFiltrada(predicado);
            MostrarDatosEnGrilla();
            ActualizarCantidadDeRegistros();
        }

        private void paginasAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaPaginasAsc();
            MostrarDatosEnGrilla();
        }

        private void paginasDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.GetListaPaginasDesc();
            MostrarDatosEnGrilla();
        }

        private void ActualizarToolStripButton_Click(object sender, EventArgs e)
        {
            if (repositorio.GetCantidad() > 0)
            {
                lista = repositorio.GetLista();
                MostrarDatosEnGrilla();
                ActualizarCantidadDeRegistros();
            }
        }
    }
}
