using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmCliente : FrmBase
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            string sql = "select * from cliente";
            Database.Select(sql);
            cargarBarrios();
        }

        private void cargarBarrios()
        {
            Barrio b = new Barrio();
            DataTable tb = b.getbarrios();
            cmbBarrio.DataSource = tb;
            cmbBarrio.DisplayMember = "nombre";
            cmbBarrio.ValueMember = "idbarrio";
            cmbBarrio.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un apellido");
                return;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe ingresar un telefono");
                return;
            }
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Debe ingresar un documento");
                return;
            }

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;
            string documento = txtDocumento.Text;
            int codbarrio = Convert.ToInt32(cmbBarrio.SelectedValue);
            Cliente cli = new Cliente();
            cli.Insertar(nombre, apellido, telefono, documento, codbarrio);
            MessageBox.Show("Datos guardados correctamente");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
            cmbBarrio.Text = "";
        }
    }
}