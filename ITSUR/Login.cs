using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Datos;
using Modelos;
//using MySql.Data.MySqlClient;



namespace ITSUR
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DAOUsuario login = new DAOUsuario();
           
           
            if (login.validarUsuario(txtUsuario.Text.ToString(), txtPassword.Text.ToString()))
            {
                Inicio inicio = new Inicio();
                this.Hide();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contrasela incorrectos");
            }
        }
    }
}
