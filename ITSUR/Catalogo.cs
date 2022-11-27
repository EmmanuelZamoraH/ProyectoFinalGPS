using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Modelos;

namespace ITSUR
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
            cargarLista();
        }

        private void cargarLista()
        {
            DataTable resultado = new DAOLibro().obtenerTodas();
            dgvLibros.DataSource = resultado;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form regresar = new Inicio();
            this.Hide();
            regresar.Show();
        }

        private void btnAgregarLi_Click(object sender, EventArgs e)
        {
            Form mostrar = new Agregar();
            this.Hide();
            mostrar.Show();
        }

        private void btnEliminarLi_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                String NombreLibro  = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();
  
                DialogResult respuesta = MessageBox.Show(this, "¿Estás seguro de que quieres eliminar al libro " +
                    NombreLibro +"?", "Eliminación de libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    DAOLibro dao = new DAOLibro();
                    if (dao.eliminar(NombreLibro))
                    {
                        MessageBox.Show("Libro eliminado");
                        cargarLista();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona al alumno que deseas eliminar");
            }
        }

        private void btnModificarLi_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                String NombreLibro = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();
                Agregar form = new Agregar(NombreLibro);
                form.ShowDialog();
                cargarLista();
            }
            else
            {
                MessageBox.Show("Selecciona al alumno que deseas editar");
            }
        }
    }
}
