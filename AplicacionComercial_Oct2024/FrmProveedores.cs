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
        bool Modificar = false;
        bool Nuevo=false;
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void proveedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);
            this.proveedorTableAdapter.Fill(this.dsAplicacionComercialxsd.Proveedor);

        }

        private void DeshabilitarCampos()
        {
            //  bloquear cajas de textos
            iDTipoDocumentoComboBox.Enabled = false;
            documentoTextBox.ReadOnly = true;
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

        }

        private void TsbModificar_Click(object sender, EventArgs e)
        {
            Modificar = true;
            Nuevo = false;
            HabilitarCampos();
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            this.proveedorTableAdapter.Fill(this.dsAplicacionComercialxsd.Proveedor);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
  
        {
            Nuevo=true;
            Modificar=false;
            HabilitarCampos();
        }
    }
}
