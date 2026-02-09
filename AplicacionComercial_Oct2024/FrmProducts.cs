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
    public partial class FrmProducts : Form
    {
        private bool esNuevo = false;

        public FrmProducts()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsAplicacionComercialxsd);
            DeshabilitarCampos();


        }

        private bool ValidarCampos()
        {
            if (descripcionTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una DESCRIPCIÓN para este producto");
                descripcionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (iDDepartamentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDDepartamentoComboBox, "Debe ingresar un DEPARTAMENTO para este Producto ");
                iDDepartamentoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            decimal precio;
            if (!decimal.TryParse(precioTextBox.Text, out precio))
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un PRECIO Valido  ");
                precioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (precio<=0)
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un PRECIO Valido  ");
                precioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();
            if (iDIVAComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDIVAComboBox, "Debe ingresar un IVA para este Producto ");
                iDIVAComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();
            if (iDMedidaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDMedidaComboBox, "Debe ingresar un tipo de MEDIDA para este Producto ");
                iDMedidaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();
            float med;
            if (!float.TryParse(medidaTextBox.Text, out med))
            {
                errorProvider1.SetError(medidaTextBox, "Debe ingresar una MEDIDA para este Producto ");
                medidaTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();
            //if (imagenTextBox.Text== String.Empty)
            //{
            //    errorProvider1.SetError(imagenTextBox, "Debe ingresar una Imagen Valida ");
            //    imagenTextBox.Focus();
            //    return false;
            //}
            //errorProvider1.Clear();
            if (iDMedidaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDMedidaComboBox, "Debe ingresar un TIPO DE MEDIDA para este producto  ");
                iDMedidaComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (medidaTextBox.Text==String.Empty)
            {
                errorProvider1.SetError(medidaTextBox, "Debe ingresar una MEDIDA para este producto  ");
                medidaTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();
            //if (notasTextBox.Text == String.Empty)
            //{
            //    errorProvider1.SetError(notasTextBox, "Debe ingresar al menos una NOTA para este producto  ");
            //    notasTextBox.Focus();
            //    return false;
            //}
            //errorProvider1.Clear();
            return true;

        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.BodegaProducto' Puede moverla o quitarla según sea necesario.
            this.bodegaProductoTableAdapter.Fill(this.dsAplicacionComercialxsd.BodegaProducto);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Medida' Puede moverla o quitarla según sea necesario.
            this.medidaTableAdapter.Fill(this.dsAplicacionComercialxsd.Medida);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.IVA' Puede moverla o quitarla según sea necesario.
            this.iVATableAdapter.Fill(this.dsAplicacionComercialxsd.IVA);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dsAplicacionComercialxsd.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dsAplicacionComercialxsd.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Barra' Puede moverla o quitarla según sea necesario.
            this.barraTableAdapter.Fill(this.dsAplicacionComercialxsd.Barra);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dsAplicacionComercialxsd.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Barra' Puede moverla o quitarla según sea necesario.
            this.barraTableAdapter.Fill(this.dsAplicacionComercialxsd.Barra);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Medida' Puede moverla o quitarla según sea necesario.
            this.medidaTableAdapter.Fill(this.dsAplicacionComercialxsd.Medida);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.IVA' Puede moverla o quitarla según sea necesario.
            this.iVATableAdapter.Fill(this.dsAplicacionComercialxsd.IVA);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.dsAplicacionComercialxsd.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'dsAplicacionComercialxsd.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dsAplicacionComercialxsd.Producto);
            MostrarBarraBodega();
            CargarImagen();

        }



        private void HabilitarCampos()
        {
            //Botones
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorPositionItem.Enabled = false;
            bindingNavigatorModifyItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorPositionItem.ReadOnly = false;
            bindingNavigatorCancel.Enabled = true;
            bindingNavigatorSaveItem.Enabled = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled=false;
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
            productoDataGridView.Enabled = false;
            //TextBox
            descripcionTextBox.ReadOnly = false;
            iDDepartamentoComboBox.Enabled = true;
            iDIVAComboBox.Enabled = true;
            precioTextBox.ReadOnly = false;
            imagenTextBox.ReadOnly = true;
            BtnSeleccionar.Enabled = true;
            iDMedidaComboBox.Enabled = true;
            medidaTextBox.ReadOnly = false;
            imagenTextBox.ReadOnly = false;
            if (esNuevo ==false)
            {
                btnAgregarBarra.Enabled = true;
                btnEliminarBarra.Enabled = true;
                btnAgregarBodega.Enabled = true;

            }
            else
            {
                btnAgregarBarra.Enabled = false;
                btnEliminarBarra.Enabled = false;
                btnAgregarBodega.Enabled = false;
            }
                descripcionTextBox.Focus();
        }
        private void DeshabilitarCampos()
        {
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorPositionItem.Enabled = true;
            bindingNavigatorModifyItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorShearchItem.Enabled = true;
            bindingNavigatorPositionItem.ReadOnly = true;
            bindingNavigatorCancel.Enabled = false;
            bindingNavigatorSaveItem.Enabled = false;
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            productoDataGridView.Enabled = true;
            //TextBox
            descripcionTextBox.ReadOnly = true;
            iDDepartamentoComboBox.Enabled = false;
            iDIVAComboBox.Enabled = false;
            precioTextBox.ReadOnly = true;
            imagenTextBox.ReadOnly = false;
            BtnSeleccionar.Enabled = false;
            iDMedidaComboBox.Enabled = false;
            medidaTextBox.ReadOnly = true;
            btnAgregarBarra.Enabled = false;
            btnEliminarBarra.Enabled = false;
            btnAgregarBodega.Enabled = false;
            imagenTextBox.ReadOnly = true;
            productoDataGridView.Focus();
        }

        private void bindingNavigatorModifyItem_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            HabilitarCampos();
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {           
            DeshabilitarCampos();
            this.productoBindingSource.CancelEdit();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            HabilitarCampos();
            productoBindingSource.AddNew();

        }

        private void MostrarBarraBodega()
        {
            if (iDProductoTextBox.Text == "" ) return;
            try
            {
                int.TryParse(iDProductoTextBox.Text, out int idProducto);
               // this.barraTableAdapter.FillByBarras(this.dsAplicacionComercialxsd.Barra,idProducto );
                //this.bodegaTableAdapter.FillByBodega(this.dsAplicacionComercialxsd.Bodega,idProducto);

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            DialogResult rta = MessageBox.Show("Esta seguro de querer borrar el registro actual ? ", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            productoBindingSource.RemoveAt(productoBindingSource.Position);
            this.tableAdapterManager.UpdateAll(dsAplicacionComercialxsd);

        
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            MostrarBarraBodega();
            CargarImagen();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
           openFileDialog1.ShowDialog();
           imagenTextBox.Text = openFileDialog1.FileName;
           CargarImagen();
        }

        private void CargarImagen()
        {
            if (imagenTextBox.Text == String.Empty)
            {
                 pbxProducto.Image = null;
                 
            }else
            {
                try
                {
                    pbxProducto.Image = Image.FromFile(imagenTextBox.Text);
                }
                catch (Exception )
                {
                    pbxProducto.Image = null;
                   // MessageBox.Show("No se pudo cargar la imagen: " + e.Message);
                }
            }

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            productoBindingNavigatorSaveItem_Click(sender,e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bindingNavigatorCancel_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            productoBindingSource.AddNew();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem_Click(sender,e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bindingNavigatorShearchItem_Click(sender, e);
        }

        private void bindingNavigatorShearchItem_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto buscarProducto= new FrmBuscarProducto();
            buscarProducto.ShowDialog();
            if (buscarProducto.IdProducto == 0)
            {
                return;
            }
            int posicion = productoBindingSource.Find("IDProducto", buscarProducto.IdProducto);
            productoBindingSource.Position= posicion;

        }

        private void btnAgregarBarra_Click(object sender, EventArgs e)
        {
            FrmAgregarBarra agregarBarra= new FrmAgregarBarra();
            agregarBarra.ShowDialog();
            if (agregarBarra.Barra == 0)
            {
                return;
            }
            else
            {
                int idProducto = int.Parse(iDProductoTextBox.Text);
                long nuevaBarra = agregarBarra.Barra;
                CADBarra.InsertarBarra(idProducto, nuevaBarra);
                MostrarBarraBodega();
            }
        }

        private void btnEliminarBarra_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("Esta seguro de querer borrar esta BARRA del producto ? ", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            long barra = (long)BarraDataGridView.Rows[barraBindingSource.Position].Cells[1].Value;
            CADBarra.DeleteBarra(barra);
            this.tableAdapterManager.UpdateAll(dsAplicacionComercialxsd);
            MostrarBarraBodega();
        }

        private void btnAgregarBodega_Click(object sender, EventArgs e)
        {
            FrmParaBobega parametrosBodega= new FrmParaBobega();
            parametrosBodega.IdProducto = int.Parse(iDProductoTextBox.Text);
            parametrosBodega.ShowDialog();
            MostrarBarraBodega();
        }


    }
}
