namespace AplicacionComercial_Oct2024
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsbPrimero = new System.Windows.Forms.ToolStripButton();
            this.TsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.TsbSiguiente = new System.Windows.Forms.ToolStripButton();
            this.TsbUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbModificar = new System.Windows.Forms.ToolStripButton();
            this.TsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.TsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.TsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.TsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpAniversario = new System.Windows.Forms.DateTimePicker();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtTelefono1 = new System.Windows.Forms.TextBox();
            this.TxtTelefono2 = new System.Windows.Forms.TextBox();
            this.TxtNombreComercial = new System.Windows.Forms.TextBox();
            this.TxtApellidosContacto = new System.Windows.Forms.TextBox();
            this.TxtNombreContacto = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.CmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.tipoDocumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAplicacionComercialxsdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAplicacionComercialxsd = new AplicacionComercial_Oct2024.DsAplicacionComercialxsd();
            this.TxtIDCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.tipoDocumentoTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.TipoDocumentoTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbPrimero,
            this.TsbAnterior,
            this.TsbSiguiente,
            this.TsbUltimo,
            this.toolStripSeparator1,
            this.TsbModificar,
            this.TsbNuevo,
            this.TsbEliminar,
            this.TsbGuardar,
            this.TsbCancelar,
            this.TsbBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1700, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbPrimero
            // 
            this.TsbPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPrimero.Image = ((System.Drawing.Image)(resources.GetObject("TsbPrimero.Image")));
            this.TsbPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPrimero.Name = "TsbPrimero";
            this.TsbPrimero.Size = new System.Drawing.Size(29, 28);
            this.TsbPrimero.Text = "toolStripButton1";
            this.TsbPrimero.ToolTipText = "Primer Registro";
            // 
            // TsbAnterior
            // 
            this.TsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbAnterior.Image = ((System.Drawing.Image)(resources.GetObject("TsbAnterior.Image")));
            this.TsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAnterior.Name = "TsbAnterior";
            this.TsbAnterior.Size = new System.Drawing.Size(29, 28);
            this.TsbAnterior.Text = "toolStripButton2";
            this.TsbAnterior.ToolTipText = "Registro anterior";
            // 
            // TsbSiguiente
            // 
            this.TsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("TsbSiguiente.Image")));
            this.TsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSiguiente.Name = "TsbSiguiente";
            this.TsbSiguiente.Size = new System.Drawing.Size(29, 28);
            this.TsbSiguiente.Text = "toolStripButton3";
            this.TsbSiguiente.ToolTipText = "Registro Siguiente";
            // 
            // TsbUltimo
            // 
            this.TsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbUltimo.Image = ((System.Drawing.Image)(resources.GetObject("TsbUltimo.Image")));
            this.TsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbUltimo.Name = "TsbUltimo";
            this.TsbUltimo.Size = new System.Drawing.Size(29, 28);
            this.TsbUltimo.Text = "toolStripButton4";
            this.TsbUltimo.ToolTipText = "Ultimo Registro";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // TsbModificar
            // 
            this.TsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("TsbModificar.Image")));
            this.TsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbModificar.Name = "TsbModificar";
            this.TsbModificar.Size = new System.Drawing.Size(29, 28);
            this.TsbModificar.Text = "toolStripButton5";
            this.TsbModificar.ToolTipText = "Modificar Registro";
            // 
            // TsbNuevo
            // 
            this.TsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("TsbNuevo.Image")));
            this.TsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNuevo.Name = "TsbNuevo";
            this.TsbNuevo.Size = new System.Drawing.Size(29, 28);
            this.TsbNuevo.Text = "toolStripButton6";
            this.TsbNuevo.ToolTipText = "Crear un Nuevo Registro";
            // 
            // TsbEliminar
            // 
            this.TsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TsbEliminar.Image")));
            this.TsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEliminar.Name = "TsbEliminar";
            this.TsbEliminar.Size = new System.Drawing.Size(29, 28);
            this.TsbEliminar.Text = "toolStripButton7";
            this.TsbEliminar.ToolTipText = "Eliminar Registro";
            // 
            // TsbGuardar
            // 
            this.TsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TsbGuardar.Image")));
            this.TsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbGuardar.Name = "TsbGuardar";
            this.TsbGuardar.Size = new System.Drawing.Size(29, 28);
            this.TsbGuardar.Text = "toolStripButton8";
            this.TsbGuardar.ToolTipText = "Guardar Cambios";
            // 
            // TsbCancelar
            // 
            this.TsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("TsbCancelar.Image")));
            this.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCancelar.Name = "TsbCancelar";
            this.TsbCancelar.Size = new System.Drawing.Size(29, 28);
            this.TsbCancelar.Text = "toolStripButton9";
            this.TsbCancelar.ToolTipText = "Cancelar";
            // 
            // TsbBuscar
            // 
            this.TsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("TsbBuscar.Image")));
            this.TsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbBuscar.Name = "TsbBuscar";
            this.TsbBuscar.Size = new System.Drawing.Size(29, 28);
            this.TsbBuscar.ToolTipText = "Buscar un Registro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpAniversario);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.TxtNotas);
            this.groupBox1.Controls.Add(this.TxtCorreo);
            this.groupBox1.Controls.Add(this.TxtTelefono1);
            this.groupBox1.Controls.Add(this.TxtTelefono2);
            this.groupBox1.Controls.Add(this.TxtNombreComercial);
            this.groupBox1.Controls.Add(this.TxtApellidosContacto);
            this.groupBox1.Controls.Add(this.TxtNombreContacto);
            this.groupBox1.Controls.Add(this.TxtDocumento);
            this.groupBox1.Controls.Add(this.CmbTipoDocumento);
            this.groupBox1.Controls.Add(this.TxtIDCliente);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1346, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // DtpAniversario
            // 
            this.DtpAniversario.Location = new System.Drawing.Point(1055, 148);
            this.DtpAniversario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpAniversario.Name = "DtpAniversario";
            this.DtpAniversario.Size = new System.Drawing.Size(272, 22);
            this.DtpAniversario.TabIndex = 36;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(140, 150);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(853, 22);
            this.TxtDireccion.TabIndex = 35;
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(571, 185);
            this.TxtNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.Size = new System.Drawing.Size(756, 50);
            this.TxtNotas.TabIndex = 34;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(140, 185);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(354, 22);
            this.TxtCorreo.TabIndex = 33;
            // 
            // TxtTelefono1
            // 
            this.TxtTelefono1.Location = new System.Drawing.Point(1117, 36);
            this.TxtTelefono1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelefono1.Name = "TxtTelefono1";
            this.TxtTelefono1.Size = new System.Drawing.Size(218, 22);
            this.TxtTelefono1.TabIndex = 32;
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Location = new System.Drawing.Point(1117, 76);
            this.TxtTelefono2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.Size = new System.Drawing.Size(218, 22);
            this.TxtTelefono2.TabIndex = 31;
            // 
            // TxtNombreComercial
            // 
            this.TxtNombreComercial.Location = new System.Drawing.Point(175, 118);
            this.TxtNombreComercial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombreComercial.Name = "TxtNombreComercial";
            this.TxtNombreComercial.Size = new System.Drawing.Size(817, 22);
            this.TxtNombreComercial.TabIndex = 30;
            // 
            // TxtApellidosContacto
            // 
            this.TxtApellidosContacto.Location = new System.Drawing.Point(676, 78);
            this.TxtApellidosContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApellidosContacto.Name = "TxtApellidosContacto";
            this.TxtApellidosContacto.Size = new System.Drawing.Size(317, 22);
            this.TxtApellidosContacto.TabIndex = 29;
            // 
            // TxtNombreContacto
            // 
            this.TxtNombreContacto.Location = new System.Drawing.Point(175, 78);
            this.TxtNombreContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombreContacto.Name = "TxtNombreContacto";
            this.TxtNombreContacto.Size = new System.Drawing.Size(325, 22);
            this.TxtNombreContacto.TabIndex = 28;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(801, 38);
            this.TxtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(159, 22);
            this.TxtDocumento.TabIndex = 27;
            // 
            // CmbTipoDocumento
            // 
            this.CmbTipoDocumento.DataSource = this.tipoDocumentoBindingSource;
            this.CmbTipoDocumento.DisplayMember = "Descripcion";
            this.CmbTipoDocumento.FormattingEnabled = true;
            this.CmbTipoDocumento.Location = new System.Drawing.Point(418, 38);
            this.CmbTipoDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTipoDocumento.Name = "CmbTipoDocumento";
            this.CmbTipoDocumento.Size = new System.Drawing.Size(224, 24);
            this.CmbTipoDocumento.TabIndex = 26;
            this.CmbTipoDocumento.ValueMember = "IDTipoDocumento";
            // 
            // tipoDocumentoBindingSource
            // 
            this.tipoDocumentoBindingSource.DataMember = "TipoDocumento";
            this.tipoDocumentoBindingSource.DataSource = this.dsAplicacionComercialxsdBindingSource;
            // 
            // dsAplicacionComercialxsdBindingSource
            // 
            this.dsAplicacionComercialxsdBindingSource.DataSource = this.dsAplicacionComercialxsd;
            this.dsAplicacionComercialxsdBindingSource.Position = 0;
            // 
            // dsAplicacionComercialxsd
            // 
            this.dsAplicacionComercialxsd.DataSetName = "DsAplicacionComercialxsd";
            this.dsAplicacionComercialxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtIDCliente
            // 
            this.TxtIDCliente.Location = new System.Drawing.Point(122, 38);
            this.TxtIDCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIDCliente.Name = "TxtIDCliente";
            this.TxtIDCliente.ReadOnly = true;
            this.TxtIDCliente.Size = new System.Drawing.Size(116, 22);
            this.TxtIDCliente.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1020, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Aniversario :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1021, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefono 2 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Notas: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Correo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Direccion :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1020, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefono1 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Apellido contacto :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre Contacto :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre Comercial :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(694, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Documento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo documento :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id Cliente :";
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.AllowUserToOrderColumns = true;
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(11, 292);
            this.DgvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersWidth = 62;
            this.DgvClientes.RowTemplate.Height = 28;
            this.DgvClientes.Size = new System.Drawing.Size(1677, 381);
            this.DgvClientes.TabIndex = 2;
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 684);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCliente";
            this.Text = "Formulario  de Clientes";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TsbPrimero;
        private System.Windows.Forms.ToolStripButton TsbAnterior;
        private System.Windows.Forms.ToolStripButton TsbSiguiente;
        private System.Windows.Forms.ToolStripButton TsbUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsbModificar;
        private System.Windows.Forms.ToolStripButton TsbNuevo;
        private System.Windows.Forms.ToolStripButton TsbEliminar;
        private System.Windows.Forms.ToolStripButton TsbGuardar;
        private System.Windows.Forms.ToolStripButton TsbCancelar;
        private System.Windows.Forms.ToolStripButton TsbBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNombreContacto;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.ComboBox CmbTipoDocumento;
        private System.Windows.Forms.TextBox TxtIDCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtApellidosContacto;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtTelefono1;
        private System.Windows.Forms.TextBox TxtTelefono2;
        private System.Windows.Forms.TextBox TxtNombreComercial;
        private System.Windows.Forms.DateTimePicker DtpAniversario;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.BindingSource dsAplicacionComercialxsdBindingSource;
        private DsAplicacionComercialxsd dsAplicacionComercialxsd;
        private System.Windows.Forms.BindingSource tipoDocumentoBindingSource;
        private DsAplicacionComercialxsdTableAdapters.TipoDocumentoTableAdapter tipoDocumentoTableAdapter;
    }
}