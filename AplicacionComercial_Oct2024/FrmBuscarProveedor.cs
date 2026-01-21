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
    public partial class FrmBuscarProveedor : Form
    {
        private int idProveedor;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }

        public FrmBuscarProveedor()
        {
            InitializeComponent();
        }


        private void FrmBuscarProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dsAplicacionComercialxsd.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(dsAplicacionComercialxsd.Proveedor);
            this.KeyPreview = true;
            this.KeyDown += FrmBuscarProveedor_KeyDown;

        }

        private void FrmBuscarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                // CTRL + S
                fillByToolStripButton_Click(sender, e);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            Buscar();
            

        }

        private void Buscar()
        {
            try
            {
                this.proveedorTableAdapter.Buscar(this.dsAplicacionComercialxsd.Proveedor,
                                   "%" + nombreTextBox.Text + "%",
                                   "%" + documentoTextBox.Text + "%",
                                   "%" + nombresContactoTextBox.Text + "%",
                                   "%" + apellidosContactoTextBox.Text + "%");
                             
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // borrar datos en cajas de textos
            nombreTextBox.Text = "";
            documentoTextBox.Text = "";
            nombresContactoTextBox.Text = "";
            apellidosContactoTextBox.Text = "";
            //regresar datagridview
            this.proveedorTableAdapter.Fill(dsAplicacionComercialxsd.Proveedor);
            nombreTextBox.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idProveedor = 0;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (proveedorDataGridView.Rows.Count == 0)
            {
                idProveedor = 0;
            }
            else
            {
                if (proveedorDataGridView.SelectedRows.Count != 0)
                {
                    idProveedor = (int)proveedorDataGridView.SelectedRows[0].Cells[0].Value;
                }
                else
                {
                    idProveedor = (int)proveedorDataGridView.Rows[0].Cells[0].Value;
                }
                this.Close();
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void nombresContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void documentoTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void apellidosContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
