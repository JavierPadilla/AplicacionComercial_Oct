namespace AplicacionComercial_Oct2024
{
    partial class FrmParametrosBodega
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
            System.Windows.Forms.Label iDBodegaLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label minimoLabel;
            System.Windows.Forms.Label maximoLabel;
            System.Windows.Forms.Label diasReposicionLabel;
            System.Windows.Forms.Label cantidadMinimaLabel;
            System.Windows.Forms.Label iDProductoLabel;
            this.dsAplicacionComercialxsd = new AplicacionComercial_Oct2024.DsAplicacionComercialxsd();
            this.bodegaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaProductoTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.BodegaProductoTableAdapter();
            this.tableAdapterManager = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.TableAdapterManager();
            this.bodegaTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.BodegaTableAdapter();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.minimoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.diasReposicionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cantidadMinimaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bodegacomboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDProductoTextBox = new System.Windows.Forms.TextBox();
            iDBodegaLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            minimoLabel = new System.Windows.Forms.Label();
            maximoLabel = new System.Windows.Forms.Label();
            diasReposicionLabel = new System.Windows.Forms.Label();
            cantidadMinimaLabel = new System.Windows.Forms.Label();
            iDProductoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReposicionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadMinimaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDBodegaLabel
            // 
            iDBodegaLabel.AutoSize = true;
            iDBodegaLabel.Location = new System.Drawing.Point(210, 12);
            iDBodegaLabel.Name = "iDBodegaLabel";
            iDBodegaLabel.Size = new System.Drawing.Size(47, 13);
            iDBodegaLabel.TabIndex = 1;
            iDBodegaLabel.Text = "Bodega:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(18, 51);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(38, 13);
            stockLabel.TabIndex = 3;
            stockLabel.Text = "Stock:";
            // 
            // minimoLabel
            // 
            minimoLabel.AutoSize = true;
            minimoLabel.Location = new System.Drawing.Point(13, 95);
            minimoLabel.Name = "minimoLabel";
            minimoLabel.Size = new System.Drawing.Size(43, 13);
            minimoLabel.TabIndex = 5;
            minimoLabel.Text = "Minimo:";
            // 
            // maximoLabel
            // 
            maximoLabel.AutoSize = true;
            maximoLabel.Location = new System.Drawing.Point(10, 132);
            maximoLabel.Name = "maximoLabel";
            maximoLabel.Size = new System.Drawing.Size(46, 13);
            maximoLabel.TabIndex = 7;
            maximoLabel.Text = "Maximo:";
            // 
            // diasReposicionLabel
            // 
            diasReposicionLabel.AutoSize = true;
            diasReposicionLabel.Location = new System.Drawing.Point(196, 95);
            diasReposicionLabel.Name = "diasReposicionLabel";
            diasReposicionLabel.Size = new System.Drawing.Size(87, 13);
            diasReposicionLabel.TabIndex = 9;
            diasReposicionLabel.Text = "Dias Reposicion:";
            // 
            // cantidadMinimaLabel
            // 
            cantidadMinimaLabel.AutoSize = true;
            cantidadMinimaLabel.Location = new System.Drawing.Point(195, 132);
            cantidadMinimaLabel.Name = "cantidadMinimaLabel";
            cantidadMinimaLabel.Size = new System.Drawing.Size(88, 13);
            cantidadMinimaLabel.TabIndex = 11;
            cantidadMinimaLabel.Text = "Cantidad Minima:";
            // 
            // iDProductoLabel
            // 
            iDProductoLabel.AutoSize = true;
            iDProductoLabel.Location = new System.Drawing.Point(12, 9);
            iDProductoLabel.Name = "iDProductoLabel";
            iDProductoLabel.Size = new System.Drawing.Size(64, 13);
            iDProductoLabel.TabIndex = 13;
            iDProductoLabel.Text = "IDProducto:";
            // 
            // dsAplicacionComercialxsd
            // 
            this.dsAplicacionComercialxsd.DataSetName = "DsAplicacionComercialxsd";
            this.dsAplicacionComercialxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.BodegaProductoTableAdapter = this.bodegaProductoTableAdapter;
            this.tableAdapterManager.BodegaTableAdapter = this.bodegaTableAdapter;
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
            this.tableAdapterManager.ProductoTableAdapter = null;
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
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bodegaProductoBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(62, 48);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(100, 20);
            this.stockTextBox.TabIndex = 4;
            // 
            // minimoNumericUpDown
            // 
            this.minimoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bodegaProductoBindingSource, "Minimo", true));
            this.minimoNumericUpDown.Location = new System.Drawing.Point(62, 95);
            this.minimoNumericUpDown.Name = "minimoNumericUpDown";
            this.minimoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.minimoNumericUpDown.TabIndex = 6;
            // 
            // maximoNumericUpDown
            // 
            this.maximoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bodegaProductoBindingSource, "Maximo", true));
            this.maximoNumericUpDown.Location = new System.Drawing.Point(62, 132);
            this.maximoNumericUpDown.Name = "maximoNumericUpDown";
            this.maximoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.maximoNumericUpDown.TabIndex = 8;
            // 
            // diasReposicionNumericUpDown
            // 
            this.diasReposicionNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bodegaProductoBindingSource, "DiasReposicion", true));
            this.diasReposicionNumericUpDown.Location = new System.Drawing.Point(289, 95);
            this.diasReposicionNumericUpDown.Name = "diasReposicionNumericUpDown";
            this.diasReposicionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.diasReposicionNumericUpDown.TabIndex = 10;
            // 
            // cantidadMinimaNumericUpDown
            // 
            this.cantidadMinimaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bodegaProductoBindingSource, "CantidadMinima", true));
            this.cantidadMinimaNumericUpDown.Location = new System.Drawing.Point(289, 132);
            this.cantidadMinimaNumericUpDown.Name = "cantidadMinimaNumericUpDown";
            this.cantidadMinimaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadMinimaNumericUpDown.TabIndex = 12;
            // 
            // bodegacomboBox
            // 
            this.bodegacomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bodegaProductoBindingSource, "IDBodega", true));
            this.bodegacomboBox.DataSource = this.bodegaBindingSource;
            this.bodegacomboBox.DisplayMember = "Descripcion";
            this.bodegacomboBox.FormattingEnabled = true;
            this.bodegacomboBox.Location = new System.Drawing.Point(274, 12);
            this.bodegacomboBox.Name = "bodegacomboBox";
            this.bodegacomboBox.Size = new System.Drawing.Size(121, 21);
            this.bodegacomboBox.TabIndex = 13;
            this.bodegacomboBox.ValueMember = "IDBodega";
            this.bodegacomboBox.SelectedIndexChanged += new System.EventHandler(this.bodegacomboBox_SelectedIndexChanged);
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // iDProductoTextBox
            // 
            this.iDProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bodegaProductoBindingSource, "IDProducto", true));
            this.iDProductoTextBox.Location = new System.Drawing.Point(82, 6);
            this.iDProductoTextBox.Name = "iDProductoTextBox";
            this.iDProductoTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDProductoTextBox.TabIndex = 14;
            // 
            // FrmParametrosBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 168);
            this.Controls.Add(iDProductoLabel);
            this.Controls.Add(this.iDProductoTextBox);
            this.Controls.Add(this.bodegacomboBox);
            this.Controls.Add(cantidadMinimaLabel);
            this.Controls.Add(this.cantidadMinimaNumericUpDown);
            this.Controls.Add(diasReposicionLabel);
            this.Controls.Add(this.diasReposicionNumericUpDown);
            this.Controls.Add(maximoLabel);
            this.Controls.Add(this.maximoNumericUpDown);
            this.Controls.Add(minimoLabel);
            this.Controls.Add(this.minimoNumericUpDown);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(iDBodegaLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmParametrosBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parametros de Bodega";
            this.Load += new System.EventHandler(this.FrmParametrosBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diasReposicionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadMinimaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DsAplicacionComercialxsd dsAplicacionComercialxsd;
        private System.Windows.Forms.BindingSource bodegaProductoBindingSource;
        private DsAplicacionComercialxsdTableAdapters.BodegaProductoTableAdapter bodegaProductoTableAdapter;
        private DsAplicacionComercialxsdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.NumericUpDown minimoNumericUpDown;
        private System.Windows.Forms.NumericUpDown maximoNumericUpDown;
        private System.Windows.Forms.NumericUpDown diasReposicionNumericUpDown;
        private System.Windows.Forms.NumericUpDown cantidadMinimaNumericUpDown;
        private DsAplicacionComercialxsdTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.ComboBox bodegacomboBox;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private System.Windows.Forms.TextBox iDProductoTextBox;
    }
}