namespace MyBody
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.btnPicture = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRetornable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Opciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optCantidad = new System.Windows.Forms.ToolStripMenuItem();
            this.optCantidadValor = new System.Windows.Forms.ToolStripTextBox();
            this.optImporte = new System.Windows.Forms.ToolStripMenuItem();
            this.optImporteValor = new System.Windows.Forms.ToolStripTextBox();
            this.optEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tblVenta = new System.Windows.Forms.TableLayoutPanel();
            this.layCB = new System.Windows.Forms.TableLayoutPanel();
            this.txtSocio = new System.Windows.Forms.TextBox();
            this.txtCB = new System.Windows.Forms.TextBox();
            this.pnlSum = new System.Windows.Forms.Panel();
            this.lblUltimo = new System.Windows.Forms.Label();
            this.txtVuelto = new System.Windows.Forms.TextBox();
            this.lblVuelto = new System.Windows.Forms.Label();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.pnlFoto.SuspendLayout();
            this.Opciones.SuspendLayout();
            this.tblVenta.SuspendLayout();
            this.layCB.SuspendLayout();
            this.pnlSum.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(106, 103);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(65, 47);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "OK";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(177, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 47);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlFoto
            // 
            this.pnlFoto.BackgroundImage = global::MyBody.Properties.Resources.PowerAde;
            this.pnlFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFoto.Controls.Add(this.btnPicture);
            this.pnlFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFoto.Location = new System.Drawing.Point(0, 0);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(286, 554);
            this.pnlFoto.TabIndex = 18;
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPicture.BackgroundImage")));
            this.btnPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Location = new System.Drawing.Point(2, 450);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(20, 20);
            this.btnPicture.TabIndex = 11;
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colProducto,
            this.colRetornable,
            this.colCantidad,
            this.colPrecio,
            this.colTotal});
            this.lstProductos.ContextMenuStrip = this.Opciones;
            this.lstProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductos.FullRowSelect = true;
            this.lstProductos.GridLines = true;
            this.lstProductos.Location = new System.Drawing.Point(3, 54);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(504, 322);
            this.lstProductos.TabIndex = 22;
            this.lstProductos.UseCompatibleStateImageBehavior = false;
            this.lstProductos.View = System.Windows.Forms.View.Details;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            this.lstProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstProductos_KeyPress);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 0;
            // 
            // colProducto
            // 
            this.colProducto.Text = "Producto";
            this.colProducto.Width = 167;
            // 
            // colRetornable
            // 
            this.colRetornable.Text = "Retornable";
            this.colRetornable.Width = 66;
            // 
            // colCantidad
            // 
            this.colCantidad.Text = "Cantidad";
            this.colCantidad.Width = 92;
            // 
            // colPrecio
            // 
            this.colPrecio.Text = "Precio";
            this.colPrecio.Width = 92;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            this.colTotal.Width = 83;
            // 
            // Opciones
            // 
            this.Opciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optCantidad,
            this.optImporte,
            this.optEliminar});
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(190, 70);
            // 
            // optCantidad
            // 
            this.optCantidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optCantidadValor});
            this.optCantidad.Name = "optCantidad";
            this.optCantidad.Size = new System.Drawing.Size(189, 22);
            this.optCantidad.Text = "Cambiar cantidad";
            // 
            // optCantidadValor
            // 
            this.optCantidadValor.Name = "optCantidadValor";
            this.optCantidadValor.Size = new System.Drawing.Size(100, 23);
            this.optCantidadValor.TextChanged += new System.EventHandler(this.optCantidadValor_TextChanged);
            // 
            // optImporte
            // 
            this.optImporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optImporteValor});
            this.optImporte.Name = "optImporte";
            this.optImporte.Size = new System.Drawing.Size(189, 22);
            this.optImporte.Text = "Cambiar importe";
            // 
            // optImporteValor
            // 
            this.optImporteValor.Name = "optImporteValor";
            this.optImporteValor.Size = new System.Drawing.Size(100, 23);
            this.optImporteValor.TextChanged += new System.EventHandler(this.optImporteValor_TextChanged);
            // 
            // optEliminar
            // 
            this.optEliminar.Name = "optEliminar";
            this.optEliminar.Size = new System.Drawing.Size(189, 22);
            this.optEliminar.Text = "Eliminar seleccionado";
            this.optEliminar.Click += new System.EventHandler(this.optEliminar_Click);
            // 
            // tblVenta
            // 
            this.tblVenta.ColumnCount = 1;
            this.tblVenta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblVenta.Controls.Add(this.layCB, 0, 0);
            this.tblVenta.Controls.Add(this.lstProductos, 0, 1);
            this.tblVenta.Controls.Add(this.pnlSum, 0, 2);
            this.tblVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblVenta.Location = new System.Drawing.Point(286, 0);
            this.tblVenta.Name = "tblVenta";
            this.tblVenta.RowCount = 3;
            this.tblVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tblVenta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblVenta.Size = new System.Drawing.Size(510, 554);
            this.tblVenta.TabIndex = 23;
            // 
            // layCB
            // 
            this.layCB.ColumnCount = 1;
            this.layCB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layCB.Controls.Add(this.txtSocio, 0, 0);
            this.layCB.Controls.Add(this.txtCB, 0, 1);
            this.layCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layCB.Location = new System.Drawing.Point(3, 3);
            this.layCB.Name = "layCB";
            this.layCB.RowCount = 2;
            this.layCB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layCB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layCB.Size = new System.Drawing.Size(504, 45);
            this.layCB.TabIndex = 24;
            // 
            // txtSocio
            // 
            this.txtSocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSocio.Location = new System.Drawing.Point(3, 3);
            this.txtSocio.Name = "txtSocio";
            this.txtSocio.Size = new System.Drawing.Size(498, 20);
            this.txtSocio.TabIndex = 23;
            this.txtSocio.Text = "DESCONOCIDO  | 0";
            // 
            // txtCB
            // 
            this.txtCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCB.Location = new System.Drawing.Point(3, 25);
            this.txtCB.MaxLength = 25;
            this.txtCB.Name = "txtCB";
            this.txtCB.Size = new System.Drawing.Size(498, 20);
            this.txtCB.TabIndex = 22;
            // 
            // pnlSum
            // 
            this.pnlSum.Controls.Add(this.btnAceptar);
            this.pnlSum.Controls.Add(this.lblUltimo);
            this.pnlSum.Controls.Add(this.btnCancelar);
            this.pnlSum.Controls.Add(this.txtVuelto);
            this.pnlSum.Controls.Add(this.lblVuelto);
            this.pnlSum.Controls.Add(this.txtEntrega);
            this.pnlSum.Controls.Add(this.lblEntrega);
            this.pnlSum.Controls.Add(this.txtTotal);
            this.pnlSum.Controls.Add(this.lblTotal);
            this.pnlSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSum.Location = new System.Drawing.Point(3, 382);
            this.pnlSum.Name = "pnlSum";
            this.pnlSum.Size = new System.Drawing.Size(504, 169);
            this.pnlSum.TabIndex = 24;
            // 
            // lblUltimo
            // 
            this.lblUltimo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUltimo.Location = new System.Drawing.Point(291, 0);
            this.lblUltimo.Name = "lblUltimo";
            this.lblUltimo.Size = new System.Drawing.Size(213, 169);
            this.lblUltimo.TabIndex = 18;
            // 
            // txtVuelto
            // 
            this.txtVuelto.Enabled = false;
            this.txtVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuelto.Location = new System.Drawing.Point(106, 67);
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.Size = new System.Drawing.Size(179, 30);
            this.txtVuelto.TabIndex = 5;
            this.txtVuelto.Text = "0.00";
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelto.Location = new System.Drawing.Point(22, 70);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(68, 25);
            this.lblVuelto.TabIndex = 4;
            this.lblVuelto.Text = "Vuelto";
            // 
            // txtEntrega
            // 
            this.txtEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrega.Location = new System.Drawing.Point(106, 41);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(179, 30);
            this.txtEntrega.TabIndex = 3;
            this.txtEntrega.Text = "0.00";
            this.txtEntrega.TextChanged += new System.EventHandler(this.txtEntrega_TextChanged);
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrega.Location = new System.Drawing.Point(4, 44);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(102, 25);
            this.lblEntrega.TabIndex = 2;
            this.lblEntrega.Text = "Entregado";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(106, 15);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(179, 30);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(4, 18);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 25);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Gran total";
            // 
            // Tiempo
            // 
            this.Tiempo.Interval = 999;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(796, 554);
            this.Controls.Add(this.tblVenta);
            this.Controls.Add(this.pnlFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.pnlFoto.ResumeLayout(false);
            this.Opciones.ResumeLayout(false);
            this.tblVenta.ResumeLayout(false);
            this.layCB.ResumeLayout(false);
            this.layCB.PerformLayout();
            this.pnlSum.ResumeLayout(false);
            this.pnlSum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.ListView lstProductos;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colProducto;
        private System.Windows.Forms.ColumnHeader colPrecio;
        private System.Windows.Forms.ColumnHeader colRetornable;
        private System.Windows.Forms.ColumnHeader colCantidad;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.TableLayoutPanel tblVenta;

       
        private System.Windows.Forms.TextBox txtCB;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.TextBox txtSocio;
        private System.Windows.Forms.Panel pnlSum;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtVuelto;
        private System.Windows.Forms.Label lblVuelto;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.ContextMenuStrip Opciones;
        private System.Windows.Forms.ToolStripMenuItem optCantidad;
        private System.Windows.Forms.ToolStripTextBox optCantidadValor;
        private System.Windows.Forms.ToolStripMenuItem optEliminar;
        private System.Windows.Forms.ToolStripMenuItem optImporte;
        private System.Windows.Forms.ToolStripTextBox optImporteValor;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.TableLayoutPanel layCB;
        private System.Windows.Forms.Label lblUltimo;
    }
}