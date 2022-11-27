using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSUR
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnRentar_Click(object sender, EventArgs e)
        {
            Form formulario = new Rentar();
            this.Hide();
            formulario.Show();
        }

        private void btnCatalgo_Click(object sender, EventArgs e)
        {
            Form formulario = new Catalogo();
            this.Hide();
            formulario.Show();
        }
    }
}
