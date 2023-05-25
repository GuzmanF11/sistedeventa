
namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.menurol = new FontAwesome.Sharp.IconMenuItem();
            this.administrarPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuproductos = new FontAwesome.Sharp.IconMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.creditoFsicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menucompras = new FontAwesome.Sharp.IconMenuItem();
            this.submenuregistarcompra = new FontAwesome.Sharp.IconMenuItem();
            this.submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.creditoFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteCreditoFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menuacerca = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.MenuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(1273, 74);
            this.MenuTitulo.TabIndex = 4;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Silver;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.menurol,
            this.menuproductos,
            this.menuventas,
            this.menucompras,
            this.menuclientes,
            this.menuproveedores,
            this.menureportes,
            this.menuacerca});
            this.menu.Location = new System.Drawing.Point(0, 74);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1273, 88);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.IconSize = 60;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(85, 84);
            this.menuusuario.Text = "Usuario";
            this.menuusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click);
            // 
            // menurol
            // 
            this.menurol.AutoSize = false;
            this.menurol.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPermisosToolStripMenuItem});
            this.menurol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menurol.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.menurol.IconColor = System.Drawing.Color.Black;
            this.menurol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menurol.IconSize = 60;
            this.menurol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menurol.Name = "menurol";
            this.menurol.Size = new System.Drawing.Size(85, 84);
            this.menurol.Text = "Roles";
            this.menurol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menurol.Click += new System.EventHandler(this.menurol_Click);
            // 
            // administrarPermisosToolStripMenuItem
            // 
            this.administrarPermisosToolStripMenuItem.Name = "administrarPermisosToolStripMenuItem";
            this.administrarPermisosToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.administrarPermisosToolStripMenuItem.Text = "Administrar Permisos";
            this.administrarPermisosToolStripMenuItem.Click += new System.EventHandler(this.administrarPermisosToolStripMenuItem_Click);
            // 
            // menuproductos
            // 
            this.menuproductos.AutoSize = false;
            this.menuproductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.submenucategoria});
            this.menuproductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproductos.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.menuproductos.IconColor = System.Drawing.Color.Black;
            this.menuproductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproductos.IconSize = 60;
            this.menuproductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproductos.Name = "menuproductos";
            this.menuproductos.Size = new System.Drawing.Size(85, 84);
            this.menuproductos.Text = "Productos";
            this.menuproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproductos.Click += new System.EventHandler(this.menuproductos_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // submenucategoria
            // 
            this.submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenucategoria.IconColor = System.Drawing.Color.Black;
            this.submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenucategoria.Name = "submenucategoria";
            this.submenucategoria.Size = new System.Drawing.Size(166, 26);
            this.submenucategoria.Text = "Categorias";
            this.submenucategoria.Click += new System.EventHandler(this.submenucategoria_Click);
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistrarventa,
            this.submenuverdetalleventa,
            this.creditoFsicalToolStripMenuItem});
            this.menuventas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 60;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(84, 84);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarventa
            // 
            this.submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistrarventa.IconColor = System.Drawing.Color.Black;
            this.submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistrarventa.Name = "submenuregistrarventa";
            this.submenuregistrarventa.Size = new System.Drawing.Size(224, 26);
            this.submenuregistrarventa.Text = "Registrar";
            this.submenuregistrarventa.Click += new System.EventHandler(this.submenuregistrarventa_Click);
            // 
            // submenuverdetalleventa
            // 
            this.submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetalleventa.IconColor = System.Drawing.Color.Black;
            this.submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetalleventa.Name = "submenuverdetalleventa";
            this.submenuverdetalleventa.Size = new System.Drawing.Size(224, 26);
            this.submenuverdetalleventa.Text = "Ver Detalle";
            this.submenuverdetalleventa.Click += new System.EventHandler(this.submenuverdetalleventa_Click);
            // 
            // creditoFsicalToolStripMenuItem
            // 
            this.creditoFsicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.verDetalleToolStripMenuItem});
            this.creditoFsicalToolStripMenuItem.Name = "creditoFsicalToolStripMenuItem";
            this.creditoFsicalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.creditoFsicalToolStripMenuItem.Text = "Credito Fiscal";
            this.creditoFsicalToolStripMenuItem.Click += new System.EventHandler(this.creditoFsicalToolStripMenuItem_Click);
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            this.registrarVentaToolStripMenuItem.Click += new System.EventHandler(this.registrarVentaToolStripMenuItem_Click);
            // 
            // verDetalleToolStripMenuItem
            // 
            this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verDetalleToolStripMenuItem.Text = "Ver Detalle ";
            this.verDetalleToolStripMenuItem.Click += new System.EventHandler(this.verDetalleToolStripMenuItem_Click);
            // 
            // menucompras
            // 
            this.menucompras.AutoSize = false;
            this.menucompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuregistarcompra,
            this.submenuverdetallecompra});
            this.menucompras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucompras.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.menucompras.IconColor = System.Drawing.Color.Black;
            this.menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompras.IconSize = 60;
            this.menucompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompras.Name = "menucompras";
            this.menucompras.Size = new System.Drawing.Size(85, 84);
            this.menucompras.Text = "Compras";
            this.menucompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // submenuregistarcompra
            // 
            this.submenuregistarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuregistarcompra.IconColor = System.Drawing.Color.Black;
            this.submenuregistarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuregistarcompra.Name = "submenuregistarcompra";
            this.submenuregistarcompra.Size = new System.Drawing.Size(168, 26);
            this.submenuregistarcompra.Text = "Registrar";
            this.submenuregistarcompra.Click += new System.EventHandler(this.submenuregistarcompra_Click);
            // 
            // submenuverdetallecompra
            // 
            this.submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.submenuverdetallecompra.IconColor = System.Drawing.Color.Black;
            this.submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.submenuverdetallecompra.Name = "submenuverdetallecompra";
            this.submenuverdetallecompra.Size = new System.Drawing.Size(168, 26);
            this.submenuverdetallecompra.Text = "Ver Detalle";
            this.submenuverdetallecompra.Click += new System.EventHandler(this.submenuverdetallecompra_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditoFiscalToolStripMenuItem,
            this.clienteCreditoFiscalToolStripMenuItem});
            this.menuclientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 60;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(85, 84);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // creditoFiscalToolStripMenuItem
            // 
            this.creditoFiscalToolStripMenuItem.Name = "creditoFiscalToolStripMenuItem";
            this.creditoFiscalToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.creditoFiscalToolStripMenuItem.Text = "Cliente";
            this.creditoFiscalToolStripMenuItem.Click += new System.EventHandler(this.creditoFiscalToolStripMenuItem_Click);
            // 
            // clienteCreditoFiscalToolStripMenuItem
            // 
            this.clienteCreditoFiscalToolStripMenuItem.Name = "clienteCreditoFiscalToolStripMenuItem";
            this.clienteCreditoFiscalToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.clienteCreditoFiscalToolStripMenuItem.Text = "Cliente Credito Fiscal";
            this.clienteCreditoFiscalToolStripMenuItem.Click += new System.EventHandler(this.clienteCreditoFiscalToolStripMenuItem_Click);
            // 
            // menuproveedores
            // 
            this.menuproveedores.AutoSize = false;
            this.menuproveedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuproveedores.IconColor = System.Drawing.Color.Black;
            this.menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuproveedores.IconSize = 60;
            this.menuproveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuproveedores.Name = "menuproveedores";
            this.menuproveedores.Size = new System.Drawing.Size(93, 84);
            this.menuproveedores.Text = "Proveedores";
            this.menuproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuproveedores.Click += new System.EventHandler(this.menuproveedores_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 60;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(85, 84);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureportes.Click += new System.EventHandler(this.menureportes_Click);
            // 
            // menuacerca
            // 
            this.menuacerca.AutoSize = false;
            this.menuacerca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuacerca.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacerca.IconColor = System.Drawing.Color.Black;
            this.menuacerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacerca.IconSize = 60;
            this.menuacerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacerca.Name = "menuacerca";
            this.menuacerca.Size = new System.Drawing.Size(84, 84);
            this.menuacerca.Text = "Acerca De";
            this.menuacerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuacerca.Click += new System.EventHandler(this.menuacerca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(256, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "SISTEMA DE INVENTARIO Y GARANTIA";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 162);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1273, 697);
            this.contenedor.TabIndex = 7;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(908, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "usuario:";
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbusuario.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.ForeColor = System.Drawing.Color.White;
            this.lbusuario.Location = new System.Drawing.Point(966, 37);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(70, 20);
            this.lbusuario.TabIndex = 9;
            this.lbusuario.Text = "lbusuario";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 52;
            this.btnsalir.Location = new System.Drawing.Point(1177, 5);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(67, 63);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 859);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.MenuTitulo);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuproductos;
        private FontAwesome.Sharp.IconMenuItem menuacerca;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbusuario;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuregistarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private FontAwesome.Sharp.IconMenuItem menurol;
        private System.Windows.Forms.ToolStripMenuItem administrarPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnsalir;
        private System.Windows.Forms.ToolStripMenuItem creditoFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteCreditoFiscalToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private System.Windows.Forms.ToolStripMenuItem creditoFsicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
    }
}

