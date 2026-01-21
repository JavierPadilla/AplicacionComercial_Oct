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
    public partial class FrmParametrosBodega : Form
    {
        private int _idproducto=0;
        public FrmParametrosBodega()
        {
            InitializeComponent();
        }

        public int IdProducto { get => _idproducto; set => _idproducto = value; }

        private void bodegaProductoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bodegaProductoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);

        }

        private void bodegaProductoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bodegaProductoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);

        }

        private void FrmParametrosBodega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dsAplicacionComercialxsd.Bodega);
           bodegacomboBox.SelectedIndex = -1;
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.BodegaProducto' Puede moverla o quitarla según sea necesario.
            this.bodegaProductoTableAdapter.Fill(this.dsAplicacionComercialxsd.BodegaProducto,_idproducto);
            //this.bodegaProductoTableAdapter.BuscarBodegaProductoByIDProducto(_idproducto);

        }

        private void bodegacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Al cambiar el valor del combobox-- se debe actualizar los datos de las existencias

        }
    }
}
