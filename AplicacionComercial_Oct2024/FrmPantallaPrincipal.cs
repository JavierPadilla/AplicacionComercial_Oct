using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionComercial_Oct2024
{
    public partial class FrmPantallaPrincipal : Form
    {
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente formCliente = new FrmCliente();  
            formCliente.MdiParent=this;
            formCliente.Show();
        }

        private void FrmPantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores formProveedores=new FrmProveedores();
            formProveedores.MdiParent = this;
            formProveedores.Show();

        }



        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducts miFrmProductos = new FrmProducts();
            miFrmProductos.MdiParent = this;
            miFrmProductos.Show();
        }

        private void TsbClientes_Click(object sender, EventArgs e)
        {
            clientesToolStripMenuItem_Click(sender,e);

        }

        private void TsbProveedores_Click(object sender, EventArgs e)
        {
            proveedoresToolStripMenuItem_Click(sender,e);
        }

        private void TsbProductos_Click(object sender, EventArgs e)
        {
            productosToolStripMenuItem_Click(sender,e);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();

        }
    }
}
