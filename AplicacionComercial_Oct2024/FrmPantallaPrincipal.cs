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
    public partial class FrmPantallaPrincipal : Form
    {
        public FrmPantallaPrincipal()
        {
            InitializeComponent();
            ConfigurarToolStrip();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente formCliente = new FrmCliente();  
            formCliente.MdiParent=this;
            formCliente.Show();
        }

        private void FrmPantallaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores formProveedores=new FrmProveedores();
            formProveedores.MdiParent = this;
            formProveedores.Show();

        }



        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducts miFrmProductos = new FrmProducts();
            miFrmProductos.MdiParent = this;
            miFrmProductos.Show();
        }

        private void TsbClientes_Click(object sender, EventArgs e)
        {
            clientesToolStripMenuItem_Click(sender,e);

        }

        private void TsbProveedores_Click(object sender, EventArgs e)
        {
            proveedoresToolStripMenuItem_Click(sender,e);
        }

        private void TsbProductos_Click(object sender, EventArgs e)
        {
            productosToolStripMenuItem_Click(sender,e);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();

        }

        private void FrmPantallaPrincipal_Load(object sender, EventArgs e)
        {

        }
        #region Metodos

        #region Configuracion de tooslstrip
        private void ConfigurarToolStrip()
        {
            // Configurar el tamaño del ToolStrip
            toolStrip1.AutoSize = true;
            toolStrip1.Height = 500; // Altura personalizada

            // Estilo visual moderno
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.BackColor = Color.FromArgb(45, 45, 48); // Color oscuro moderno
            toolStrip1.ForeColor = Color.White;
            

            // Padding para mejor espaciado
            toolStrip1.Padding = new Padding(5, 0, 5, 0);

            // Configurar los botones del ToolStrip
            toolStrip1.ImageScalingSize = new Size(64, 64); // Tamaño de las imágenes
            ConfigurarBotonesToolStrip();
        }

        private void ConfigurarBotonesToolStrip()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item is ToolStripButton button)
                {
                    // Tamaño de los botones
                    button.AutoSize = true;
                    button.Size = new Size(160, 140);
                    button.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                
                    //button.ImageScaling = ToolStripItemImageScaling.None;
                    // Estilo del texto
                    button.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                    button.ForeColor = Color.White;

                    // Alineación del contenido
                    button.TextImageRelation = TextImageRelation.ImageBeforeText;
                    button.ImageAlign = ContentAlignment.MiddleLeft;
                    button.TextAlign = ContentAlignment.MiddleLeft;

                    // Efecto hover
                    button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(62, 62, 66);
                    button.MouseLeave += (s, e) => button.BackColor = Color.Transparent;
                }

                // Configurar separadores
                if (item is ToolStripSeparator separator)
                {
                    separator.ForeColor = Color.FromArgb(80, 80, 80);
                }
            }
        }

        // Renderizador personalizado para mayor control
        private void AplicarRenderizadorPersonalizado()
        {
            toolStrip1.Renderer = new MiToolStripRenderer();
        }

        // Clase de renderizador personalizado
        public class MiToolStripRenderer : ToolStripProfessionalRenderer
        {
            public MiToolStripRenderer() : base(new MiColorTable()) { }

            protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
            {
                if (e.Item is ToolStripButton button)
                {
                    if (button.Selected || button.Pressed)
                    {
                        // Color cuando está seleccionado o presionado
                        Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
                        using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 122, 204)))
                        {
                            e.Graphics.FillRectangle(brush, bounds);
                        }
                    }
                    else if (button.BackColor != Color.Transparent)
                    {
                        // Color de fondo personalizado
                        Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
                        using (SolidBrush brush = new SolidBrush(button.BackColor))
                        {
                            e.Graphics.FillRectangle(brush, bounds);
                        }
                    }
                }
            }
        }
        // Método auxiliar para redimensionar imágenes
        private Image RedimensionarImagen(Image imgOriginal, int ancho, int alto)
        {
            if (imgOriginal == null) return null;

            Bitmap bmp = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgOriginal, 0, 0, ancho, alto);
            }
            return bmp;
        }

        // Tabla de colores personalizada
        public class MiColorTable : ProfessionalColorTable
        {
            public override Color ToolStripGradientBegin => Color.FromArgb(225, 235, 245);
            public override Color ToolStripGradientMiddle => Color.FromArgb(225, 235, 245);
            public override Color ToolStripGradientEnd => Color.FromArgb(225, 235, 245);

            // Colores de los botones
            public override Color ButtonSelectedHighlight => Color.FromArgb(180, 210, 240);
            public override Color ButtonSelectedBorder => Color.FromArgb(100, 150, 200);
            public override Color ButtonPressedHighlight => Color.FromArgb(100, 150, 200);
            public override Color ButtonPressedBorder => Color.FromArgb(70, 120, 170);
            public override Color ButtonPressedGradientBegin => Color.FromArgb(100, 150, 200);
            public override Color ButtonPressedGradientEnd => Color.FromArgb(120, 170, 220);
            public override Color ButtonSelectedGradientBegin => Color.FromArgb(180, 210, 240);
            public override Color ButtonSelectedGradientEnd => Color.FromArgb(200, 220, 245);

        }
        #endregion
        #endregion
    }
}
