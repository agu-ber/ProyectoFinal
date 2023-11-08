using ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmProducto : FrmBase
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            //txtIdProducto.Text = FrmPrincipal.IdProducto;
            //if (txtIdProducto.Text != "")
            //{
            //    Int32 codproducto = Convert.ToInt32(txtIdProducto.Text);
            //    Producto prod = new Producto();
            //    DataTable dt = prod.BuscarPorID(idproducto);
            //    txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
            //    txtPrecio.Text = dt.Rows[0]["Precio"].ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }

            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio");
                return;
            }

            int idproducto = 0;
            string nombre = "";
            string codbarra = "";
            double precio = 0;
            int stock = 0;

            nombre = txtNombre.Text;
            precio = Convert.ToDouble(txtPrecio.Text);
            codbarra = txtCodBarra.Text;
            if (txtStock.Text != "")
            {
                stock = Convert.ToInt32(txtStock.Text);
            }

            Producto Pro = new Producto();
            if (txtIdProducto.Text == "")
            {
                Pro.Insertar(nombre, precio, codbarra, stock);
            }
            else
            {
                idproducto = Convert.ToInt32(txtIdProducto.Text);
                Pro.Modificar(idproducto, nombre, codbarra, precio, stock);
            }
            MessageBox.Show("Producto registrado correctamente");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCodBarra.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
