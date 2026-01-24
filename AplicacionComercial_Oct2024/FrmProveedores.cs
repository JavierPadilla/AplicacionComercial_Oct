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
    public partial class FrmProveedores : Form
    {

        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if(!ValidaCampos())return;
            DeshabilitarCampos();
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);
            this.proveedorTableAdapter.Fill(this.dsAplicacionComercialxsd.Proveedor);

        }

        private bool ValidaCampos()
        {
            if (iDTipoDocumentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDTipoDocumentoComboBox, "Ingresa el TIPO DE DOCUMENTO correcto");
                iDTipoDocumentoComboBox.Focus();
                return false;
            }
            errorProvider1.SetError(iDTipoDocumentoComboBox,"");

            if (documentoTextBox.Text=="")
            {
                errorProvider1.SetError(documentoTextBox, "Ingresa el DOCUMENTO");
                documentoTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(documentoTextBox, "");

            if (nombreTextBox.Text == "")
            {
                errorProvider1.SetError(nombreTextBox, "Cuál es NOMBRE del empresa del proveedor");
                nombreTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(nombreTextBox, "");

            if (nombresContactoTextBox.Text == "")
            {
                errorProvider1.SetError(nombresContactoTextBox, "Cuál es NOMBRE del Contacto");
                nombresContactoTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(nombresContactoTextBox, "");

            if (apellidosContactoTextBox.Text == "")
            {
                errorProvider1.SetError(apellidosContactoTextBox, "Cuál es el APELLIDO del empresa del Contacto");
                apellidosContactoTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(apellidosContactoTextBox, "");

            if(correoTextBox.Text != "")
            {
                RegexUtilities regexUtilities = new RegexUtilities();
                if (!regexUtilities.IsValidEmail(correoTextBox.Text))
                {
                    errorProvider1.SetError(correoTextBox, "Debe ingresar un CORREO VALIDO ");
                    correoTextBox.Focus();
                    return false;
                }
                errorProvider1.SetError(correoTextBox, "");
            }
            return true;
        }

        private void DeshabilitarCampos()
        {
            //  bloquear cajas de textos
            iDTipoDocumentoComboBox.Enabled = false;
            documentoTextBox.ReadOnly = true;
            nombreTextBox.ReadOnly = true;
            nombresContactoTextBox.ReadOnly = true;
            apellidosContactoTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            telefono1TextBox.ReadOnly = true;
            telefono2TextBox.ReadOnly = true;
            correoTextBox.ReadOnly= true;
            notasTextBox.ReadOnly = true;
            //  habilitar botones
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            TsbBuscar.Enabled = true;
            TsbModificar.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorPositionItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            proveedorBindingNavigatorSaveItem.Enabled = false;
            TsbCancelar.Enabled = false;
        }
        private void HabilitarCampos()
        {
            //  Habilitar Cajas de textos
            iDTipoDocumentoComboBox.Enabled = true;
            documentoTextBox.ReadOnly = false;
            nombreTextBox.ReadOnly = false;
            nombresContactoTextBox.ReadOnly = false;
            apellidosContactoTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            telefono1TextBox.ReadOnly = false;
            telefono2TextBox.ReadOnly = false;
            correoTextBox.ReadOnly = false;
            notasTextBox.ReadOnly = false;
            //  deshabilitar botones
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            TsbBuscar.Enabled = false;
            TsbModificar.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorPositionItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            proveedorBindingNavigatorSaveItem.Enabled = true;
            TsbCancelar.Enabled = true;
        }
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.TipoDocumento' Puede moverla o quitarla según sea necesario.
            this.tipoDocumentoTableAdapter.Fill(this.dsAplicacionComercialxsd.TipoDocumento);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.dsAplicacionComercialxsd.Proveedor);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Estas seguro de eliminar este registro - actual - ?", "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            proveedorBindingSource.RemoveAt(proveedorBindingSource.Position);

        }

        private void TsbModificar_Click(object sender, EventArgs e)
        {
       
            HabilitarCampos();
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            this.proveedorTableAdapter.Fill(this.dsAplicacionComercialxsd.Proveedor);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
  
        {

            HabilitarCampos();
            proveedorBindingSource.AddNew();
            iDTipoDocumentoComboBox.Focus();
        }



        private void ArmaNombre()
        {
            if (iDTipoDocumentoComboBox.SelectedIndex == 0)
            {
                nombreTextBox.Text=nombresContactoTextBox.Text+ " " +apellidosContactoTextBox.Text;
            }
        }

        private void nombresContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            ArmaNombre();
        }

        private void apellidosContactoTextBox_TextChanged(object sender, EventArgs e)
        {
            ArmaNombre();
        }




        private void TsbBuscar_Click(object sender, EventArgs e)
        {
            
            FrmBuscarProveedor miProveedor =new FrmBuscarProveedor();
            miProveedor.ShowDialog();
            if(miProveedor.IdProveedor==0) return;
            int position = proveedorBindingSource.Find("IDProveedor", miProveedor.IdProveedor);
            proveedorBindingSource.Position= position;

        }

        private void proveedorBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
