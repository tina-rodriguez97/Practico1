using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1
{
    public partial class MiPrimerForm : Form
    {
        public MiPrimerForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;

            String nombreCompleto = nombre + " " + apellido;

            txtMuestra.Text = nombreCompleto;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtMuestra.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
