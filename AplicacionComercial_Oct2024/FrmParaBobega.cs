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
        private int IdProducto;
        public int IdProducto1 { get => IdProducto; set => IdProducto = value; }
        public FrmParaBobega()
        {
            InitializeComponent();
        }

       

        private void FrmParaBabega_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsAplicacionComercialxsd.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dsAplicacionComercialxsd.Users);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dsAplicacionComercialxsd.Bodega);

        }
    }
}
