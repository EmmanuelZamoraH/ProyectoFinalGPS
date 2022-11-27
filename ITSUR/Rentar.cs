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
    public partial class Rentar : Form
    {
        
        public Rentar()
        {
            InitializeComponent();
            cargarLista();
        }

        private void cargarLista()
        {
            DataTable resultado = new DAORegistro().obtenerTodas();
            dgvRegistro.DataSource = resultado;
        }

        private Registro llenarDatos()
        {
            Registro registro = new Registro();
            registro.NUMCONTROL = txtNumControl.Text.ToString();
            registro.NombreAlumno = txtNombreAlumno.Text.ToString();
            registro.Apellido = txtApellidos.Text.ToString();
            registro.Carrera = cbCarrera.SelectedItem.ToString();
            registro.Id_Libro = int.Parse(cbLibro.SelectedItem.ToString());
            registro.Fecha = dtpFecha.Value;
            return registro;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DAORegistro registro = new DAORegistro();
            registro.insertar(llenarDatos());
            DataTable resultado = new DAORegistro().obtenerTodas();
            dgvRegistro.DataSource = resultado;
        }

            private void button2_Click(object sender, EventArgs e)
        {
            Form regresar = new Inicio();
            this.Hide();
            regresar.Show();
        }
    }
}
