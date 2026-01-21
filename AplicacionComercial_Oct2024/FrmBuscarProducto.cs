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
    public partial class FrmBuscarProducto : Form
    {
        private int idProducto;

        public int IdProducto { get => idProducto; set => idProducto = value; }

        public FrmBuscarProducto()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);

        }

        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dsAplicacionComercialxsd.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dsAplicacionComercialxsd.Producto);
            this.KeyPreview = true;
            this.KeyDown += FrmBuscarProducto_KeyDown;
        }

        private void fillByBuscarProductoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.FillByBuscarProducto(this.dsAplicacionComercialxsd.Producto,
                    "%" + descripcionToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idProducto = 0;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (productoDataGridView.Rows.Count == 0)
            {
                idProducto = 0;
            }
            else
            {
                if (productoDataGridView.SelectedRows.Count != 0)
                {
                    idProducto = (int)productoDataGridView.SelectedRows[0].Cells[0].Value;
                }
                else
                {
                    idProducto = (int)productoDataGridView.Rows[0].Cells[0].Value;
                }
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.descripcionToolStripTextBox.Text = "";
            descripcionToolStripTextBox.Focus();
        }
        private void FrmBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                // CTRL + S
                fillByBuscarProductoToolStripButton_Click(sender, e);
            }
        }

        private void descripcionToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            fillByBuscarProductoToolStripButton_Click(sender, e);
        }
    }
}