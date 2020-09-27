namespace FormMain
{
    partial class FormCompra
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
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.dtgProductosVendidos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalNumero = new System.Windows.Forms.Label();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblMensajeTotal = new System.Windows.Forms.Label();
            this.lblErrorCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnularCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbNombre.Location = new System.Drawing.Point(172, 12);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(128, 20);
            this.txbNombre.TabIndex = 0;
            // 
            // txbApellido
            // 
            this.txbApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbApellido.Location = new System.Drawing.Point(372, 12);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(138, 20);
            this.txbApellido.TabIndex = 1;
            this.txbApellido.TextChanged += new System.EventHandler(this.txbApellido_TextChanged);
            // 
            // txbDni
            // 
            this.txbDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbDni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbDni.Location = new System.Drawing.Point(565, 11);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(136, 20);
            this.txbDni.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(119, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(321, 15);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(533, 14);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 5;
            this.lblDni.Text = "Dni:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(148, 93);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(187, 21);
            this.cmbEmpleado.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(15, 2);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(83, 30);
            this.lblCliente.TabIndex = 8;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(12, 84);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(106, 30);
            this.lblEmpleado.TabIndex = 9;
            this.lblEmpleado.Text = "Empleado";
            // 
            // dtgProductos
            // 
            this.dtgProductos.AllowUserToAddRows = false;
            this.dtgProductos.AllowUserToDeleteRows = false;
            this.dtgProductos.AllowUserToResizeColumns = false;
            this.dtgProductos.AllowUserToResizeRows = false;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(12, 142);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.ReadOnly = true;
            this.dtgProductos.Size = new System.Drawing.Size(771, 231);
            this.dtgProductos.TabIndex = 10;
            this.dtgProductos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgProductos_MouseDown);
            // 
            // lblSeparador
            // 
            this.lblSeparador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador.Location = new System.Drawing.Point(12, 127);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(766, 2);
            this.lblSeparador.TabIndex = 11;
            // 
            // dtgProductosVendidos
            // 
            this.dtgProductosVendidos.AllowDrop = true;
            this.dtgProductosVendidos.AllowUserToAddRows = false;
            this.dtgProductosVendidos.AllowUserToResizeColumns = false;
            this.dtgProductosVendidos.AllowUserToResizeRows = false;
            this.dtgProductosVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductosVendidos.Location = new System.Drawing.Point(12, 398);
            this.dtgProductosVendidos.Name = "dtgProductosVendidos";
            this.dtgProductosVendidos.Size = new System.Drawing.Size(766, 229);
            this.dtgProductosVendidos.TabIndex = 12;
            this.dtgProductosVendidos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductosVendidos_CellValueChanged);
            this.dtgProductosVendidos.DragDrop += new System.Windows.Forms.DragEventHandler(this.dtgProductosVendidos_DragDrop);
            this.dtgProductosVendidos.DragEnter += new System.Windows.Forms.DragEventHandler(this.dtgProductosVendidos_DragEnter);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(7, 660);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 30);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total: ";
            // 
            // lblTotalNumero
            // 
            this.lblTotalNumero.AutoSize = true;
            this.lblTotalNumero.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumero.Location = new System.Drawing.Point(92, 660);
            this.lblTotalNumero.Name = "lblTotalNumero";
            this.lblTotalNumero.Size = new System.Drawing.Size(0, 30);
            this.lblTotalNumero.TabIndex = 14;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(577, 732);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(201, 46);
            this.btnFinalizarCompra.TabIndex = 15;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // lblMensajeTotal
            // 
            this.lblMensajeTotal.AutoSize = true;
            this.lblMensajeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeTotal.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeTotal.Location = new System.Drawing.Point(20, 690);
            this.lblMensajeTotal.Name = "lblMensajeTotal";
            this.lblMensajeTotal.Size = new System.Drawing.Size(0, 20);
            this.lblMensajeTotal.TabIndex = 16;
            // 
            // lblErrorCliente
            // 
            this.lblErrorCliente.AutoSize = true;
            this.lblErrorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCliente.Location = new System.Drawing.Point(263, 35);
            this.lblErrorCliente.Name = "lblErrorCliente";
            this.lblErrorCliente.Size = new System.Drawing.Size(0, 20);
            this.lblErrorCliente.TabIndex = 17;
            this.lblErrorCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(766, 2);
            this.label2.TabIndex = 18;
            // 
            // btnAnularCompra
            // 
            this.btnAnularCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularCompra.Location = new System.Drawing.Point(339, 732);
            this.btnAnularCompra.Name = "btnAnularCompra";
            this.btnAnularCompra.Size = new System.Drawing.Size(201, 46);
            this.btnAnularCompra.TabIndex = 19;
            this.btnAnularCompra.Text = "Anular Compra";
            this.btnAnularCompra.UseVisualStyleBackColor = true;
            this.btnAnularCompra.Click += new System.EventHandler(this.btnAnularCompra_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 2);
            this.label1.TabIndex = 20;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 790);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnularCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorCliente);
            this.Controls.Add(this.lblMensajeTotal);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.lblTotalNumero);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtgProductosVendidos);
            this.Controls.Add(this.lblSeparador);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductosVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.DataGridView dtgProductosVendidos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalNumero;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label lblMensajeTotal;
        private System.Windows.Forms.Label lblErrorCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnularCompra;
        private System.Windows.Forms.Label label1;
    }
}