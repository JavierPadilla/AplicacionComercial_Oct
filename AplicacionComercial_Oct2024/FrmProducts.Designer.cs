namespace AplicacionComercial_Oct2024
{
    partial class FrmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label medidaLabel;
            System.Windows.Forms.Label iDMedidaLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label iDIVALabel;
            System.Windows.Forms.Label iDDepartamentoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label iDProductoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsAplicacionComercialxsd = new AplicacionComercial_Oct2024.DsAplicacionComercialxsd();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.ProductoTableAdapter();
            this.tableAdapterManager = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.TableAdapterManager();
            this.productoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorModifyItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancel = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorShearchItem = new System.Windows.Forms.ToolStripButton();
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.medidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbxBarras = new System.Windows.Forms.GroupBox();
            this.BarraDataGridView = new System.Windows.Forms.DataGridView();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxBodegas = new System.Windows.Forms.GroupBox();
            this.btnAgregarBodega = new System.Windows.Forms.Button();
            this.btnEliminarBarra = new System.Windows.Forms.Button();
            this.btnAgregarBarra = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.imagenTextBox = new System.Windows.Forms.TextBox();
            this.medidaTextBox = new System.Windows.Forms.TextBox();
            this.iDMedidaComboBox = new System.Windows.Forms.ComboBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.iDIVAComboBox = new System.Windows.Forms.ComboBox();
            this.iDDepartamentoComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.iDProductoTextBox = new System.Windows.Forms.TextBox();
            this.barraTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.BarraTableAdapter();
            this.bodegaTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.BodegaTableAdapter();
            this.departamentoTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.DepartamentoTableAdapter();
            this.iVATableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.IVATableAdapter();
            this.medidaTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.MedidaTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bodegaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaProductoTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.BodegaProductoTableAdapter();
            this.iDBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasReposicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            imagenLabel = new System.Windows.Forms.Label();
            medidaLabel = new System.Windows.Forms.Label();
            iDMedidaLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            iDIVALabel = new System.Windows.Forms.Label();
            iDDepartamentoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            iDProductoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).BeginInit();
            this.productoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.gbxBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarraDataGridView)).BeginInit();
            this.gbxBodegas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(591, 27);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(52, 13);
            imagenLabel.TabIndex = 38;
            imagenLabel.Text = "* Imagen:";
            // 
            // medidaLabel
            // 
            medidaLabel.AutoSize = true;
            medidaLabel.Location = new System.Drawing.Point(326, 89);
            medidaLabel.Name = "medidaLabel";
            medidaLabel.Size = new System.Drawing.Size(52, 13);
            medidaLabel.TabIndex = 36;
            medidaLabel.Text = "* Medida:";
            // 
            // iDMedidaLabel
            // 
            iDMedidaLabel.AutoSize = true;
            iDMedidaLabel.Location = new System.Drawing.Point(8, 91);
            iDMedidaLabel.Name = "iDMedidaLabel";
            iDMedidaLabel.Size = new System.Drawing.Size(91, 13);
            iDMedidaLabel.TabIndex = 34;
            iDMedidaLabel.Text = "* Tipo de Medida:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(587, 89);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 32;
            notasLabel.Text = "Notas:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(338, 56);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(47, 13);
            precioLabel.TabIndex = 30;
            precioLabel.Text = "* Precio:";
            // 
            // iDIVALabel
            // 
            iDIVALabel.AutoSize = true;
            iDIVALabel.Location = new System.Drawing.Point(487, 55);
            iDIVALabel.Name = "iDIVALabel";
            iDIVALabel.Size = new System.Drawing.Size(34, 13);
            iDIVALabel.TabIndex = 28;
            iDIVALabel.Text = "* IVA:";
            // 
            // iDDepartamentoLabel
            // 
            iDDepartamentoLabel.AutoSize = true;
            iDDepartamentoLabel.Location = new System.Drawing.Point(8, 56);
            iDDepartamentoLabel.Name = "iDDepartamentoLabel";
            iDDepartamentoLabel.Size = new System.Drawing.Size(84, 13);
            iDDepartamentoLabel.TabIndex = 26;
            iDDepartamentoLabel.Text = "* Departamento:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(228, 22);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(73, 13);
            descripcionLabel.TabIndex = 24;
            descripcionLabel.Text = "* Descripción:";
            // 
            // iDProductoLabel
            // 
            iDProductoLabel.AutoSize = true;
            iDProductoLabel.Location = new System.Drawing.Point(8, 19);
            iDProductoLabel.Name = "iDProductoLabel";
            iDProductoLabel.Size = new System.Drawing.Size(74, 13);
            iDProductoLabel.TabIndex = 22;
            iDProductoLabel.Text = "* ID Producto:";
            // 
            // dsAplicacionComercialxsd
            // 
            this.dsAplicacionComercialxsd.DataSetName = "DsAplicacionComercialxsd";
            this.dsAplicacionComercialxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApplicationsTableAdapter = null;
            this.tableAdapterManager.aspnet_ApplicationsTableAdapter = null;
            this.tableAdapterManager.aspnet_MembershipTableAdapter = null;
            this.tableAdapterManager.aspnet_PathsTableAdapter = null;
            this.tableAdapterManager.aspnet_PersonalizationAllUsersTableAdapter = null;
            this.tableAdapterManager.aspnet_PersonalizationPerUserTableAdapter = null;
            this.tableAdapterManager.aspnet_ProfileTableAdapter = null;
            this.tableAdapterManager.aspnet_RolesTableAdapter = null;
            this.tableAdapterManager.aspnet_SchemaVersionsTableAdapter = null;
            this.tableAdapterManager.aspnet_UsersInRolesTableAdapter = null;
            this.tableAdapterManager.aspnet_UsersTableAdapter = null;
            this.tableAdapterManager.aspnet_WebEvent_EventsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarraTableAdapter = null;
            this.tableAdapterManager.BodegaProductoTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraDetalleTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.ConceptoTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.DevolucionClienteDetalleTableAdapter = null;
            this.tableAdapterManager.DevolucionClienteTableAdapter = null;
            this.tableAdapterManager.DevolucionProveedorDetalleTableAdapter = null;
            this.tableAdapterManager.DevolucionProveedorTableAdapter = null;
            this.tableAdapterManager.InventarioDetalleTableAdapter = null;
            this.tableAdapterManager.InventarioTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.KardexTableAdapter = null;
            this.tableAdapterManager.MedidaTableAdapter = null;
            this.tableAdapterManager.MembershipsTableAdapter = null;
            this.tableAdapterManager.PermisoRolTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = this.productoTableAdapter;
            this.tableAdapterManager.ProfilesTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SalidaDetalleTableAdapter = null;
            this.tableAdapterManager.SalidaTableAdapter = null;
            this.tableAdapterManager.TipoDocumentoTableAdapter = null;
            this.tableAdapterManager.TrasladoDetalleTableAdapter = null;
            this.tableAdapterManager.TrasladoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersInRolesTableAdapter = null;
            this.tableAdapterManager.UsersOpenAuthAccountsTableAdapter = null;
            this.tableAdapterManager.UsersOpenAuthDataTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VentaDetalleTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // productoBindingNavigator
            // 
            this.productoBindingNavigator.AddNewItem = null;
            this.productoBindingNavigator.BindingSource = this.productoBindingSource;
            this.productoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productoBindingNavigator.DeleteItem = null;
            this.productoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorModifyItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCancel,
            this.bindingNavigatorShearchItem});
            this.productoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productoBindingNavigator.Name = "productoBindingNavigator";
            this.productoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productoBindingNavigator.Size = new System.Drawing.Size(1105, 25);
            this.productoBindingNavigator.TabIndex = 0;
            this.productoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.ReadOnly = true;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.bindingNavigatorPositionItem_TextChanged);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorModifyItem
            // 
            this.bindingNavigatorModifyItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorModifyItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorModifyItem.Image")));
            this.bindingNavigatorModifyItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorModifyItem.Name = "bindingNavigatorModifyItem";
            this.bindingNavigatorModifyItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorModifyItem.Text = "Modificar";
            this.bindingNavigatorModifyItem.ToolTipText = "Modificar Registro";
            this.bindingNavigatorModifyItem.Click += new System.EventHandler(this.bindingNavigatorModifyItem_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSaveItem.Text = "Guardar datos";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.productoBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCancel
            // 
            this.bindingNavigatorCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancel.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancel.Image")));
            this.bindingNavigatorCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancel.Name = "bindingNavigatorCancel";
            this.bindingNavigatorCancel.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorCancel.Text = "Cancelar";
            this.bindingNavigatorCancel.Click += new System.EventHandler(this.bindingNavigatorCancel_Click);
            // 
            // bindingNavigatorShearchItem
            // 
            this.bindingNavigatorShearchItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorShearchItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorShearchItem.Image")));
            this.bindingNavigatorShearchItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorShearchItem.Name = "bindingNavigatorShearchItem";
            this.bindingNavigatorShearchItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorShearchItem.Text = "Buscar";
            this.bindingNavigatorShearchItem.ToolTipText = "Buscar Registro";
            this.bindingNavigatorShearchItem.Click += new System.EventHandler(this.bindingNavigatorShearchItem_Click);
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AllowUserToDeleteRows = false;
            this.productoDataGridView.AllowUserToOrderColumns = true;
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(12, 376);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.Size = new System.Drawing.Size(1080, 235);
            this.productoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDDepartamento";
            this.dataGridViewTextBoxColumn3.DataSource = this.departamentoBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IDDepartamento";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDIVA";
            this.dataGridViewTextBoxColumn4.DataSource = this.iVABindingSource;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Tarifa";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDIVA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IDIVA";
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Imagen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Imagen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IDMedida";
            this.dataGridViewTextBoxColumn8.DataSource = this.medidaBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Tipo Medida";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "IDMedida";
            // 
            // medidaBindingSource
            // 
            this.medidaBindingSource.DataMember = "Medida";
            this.medidaBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Medida";
            this.dataGridViewTextBoxColumn9.HeaderText = "Medida";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // barraBindingSource
            // 
            this.barraBindingSource.DataMember = "Barra";
            this.barraBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnBuscar);
            this.gbxDatos.Controls.Add(this.btnEliminar);
            this.gbxDatos.Controls.Add(this.btnNuevo);
            this.gbxDatos.Controls.Add(this.btnModificar);
            this.gbxDatos.Controls.Add(this.btnCancelar);
            this.gbxDatos.Controls.Add(this.btnAceptar);
            this.gbxDatos.Controls.Add(this.gbxBarras);
            this.gbxDatos.Controls.Add(this.gbxBodegas);
            this.gbxDatos.Controls.Add(this.btnAgregarBodega);
            this.gbxDatos.Controls.Add(this.btnEliminarBarra);
            this.gbxDatos.Controls.Add(this.btnAgregarBarra);
            this.gbxDatos.Controls.Add(this.BtnSeleccionar);
            this.gbxDatos.Controls.Add(this.pbxProducto);
            this.gbxDatos.Controls.Add(imagenLabel);
            this.gbxDatos.Controls.Add(this.imagenTextBox);
            this.gbxDatos.Controls.Add(medidaLabel);
            this.gbxDatos.Controls.Add(this.medidaTextBox);
            this.gbxDatos.Controls.Add(iDMedidaLabel);
            this.gbxDatos.Controls.Add(this.iDMedidaComboBox);
            this.gbxDatos.Controls.Add(notasLabel);
            this.gbxDatos.Controls.Add(this.notasTextBox);
            this.gbxDatos.Controls.Add(precioLabel);
            this.gbxDatos.Controls.Add(this.precioTextBox);
            this.gbxDatos.Controls.Add(iDIVALabel);
            this.gbxDatos.Controls.Add(this.iDIVAComboBox);
            this.gbxDatos.Controls.Add(iDDepartamentoLabel);
            this.gbxDatos.Controls.Add(this.iDDepartamentoComboBox);
            this.gbxDatos.Controls.Add(descripcionLabel);
            this.gbxDatos.Controls.Add(this.descripcionTextBox);
            this.gbxDatos.Controls.Add(iDProductoLabel);
            this.gbxDatos.Controls.Add(this.iDProductoTextBox);
            this.gbxDatos.Location = new System.Drawing.Point(12, 28);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(1080, 342);
            this.gbxDatos.TabIndex = 29;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(594, 284);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(102, 52);
            this.btnBuscar.TabIndex = 52;
            this.btnBuscar.Text = "B&uscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::AplicacionComercial_Oct2024.Properties.Resources.Borrar2;
            this.btnEliminar.Location = new System.Drawing.Point(246, 284);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 52);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::AplicacionComercial_Oct2024.Properties.Resources.Nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(125, 284);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 52);
            this.btnNuevo.TabIndex = 50;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::AplicacionComercial_Oct2024.Properties.Resources.Modificar;
            this.btnModificar.Location = new System.Drawing.Point(11, 284);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 52);
            this.btnModificar.TabIndex = 49;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(484, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 52);
            this.btnCancelar.TabIndex = 48;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = global::AplicacionComercial_Oct2024.Properties.Resources.Aceptar2;
            this.btnAceptar.Location = new System.Drawing.Point(372, 284);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 52);
            this.btnAceptar.TabIndex = 47;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbxBarras
            // 
            this.gbxBarras.Controls.Add(this.BarraDataGridView);
            this.gbxBarras.Location = new System.Drawing.Point(5, 153);
            this.gbxBarras.Name = "gbxBarras";
            this.gbxBarras.Size = new System.Drawing.Size(394, 131);
            this.gbxBarras.TabIndex = 46;
            this.gbxBarras.TabStop = false;
            this.gbxBarras.Text = "Barras";
            // 
            // BarraDataGridView
            // 
            this.BarraDataGridView.AllowUserToAddRows = false;
            this.BarraDataGridView.AllowUserToDeleteRows = false;
            this.BarraDataGridView.AllowUserToOrderColumns = true;
            this.BarraDataGridView.AutoGenerateColumns = false;
            this.BarraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BarraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.barraDataGridViewTextBoxColumn});
            this.BarraDataGridView.DataSource = this.barraBindingSource;
            this.BarraDataGridView.Location = new System.Drawing.Point(17, 15);
            this.BarraDataGridView.Name = "BarraDataGridView";
            this.BarraDataGridView.ReadOnly = true;
            this.BarraDataGridView.Size = new System.Drawing.Size(363, 98);
            this.BarraDataGridView.TabIndex = 29;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProductoDataGridViewTextBoxColumn.Visible = false;
            // 
            // barraDataGridViewTextBoxColumn
            // 
            this.barraDataGridViewTextBoxColumn.DataPropertyName = "Barra";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.barraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.barraDataGridViewTextBoxColumn.HeaderText = "Barra";
            this.barraDataGridViewTextBoxColumn.Name = "barraDataGridViewTextBoxColumn";
            this.barraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gbxBodegas
            // 
            this.gbxBodegas.Controls.Add(this.dataGridView1);
            this.gbxBodegas.Location = new System.Drawing.Point(449, 153);
            this.gbxBodegas.Name = "gbxBodegas";
            this.gbxBodegas.Size = new System.Drawing.Size(392, 131);
            this.gbxBodegas.TabIndex = 42;
            this.gbxBodegas.TabStop = false;
            this.gbxBodegas.Text = "Bodegas";
            // 
            // btnAgregarBodega
            // 
            this.btnAgregarBodega.Enabled = false;
            this.btnAgregarBodega.Location = new System.Drawing.Point(479, 124);
            this.btnAgregarBodega.Name = "btnAgregarBodega";
            this.btnAgregarBodega.Size = new System.Drawing.Size(102, 23);
            this.btnAgregarBodega.TabIndex = 45;
            this.btnAgregarBodega.Text = "Agregar Bode&ga";
            this.btnAgregarBodega.UseVisualStyleBackColor = true;
            this.btnAgregarBodega.Click += new System.EventHandler(this.btnAgregarBodega_Click);
            // 
            // btnEliminarBarra
            // 
            this.btnEliminarBarra.Enabled = false;
            this.btnEliminarBarra.Location = new System.Drawing.Point(305, 124);
            this.btnEliminarBarra.Name = "btnEliminarBarra";
            this.btnEliminarBarra.Size = new System.Drawing.Size(94, 23);
            this.btnEliminarBarra.TabIndex = 44;
            this.btnEliminarBarra.Text = "Elimina&r Barra";
            this.btnEliminarBarra.UseVisualStyleBackColor = true;
            this.btnEliminarBarra.Click += new System.EventHandler(this.btnEliminarBarra_Click);
            // 
            // btnAgregarBarra
            // 
            this.btnAgregarBarra.Enabled = false;
            this.btnAgregarBarra.Location = new System.Drawing.Point(200, 124);
            this.btnAgregarBarra.Name = "btnAgregarBarra";
            this.btnAgregarBarra.Size = new System.Drawing.Size(99, 23);
            this.btnAgregarBarra.TabIndex = 43;
            this.btnAgregarBarra.Text = "Agregar &Barra";
            this.btnAgregarBarra.UseVisualStyleBackColor = true;
            this.btnAgregarBarra.Click += new System.EventHandler(this.btnAgregarBarra_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Enabled = false;
            this.BtnSeleccionar.Location = new System.Drawing.Point(815, 22);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(26, 23);
            this.BtnSeleccionar.TabIndex = 41;
            this.BtnSeleccionar.Text = "...";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(852, 19);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(219, 265);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 40;
            this.pbxProducto.TabStop = false;
            // 
            // imagenTextBox
            // 
            this.imagenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Imagen", true));
            this.imagenTextBox.Location = new System.Drawing.Point(642, 24);
            this.imagenTextBox.Name = "imagenTextBox";
            this.imagenTextBox.ReadOnly = true;
            this.imagenTextBox.Size = new System.Drawing.Size(167, 20);
            this.imagenTextBox.TabIndex = 39;
            // 
            // medidaTextBox
            // 
            this.medidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Medida", true));
            this.medidaTextBox.Location = new System.Drawing.Point(377, 86);
            this.medidaTextBox.Name = "medidaTextBox";
            this.medidaTextBox.ReadOnly = true;
            this.medidaTextBox.Size = new System.Drawing.Size(195, 20);
            this.medidaTextBox.TabIndex = 37;
            // 
            // iDMedidaComboBox
            // 
            this.iDMedidaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDMedida", true));
            this.iDMedidaComboBox.DataSource = this.medidaBindingSource;
            this.iDMedidaComboBox.DisplayMember = "Descripcion";
            this.iDMedidaComboBox.Enabled = false;
            this.iDMedidaComboBox.FormattingEnabled = true;
            this.iDMedidaComboBox.Location = new System.Drawing.Point(107, 85);
            this.iDMedidaComboBox.Name = "iDMedidaComboBox";
            this.iDMedidaComboBox.Size = new System.Drawing.Size(202, 21);
            this.iDMedidaComboBox.TabIndex = 35;
            this.iDMedidaComboBox.ValueMember = "IDMedida";
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(642, 56);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ReadOnly = true;
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(199, 59);
            this.notasTextBox.TabIndex = 33;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(391, 53);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(78, 20);
            this.precioTextBox.TabIndex = 31;
            // 
            // iDIVAComboBox
            // 
            this.iDIVAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDIVA", true));
            this.iDIVAComboBox.DataSource = this.iVABindingSource;
            this.iDIVAComboBox.DisplayMember = "Descripcion";
            this.iDIVAComboBox.Enabled = false;
            this.iDIVAComboBox.FormattingEnabled = true;
            this.iDIVAComboBox.Location = new System.Drawing.Point(531, 52);
            this.iDIVAComboBox.Name = "iDIVAComboBox";
            this.iDIVAComboBox.Size = new System.Drawing.Size(85, 21);
            this.iDIVAComboBox.TabIndex = 29;
            this.iDIVAComboBox.ValueMember = "IDIVA";
            // 
            // iDDepartamentoComboBox
            // 
            this.iDDepartamentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "IDDepartamento", true));
            this.iDDepartamentoComboBox.DataSource = this.departamentoBindingSource;
            this.iDDepartamentoComboBox.DisplayMember = "Descripcion";
            this.iDDepartamentoComboBox.Enabled = false;
            this.iDDepartamentoComboBox.FormattingEnabled = true;
            this.iDDepartamentoComboBox.Location = new System.Drawing.Point(107, 53);
            this.iDDepartamentoComboBox.Name = "iDDepartamentoComboBox";
            this.iDDepartamentoComboBox.Size = new System.Drawing.Size(226, 21);
            this.iDDepartamentoComboBox.TabIndex = 27;
            this.iDDepartamentoComboBox.ValueMember = "IDDepartamento";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(316, 19);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(269, 20);
            this.descripcionTextBox.TabIndex = 25;
            // 
            // iDProductoTextBox
            // 
            this.iDProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "IDProducto", true));
            this.iDProductoTextBox.Location = new System.Drawing.Point(105, 15);
            this.iDProductoTextBox.Name = "iDProductoTextBox";
            this.iDProductoTextBox.ReadOnly = true;
            this.iDProductoTextBox.Size = new System.Drawing.Size(117, 20);
            this.iDProductoTextBox.TabIndex = 23;
            // 
            // barraTableAdapter
            // 
            this.barraTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // medidaTableAdapter
            // 
            this.medidaTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBodegaDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn1,
            this.stockDataGridViewTextBoxColumn,
            this.minimoDataGridViewTextBoxColumn,
            this.maximoDataGridViewTextBoxColumn,
            this.diasReposicionDataGridViewTextBoxColumn,
            this.cantidadMinimaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bodegaProductoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(379, 110);
            this.dataGridView1.TabIndex = 0;
            // 
            // bodegaProductoBindingSource
            // 
            this.bodegaProductoBindingSource.DataMember = "BodegaProducto";
            this.bodegaProductoBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // bodegaProductoTableAdapter
            // 
            this.bodegaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // iDBodegaDataGridViewTextBoxColumn
            // 
            this.iDBodegaDataGridViewTextBoxColumn.DataPropertyName = "IDBodega";
            this.iDBodegaDataGridViewTextBoxColumn.DataSource = this.bodegaBindingSource;
            this.iDBodegaDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDBodegaDataGridViewTextBoxColumn.HeaderText = "Bodega";
            this.iDBodegaDataGridViewTextBoxColumn.Name = "iDBodegaDataGridViewTextBoxColumn";
            this.iDBodegaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBodegaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDBodegaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDBodegaDataGridViewTextBoxColumn.ValueMember = "IDBodega";
            // 
            // iDProductoDataGridViewTextBoxColumn1
            // 
            this.iDProductoDataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.Name = "iDProductoDataGridViewTextBoxColumn1";
            this.iDProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDProductoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minimoDataGridViewTextBoxColumn
            // 
            this.minimoDataGridViewTextBoxColumn.DataPropertyName = "Minimo";
            this.minimoDataGridViewTextBoxColumn.HeaderText = "Minimo";
            this.minimoDataGridViewTextBoxColumn.Name = "minimoDataGridViewTextBoxColumn";
            this.minimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maximoDataGridViewTextBoxColumn
            // 
            this.maximoDataGridViewTextBoxColumn.DataPropertyName = "Maximo";
            this.maximoDataGridViewTextBoxColumn.HeaderText = "Maximo";
            this.maximoDataGridViewTextBoxColumn.Name = "maximoDataGridViewTextBoxColumn";
            this.maximoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasReposicionDataGridViewTextBoxColumn
            // 
            this.diasReposicionDataGridViewTextBoxColumn.DataPropertyName = "DiasReposicion";
            this.diasReposicionDataGridViewTextBoxColumn.HeaderText = "DiasReposicion";
            this.diasReposicionDataGridViewTextBoxColumn.Name = "diasReposicionDataGridViewTextBoxColumn";
            this.diasReposicionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadMinimaDataGridViewTextBoxColumn
            // 
            this.cantidadMinimaDataGridViewTextBoxColumn.DataPropertyName = "CantidadMinima";
            this.cantidadMinimaDataGridViewTextBoxColumn.HeaderText = "CantidadMinima";
            this.cantidadMinimaDataGridViewTextBoxColumn.Name = "cantidadMinimaDataGridViewTextBoxColumn";
            this.cantidadMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmProducts
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1105, 623);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.productoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmProducts";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingNavigator)).EndInit();
            this.productoBindingNavigator.ResumeLayout(false);
            this.productoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barraBindingSource)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxBarras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarraDataGridView)).EndInit();
            this.gbxBodegas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsAplicacionComercialxsd dsAplicacionComercialxsd;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DsAplicacionComercialxsdTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DsAplicacionComercialxsdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.TextBox imagenTextBox;
        private System.Windows.Forms.TextBox medidaTextBox;
        private System.Windows.Forms.ComboBox iDMedidaComboBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ComboBox iDIVAComboBox;
        private System.Windows.Forms.ComboBox iDDepartamentoComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox iDProductoTextBox;
        private System.Windows.Forms.BindingSource barraBindingSource;
        private DsAplicacionComercialxsdTableAdapters.BarraTableAdapter barraTableAdapter;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DsAplicacionComercialxsdTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private DsAplicacionComercialxsdTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DsAplicacionComercialxsdTableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource medidaBindingSource;
        private DsAplicacionComercialxsdTableAdapters.MedidaTableAdapter medidaTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorModifyItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorShearchItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbxBarras;
        private System.Windows.Forms.DataGridView BarraDataGridView;
        private System.Windows.Forms.GroupBox gbxBodegas;
        private System.Windows.Forms.Button btnAgregarBodega;
        private System.Windows.Forms.Button btnEliminarBarra;
        private System.Windows.Forms.Button btnAgregarBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bodegaProductoBindingSource;
        private DsAplicacionComercialxsdTableAdapters.BodegaProductoTableAdapter bodegaProductoTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasReposicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMinimaDataGridViewTextBoxColumn;
    }
}