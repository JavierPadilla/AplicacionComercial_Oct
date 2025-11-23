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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void CmdAceptar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                errorProvider1.SetError(TxtUsuario, "Debe ingresar un Nombre de usuario Valido !");
                TxtUsuario.Focus();
                return;
            }
            errorProvider1.SetError(TxtUsuario, "");
            
            if (TxtClave.Text == "")
            {
                errorProvider1.SetError(TxtClave, "Debe ingresar una contrasena Valida !");
                TxtClave.Focus();
                return;
            }
            errorProvider1.SetError(TxtClave, "");
            
            if (!CADUsuario.ValidaUsuario(TxtUsuario.Text, TxtClave.Text))
            {
                TxtClave.Text = "";
                TxtUsuario.Text = "";
                TxtUsuario.Focus();
                MessageBox.Show("Usuario o clave Incorrectos !!", "Error de autenticacion", MessageBoxButtons.OK);
            }
            else
            {
                FrmPantallaPrincipal miform = new FrmPantallaPrincipal();
                miform.Show();
                this.Hide();
            }
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtUsuario.Text = "zulu";
            TxtClave.Text = "123";
     
        }
    }
}
