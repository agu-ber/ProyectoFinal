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
    public partial class FrmPrincipal : Form
    {
        public static string idProducto;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ConsultaProducto(object sender, EventArgs e)
        {
            FrmConsultaProducto childForm = new FrmConsultaProducto();
            childForm.MdiParent = this;
            childForm.Text = "Consulta de producto";
            childForm.Show();
        }

        private void NuevoCliente(object sender, EventArgs e)
        {
            FrmCliente childForm = new FrmCliente();
            childForm.MdiParent = this;
            childForm.Text = "Cliente";
            childForm.Show();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
