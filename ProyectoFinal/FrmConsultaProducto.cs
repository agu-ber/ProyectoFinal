﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Clases;

namespace ProyectoFinal
{
    public partial class FrmConsultaProducto : FrmBase
    {
        public FrmConsultaProducto()
        {
            InitializeComponent();
        }

        private void FrmConsultaProducto_Load(object sender, EventArgs e)
        {
            string sql = "select * from producto";
            DataTable tbproducto = Database.Select(sql);
            grdProducto.DataSource = tbproducto;
            grdProducto.Columns[0].Visible = false;
            grdProducto.Columns[1].Width = 200;
            grdProducto.Columns[2].Width = 100;
            grdProducto.Columns[3].Width = 250;
        }

        private void txtCodBarra_TextChanged(object sender, EventArgs e)
        {
            string codigo = txtCodBarra.Text;
            Producto pro = new Producto();
            DataTable tabla = pro.BuscarPorCodBarra(codigo);
            grdProducto.DataSource = tabla;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            Producto producto = new Producto();
            DataTable tbproducto = producto.Buscar(nombre);
            grdProducto.DataSource = tbproducto;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPrincipal.idProducto = "";
            FrmProducto frm = new FrmProducto();
            frm.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string codigo = grdProducto.CurrentRow.Cells[0].Value.ToString();
            FrmPrincipal.idProducto = codigo;
            FrmProducto frm = new FrmProducto();
            frm.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = grdProducto.SelectedCells[0].RowIndex;
            int selectedColumnIndex = grdProducto.SelectedCells[0].ColumnIndex;
            string cellText = grdProducto.Rows[selectedRowIndex].Cells[selectedColumnIndex].Value.ToString();

            var resultado = MessageBox.Show("Está a punto de eliminar el producto " + cellText + ", ¿desea continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            int codigo = Convert.ToInt32(grdProducto.CurrentRow.Cells[0].Value.ToString());
            Producto pro = new Producto();
            pro.Eliminar(codigo);
            string nombre = txtNombre.Text;
            Producto producto = new Producto();
            DataTable tbproducto = producto.Buscar(nombre);
            grdProducto.DataSource = tbproducto;
            MessageBox.Show("El producto se ha eliminado correctamente");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
