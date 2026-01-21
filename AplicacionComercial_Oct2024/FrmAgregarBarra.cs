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
    public partial class FrmAgregarBarra : Form
    {
        private long barra = 0;
        public long Barra { get => barra; set => barra = value; }
        public FrmAgregarBarra()
        {
            InitializeComponent();
        }



        private void FrmAgregarBarra_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            barra = 0;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtBarra.Text == string.Empty)
            {

                this.Close();
            }
            else
            {
                if (txtBarra.Text.Length < 9)
                {
                    MessageBox.Show("El valor ingresado no cumple con la longitud minima requerida de 9 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (long.TryParse(txtBarra.Text, out barra))
                    {
                        if (barra <= 0)
                        {
                            MessageBox.Show("El valor ingresado debe ser un número entero positivo mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }
                        else
                        {
                            //Comprobar si la barra ya existe en la base de datos
                            if(CADAplicacion.CADBarra.ExisteBarra(barra))
                            {
                                MessageBox.Show("La barra ingresada ya existe en la base de datos. Por favor, ingrese una barra diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                barra = 0;
                                return;
                            }
                            else
                            {
                                this.Close();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("El valor ingresado no es válido. Por favor, ingrese un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
