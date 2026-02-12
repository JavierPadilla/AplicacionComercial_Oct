using CADAplicacionComercial;
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
        private int _Position = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //Como acceder a este codigo
            if (ValidadarCampos() == true)
            {               
                try
                {
                    this.usuarioBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);
                    ConfirmacionTextBox.Text = string.Empty;
                    Deshabilitar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    iDUsuarioTextBox.Focus();
                    return;
                }

            }
            else
            {
                return;
            }


        }

        private bool ValidadarCampos()
        {
            if (iDUsuarioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(iDUsuarioTextBox, "El campo ID Usuario es obligatorio");
                iDUsuarioTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(iDUsuarioTextBox, string.Empty);
            if (nombresTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombresTextBox, "El campo Nombres es obligatorio");
                nombresTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(nombresTextBox, string.Empty);
            if (apellidosTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidosTextBox, "El campo Apellidos es obligatorio");
                apellidosTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(apellidosTextBox, string.Empty);
            if (claveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(claveTextBox, "El campo Clave es obligatorio");
                claveTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(claveTextBox, string.Empty);
            if (iDRolComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDRolComboBox, "El campo Rol es obligatorio");
                iDRolComboBox.Focus();
                return false;
            }
            errorProvider1.SetError(iDRolComboBox, string.Empty);
            if (correoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(correoTextBox, "El campo Correo es obligatorio");
                correoTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(correoTextBox, string.Empty);
            if (ConfirmacionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ConfirmacionTextBox, "El campo Confirmación es obligatorio");
                ConfirmacionTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(ConfirmacionTextBox, string.Empty);
            if (claveTextBox.Text != ConfirmacionTextBox.Text)
            {
                errorProvider1.SetError(ConfirmacionTextBox, "La confirmación no coincide con la clave");
                ConfirmacionTextBox.Focus();
                return false;
            }
            errorProvider1.SetError(ConfirmacionTextBox, string.Empty);
            if (fechaModificacionClaveDateTimePicker.Value > DateTime.Now)
            {
                errorProvider1.SetError(fechaModificacionClaveDateTimePicker, "La fecha de modificación de clave no puede ser mayor a la fecha actual");
                fechaModificacionClaveDateTimePicker.Focus();
                return false;
            }
            errorProvider1.SetError(fechaModificacionClaveDateTimePicker, string.Empty);
            if (fechaModificacionClaveDateTimePicker.Value == null)
            {
                errorProvider1.SetError(fechaModificacionClaveDateTimePicker, "El campo Fecha de Modificación de Clave es obligatorio");
                fechaModificacionClaveDateTimePicker.Focus();
                return false;
            }
            errorProvider1.SetError(fechaModificacionClaveDateTimePicker, string.Empty);
            if(CADUsuario.ExisteUsuario(iDUsuarioTextBox.Text) == true && usuarioBindingSource.Current == null)
            {
                errorProvider1.SetError(iDUsuarioTextBox, "El ID Usuario ya existe, ingrese otro");
                iDUsuarioTextBox.Focus();
                return false;
            }
            return true;
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
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorPositionItem.Enabled = true;
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;

            TsbEditar.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            TsbBuscar.Enabled = true;
            usuarioDataGridView.Enabled = true;
            //
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

            ConfirmacionTextBox.Text = string.Empty;

            usuarioBindingSource.Position = _Position;
            usuarioDataGridView.Focus();    

        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            fechaModificacionClaveDateTimePicker.Value = DateTime.Now;
            iDUsuarioTextBox.Focus();

        }

        private void HabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorPositionItem.Enabled = false;
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;

            TsbEditar.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            TsbBuscar.Enabled = false;
            usuarioDataGridView.Enabled = false;

            TsbCancelar.Enabled = true;
            usuarioBindingNavigatorSaveItem.Enabled = true;


            iDUsuarioTextBox.ReadOnly = false;
            nombresTextBox.ReadOnly = false;
            apellidosTextBox.ReadOnly = false;
            claveTextBox.ReadOnly = false;
            iDRolComboBox.Enabled = true;
            correoTextBox.ReadOnly = false;
            ConfirmacionTextBox.ReadOnly = false;
            fechaModificacionClaveDateTimePicker.Enabled = false;
            _Position = usuarioBindingSource.Position;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            HabilitarCampos();
            usuarioBindingSource.AddNew();
            fechaModificacionClaveDateTimePicker.Value = DateTime.Now;
            iDUsuarioTextBox.Focus();


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Estas seguro de eliminar este registro - actual - ?", "Confirmación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            usuarioBindingSource.RemoveAt(usuarioBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);
        }

        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            Deshabilitar();
            usuarioBindingSource.CancelEdit(); 
            usuarioDataGridView.Focus();
        }

        private void TsbBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarUsuario frmBuscarUsuario = new FrmBuscarUsuario();
            frmBuscarUsuario.ShowDialog();
                if (frmBuscarUsuario.IDUsuario != null)
                {
                string idUsuarioSeleccionado = frmBuscarUsuario.IDUsuario;
                int posicion = usuarioBindingSource.Find("IDUsuario", idUsuarioSeleccionado);
                if (posicion != -1)
                {
                    usuarioBindingSource.Position = posicion;
                }
            }
        }
    }
}
