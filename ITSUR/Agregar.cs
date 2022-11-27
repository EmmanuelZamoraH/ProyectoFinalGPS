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
    public partial class Agregar : Form
    {
        private String NombreAutor;
        public Agregar()
        {
            InitializeComponent();
        }

        private Libro llenarDatos()
        {
            Libro libro = new Libro();
            libro.NombreLibro = txtNombLibro.Text.ToString();
            libro.NombreAutor = txtNombAutor.Text.ToString();
            libro.Categoria = cbCategoria.SelectedItem.ToString();
            return libro;
        }

        public Agregar(String NombreLibro) : this()
        {
            this.Text = "Editar libro " + NombreLibro;
            //Cargar el noControl en la variable local
            this.NombreAutor = NombreLibro;
            //Cargar la info del alumno
            DAOLibro dao = new DAOLibro();
            Libro libro = dao.obtenerUno(NombreLibro);
            //Llenar los datos del alumno
            txtNombLibro.Text = NombreLibro;
            txtNombAutor.Text = libro.NombreAutor;
            cbCategoria.SelectedValue = libro.Categoria;
        }

        private void btnAgregarLib_Click(object sender, EventArgs e)
        {
            DAOLibro registro = new DAOLibro();
            registro.insertar(llenarDatos());
            Form regresar = new Catalogo();
            this.Hide();
            regresar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form regresar = new Catalogo();
            this.Hide();
            regresar.Show();
        }
    }
}

