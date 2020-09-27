namespace FormMain
{
    partial class FormProducto
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txbStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorDescripcion = new System.Windows.Forms.Label();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.lblErrorStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(44, 48);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(113, 45);
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txbDescripcion.TabIndex = 1;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(113, 81);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 20);
            this.txbPrecio.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(44, 84);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // txbStock
            // 
            this.txbStock.Location = new System.Drawing.Point(113, 117);
            this.txbStock.Name = "txbStock";
            this.txbStock.Size = new System.Drawing.Size(100, 20);
            this.txbStock.TabIndex = 5;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(44, 120);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Stock:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(47, 179);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(150, 179);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Crear Producto";
            // 
            // lblErrorDescripcion
            // 
            this.lblErrorDescripcion.AutoSize = true;
            this.lblErrorDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescripcion.Location = new System.Drawing.Point(113, 65);
            this.lblErrorDescripcion.Name = "lblErrorDescripcion";
            this.lblErrorDescripcion.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDescripcion.TabIndex = 9;
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio.Location = new System.Drawing.Point(113, 101);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPrecio.TabIndex = 10;
            // 
            // lblErrorStock
            // 
            this.lblErrorStock.AutoSize = true;
            this.lblErrorStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStock.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStock.Location = new System.Drawing.Point(113, 140);
            this.lblErrorStock.Name = "lblErrorStock";
            this.lblErrorStock.Size = new System.Drawing.Size(0, 13);
            this.lblErrorStock.TabIndex = 11;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(271, 244);
            this.Controls.Add(this.lblErrorStock);
            this.Controls.Add(this.lblErrorPrecio);
            this.Controls.Add(this.lblErrorDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "FormProducto";
            this.Text = "Kiwk-E-Mart -> Crear Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txbStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorDescripcion;
        private System.Windows.Forms.Label lblErrorPrecio;
        private System.Windows.Forms.Label lblErrorStock;
    }
}