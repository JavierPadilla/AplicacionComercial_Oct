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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //Como acceder a este codigo

            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.dsAplicacionComercialxsd.Rol);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dsAplicacionComercialxsd.Usuario);

            //desabilitar botones de navegacion
            Deshabilitar();
           

        }

        private void Deshabilitar()
        {
            TsbCancelar.Enabled = false;
            usuarioBindingNavigatorSaveItem.Enabled = false;
            iDUsuarioTextBox.ReadOnly = true;
            nombresTextBox.ReadOnly = true;
            apellidosTextBox.ReadOnly = true;
            claveTextBox.ReadOnly = true;
            iDRolComboBox.Enabled = false;
            correoTextBox.ReadOnly = true;
            ConfirmacionTextBox.ReadOnly = true;
            fechaModificacionClaveDateTimePicker.Enabled = false;

        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();

        }

        private void HabilitarCampos()
        {
            TsbCancelar.Enabled = true;
            usuarioBindingNavigatorSaveItem.Enabled = true;
            iDUsuarioTextBox.ReadOnly = false;
            nombresTextBox.ReadOnly = false;
            apellidosTextBox.ReadOnly = false;
            claveTextBox.ReadOnly = false;
            iDRolComboBox.Enabled = true;
            correoTextBox.ReadOnly = false;
            ConfirmacionTextBox.ReadOnly = false;
            fechaModificacionClaveDateTimePicker.Enabled = true;
  
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }


    }
}
