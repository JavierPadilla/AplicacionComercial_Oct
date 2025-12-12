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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDocumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1028, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsbPrimero
            // 
            this.TsbPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbPrimero.Image = ((System.Drawing.Image)(resources.GetObject("TsbPrimero.Image")));
            this.TsbPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbPrimero.Name = "TsbPrimero";
            this.TsbPrimero.Size = new System.Drawing.Size(28, 28);
            this.TsbPrimero.Text = "toolStripButton1";
            this.TsbPrimero.ToolTipText = "Primer Registro";
            this.TsbPrimero.Click += new System.EventHandler(this.TsbPrimero_Click);
            // 
            // TsbAnterior
            // 
            this.TsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbAnterior.Image = ((System.Drawing.Image)(resources.GetObject("TsbAnterior.Image")));
            this.TsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAnterior.Name = "TsbAnterior";
            this.TsbAnterior.Size = new System.Drawing.Size(28, 28);
            this.TsbAnterior.Text = "toolStripButton2";
            this.TsbAnterior.ToolTipText = "Registro anterior";
            this.TsbAnterior.Click += new System.EventHandler(this.TsbAnterior_Click);
            // 
            // TsbSiguiente
            // 
            this.TsbSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("TsbSiguiente.Image")));
            this.TsbSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSiguiente.Name = "TsbSiguiente";
            this.TsbSiguiente.Size = new System.Drawing.Size(28, 28);
            this.TsbSiguiente.Text = "toolStripButton3";
            this.TsbSiguiente.ToolTipText = "Registro Siguiente";
            this.TsbSiguiente.Click += new System.EventHandler(this.TsbSiguiente_Click);
            // 
            // TsbUltimo
            // 
            this.TsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbUltimo.Image = ((System.Drawing.Image)(resources.GetObject("TsbUltimo.Image")));
            this.TsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbUltimo.Name = "TsbUltimo";
            this.TsbUltimo.Size = new System.Drawing.Size(28, 28);
            this.TsbUltimo.Text = "toolStripButton4";
            this.TsbUltimo.ToolTipText = "Ultimo Registro";
            this.TsbUltimo.Click += new System.EventHandler(this.TsbUltimo_Click);
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
            this.TsbModificar.Size = new System.Drawing.Size(28, 28);
            this.TsbModificar.Text = "toolStripButton5";
            this.TsbModificar.ToolTipText = "Modificar Registro";
            this.TsbModificar.Click += new System.EventHandler(this.TsbModificar_Click);
            // 
            // TsbNuevo
            // 
            this.TsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("TsbNuevo.Image")));
            this.TsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNuevo.Name = "TsbNuevo";
            this.TsbNuevo.Size = new System.Drawing.Size(28, 28);
            this.TsbNuevo.Text = "toolStripButton6";
            this.TsbNuevo.ToolTipText = "Crear un Nuevo Registro";
            this.TsbNuevo.Click += new System.EventHandler(this.TsbNuevo_Click);
            // 
            // TsbEliminar
            // 
            this.TsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TsbEliminar.Image")));
            this.TsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEliminar.Name = "TsbEliminar";
            this.TsbEliminar.Size = new System.Drawing.Size(28, 28);
            this.TsbEliminar.Text = "toolStripButton7";
            this.TsbEliminar.ToolTipText = "Eliminar Registro";
            this.TsbEliminar.Click += new System.EventHandler(this.TsbEliminar_Click);
            // 
            // TsbGuardar
            // 
            this.TsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbGuardar.Enabled = false;
            this.TsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TsbGuardar.Image")));
            this.TsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbGuardar.Name = "TsbGuardar";
            this.TsbGuardar.Size = new System.Drawing.Size(28, 28);
            this.TsbGuardar.Text = "toolStripButton8";
            this.TsbGuardar.ToolTipText = "Guardar Cambios";
            this.TsbGuardar.Click += new System.EventHandler(this.TsbGuardar_Click);
            // 
            // TsbCancelar
            // 
            this.TsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbCancelar.Enabled = false;
            this.TsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("TsbCancelar.Image")));
            this.TsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCancelar.Name = "TsbCancelar";
            this.TsbCancelar.Size = new System.Drawing.Size(28, 28);
            this.TsbCancelar.Text = "toolStripButton9";
            this.TsbCancelar.ToolTipText = "Cancelar";
            this.TsbCancelar.Click += new System.EventHandler(this.TsbCancelar_Click);
            // 
            // TsbBuscar
            // 
            this.TsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("TsbBuscar.Image")));
            this.TsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbBuscar.Name = "TsbBuscar";
            this.TsbBuscar.Size = new System.Drawing.Size(28, 28);
            this.TsbBuscar.ToolTipText = "Buscar un Registro";
            this.TsbBuscar.Click += new System.EventHandler(this.TsbBuscar_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1010, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // DtpAniversario
            // 
            this.DtpAniversario.Enabled = false;
            this.DtpAniversario.Location = new System.Drawing.Point(791, 120);
            this.DtpAniversario.Margin = new System.Windows.Forms.Padding(2);
            this.DtpAniversario.Name = "DtpAniversario";
            this.DtpAniversario.Size = new System.Drawing.Size(205, 20);
            this.DtpAniversario.TabIndex = 36;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(105, 122);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(641, 20);
            this.TxtDireccion.TabIndex = 35;
            // 
            // TxtNotas
            // 
            this.TxtNotas.Location = new System.Drawing.Point(428, 150);
            this.TxtNotas.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ReadOnly = true;
            this.TxtNotas.Size = new System.Drawing.Size(568, 41);
            this.TxtNotas.TabIndex = 34;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(105, 150);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.ReadOnly = true;
            this.TxtCorreo.Size = new System.Drawing.Size(266, 20);
            this.TxtCorreo.TabIndex = 33;
            // 
            // TxtTelefono1
            // 
            this.TxtTelefono1.Location = new System.Drawing.Point(838, 29);
            this.TxtTelefono1.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTelefono1.Name = "TxtTelefono1";
            this.TxtTelefono1.ReadOnly = true;
            this.TxtTelefono1.Size = new System.Drawing.Size(164, 20);
            this.TxtTelefono1.TabIndex = 32;
            // 
            // TxtTelefono2
            // 
            this.TxtTelefono2.Location = new System.Drawing.Point(838, 62);
            this.TxtTelefono2.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTelefono2.Name = "TxtTelefono2";
            this.TxtTelefono2.ReadOnly = true;
            this.TxtTelefono2.Size = new System.Drawing.Size(164, 20);
            this.TxtTelefono2.TabIndex = 31;
            // 
            // TxtNombreComercial
            // 
            this.TxtNombreComercial.Location = new System.Drawing.Point(131, 96);
            this.TxtNombreComercial.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreComercial.Name = "TxtNombreComercial";
            this.TxtNombreComercial.ReadOnly = true;
            this.TxtNombreComercial.Size = new System.Drawing.Size(614, 20);
            this.TxtNombreComercial.TabIndex = 30;
            // 
            // TxtApellidosContacto
            // 
            this.TxtApellidosContacto.Location = new System.Drawing.Point(507, 63);
            this.TxtApellidosContacto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellidosContacto.Name = "TxtApellidosContacto";
            this.TxtApellidosContacto.ReadOnly = true;
            this.TxtApellidosContacto.Size = new System.Drawing.Size(239, 20);
            this.TxtApellidosContacto.TabIndex = 29;
            // 
            // TxtNombreContacto
            // 
            this.TxtNombreContacto.Location = new System.Drawing.Point(131, 63);
            this.TxtNombreContacto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreContacto.Name = "TxtNombreContacto";
            this.TxtNombreContacto.ReadOnly = true;
            this.TxtNombreContacto.Size = new System.Drawing.Size(245, 20);
            this.TxtNombreContacto.TabIndex = 28;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Location = new System.Drawing.Point(601, 31);
            this.TxtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.ReadOnly = true;
            this.TxtDocumento.Size = new System.Drawing.Size(120, 20);
            this.TxtDocumento.TabIndex = 27;
            // 
            // CmbTipoDocumento
            // 
            this.CmbTipoDocumento.DataSource = this.tipoDocumentoBindingSource;
            this.CmbTipoDocumento.DisplayMember = "Descripcion";
            this.CmbTipoDocumento.Enabled = false;
            this.CmbTipoDocumento.FormattingEnabled = true;
            this.CmbTipoDocumento.Location = new System.Drawing.Point(314, 31);
            this.CmbTipoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.CmbTipoDocumento.Name = "CmbTipoDocumento";
            this.CmbTipoDocumento.Size = new System.Drawing.Size(169, 21);
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
            this.TxtIDCliente.Enabled = false;
            this.TxtIDCliente.Location = new System.Drawing.Point(92, 31);
            this.TxtIDCliente.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIDCliente.Name = "TxtIDCliente";
            this.TxtIDCliente.ReadOnly = true;
            this.TxtIDCliente.Size = new System.Drawing.Size(88, 20);
            this.TxtIDCliente.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(765, 96);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Aniversario :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(766, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefono 2 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 152);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Notas: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 152);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Correo :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Direccion :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(765, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefono1 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Apellido contacto :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nombre Contacto :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre Comercial :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Documento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo documento :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id Cliente :";
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.AllowUserToOrderColumns = true;
            this.DgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(8, 248);
            this.DgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersWidth = 62;
            this.DgvClientes.RowTemplate.Height = 28;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(1010, 308);
            this.DgvClientes.TabIndex = 2;
            this.DgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentClick);
            // 
            // tipoDocumentoTableAdapter
            // 
            this.tipoDocumentoTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 556);
            this.Controls.Add(this.DgvClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}