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
    public partial class FrmEditListaDeLibros : Form
    {
        public FrmEditListaDeLibros()
        {
            InitializeComponent();
        }
        private Libro libro;
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (libro==null)
                {
                    libro = new Libro();
                }
                libro.Nombre = NombreTextBox.Text;
                libro.Editorial = (Editoriales) EditorialComboBox.SelectedItem;
                libro.Tema = (Temas)TemaComboBox.SelectedItem;
                libro.Paginas = int.Parse(PaginasTextBox.Text);
                libro.ISBN = int.Parse(IsbnTextBox.Text);
                libro.Autor = AutorTextBox.Text;

                DialogResult = DialogResult.OK;



            }
        }

        public Libro GetLibro()
        {
            return libro;
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (NombreTextBox.TextLength<=0)
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese un nombre valido");
                esValido = false;
            }
            else if (!int.TryParse(PaginasTextBox.Text, out int paginas) || paginas<=0)
            {
                errorProvider1.SetError(PaginasTextBox, "Ingrese una cantidad de paginas valida");
                esValido = false;
            }
            else if (!int.TryParse(IsbnTextBox.Text, out int isbn) || isbn<=0)
            {
                errorProvider1.SetError(IsbnTextBox, "Ingrese un numero de ISBN valido");
                esValido = false;
            }
            else if (AutorTextBox.TextLength<=0)
            {
                errorProvider1.SetError(AutorTextBox, "Ingrese un nombre valido");
                esValido = false;
            }
            return esValido;
        }

        private void FrmEditListaDeLibros_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboBox(ref EditorialComboBox, ref TemaComboBox);
        }

        private void CargarDatosComboBox(ref ComboBox editoriales, ref ComboBox temas)
        {
            editoriales.DataSource = Enum.GetValues(typeof(Editoriales));
            temas.DataSource = Enum.GetValues(typeof(Temas));
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        internal void SetLibro(Libro librocopia)
        {
            this.libro = librocopia;
        }
    }
}
