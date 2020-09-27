namespace FormMain
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stock10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.lblProductosDataGrid = new System.Windows.Forms.Label();
            this.hardcodearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgCompras = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.hardcodearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompraToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.archivoToolStripMenuItem.Text = "&Compras";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaCompraToolStripMenuItem.Text = "&Nueva Compra";
            this.nuevaCompraToolStripMenuItem.Click += new System.EventHandler(this.nuevaCompraToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verStockToolStripMenuItem,
            this.nuevoProductoToolStripMenuItem,
            this.stock10ToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "&Productos";
            // 
            // verStockToolStripMenuItem
            // 
            this.verStockToolStripMenuItem.Name = "verStockToolStripMenuItem";
            this.verStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verStockToolStripMenuItem.Text = "&Ver Stock";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoProductoToolStripMenuItem.Text = "&Nuevo Producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // stock10ToolStripMenuItem
            // 
            this.stock10ToolStripMenuItem.Name = "stock10ToolStripMenuItem";
            this.stock10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stock10ToolStripMenuItem.Text = "M&enos de 10!";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "C&lientes";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cli&ente";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEmpleadoToolStripMenuItem,
            this.listarEmpleadosToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "E&mpleados";
            // 
            // nuevoEmpleadoToolStripMenuItem
            // 
            this.nuevoEmpleadoToolStripMenuItem.Name = "nuevoEmpleadoToolStripMenuItem";
            this.nuevoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nuevoEmpleadoToolStripMenuItem.Text = "Nuev&o Empleado";
            // 
            // listarEmpleadosToolStripMenuItem
            // 
            this.listarEmpleadosToolStripMenuItem.Name = "listarEmpleadosToolStripMenuItem";
            this.listarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listarEmpleadosToolStripMenuItem.Text = "List&ar Empleados";
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(38, 68);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.Size = new System.Drawing.Size(737, 150);
            this.dtgProductos.TabIndex = 1;
            // 
            // lblProductosDataGrid
            // 
            this.lblProductosDataGrid.AutoSize = true;
            this.lblProductosDataGrid.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosDataGrid.Location = new System.Drawing.Point(33, 35);
            this.lblProductosDataGrid.Name = "lblProductosDataGrid";
            this.lblProductosDataGrid.Size = new System.Drawing.Size(110, 30);
            this.lblProductosDataGrid.TabIndex = 2;
            this.lblProductosDataGrid.Text = "Productos";
            // 
            // hardcodearToolStripMenuItem
            // 
            this.hardcodearToolStripMenuItem.Name = "hardcodearToolStripMenuItem";
            this.hardcodearToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hardcodearToolStripMenuItem.Text = "&Hardcodear";
            this.hardcodearToolStripMenuItem.Click += new System.EventHandler(this.hardcodearToolStripMenuItem_Click);
            // 
            // dtgCompras
            // 
            this.dtgCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCompras.Location = new System.Drawing.Point(38, 264);
            this.dtgCompras.Name = "dtgCompras";
            this.dtgCompras.Size = new System.Drawing.Size(737, 150);
            this.dtgCompras.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Compras";
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(38, 464);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.Size = new System.Drawing.Size(737, 77);
            this.dtgEmpleados.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Empleados";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCompras);
            this.Controls.Add(this.lblProductosDataGrid);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Kwik-E-Mart Management System";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stock10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label lblProductosDataGrid;
        private System.Windows.Forms.ToolStripMenuItem hardcodearToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Label label2;
    }
}

