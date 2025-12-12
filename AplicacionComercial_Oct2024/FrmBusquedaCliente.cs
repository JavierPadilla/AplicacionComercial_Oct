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
    public partial class FrmBusquedaCliente : Form
    {
        private int idCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }

        public FrmBusquedaCliente()
        {
            InitializeComponent();
        }



        private void FrmBusquedaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dsAplicacionComercialxsd.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.dsAplicacionComercialxsd.Cliente);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();

        }

        private void Buscar()
        {
            this.clienteTableAdapter.BuscarCliente(this.dsAplicacionComercialxsd.Cliente,
      "%" + nombreComercialTextBox.Text.ToUpper() + "%",
      "%" + nombresContactoTextBox.Text.ToUpper() + "%",
      "%" + apellidosContactoTextBox.Text.ToUpper() + "%",
      "%" + correoTextBox.Text.ToUpper() + "%");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idCliente = 0;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (clienteDataGridView.Rows.Count == 0)
            {
                idCliente = 0;
            }
            else
            {
                if (clienteDataGridView.SelectedRows.Count != 0)
                {
                    idCliente = (int)clienteDataGridView.SelectedRows[0].Cells[0].Value;
                }
                else
                {
                    idCliente = (int)clienteDataGridView.Rows[0].Cells[0].Value;
                }
                this.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nombreComercialTextBox.Text = "";
            nombresContactoTextBox.Text = "";
            apellidosContactoTextBox.Text = "";
            correoTextBox.Text = "";
            this.clienteTableAdapter.Fill(this.dsAplicacionComercialxsd.Cliente);
            nombreComercialTextBox.Focus();

        }

        private void nombreComercialTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void correoTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void nombresContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void apellidosContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
