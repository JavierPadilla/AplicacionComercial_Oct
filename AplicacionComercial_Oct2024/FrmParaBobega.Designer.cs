namespace AplicacionComercial_Oct2024
{
    partial class FrmParaBobega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParaBobega));
            this.label1 = new System.Windows.Forms.Label();
            this.BodegaComboBox = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAplicacionComercialxsd = new AplicacionComercial_Oct2024.DsAplicacionComercialxsd();
            this.bodegaTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.BodegaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.MinimoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaximoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinimoOrdenarNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DiasReposicionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAplicacionComercialxsdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodegaProductoTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.BodegaProductoTableAdapter();
            this.usersTableAdapter = new AplicacionComercial_Oct2024.DsAplicacionComercialxsdTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimoOrdenarNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasReposicionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bodega: ";
            // 
            // BodegaComboBox
            // 
            this.BodegaComboBox.DataSource = this.bodegaBindingSource;
            this.BodegaComboBox.DisplayMember = "Descripcion";
            this.BodegaComboBox.FormattingEnabled = true;
            this.BodegaComboBox.Location = new System.Drawing.Point(70, 12);
            this.BodegaComboBox.Name = "BodegaComboBox";
            this.BodegaComboBox.Size = new System.Drawing.Size(143, 21);
            this.BodegaComboBox.TabIndex = 1;
            this.BodegaComboBox.ValueMember = "IDBodega";
            this.BodegaComboBox.SelectedIndexChanged += new System.EventHandler(this.BodegaComboBox_SelectedIndexChanged);
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // dsAplicacionComercialxsd
            // 
            this.dsAplicacionComercialxsd.DataSetName = "DsAplicacionComercialxsd";
            this.dsAplicacionComercialxsd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad Mínima :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Días de reposición : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad Máxima :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = " Cantidad Minima a Ordenar :  ";
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(318, 8);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.ReadOnly = true;
            this.StockTextBox.Size = new System.Drawing.Size(84, 20);
            this.StockTextBox.TabIndex = 7;
            // 
            // MinimoNumericUpDown
            // 
            this.MinimoNumericUpDown.Location = new System.Drawing.Point(103, 56);
            this.MinimoNumericUpDown.Name = "MinimoNumericUpDown";
            this.MinimoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MinimoNumericUpDown.TabIndex = 8;
            // 
            // MaximoNumericUpDown
            // 
            this.MaximoNumericUpDown.Location = new System.Drawing.Point(376, 56);
            this.MaximoNumericUpDown.Name = "MaximoNumericUpDown";
            this.MaximoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MaximoNumericUpDown.TabIndex = 9;
            // 
            // MinimoOrdenarNumericUpDown
            // 
            this.MinimoOrdenarNumericUpDown.Location = new System.Drawing.Point(376, 93);
            this.MinimoOrdenarNumericUpDown.Name = "MinimoOrdenarNumericUpDown";
            this.MinimoOrdenarNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MinimoOrdenarNumericUpDown.TabIndex = 10;
            // 
            // DiasReposicionNumericUpDown
            // 
            this.DiasReposicionNumericUpDown.Location = new System.Drawing.Point(103, 90);
            this.DiasReposicionNumericUpDown.Name = "DiasReposicionNumericUpDown";
            this.DiasReposicionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DiasReposicionNumericUpDown.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(539, 78);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 62);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = global::AplicacionComercial_Oct2024.Properties.Resources.Guardar;
            this.btnAceptar.Location = new System.Drawing.Point(539, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(102, 64);
            this.btnAceptar.TabIndex = 49;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dsAplicacionComercialxsd;
            // 
            // dsAplicacionComercialxsdBindingSource
            // 
            this.dsAplicacionComercialxsdBindingSource.DataSource = this.dsAplicacionComercialxsd;
            this.dsAplicacionComercialxsdBindingSource.Position = 0;
            // 
            // bodegaProductoBindingSource
            // 
            this.bodegaProductoBindingSource.DataMember = "BodegaProducto";
            this.bodegaProductoBindingSource.DataSource = this.dsAplicacionComercialxsdBindingSource;
            // 
            // bodegaProductoTableAdapter
            // 
            this.bodegaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmParaBobega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 145);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.DiasReposicionNumericUpDown);
            this.Controls.Add(this.MinimoOrdenarNumericUpDown);
            this.Controls.Add(this.MaximoNumericUpDown);
            this.Controls.Add(this.MinimoNumericUpDown);
            this.Controls.Add(this.StockTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BodegaComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmParaBobega";
            this.Text = "Parametros de Babega";
            this.Load += new System.EventHandler(this.FrmParaBabega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimoOrdenarNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiasReposicionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAplicacionComercialxsdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BodegaComboBox;
        private DsAplicacionComercialxsd dsAplicacionComercialxsd;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DsAplicacionComercialxsdTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.NumericUpDown MinimoNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaximoNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinimoOrdenarNumericUpDown;
        private System.Windows.Forms.NumericUpDown DiasReposicionNumericUpDown;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource bodegaProductoBindingSource;
        private System.Windows.Forms.BindingSource dsAplicacionComercialxsdBindingSource;
        private DsAplicacionComercialxsdTableAdapters.BodegaProductoTableAdapter bodegaProductoTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DsAplicacionComercialxsdTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}