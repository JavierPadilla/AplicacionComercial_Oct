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
    public partial class FrmParaBobega : Form
    {
        private int _IdProducto;
        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public FrmParaBobega()
        {
            InitializeComponent();
        }

       

        private void FrmParaBabega_Load(object sender, EventArgs e)
        {
           

            this.bodegaTableAdapter.Fill(this.dsAplicacionComercialxsd.Bodega);

        }

        private void BodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BodegaComboBox.SelectedIndex == -1) return;


                CADBodegaProducto miBodegaProducto =
                    CADBodegaProducto.GetBodegaProductoByIDBodegaAndIDProducto(
                        (int)BodegaComboBox.SelectedValue, IdProducto);
                if (miBodegaProducto != null)
                {
                  StockTextBox.Text = miBodegaProducto.Stock.ToString();
                    MinimoNumericUpDown.Value = miBodegaProducto.Minimo;
                    MaximoNumericUpDown.Value = miBodegaProducto.Maximo;
                    DiasReposicionNumericUpDown.Value = miBodegaProducto.DiasReposicion;
                    MinimoOrdenarNumericUpDown.Value = miBodegaProducto.MinimoOrdenar;
                }
                else
                {
                    StockTextBox.Text = "0";
                    MinimoNumericUpDown.Value = 0;
                    MaximoNumericUpDown.Value = 0;
                    DiasReposicionNumericUpDown.Value = 0;
                    MinimoOrdenarNumericUpDown.Value = 0;
                }

                return;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CADBodegaProducto.UpdateBodegaProducto((int)BodegaComboBox.SelectedValue, IdProducto, (double)MinimoNumericUpDown.Value, (double)MaximoNumericUpDown.Value, (int)DiasReposicionNumericUpDown.Value, (double)MinimoOrdenarNumericUpDown.Value);
             MessageBox.Show("Datos guardados correctamente");
             this.Close();
        }
    }
}
