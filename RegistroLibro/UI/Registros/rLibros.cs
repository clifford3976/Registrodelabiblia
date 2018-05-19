using RegistroLibro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroLibro.UI.Registros
{
    public partial class rLibros : Form
    {
        public rLibros()
        {
            InitializeComponent();
        }


        public bool Validar()
        {

            if (string.IsNullOrEmpty(DescripcionrichTextBox.Text))
            {
                errorProvider1.SetError(DescripcionrichTextBox, "llenar");
                return false;
            }
            if (string.IsNullOrEmpty(SiglastextBox.Text))
            {
                errorProvider1.SetError(SiglastextBox, "llenar");
                return false;
            }
            return true;
        }

        private Libros LLenaClase()
        {
            Libros Libro = new Libros();
            Libro.TipoId = Convert.ToInt32(TipoIDnumericUpDown.Value);
            Libro.LibroId = Convert.ToInt32(LibroIdnumericUpDown.Value);
            Libro.Descripcion = DescripcionrichTextBox.Text;
            Libro.Siglas = SiglastextBox.Text;

            return Libro;
        }

        private void rLibros_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            TipoIDnumericUpDown.Value = 0;
            LibroIdnumericUpDown.Value = 0;
            DescripcionrichTextBox.Clear();
            SiglastextBox.Clear();
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            {
                if (!Validar())
                {
                    MessageBox.Show("llenar", "y trate de guardar de nuevo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    Libros Libro = LLenaClase();
                    bool paso = false;

                    if (TipoIDnumericUpDown.Value == 0)
                    {
                        paso = BLL.LibrosBLL.Guardar(Libro);
                    }
                    else
                    {
                        paso = BLL.LibrosBLL.Modificar(Libro);
                    }
                   
                    if (paso)
                    {
                        MessageBox.Show("guardado", "se guardo exitosamente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }


        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TipoIDnumericUpDown.Value);
            Libros Libro = BLL.LibrosBLL.Buscar(id);

            if (Libro != null)
            {
                DescripcionrichTextBox.Text = Libro.Descripcion;
                SiglastextBox.Text = Libro.Siglas;
                LibroIdnumericUpDown.Value = Libro.LibroId;
            }
            else
            {
                MessageBox.Show("no encontrado", "Buscar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(TipoIDnumericUpDown.Value);
            if (BLL.LibrosBLL.Eliminar(id))
                MessageBox.Show("fue eliminado", "acceptado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    
        private void DescripcionrichTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
