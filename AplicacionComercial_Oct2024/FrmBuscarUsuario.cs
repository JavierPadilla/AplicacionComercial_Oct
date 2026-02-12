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
    public partial class FrmBuscarUsuario : Form
    {
        public string IDUsuario { get; set; }

        public FrmBuscarUsuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);

        }

        private void FrmBuscarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dsAplicacionComercialxsd.Usuario);
            iDUsuarioToolStripTextBox.Focus();

        }

        private void fillBuscarUsuarioToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuarioTableAdapter.FillBuscarUsuario
                    (this.dsAplicacionComercialxsd.Usuario,"%"+ iDUsuarioToolStripTextBox.Text+"%", "%"+nombresToolStripTextBox.Text+ "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void iDUsuarioToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            fillBuscarUsuarioToolStripButton_Click(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (usuarioDataGridView.Rows.Count == 0)
            {
                IDUsuario = string.Empty;
            }
            else
            {
                if (usuarioDataGridView.SelectedRows.Count != 0)
                {
                    IDUsuario = (string)usuarioDataGridView.SelectedRows[0].Cells[0].Value;
                }
                else
                {
                    IDUsuario = (string)usuarioDataGridView.Rows[0].Cells[0].Value;
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IDUsuario = string.Empty;
            this.Close();

        }
    }
}
