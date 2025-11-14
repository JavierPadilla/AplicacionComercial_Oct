using CADAplicacion;
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
    public partial class FrmCliente : Form
    {
        private int i=0;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAplicacionComercialxsd.TipoDocumento' table. You can move, or remove it, as needed.

            // rellena combobox TipoDocumento
            this.tipoDocumentoTableAdapter.Fill(this.dsAplicacionComercialxsd.TipoDocumento);
            //Rellena datagriv Clientes con el metodo get data  de la clase cad cliente.
            DgvClientes.DataSource = CADCliente.getData();
            //Llamar metodo para mostrar registros en texbox y otros

            MostrarRegistro();
        }

        private void MostrarRegistro()
        {
            if (DgvClientes.Rows.Count == 0) return;
            TxtIDCliente.Text = DgvClientes.Rows[i].Cells["IDCliente"].Value.ToString();
            TxtDocumento.Text = DgvClientes.Rows[i].Cells["Documento"].Value.ToString();
            TxtNombreComercial.Text = DgvClientes.Rows[i].Cells["NombreComercial"].Value.ToString();
            TxtNombreContacto.Text = DgvClientes.Rows[i].Cells["NombresContacto"].Value.ToString();
            TxtApellidosContacto.Text = DgvClientes.Rows[i].Cells["ApellidosContacto"].Value.ToString();
            TxtDireccion.Text = DgvClientes.Rows[i].Cells["Direccion"].Value.ToString();
            TxtTelefono1.Text = DgvClientes.Rows[i].Cells["Telefono1"].Value.ToString();
            TxtTelefono2.Text = DgvClientes.Rows[i].Cells["Telefono2"].Value.ToString();
            TxtCorreo.Text = DgvClientes.Rows[i].Cells["Correo"].Value.ToString();
            TxtNotas.Text = DgvClientes.Rows[i].Cells["Notas"].Value.ToString();
            CmbTipoDocumento.SelectedValue= DgvClientes.Rows[i].Cells["IDTipoDocumento"].Value;
            DtpAniversario.Value = Convert.ToDateTime(DgvClientes.Rows[i].Cells["Aniversario"].Value);
        }


    }
}
