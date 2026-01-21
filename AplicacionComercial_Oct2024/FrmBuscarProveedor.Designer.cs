namespace AplicacionComercial_Oct2024
{
    partial class FrmBuscarProveedor
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
            System.Windows.Forms.Label apellidosContactoLabel;
            System.Windows.Forms.Label nombresContactoLabel;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label nombreLabel;
            this.proveedorDataGridView = new System.Windows.Forms.DataGridView();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAplicacionComercialxsd = new AplicacionComercial_Oct2024.DsAplicacionComercialxsd();
            this.proveedorTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.ProveedorTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.apellidosContactoTextBox = new System.Windows.Forms.TextBox();
            this.nombresContactoTextBox = new System.Windows.Forms.TextBox();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.iDProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            apellidosContactoLabel = new System.Windows.Forms.Label();
            nombresContactoLabel = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidosContactoLabel
            // 
            apellidosContactoLabel.AutoSize = true;
            apellidosContactoLabel.Location = new System.Drawing.Point(294, 38);
            apellidosContactoLabel.Name = "apellidosContactoLabel";
            apellidosContactoLabel.Size = new System.Drawing.Size(98, 13);
            apellidosContactoLabel.TabIndex = 26;
            apellidosContactoLabel.Text = "Apellidos Contacto:";
            // 
            // nombresContactoLabel
            // 
            nombresContactoLabel.AutoSize = true;
            nombresContactoLabel.Location = new System.Drawing.Point(10, 35);
            nombresContactoLabel.Name = "nombresContactoLabel";
            nombresContactoLabel.Size = new System.Drawing.Size(98, 13);
            nombresContactoLabel.TabIndex = 24;
            nombresContactoLabel.Text = "Nombres Contacto:";
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Location = new System.Drawing.Point(326, 12);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 22;
            documentoLabel.Text = "Documento:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(57, 9);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 20;
            nombreLabel.Text = "Nombre:";
            // 
            // proveedorDataGridView
            // 
            this.proveedorDataGridView.AllowUserToAddRows = false;
            this.proveedorDataGridView.AllowUserToDeleteRows = false;
            this.proveedorDataGridView.AllowUserToOrderColumns = true;
            this.proveedorDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.proveedorDataGridView.AutoGenerateColumns = false;
            this.proveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProveedorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.iDTipoDocumentoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.nombresContactoDataGridViewTextBoxColumn,
            this.apellidosContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn});
            this.proveedorDataGridView.DataSource = this.proveedorBindingSource;
            this.proveedorDataGridView.Location = new System.Drawing.Point(0, 118);
            this.proveedorDataGridView.Name = "proveedorDataGridView";
            this.proveedorDataGridView.ReadOnly = true;
            this.proveedorDataGridView.Size = new System.Drawing.Size(744, 193);
            this.proveedorDataGridView.TabIndex = 0;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // dsAplicacionComercialxsd
            // 
            this.dsAplicacionComercialxsd.DataSetName = "DsAplicacionComercialxsd";
            this.dsAplicacionComercialxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = global::AplicacionComercial_Oct2024.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(642, 61);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 51);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::AplicacionComercial_Oct2024.Properties.Resources.Aceptar2;
            this.btnAceptar.Location = new System.Drawing.Point(558, 61);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 51);
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::AplicacionComercial_Oct2024.Properties.Resources.Buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(390, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 51);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(474, 61);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(78, 51);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // apellidosContactoTextBox
            // 
            this.apellidosContactoTextBox.Location = new System.Drawing.Point(398, 35);
            this.apellidosContactoTextBox.Name = "apellidosContactoTextBox";
            this.apellidosContactoTextBox.Size = new System.Drawing.Size(161, 20);
            this.apellidosContactoTextBox.TabIndex = 27;
            this.apellidosContactoTextBox.TextChanged += new System.EventHandler(this.apellidosContactoTextBox_TextChanged);
            // 
            // nombresContactoTextBox
            // 
            this.nombresContactoTextBox.Location = new System.Drawing.Point(110, 32);
            this.nombresContactoTextBox.Name = "nombresContactoTextBox";
            this.nombresContactoTextBox.Size = new System.Drawing.Size(161, 20);
            this.nombresContactoTextBox.TabIndex = 25;
            this.nombresContactoTextBox.TextChanged += new System.EventHandler(this.nombresContactoTextBox_TextChanged);
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.Location = new System.Drawing.Point(398, 9);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoTextBox.TabIndex = 23;
            this.documentoTextBox.TextChanged += new System.EventHandler(this.documentoTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(110, 6);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(161, 20);
            this.nombreTextBox.TabIndex = 21;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // iDProveedorDataGridViewTextBoxColumn
            // 
            this.iDProveedorDataGridViewTextBoxColumn.DataPropertyName = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.HeaderText = "IDProveedor";
            this.iDProveedorDataGridViewTextBoxColumn.Name = "iDProveedorDataGridViewTextBoxColumn";
            this.iDProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProveedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDTipoDocumentoDataGridViewTextBoxColumn
            // 
            this.iDTipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "IDTipoDocumento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.HeaderText = "IDTipoDocumento";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.Name = "iDTipoDocumentoDataGridViewTextBoxColumn";
            this.iDTipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresContactoDataGridViewTextBoxColumn
            // 
            this.nombresContactoDataGridViewTextBoxColumn.DataPropertyName = "NombresContacto";
            this.nombresContactoDataGridViewTextBoxColumn.HeaderText = "NombresContacto";
            this.nombresContactoDataGridViewTextBoxColumn.Name = "nombresContactoDataGridViewTextBoxColumn";
            this.nombresContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosContactoDataGridViewTextBoxColumn
            // 
            this.apellidosContactoDataGridViewTextBoxColumn.DataPropertyName = "ApellidosContacto";
            this.apellidosContactoDataGridViewTextBoxColumn.HeaderText = "ApellidosContacto";
            this.apellidosContactoDataGridViewTextBoxColumn.Name = "apellidosContactoDataGridViewTextBoxColumn";
            this.apellidosContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            this.telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            this.telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefono2DataGridViewTextBoxColumn.Visible = false;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoDataGridViewTextBoxColumn.Visible = false;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            this.notasDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmBuscarProveedor
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(760, 329);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(apellidosContactoLabel);
            this.Controls.Add(this.apellidosContactoTextBox);
            this.Controls.Add(nombresContactoLabel);
            this.Controls.Add(this.nombresContactoTextBox);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.proveedorDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarProveedor";
            this.Text = "Buscar Proveedor";
            this.Load += new System.EventHandler(this.FrmBuscarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proveedorDataGridView;
        private DsAplicacionComercialxsd dsAplicacionComercialxsd;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DsAplicacionComercialxsdTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox apellidosContactoTextBox;
        private System.Windows.Forms.TextBox nombresContactoTextBox;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
    }
}