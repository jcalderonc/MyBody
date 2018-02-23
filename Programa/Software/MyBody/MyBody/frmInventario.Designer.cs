namespace MyBody
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.tbcInventario = new System.Windows.Forms.TabControl();
            this.tpgProductos = new System.Windows.Forms.TabPage();
            this.tblEdicion = new System.Windows.Forms.TableLayoutPanel();
            this.tblModificar = new System.Windows.Forms.TableLayoutPanel();
            this.gbxProducto = new System.Windows.Forms.GroupBox();
            this.txtPiezas = new System.Windows.Forms.TextBox();
            this.lblPiezas = new System.Windows.Forms.Label();
            this.cbxRetornable = new System.Windows.Forms.CheckBox();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.lblCompra = new System.Windows.Forms.Label();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblCB = new System.Windows.Forms.Label();
            this.txtBarras = new System.Windows.Forms.TextBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.cbxActivo = new System.Windows.Forms.CheckBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPVenta = new System.Windows.Forms.Label();
            this.gbxInventario = new System.Windows.Forms.GroupBox();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblEsperado = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblMostrador = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtMostrador = new System.Windows.Forms.TextBox();
            this.lblAlmacen = new System.Windows.Forms.Label();
            this.txtAlmacen = new System.Windows.Forms.TextBox();
            this.btnMostrador = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnPicture = new System.Windows.Forms.Button();
            this.tpgExistencias = new System.Windows.Forms.TabPage();
            this.tblProductos = new System.Windows.Forms.TableLayoutPanel();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.lstInventario = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPresentacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClave = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBarra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPiezas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAlmacen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMostrador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExistencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRetornable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colActivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlEstatus = new System.Windows.Forms.ImageList(this.components);
            this.tpgServicios = new System.Windows.Forms.TabPage();
            this.tblServicios = new System.Windows.Forms.TableLayoutPanel();
            this.pnlServicios = new System.Windows.Forms.Panel();
            this.lblFechasServicio = new System.Windows.Forms.Label();
            this.dtpFinServicios = new System.Windows.Forms.DateTimePicker();
            this.txtMontoServicio = new System.Windows.Forms.TextBox();
            this.dtpInicioServicios = new System.Windows.Forms.DateTimePicker();
            this.lblMontoServicio = new System.Windows.Forms.Label();
            this.gbxFiltroServicio = new System.Windows.Forms.GroupBox();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnPrecioServicio = new System.Windows.Forms.Button();
            this.txtPrecioServicio = new System.Windows.Forms.TextBox();
            this.lblPrecioServicio = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lstServicios = new System.Windows.Forms.ListView();
            this.colIDSocio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombreSocio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSuscripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServicioCobrado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPendienteServicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.tblVentas = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.btnCortes = new System.Windows.Forms.Button();
            this.cmbCorte = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblFechaVendido = new System.Windows.Forms.Label();
            this.dtpFinVenta = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioVenta = new System.Windows.Forms.DateTimePicker();
            this.lstVenta = new System.Windows.Forms.ListView();
            this.colUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSocio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCobrado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSaldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMargen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSum = new System.Windows.Forms.Panel();
            this.txtMargen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtVendido = new System.Windows.Forms.TextBox();
            this.lblTotalVendido = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.tblInventario = new System.Windows.Forms.TableLayoutPanel();
            this.tbcInventario.SuspendLayout();
            this.tpgProductos.SuspendLayout();
            this.tblEdicion.SuspendLayout();
            this.tblModificar.SuspendLayout();
            this.gbxProducto.SuspendLayout();
            this.gbxInventario.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.tpgExistencias.SuspendLayout();
            this.tblProductos.SuspendLayout();
            this.gbxFiltros.SuspendLayout();
            this.tpgServicios.SuspendLayout();
            this.tblServicios.SuspendLayout();
            this.pnlServicios.SuspendLayout();
            this.gbxFiltroServicio.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tblVentas.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlSum.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.tblInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcInventario
            // 
            this.tbcInventario.Controls.Add(this.tpgProductos);
            this.tbcInventario.Controls.Add(this.tpgExistencias);
            this.tbcInventario.Controls.Add(this.tpgServicios);
            this.tbcInventario.Controls.Add(this.tabVentas);
            this.tbcInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcInventario.Location = new System.Drawing.Point(3, 3);
            this.tbcInventario.Name = "tbcInventario";
            this.tbcInventario.SelectedIndex = 0;
            this.tbcInventario.Size = new System.Drawing.Size(790, 532);
            this.tbcInventario.TabIndex = 0;
            this.tbcInventario.SelectedIndexChanged += new System.EventHandler(this.tbcInventario_SelectedIndexChanged);
            // 
            // tpgProductos
            // 
            this.tpgProductos.Controls.Add(this.tblEdicion);
            this.tpgProductos.Location = new System.Drawing.Point(4, 22);
            this.tpgProductos.Margin = new System.Windows.Forms.Padding(0);
            this.tpgProductos.Name = "tpgProductos";
            this.tpgProductos.Size = new System.Drawing.Size(782, 506);
            this.tpgProductos.TabIndex = 1;
            this.tpgProductos.Text = "Edición";
            this.tpgProductos.UseVisualStyleBackColor = true;
            // 
            // tblEdicion
            // 
            this.tblEdicion.ColumnCount = 2;
            this.tblEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            this.tblEdicion.Controls.Add(this.tblModificar, 1, 0);
            this.tblEdicion.Controls.Add(this.pnlLogo, 0, 0);
            this.tblEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEdicion.Location = new System.Drawing.Point(0, 0);
            this.tblEdicion.Name = "tblEdicion";
            this.tblEdicion.RowCount = 1;
            this.tblEdicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEdicion.Size = new System.Drawing.Size(782, 506);
            this.tblEdicion.TabIndex = 20;
            // 
            // tblModificar
            // 
            this.tblModificar.ColumnCount = 1;
            this.tblModificar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblModificar.Controls.Add(this.gbxProducto, 0, 0);
            this.tblModificar.Controls.Add(this.gbxInventario, 0, 1);
            this.tblModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblModificar.Location = new System.Drawing.Point(401, 3);
            this.tblModificar.Name = "tblModificar";
            this.tblModificar.RowCount = 2;
            this.tblModificar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.4142F));
            this.tblModificar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.5858F));
            this.tblModificar.Size = new System.Drawing.Size(378, 500);
            this.tblModificar.TabIndex = 19;
            // 
            // gbxProducto
            // 
            this.gbxProducto.Controls.Add(this.txtPiezas);
            this.gbxProducto.Controls.Add(this.lblPiezas);
            this.gbxProducto.Controls.Add(this.cbxRetornable);
            this.gbxProducto.Controls.Add(this.txtCompra);
            this.gbxProducto.Controls.Add(this.lblCompra);
            this.gbxProducto.Controls.Add(this.cmbPresentacion);
            this.gbxProducto.Controls.Add(this.lblPresentacion);
            this.gbxProducto.Controls.Add(this.cmbMarca);
            this.gbxProducto.Controls.Add(this.lblMarca);
            this.gbxProducto.Controls.Add(this.lblClave);
            this.gbxProducto.Controls.Add(this.txtClave);
            this.gbxProducto.Controls.Add(this.lblCB);
            this.gbxProducto.Controls.Add(this.txtBarras);
            this.gbxProducto.Controls.Add(this.txtVenta);
            this.gbxProducto.Controls.Add(this.cbxActivo);
            this.gbxProducto.Controls.Add(this.lblID);
            this.gbxProducto.Controls.Add(this.btnGuardar);
            this.gbxProducto.Controls.Add(this.txtID);
            this.gbxProducto.Controls.Add(this.lblNombre);
            this.gbxProducto.Controls.Add(this.txtNombre);
            this.gbxProducto.Controls.Add(this.lblPVenta);
            this.gbxProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxProducto.Location = new System.Drawing.Point(3, 3);
            this.gbxProducto.Name = "gbxProducto";
            this.gbxProducto.Size = new System.Drawing.Size(372, 346);
            this.gbxProducto.TabIndex = 17;
            this.gbxProducto.TabStop = false;
            this.gbxProducto.Text = "Producto";
            // 
            // txtPiezas
            // 
            this.txtPiezas.Location = new System.Drawing.Point(92, 266);
            this.txtPiezas.MaxLength = 10;
            this.txtPiezas.Name = "txtPiezas";
            this.txtPiezas.Size = new System.Drawing.Size(78, 20);
            this.txtPiezas.TabIndex = 28;
            // 
            // lblPiezas
            // 
            this.lblPiezas.AutoSize = true;
            this.lblPiezas.Location = new System.Drawing.Point(5, 269);
            this.lblPiezas.Name = "lblPiezas";
            this.lblPiezas.Size = new System.Drawing.Size(80, 13);
            this.lblPiezas.TabIndex = 27;
            this.lblPiezas.Text = "Piezas por Caja";
            // 
            // cbxRetornable
            // 
            this.cbxRetornable.AutoSize = true;
            this.cbxRetornable.Location = new System.Drawing.Point(92, 182);
            this.cbxRetornable.Name = "cbxRetornable";
            this.cbxRetornable.Size = new System.Drawing.Size(78, 17);
            this.cbxRetornable.TabIndex = 24;
            this.cbxRetornable.Text = "Retornable";
            this.cbxRetornable.UseVisualStyleBackColor = true;
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(92, 292);
            this.txtCompra.MaxLength = 10;
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(78, 20);
            this.txtCompra.TabIndex = 23;
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(10, 295);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(76, 13);
            this.lblCompra.TabIndex = 22;
            this.lblCompra.Text = "Precio Compra";
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(91, 155);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(273, 21);
            this.cmbPresentacion.TabIndex = 21;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(16, 158);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(69, 13);
            this.lblPresentacion.TabIndex = 20;
            this.lblPresentacion.Text = "Presentacion";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(91, 128);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(273, 21);
            this.cmbMarca.TabIndex = 19;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(48, 131);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 18;
            this.lblMarca.Text = "Marca";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(15, 103);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(70, 13);
            this.lblClave.TabIndex = 16;
            this.lblClave.Text = "Clave Alterna";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(91, 100);
            this.txtClave.MaxLength = 80;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(273, 20);
            this.txtClave.TabIndex = 17;
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.Location = new System.Drawing.Point(12, 77);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(73, 13);
            this.lblCB.TabIndex = 14;
            this.lblCB.Text = "Codigo Barras";
            // 
            // txtBarras
            // 
            this.txtBarras.Location = new System.Drawing.Point(91, 74);
            this.txtBarras.MaxLength = 80;
            this.txtBarras.Name = "txtBarras";
            this.txtBarras.Size = new System.Drawing.Size(273, 20);
            this.txtBarras.TabIndex = 15;
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(92, 318);
            this.txtVenta.MaxLength = 10;
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(78, 20);
            this.txtVenta.TabIndex = 13;
            // 
            // cbxActivo
            // 
            this.cbxActivo.AutoSize = true;
            this.cbxActivo.Enabled = false;
            this.cbxActivo.Location = new System.Drawing.Point(176, 24);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(56, 17);
            this.cbxActivo.TabIndex = 11;
            this.cbxActivo.Text = "Activo";
            this.cbxActivo.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(67, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(176, 315);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(188, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(91, 22);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(79, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 48);
            this.txtNombre.MaxLength = 80;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(273, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblPVenta
            // 
            this.lblPVenta.AutoSize = true;
            this.lblPVenta.Location = new System.Drawing.Point(17, 321);
            this.lblPVenta.Name = "lblPVenta";
            this.lblPVenta.Size = new System.Drawing.Size(68, 13);
            this.lblPVenta.TabIndex = 9;
            this.lblPVenta.Text = "Precio Venta";
            // 
            // gbxInventario
            // 
            this.gbxInventario.Controls.Add(this.btnAlimentar);
            this.gbxInventario.Controls.Add(this.txtMonto);
            this.gbxInventario.Controls.Add(this.lblEsperado);
            this.gbxInventario.Controls.Add(this.txtCantidad);
            this.gbxInventario.Controls.Add(this.lblMostrador);
            this.gbxInventario.Controls.Add(this.lblCantidad);
            this.gbxInventario.Controls.Add(this.txtMostrador);
            this.gbxInventario.Controls.Add(this.lblAlmacen);
            this.gbxInventario.Controls.Add(this.txtAlmacen);
            this.gbxInventario.Controls.Add(this.btnMostrador);
            this.gbxInventario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxInventario.Enabled = false;
            this.gbxInventario.Location = new System.Drawing.Point(3, 361);
            this.gbxInventario.Name = "gbxInventario";
            this.gbxInventario.Size = new System.Drawing.Size(372, 136);
            this.gbxInventario.TabIndex = 18;
            this.gbxInventario.TabStop = false;
            this.gbxInventario.Text = "Inventario";
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(176, 20);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(188, 23);
            this.btnAlimentar.TabIndex = 27;
            this.btnAlimentar.Text = "Alimentar almacen";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(91, 100);
            this.txtMonto.MaxLength = 10;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(79, 20);
            this.txtMonto.TabIndex = 26;
            this.txtMonto.Text = "0";
            // 
            // lblEsperado
            // 
            this.lblEsperado.AutoSize = true;
            this.lblEsperado.Location = new System.Drawing.Point(3, 103);
            this.lblEsperado.Name = "lblEsperado";
            this.lblEsperado.Size = new System.Drawing.Size(84, 13);
            this.lblEsperado.TabIndex = 25;
            this.lblEsperado.Text = "Monto esperado";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(91, 74);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(79, 20);
            this.txtCantidad.TabIndex = 24;
            this.txtCantidad.Text = "0";
            // 
            // lblMostrador
            // 
            this.lblMostrador.AutoSize = true;
            this.lblMostrador.Location = new System.Drawing.Point(16, 50);
            this.lblMostrador.Name = "lblMostrador";
            this.lblMostrador.Size = new System.Drawing.Size(69, 13);
            this.lblMostrador.TabIndex = 18;
            this.lblMostrador.Text = "En mostrador";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(13, 75);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(72, 13);
            this.lblCantidad.TabIndex = 23;
            this.lblCantidad.Text = "Cantidad total";
            // 
            // txtMostrador
            // 
            this.txtMostrador.Enabled = false;
            this.txtMostrador.Location = new System.Drawing.Point(91, 48);
            this.txtMostrador.MaxLength = 10;
            this.txtMostrador.Name = "txtMostrador";
            this.txtMostrador.Size = new System.Drawing.Size(79, 20);
            this.txtMostrador.TabIndex = 19;
            this.txtMostrador.Text = "0";
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.AutoSize = true;
            this.lblAlmacen.Location = new System.Drawing.Point(22, 25);
            this.lblAlmacen.Name = "lblAlmacen";
            this.lblAlmacen.Size = new System.Drawing.Size(63, 13);
            this.lblAlmacen.TabIndex = 20;
            this.lblAlmacen.Text = "En almacen";
            // 
            // txtAlmacen
            // 
            this.txtAlmacen.Enabled = false;
            this.txtAlmacen.Location = new System.Drawing.Point(91, 22);
            this.txtAlmacen.MaxLength = 10;
            this.txtAlmacen.Name = "txtAlmacen";
            this.txtAlmacen.Size = new System.Drawing.Size(79, 20);
            this.txtAlmacen.TabIndex = 21;
            this.txtAlmacen.Text = "0";
            // 
            // btnMostrador
            // 
            this.btnMostrador.Location = new System.Drawing.Point(176, 49);
            this.btnMostrador.Name = "btnMostrador";
            this.btnMostrador.Size = new System.Drawing.Size(188, 23);
            this.btnMostrador.TabIndex = 22;
            this.btnMostrador.Text = "Pasar al mostrador";
            this.btnMostrador.UseVisualStyleBackColor = true;
            this.btnMostrador.Click += new System.EventHandler(this.btnMostrador_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::MyBody.Properties.Resources.Vitaminas;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Controls.Add(this.btnPicture);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(398, 506);
            this.pnlLogo.TabIndex = 16;
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPicture.BackgroundImage")));
            this.btnPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Location = new System.Drawing.Point(5, 488);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(20, 20);
            this.btnPicture.TabIndex = 11;
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // tpgExistencias
            // 
            this.tpgExistencias.Controls.Add(this.tblProductos);
            this.tpgExistencias.Location = new System.Drawing.Point(4, 22);
            this.tpgExistencias.Name = "tpgExistencias";
            this.tpgExistencias.Padding = new System.Windows.Forms.Padding(3);
            this.tpgExistencias.Size = new System.Drawing.Size(782, 506);
            this.tpgExistencias.TabIndex = 0;
            this.tpgExistencias.Text = "Productos";
            this.tpgExistencias.UseVisualStyleBackColor = true;
            // 
            // tblProductos
            // 
            this.tblProductos.ColumnCount = 1;
            this.tblProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProductos.Controls.Add(this.gbxFiltros, 0, 0);
            this.tblProductos.Controls.Add(this.lstInventario, 0, 1);
            this.tblProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProductos.Location = new System.Drawing.Point(3, 3);
            this.tblProductos.Name = "tblProductos";
            this.tblProductos.RowCount = 2;
            this.tblProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProductos.Size = new System.Drawing.Size(776, 500);
            this.tblProductos.TabIndex = 11;
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.btnDesactivar);
            this.gbxFiltros.Controls.Add(this.btnActivar);
            this.gbxFiltros.Controls.Add(this.btnBuscar);
            this.gbxFiltros.Controls.Add(this.lblBuscar);
            this.gbxFiltros.Controls.Add(this.txtCriterio);
            this.gbxFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxFiltros.Location = new System.Drawing.Point(3, 3);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(770, 44);
            this.gbxFiltros.TabIndex = 1;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(740, 11);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(72, 23);
            this.btnDesactivar.TabIndex = 16;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(681, 11);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(55, 23);
            this.btnActivar.TabIndex = 17;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(617, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(58, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(6, 16);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(52, 13);
            this.txtCriterio.MaxLength = 100;
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(533, 20);
            this.txtCriterio.TabIndex = 0;
            // 
            // lstInventario
            // 
            this.lstInventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colMarca,
            this.colPresentacion,
            this.colClave,
            this.colBarra,
            this.colNombre,
            this.colEstatus,
            this.colPiezas,
            this.colCompra,
            this.colVenta,
            this.colAlmacen,
            this.colMostrador,
            this.colExistencia,
            this.colRetornable,
            this.colActivo});
            this.lstInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInventario.FullRowSelect = true;
            this.lstInventario.GridLines = true;
            this.lstInventario.Location = new System.Drawing.Point(3, 53);
            this.lstInventario.MultiSelect = false;
            this.lstInventario.Name = "lstInventario";
            this.lstInventario.Size = new System.Drawing.Size(770, 444);
            this.lstInventario.SmallImageList = this.imlEstatus;
            this.lstInventario.TabIndex = 0;
            this.lstInventario.UseCompatibleStateImageBehavior = false;
            this.lstInventario.View = System.Windows.Forms.View.Details;
            this.lstInventario.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstInventario_ColumnClick);
            this.lstInventario.DoubleClick += new System.EventHandler(this.lstInventario_DoubleClick);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 61;
            // 
            // colMarca
            // 
            this.colMarca.Text = "Marca";
            this.colMarca.Width = 0;
            // 
            // colPresentacion
            // 
            this.colPresentacion.Text = "Presentacion";
            this.colPresentacion.Width = 0;
            // 
            // colClave
            // 
            this.colClave.Text = "Clave";
            // 
            // colBarra
            // 
            this.colBarra.Text = "CB";
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 329;
            // 
            // colEstatus
            // 
            this.colEstatus.Text = "Estatus";
            this.colEstatus.Width = 158;
            // 
            // colPiezas
            // 
            this.colPiezas.Text = "PiezasXCaja";
            // 
            // colCompra
            // 
            this.colCompra.Text = "Compra";
            this.colCompra.Width = 64;
            // 
            // colVenta
            // 
            this.colVenta.Text = "Venta";
            // 
            // colAlmacen
            // 
            this.colAlmacen.Text = "Almacen";
            this.colAlmacen.Width = 69;
            // 
            // colMostrador
            // 
            this.colMostrador.Text = "Mostrador";
            this.colMostrador.Width = 76;
            // 
            // colExistencia
            // 
            this.colExistencia.Text = "Existencia";
            this.colExistencia.Width = 67;
            // 
            // colRetornable
            // 
            this.colRetornable.Text = "Retornable";
            // 
            // colActivo
            // 
            this.colActivo.Text = "Activo";
            // 
            // imlEstatus
            // 
            this.imlEstatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlEstatus.ImageStream")));
            this.imlEstatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imlEstatus.Images.SetKeyName(0, "RJO.jpg");
            this.imlEstatus.Images.SetKeyName(1, "VRD.jpg");
            this.imlEstatus.Images.SetKeyName(2, "AMR.jpg");
            // 
            // tpgServicios
            // 
            this.tpgServicios.Controls.Add(this.tblServicios);
            this.tpgServicios.Location = new System.Drawing.Point(4, 22);
            this.tpgServicios.Name = "tpgServicios";
            this.tpgServicios.Size = new System.Drawing.Size(782, 506);
            this.tpgServicios.TabIndex = 2;
            this.tpgServicios.Text = "Servicios";
            this.tpgServicios.UseVisualStyleBackColor = true;
            // 
            // tblServicios
            // 
            this.tblServicios.ColumnCount = 1;
            this.tblServicios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblServicios.Controls.Add(this.pnlServicios, 0, 2);
            this.tblServicios.Controls.Add(this.gbxFiltroServicio, 0, 0);
            this.tblServicios.Controls.Add(this.lstServicios, 0, 1);
            this.tblServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblServicios.Location = new System.Drawing.Point(0, 0);
            this.tblServicios.Name = "tblServicios";
            this.tblServicios.RowCount = 3;
            this.tblServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tblServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblServicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tblServicios.Size = new System.Drawing.Size(782, 506);
            this.tblServicios.TabIndex = 12;
            // 
            // pnlServicios
            // 
            this.pnlServicios.Controls.Add(this.lblFechasServicio);
            this.pnlServicios.Controls.Add(this.dtpFinServicios);
            this.pnlServicios.Controls.Add(this.txtMontoServicio);
            this.pnlServicios.Controls.Add(this.dtpInicioServicios);
            this.pnlServicios.Controls.Add(this.lblMontoServicio);
            this.pnlServicios.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlServicios.Location = new System.Drawing.Point(3, 450);
            this.pnlServicios.Name = "pnlServicios";
            this.pnlServicios.Size = new System.Drawing.Size(776, 53);
            this.pnlServicios.TabIndex = 10;
            // 
            // lblFechasServicio
            // 
            this.lblFechasServicio.AutoSize = true;
            this.lblFechasServicio.Location = new System.Drawing.Point(3, 19);
            this.lblFechasServicio.Name = "lblFechasServicio";
            this.lblFechasServicio.Size = new System.Drawing.Size(160, 13);
            this.lblFechasServicio.TabIndex = 4;
            this.lblFechasServicio.Text = "Pagos recibidos entre las fechas";
            // 
            // dtpFinServicios
            // 
            this.dtpFinServicios.Location = new System.Drawing.Point(169, 30);
            this.dtpFinServicios.Name = "dtpFinServicios";
            this.dtpFinServicios.Size = new System.Drawing.Size(200, 20);
            this.dtpFinServicios.TabIndex = 6;
            // 
            // txtMontoServicio
            // 
            this.txtMontoServicio.Enabled = false;
            this.txtMontoServicio.Location = new System.Drawing.Point(717, 16);
            this.txtMontoServicio.Name = "txtMontoServicio";
            this.txtMontoServicio.Size = new System.Drawing.Size(100, 20);
            this.txtMontoServicio.TabIndex = 8;
            // 
            // dtpInicioServicios
            // 
            this.dtpInicioServicios.Location = new System.Drawing.Point(169, 6);
            this.dtpInicioServicios.Name = "dtpInicioServicios";
            this.dtpInicioServicios.Size = new System.Drawing.Size(200, 20);
            this.dtpInicioServicios.TabIndex = 5;
            // 
            // lblMontoServicio
            // 
            this.lblMontoServicio.AutoSize = true;
            this.lblMontoServicio.Location = new System.Drawing.Point(633, 19);
            this.lblMontoServicio.Name = "lblMontoServicio";
            this.lblMontoServicio.Size = new System.Drawing.Size(79, 13);
            this.lblMontoServicio.TabIndex = 7;
            this.lblMontoServicio.Text = "Monto cobrado";
            // 
            // gbxFiltroServicio
            // 
            this.gbxFiltroServicio.Controls.Add(this.btnBuscarServicio);
            this.gbxFiltroServicio.Controls.Add(this.cmbTipo);
            this.gbxFiltroServicio.Controls.Add(this.btnPrecioServicio);
            this.gbxFiltroServicio.Controls.Add(this.txtPrecioServicio);
            this.gbxFiltroServicio.Controls.Add(this.lblPrecioServicio);
            this.gbxFiltroServicio.Controls.Add(this.lblTipo);
            this.gbxFiltroServicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxFiltroServicio.Location = new System.Drawing.Point(3, 3);
            this.gbxFiltroServicio.Name = "gbxFiltroServicio";
            this.gbxFiltroServicio.Size = new System.Drawing.Size(776, 45);
            this.gbxFiltroServicio.TabIndex = 9;
            this.gbxFiltroServicio.TabStop = false;
            this.gbxFiltroServicio.Text = "Filtros";
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Location = new System.Drawing.Point(317, 11);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarServicio.TabIndex = 8;
            this.btnBuscarServicio.Text = "Buscar";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            this.btnBuscarServicio.Click += new System.EventHandler(this.btnBuscarServicio_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(111, 11);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(200, 21);
            this.cmbTipo.TabIndex = 7;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // btnPrecioServicio
            // 
            this.btnPrecioServicio.Location = new System.Drawing.Point(739, 11);
            this.btnPrecioServicio.Name = "btnPrecioServicio";
            this.btnPrecioServicio.Size = new System.Drawing.Size(75, 23);
            this.btnPrecioServicio.TabIndex = 6;
            this.btnPrecioServicio.Text = "Cambiar";
            this.btnPrecioServicio.UseVisualStyleBackColor = true;
            this.btnPrecioServicio.Click += new System.EventHandler(this.btnPrecioServicio_Click);
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.Enabled = false;
            this.txtPrecioServicio.Location = new System.Drawing.Point(633, 11);
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioServicio.TabIndex = 5;
            // 
            // lblPrecioServicio
            // 
            this.lblPrecioServicio.AutoSize = true;
            this.lblPrecioServicio.Location = new System.Drawing.Point(558, 16);
            this.lblPrecioServicio.Name = "lblPrecioServicio";
            this.lblPrecioServicio.Size = new System.Drawing.Size(69, 13);
            this.lblPrecioServicio.TabIndex = 4;
            this.lblPrecioServicio.Text = "Precio actual";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 16);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(99, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo de suscripción";
            // 
            // lstServicios
            // 
            this.lstServicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDSocio,
            this.colNombreSocio,
            this.colSuscripcion,
            this.colImporte,
            this.colServicioCobrado,
            this.colPendienteServicio,
            this.colFecha});
            this.lstServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstServicios.GridLines = true;
            this.lstServicios.Location = new System.Drawing.Point(3, 54);
            this.lstServicios.Name = "lstServicios";
            this.lstServicios.Size = new System.Drawing.Size(776, 390);
            this.lstServicios.SmallImageList = this.imlEstatus;
            this.lstServicios.TabIndex = 0;
            this.lstServicios.UseCompatibleStateImageBehavior = false;
            this.lstServicios.View = System.Windows.Forms.View.Details;
            // 
            // colIDSocio
            // 
            this.colIDSocio.Text = "ID";
            // 
            // colNombreSocio
            // 
            this.colNombreSocio.Text = "Socio";
            this.colNombreSocio.Width = 264;
            // 
            // colSuscripcion
            // 
            this.colSuscripcion.Text = "Suscripción";
            this.colSuscripcion.Width = 116;
            // 
            // colImporte
            // 
            this.colImporte.Text = "Total";
            this.colImporte.Width = 86;
            // 
            // colServicioCobrado
            // 
            this.colServicioCobrado.Text = "Cobrado";
            this.colServicioCobrado.Width = 80;
            // 
            // colPendienteServicio
            // 
            this.colPendienteServicio.Text = "Estatus";
            this.colPendienteServicio.Width = 99;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 165;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.tblVentas);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Size = new System.Drawing.Size(782, 506);
            this.tabVentas.TabIndex = 3;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // tblVentas
            // 
            this.tblVentas.ColumnCount = 1;
            this.tblVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblVentas.Controls.Add(this.pnlFiltro, 0, 0);
            this.tblVentas.Controls.Add(this.lstVenta, 0, 1);
            this.tblVentas.Controls.Add(this.pnlSum, 0, 2);
            this.tblVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblVentas.Location = new System.Drawing.Point(0, 0);
            this.tblVentas.Name = "tblVentas";
            this.tblVentas.RowCount = 3;
            this.tblVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.187135F));
            this.tblVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.81287F));
            this.tblVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblVentas.Size = new System.Drawing.Size(782, 506);
            this.tblVentas.TabIndex = 0;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.btnCortes);
            this.pnlFiltro.Controls.Add(this.cmbCorte);
            this.pnlFiltro.Controls.Add(this.btnMostrar);
            this.pnlFiltro.Controls.Add(this.lblFechaVendido);
            this.pnlFiltro.Controls.Add(this.dtpFinVenta);
            this.pnlFiltro.Controls.Add(this.dtpInicioVenta);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltro.Location = new System.Drawing.Point(3, 3);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(776, 32);
            this.pnlFiltro.TabIndex = 0;
            // 
            // btnCortes
            // 
            this.btnCortes.Location = new System.Drawing.Point(574, 4);
            this.btnCortes.Name = "btnCortes";
            this.btnCortes.Size = new System.Drawing.Size(18, 23);
            this.btnCortes.TabIndex = 26;
            this.btnCortes.Text = "+";
            this.btnCortes.UseVisualStyleBackColor = true;
            this.btnCortes.Click += new System.EventHandler(this.btnCortes_Click);
            // 
            // cmbCorte
            // 
            this.cmbCorte.FormattingEnabled = true;
            this.cmbCorte.Location = new System.Drawing.Point(450, 6);
            this.cmbCorte.Name = "cmbCorte";
            this.cmbCorte.Size = new System.Drawing.Size(121, 21);
            this.cmbCorte.TabIndex = 25;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(594, 4);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 24;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblFechaVendido
            // 
            this.lblFechaVendido.AutoSize = true;
            this.lblFechaVendido.Location = new System.Drawing.Point(2, 11);
            this.lblFechaVendido.Name = "lblFechaVendido";
            this.lblFechaVendido.Size = new System.Drawing.Size(124, 13);
            this.lblFechaVendido.TabIndex = 21;
            this.lblFechaVendido.Text = "Vendido entre las fechas";
            // 
            // dtpFinVenta
            // 
            this.dtpFinVenta.Location = new System.Drawing.Point(292, 6);
            this.dtpFinVenta.Name = "dtpFinVenta";
            this.dtpFinVenta.Size = new System.Drawing.Size(152, 20);
            this.dtpFinVenta.TabIndex = 23;
            // 
            // dtpInicioVenta
            // 
            this.dtpInicioVenta.Location = new System.Drawing.Point(132, 6);
            this.dtpInicioVenta.Name = "dtpInicioVenta";
            this.dtpInicioVenta.Size = new System.Drawing.Size(154, 20);
            this.dtpInicioVenta.TabIndex = 22;
            // 
            // lstVenta
            // 
            this.lstVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsuario,
            this.colSocio,
            this.colProducto,
            this.colFVenta,
            this.colHora,
            this.colCantidad,
            this.colUnitario,
            this.colTotal,
            this.colCobrado,
            this.colSaldo,
            this.colMargen});
            this.lstVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVenta.GridLines = true;
            this.lstVenta.Location = new System.Drawing.Point(3, 41);
            this.lstVenta.Name = "lstVenta";
            this.lstVenta.Size = new System.Drawing.Size(776, 420);
            this.lstVenta.SmallImageList = this.imlEstatus;
            this.lstVenta.TabIndex = 1;
            this.lstVenta.UseCompatibleStateImageBehavior = false;
            this.lstVenta.View = System.Windows.Forms.View.Details;
            this.lstVenta.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstVenta_ColumnClick);
            // 
            // colUsuario
            // 
            this.colUsuario.Text = "Usuario";
            this.colUsuario.Width = 138;
            // 
            // colSocio
            // 
            this.colSocio.Text = "Socio";
            this.colSocio.Width = 171;
            // 
            // colProducto
            // 
            this.colProducto.Text = "Producto";
            this.colProducto.Width = 154;
            // 
            // colFVenta
            // 
            this.colFVenta.Text = "Fecha";
            this.colFVenta.Width = 82;
            // 
            // colHora
            // 
            this.colHora.Text = "Hora";
            // 
            // colCantidad
            // 
            this.colCantidad.Text = "Cantidad";
            // 
            // colUnitario
            // 
            this.colUnitario.Text = "Precio";
            this.colUnitario.Width = 50;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // colCobrado
            // 
            this.colCobrado.Text = "Cobrado";
            // 
            // colSaldo
            // 
            this.colSaldo.Text = "Saldo";
            // 
            // colMargen
            // 
            this.colMargen.Text = "Margen";
            // 
            // pnlSum
            // 
            this.pnlSum.Controls.Add(this.txtMargen);
            this.pnlSum.Controls.Add(this.label1);
            this.pnlSum.Controls.Add(this.txtSaldo);
            this.pnlSum.Controls.Add(this.lblSaldo);
            this.pnlSum.Controls.Add(this.txtVendido);
            this.pnlSum.Controls.Add(this.lblTotalVendido);
            this.pnlSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSum.Location = new System.Drawing.Point(3, 467);
            this.pnlSum.Name = "pnlSum";
            this.pnlSum.Size = new System.Drawing.Size(776, 36);
            this.pnlSum.TabIndex = 2;
            // 
            // txtMargen
            // 
            this.txtMargen.Location = new System.Drawing.Point(247, 7);
            this.txtMargen.Name = "txtMargen";
            this.txtMargen.Size = new System.Drawing.Size(100, 20);
            this.txtMargen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ganancia:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(660, 7);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(604, 10);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(40, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo: ";
            // 
            // txtVendido
            // 
            this.txtVendido.Location = new System.Drawing.Point(83, 7);
            this.txtVendido.Name = "txtVendido";
            this.txtVendido.Size = new System.Drawing.Size(100, 20);
            this.txtVendido.TabIndex = 1;
            // 
            // lblTotalVendido
            // 
            this.lblTotalVendido.AutoSize = true;
            this.lblTotalVendido.Location = new System.Drawing.Point(25, 11);
            this.lblTotalVendido.Name = "lblTotalVendido";
            this.lblTotalVendido.Size = new System.Drawing.Size(49, 13);
            this.lblTotalVendido.TabIndex = 0;
            this.lblTotalVendido.Text = "Vendido:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo producto";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(111, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnNuevo);
            this.pnlControl.Controls.Add(this.btnCancelar);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControl.Location = new System.Drawing.Point(559, 541);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(234, 29);
            this.pnlControl.TabIndex = 14;
            // 
            // tblInventario
            // 
            this.tblInventario.ColumnCount = 1;
            this.tblInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInventario.Controls.Add(this.pnlControl, 0, 1);
            this.tblInventario.Controls.Add(this.tbcInventario, 0, 0);
            this.tblInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInventario.Location = new System.Drawing.Point(0, 0);
            this.tblInventario.Name = "tblInventario";
            this.tblInventario.RowCount = 2;
            this.tblInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblInventario.Size = new System.Drawing.Size(796, 573);
            this.tblInventario.TabIndex = 15;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(796, 573);
            this.Controls.Add(this.tblInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de inventarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInventario_Load);
            this.tbcInventario.ResumeLayout(false);
            this.tpgProductos.ResumeLayout(false);
            this.tblEdicion.ResumeLayout(false);
            this.tblModificar.ResumeLayout(false);
            this.gbxProducto.ResumeLayout(false);
            this.gbxProducto.PerformLayout();
            this.gbxInventario.ResumeLayout(false);
            this.gbxInventario.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.tpgExistencias.ResumeLayout(false);
            this.tblProductos.ResumeLayout(false);
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.tpgServicios.ResumeLayout(false);
            this.tblServicios.ResumeLayout(false);
            this.pnlServicios.ResumeLayout(false);
            this.pnlServicios.PerformLayout();
            this.gbxFiltroServicio.ResumeLayout(false);
            this.gbxFiltroServicio.PerformLayout();
            this.tabVentas.ResumeLayout(false);
            this.tblVentas.ResumeLayout(false);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlSum.ResumeLayout(false);
            this.pnlSum.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.tblInventario.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        /*
            lvwColumnSorterVentas = new ListViewColumnSorter();
            this.lstVenta.ListViewItemSorter = lvwColumnSorterVentas;

            lvwColumnSorterProductos = new ListViewColumnSorter();
            this.lstInventario.ListViewItemSorter = lvwColumnSorterProductos;
         */


        #endregion

        private System.Windows.Forms.TabControl tbcInventario;
        private System.Windows.Forms.TabPage tpgExistencias;
        private System.Windows.Forms.TabPage tpgProductos;
        private System.Windows.Forms.ListView lstInventario;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colMostrador;
        private System.Windows.Forms.ColumnHeader colAlmacen;
        private System.Windows.Forms.ColumnHeader colExistencia;
        private System.Windows.Forms.ColumnHeader colCompra;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Label lblPVenta;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ColumnHeader colEstatus;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.GroupBox gbxProducto;
        private System.Windows.Forms.GroupBox gbxInventario;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblEsperado;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblMostrador;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtMostrador;
        private System.Windows.Forms.Label lblAlmacen;
        private System.Windows.Forms.TextBox txtAlmacen;
        private System.Windows.Forms.Button btnMostrador;
        private System.Windows.Forms.TabPage tpgServicios;
        private System.Windows.Forms.GroupBox gbxFiltroServicio;
        private System.Windows.Forms.Button btnPrecioServicio;
        private System.Windows.Forms.TextBox txtPrecioServicio;
        private System.Windows.Forms.Label lblPrecioServicio;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtMontoServicio;
        private System.Windows.Forms.Label lblMontoServicio;
        private System.Windows.Forms.DateTimePicker dtpInicioServicios;
        private System.Windows.Forms.Label lblFechasServicio;
        private System.Windows.Forms.DateTimePicker dtpFinServicios;
        private System.Windows.Forms.ListView lstServicios;
        private System.Windows.Forms.ColumnHeader colIDSocio;
        private System.Windows.Forms.ColumnHeader colNombreSocio;
        private System.Windows.Forms.ColumnHeader colSuscripcion;
        private System.Windows.Forms.ColumnHeader colImporte;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.ImageList imlEstatus;
        private System.Windows.Forms.CheckBox cbxActivo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ColumnHeader colPendienteServicio;
        private System.Windows.Forms.ColumnHeader colServicioCobrado;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.TableLayoutPanel tblEdicion;
        private System.Windows.Forms.TableLayoutPanel tblModificar;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TableLayoutPanel tblInventario;
        private System.Windows.Forms.Panel pnlServicios;
        private System.Windows.Forms.TableLayoutPanel tblProductos;
        private System.Windows.Forms.TableLayoutPanel tblServicios;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.TableLayoutPanel tblVentas;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblFechaVendido;
        private System.Windows.Forms.DateTimePicker dtpFinVenta;
        private System.Windows.Forms.DateTimePicker dtpInicioVenta;
        private System.Windows.Forms.ListView lstVenta;
        private System.Windows.Forms.ColumnHeader colUsuario;
        private System.Windows.Forms.ColumnHeader colSocio;
        private System.Windows.Forms.ColumnHeader colProducto;
        private System.Windows.Forms.ColumnHeader colFVenta;
        private System.Windows.Forms.ColumnHeader colCantidad;
        private System.Windows.Forms.ColumnHeader colUnitario;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colCobrado;
        private System.Windows.Forms.ColumnHeader colSaldo;
        private System.Windows.Forms.Panel pnlSum;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtVendido;
        private System.Windows.Forms.Label lblTotalVendido;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblCB;
        private System.Windows.Forms.TextBox txtBarras;
        private System.Windows.Forms.ComboBox cmbPresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.CheckBox cbxRetornable;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.TextBox txtPiezas;
        private System.Windows.Forms.Label lblPiezas;
        private System.Windows.Forms.ColumnHeader colClave;
        private System.Windows.Forms.ColumnHeader colBarra;
        private System.Windows.Forms.ColumnHeader colMarca;
        private System.Windows.Forms.ColumnHeader colPresentacion;
        private System.Windows.Forms.ColumnHeader colPiezas;
        private System.Windows.Forms.ColumnHeader colVenta;
        private System.Windows.Forms.ColumnHeader colRetornable;
        private System.Windows.Forms.ColumnHeader colActivo;
        private System.Windows.Forms.ColumnHeader colHora;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnCortes;
        private System.Windows.Forms.ComboBox cmbCorte;
        private System.Windows.Forms.ColumnHeader colMargen;
        private System.Windows.Forms.TextBox txtMargen;
        private System.Windows.Forms.Label label1;
    }
}