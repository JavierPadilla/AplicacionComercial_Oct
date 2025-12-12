using AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters;
using CADAplicacion;
using CADAplicacion.DsAplicacionComercialTableAdapters;
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
        bool Nuevo = false;
      
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
            
            try
            {
                DtpAniversario.Value = Convert.ToDateTime(DgvClientes.Rows[i].Cells["Aniversario"].Value);

            }
            catch (Exception)
            {
                DtpAniversario.Value = DateTime.Now;

            }
           
            DgvClientes.Rows[i].Selected = true;
        }

        private void TsbPrimero_Click(object sender, EventArgs e)
        {
            i = 0;
            MostrarRegistro();

        }

        private void TsbAnterior_Click(object sender, EventArgs e)
        {
            if (i == 0) return;
            i--;
            MostrarRegistro();
        }

        private void TsbSiguiente_Click(object sender, EventArgs e)
        {
            if (i >= DgvClientes.Rows.Count) return;
            i++;
            MostrarRegistro();
        }

        private void TsbUltimo_Click(object sender, EventArgs e)
        {
            i = DgvClientes.Rows.Count-1;
            MostrarRegistro();

        }

        private void TsbModificar_Click(object sender, EventArgs e)
        {
            Nuevo = false;
            HabilitarCampos();
           
        }

        private void HabilitarCampos()
        {
            TsbPrimero.Enabled = false;
            TsbAnterior.Enabled = false;
            TsbSiguiente.Enabled = false;
            TsbUltimo.Enabled = false;
            TsbModificar.Enabled = false;
            TsbNuevo.Enabled = false;
            TsbEliminar.Enabled = false;
            TsbBuscar.Enabled = false;
            TsbGuardar.Enabled = true;
            TsbCancelar.Enabled = true;

            TxtDocumento.ReadOnly = false;
            TxtNombreComercial.ReadOnly = false;
            TxtNombreContacto.ReadOnly = false;
            TxtApellidosContacto.ReadOnly=false;
            TxtDireccion.ReadOnly = false;
            TxtTelefono1.ReadOnly = false;
            TxtTelefono2.ReadOnly = false;
            TxtNotas.ReadOnly = false;
            TxtCorreo.ReadOnly = false;
            DtpAniversario.Enabled = true;
            CmbTipoDocumento.Enabled = true;

            CmbTipoDocumento.Focus();

        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {

            DeshabilitarCampos();
            MostrarRegistro();
            
        }

        private bool ValidarCampos()
        {
           if (CmbTipoDocumento.SelectedIndex == -1)
            {
                errorProvider1.SetError(CmbTipoDocumento, "Debe seleccionar un tipo de documento ");
                CmbTipoDocumento.Focus();
                return false;
            }
            errorProvider1.SetError(CmbTipoDocumento, "");

            if (TxtDocumento.Text=="")
            {
                errorProvider1.SetError(TxtDocumento, "Introduzca el número de documento");
                TxtDocumento.Focus();
                return false;
            }
            errorProvider1.SetError(TxtDocumento, "");

            if (TxtNombreComercial.Text == "")
            {
                errorProvider1.SetError(TxtNombreComercial, "Cuál es el NOMBRE COMERCIAL del cliente :");
                TxtNombreComercial.Focus();
                return false;
            }
            errorProvider1.SetError(TxtNombreComercial, "");

            if (TxtNombreContacto.Text == "")
            {
                errorProvider1.SetError(TxtNombreContacto, "Cuál es el NOMBRE de Contacto :");
                TxtNombreContacto.Focus();
                return false;
            }
            errorProvider1.SetError(TxtNombreContacto, "");

            if (TxtApellidosContacto.Text == "")
            {
                errorProvider1.SetError(TxtApellidosContacto, "Cuáles son los APELLIDOS del Contacto :");
                TxtApellidosContacto.Focus();
                return false;
            }
            errorProvider1.SetError(TxtApellidosContacto, "");

            if (TxtDireccion.Text == "")
            {
                errorProvider1.SetError(TxtDireccion, "Cuál es la DIRECCIÓN de la empresa o Cliente :");
                TxtDireccion.Focus();
                return false;
            }
            errorProvider1.SetError(TxtDireccion, "");


            if (DtpAniversario.Value==null)
            {
                errorProvider1.SetError(DtpAniversario, "Cuál es el ANIVERSARIO de la empresa o Cliente :");
                DtpAniversario.Focus();
                return false;
            }
            errorProvider1.SetError(DtpAniversario, "");

            if (TxtCorreo.Text != "")
            {
                RegexUtilities regexUtilities = new RegexUtilities();
                if (!regexUtilities.IsValidEmail(TxtCorreo.Text))
                {
                    errorProvider1.SetError(TxtCorreo, "Debe ingresar un CORREO VALIDO ");
                    TxtCorreo.Focus();
                    return false;
                }
                errorProvider1.SetError(TxtCorreo, "");
               
            }
            return true;
        }

        private void DeshabilitarCampos()
        {
            TsbPrimero.Enabled = true;
            TsbAnterior.Enabled = true;
            TsbSiguiente.Enabled = true;
            TsbUltimo.Enabled = true;
            TsbModificar.Enabled = true;
            TsbNuevo.Enabled = true;
            TsbEliminar.Enabled = true;
            TsbBuscar.Enabled = true;
            TsbGuardar.Enabled = false;
            TsbCancelar.Enabled = false;

            TxtDocumento.ReadOnly = true;
            TxtNombreComercial.ReadOnly = true;
            TxtNombreContacto.ReadOnly = true;
            TxtApellidosContacto.ReadOnly = true;
            TxtDireccion.ReadOnly = true;
            TxtTelefono1.ReadOnly = true;
            TxtTelefono2.ReadOnly = true;
            TxtNotas.ReadOnly = true;
            TxtCorreo.ReadOnly = true;
            DtpAniversario.Enabled = false;
            CmbTipoDocumento.Enabled = false;

            MostrarRegistro();
        }

        private void TsbNuevo_Click(object sender, EventArgs e)
        {
            Nuevo = true;
            HabilitarCampos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            TxtIDCliente.Text = "";
            TxtDocumento.Text = "";
            TxtNombreComercial.Text = "";
            TxtNombreContacto.Text = "";
            TxtApellidosContacto.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono1.Text = "";
            TxtTelefono2.Text = "";
            TxtNotas.Text = "";
            TxtCorreo.Text = "";
            DtpAniversario.Value=DateTime.Now;
            CmbTipoDocumento.SelectedIndex = -1;
        }

        private void TsbGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (Nuevo == true)
            {
                CADCliente.InsertCliente((int)CmbTipoDocumento.SelectedValue, TxtDocumento.Text,
                    TxtNombreComercial.Text, TxtNombreContacto.Text, TxtApellidosContacto.Text,
                    TxtDireccion.Text, TxtTelefono1.Text, TxtTelefono2.Text, TxtCorreo.Text, TxtNotas.Text,
                    DtpAniversario.Value);
            }
            else
            {
                CADCliente.UpdateCliente((int)CmbTipoDocumento.SelectedValue, TxtDocumento.Text,
                    TxtNombreComercial.Text, TxtNombreContacto.Text, TxtApellidosContacto.Text,
                    TxtDireccion.Text, TxtTelefono1.Text, TxtTelefono2.Text, TxtCorreo.Text, TxtNotas.Text,
                    DtpAniversario.Value, Convert.ToInt32(TxtIDCliente.Text));
            }
            DgvClientes.DataSource = null;
            DgvClientes.DataSource = CADCliente.getData();
            DeshabilitarCampos();
            MostrarRegistro();
        }

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = DgvClientes.CurrentRow.Index;
            MostrarRegistro();
        }

        private void TsbEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Estas seguro de eliminar este registro - actual - ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            CADCliente.DeleteCliente(Convert.ToInt16(TxtIDCliente.Text));
            if (i != 0) i--;
            DgvClientes.DataSource = null;
            DgvClientes.DataSource = CADCliente.getData();
            MostrarRegistro();

        }

        private void TsbBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaCliente frmBuscar =new FrmBusquedaCliente();
            frmBuscar.ShowDialog();
            DgvClientes.DataSource = CADCliente.GetCliente(frmBuscar.IdCliente);


        }


    }
}
