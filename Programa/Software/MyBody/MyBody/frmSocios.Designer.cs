namespace MyBody
{

    partial class frmSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocios));
            this.tbcSocios = new System.Windows.Forms.TabControl();
            this.tpgNuevo = new System.Windows.Forms.TabPage();
            this.tblEdicion = new System.Windows.Forms.TableLayoutPanel();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.gbxNuevo = new System.Windows.Forms.GroupBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUPago = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtFB = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.dtpUPago = new System.Windows.Forms.DateTimePicker();
            this.dtpLimite = new System.Windows.Forms.DateTimePicker();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.cmbRutina = new System.Windows.Forms.ComboBox();
            this.txtTelefonos = new System.Windows.Forms.TextBox();
            this.lblInscripcion = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblRutina = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dtpInscripcion = new System.Windows.Forms.DateTimePicker();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tpgLista = new System.Windows.Forms.TabPage();
            this.tblSocios = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPieSocio = new System.Windows.Forms.Panel();
            this.txtTodos = new System.Windows.Forms.TextBox();
            this.lblSocios = new System.Windows.Forms.Label();
            this.txtTotalAdeudado = new System.Windows.Forms.TextBox();
            this.lblActivos = new System.Windows.Forms.Label();
            this.lblTotalAdeudo = new System.Windows.Forms.Label();
            this.lblAdeudados = new System.Windows.Forms.Label();
            this.txtAdeudados = new System.Windows.Forms.TextBox();
            this.txtActivos = new System.Windows.Forms.TextBox();
            this.lstSocios = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAntiguedad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDeuda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colActivo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlEstatus = new System.Windows.Forms.ImageList(this.components);
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.chkInactivos = new System.Windows.Forms.CheckBox();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.tpgPagos = new System.Windows.Forms.TabPage();
            this.tblPagos = new System.Windows.Forms.TableLayoutPanel();
            this.lstPagos = new System.Windows.Forms.ListView();
            this.colPagoID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLimite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colConcepto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstatusPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipoPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuCambiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPiePagos = new System.Windows.Forms.Panel();
            this.chkPendientes = new System.Windows.Forms.CheckBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.gbxSocio = new System.Windows.Forms.GroupBox();
            this.btnGenerarCobro = new System.Windows.Forms.Button();
            this.lblSocio = new System.Windows.Forms.Label();
            this.tpgInteraccion = new System.Windows.Forms.TabPage();
            this.lstInteraccion = new System.Windows.Forms.ListView();
            this.colIDInteraccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaInteraccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpgAsistencias = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAsistencia = new System.Windows.Forms.Panel();
            this.txtTotalAsistencia = new System.Windows.Forms.TextBox();
            this.lblTotalAsistencia = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstAsistencia = new System.Windows.Forms.ListView();
            this.colHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tblGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.tbcSocios.SuspendLayout();
            this.tpgNuevo.SuspendLayout();
            this.tblEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.gbxNuevo.SuspendLayout();
            this.tpgLista.SuspendLayout();
            this.tblSocios.SuspendLayout();
            this.pnlPieSocio.SuspendLayout();
            this.gbxFiltros.SuspendLayout();
            this.tpgPagos.SuspendLayout();
            this.tblPagos.SuspendLayout();
            this.mnuOpciones.SuspendLayout();
            this.pnlPiePagos.SuspendLayout();
            this.gbxSocio.SuspendLayout();
            this.tpgInteraccion.SuspendLayout();
            this.tpgAsistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAsistencia.SuspendLayout();
            this.tblGeneral.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSocios
            // 
            this.tbcSocios.Controls.Add(this.tpgNuevo);
            this.tbcSocios.Controls.Add(this.tpgLista);
            this.tbcSocios.Controls.Add(this.tpgPagos);
            this.tbcSocios.Controls.Add(this.tpgInteraccion);
            this.tbcSocios.Controls.Add(this.tpgAsistencias);
            this.tbcSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcSocios.Location = new System.Drawing.Point(3, 3);
            this.tbcSocios.Name = "tbcSocios";
            this.tbcSocios.SelectedIndex = 0;
            this.tbcSocios.Size = new System.Drawing.Size(944, 478);
            this.tbcSocios.TabIndex = 0;
            this.tbcSocios.SelectedIndexChanged += new System.EventHandler(this.tbcSocios_SelectedIndexChanged);
            // 
            // tpgNuevo
            // 
            this.tpgNuevo.Controls.Add(this.tblEdicion);
            this.tpgNuevo.Location = new System.Drawing.Point(4, 22);
            this.tpgNuevo.Name = "tpgNuevo";
            this.tpgNuevo.Size = new System.Drawing.Size(936, 452);
            this.tpgNuevo.TabIndex = 2;
            this.tpgNuevo.Text = "Edición";
            this.tpgNuevo.UseVisualStyleBackColor = true;
            // 
            // tblEdicion
            // 
            this.tblEdicion.ColumnCount = 2;
            this.tblEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEdicion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tblEdicion.Controls.Add(this.imgVideo, 0, 0);
            this.tblEdicion.Controls.Add(this.gbxNuevo, 1, 0);
            this.tblEdicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEdicion.Location = new System.Drawing.Point(0, 0);
            this.tblEdicion.Name = "tblEdicion";
            this.tblEdicion.RowCount = 1;
            this.tblEdicion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEdicion.Size = new System.Drawing.Size(936, 452);
            this.tblEdicion.TabIndex = 23;
            // 
            // imgVideo
            // 
            this.imgVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgVideo.Image = global::MyBody.Properties.Resources.Nuevos;
            this.imgVideo.InitialImage = global::MyBody.Properties.Resources.Nuevos;
            this.imgVideo.Location = new System.Drawing.Point(3, 3);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(566, 446);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVideo.TabIndex = 1;
            this.imgVideo.TabStop = false;
            // 
            // gbxNuevo
            // 
            this.gbxNuevo.Controls.Add(this.btnCambiar);
            this.gbxNuevo.Controls.Add(this.lblID);
            this.gbxNuevo.Controls.Add(this.cmbTipo);
            this.gbxNuevo.Controls.Add(this.lblNombre);
            this.gbxNuevo.Controls.Add(this.lblUPago);
            this.gbxNuevo.Controls.Add(this.lblTipo);
            this.gbxNuevo.Controls.Add(this.txtFB);
            this.gbxNuevo.Controls.Add(this.txtNombres);
            this.gbxNuevo.Controls.Add(this.dtpUPago);
            this.gbxNuevo.Controls.Add(this.dtpLimite);
            this.gbxNuevo.Controls.Add(this.lblFacebook);
            this.gbxNuevo.Controls.Add(this.lblApellidos);
            this.gbxNuevo.Controls.Add(this.chkActivo);
            this.gbxNuevo.Controls.Add(this.lblLimite);
            this.gbxNuevo.Controls.Add(this.txtDireccion);
            this.gbxNuevo.Controls.Add(this.txtApellidos);
            this.gbxNuevo.Controls.Add(this.lblNacimiento);
            this.gbxNuevo.Controls.Add(this.cmbRutina);
            this.gbxNuevo.Controls.Add(this.txtTelefonos);
            this.gbxNuevo.Controls.Add(this.lblInscripcion);
            this.gbxNuevo.Controls.Add(this.lblPeso);
            this.gbxNuevo.Controls.Add(this.lblRutina);
            this.gbxNuevo.Controls.Add(this.lblDireccion);
            this.gbxNuevo.Controls.Add(this.dtpInscripcion);
            this.gbxNuevo.Controls.Add(this.txtPeso);
            this.gbxNuevo.Controls.Add(this.dtpNacimiento);
            this.gbxNuevo.Controls.Add(this.lblTelefono);
            this.gbxNuevo.Controls.Add(this.txtID);
            this.gbxNuevo.Controls.Add(this.btnGuardar);
            this.gbxNuevo.Location = new System.Drawing.Point(575, 3);
            this.gbxNuevo.Name = "gbxNuevo";
            this.gbxNuevo.Size = new System.Drawing.Size(353, 433);
            this.gbxNuevo.TabIndex = 0;
            this.gbxNuevo.TabStop = false;
            this.gbxNuevo.Text = "Nuevo usuario";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(47, 387);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(91, 23);
            this.btnCambiar.TabIndex = 33;
            this.btnCambiar.Text = "Cambiar foto...";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(116, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(143, 305);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(201, 21);
            this.cmbTipo.TabIndex = 32;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(75, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "*Nombres";
            // 
            // lblUPago
            // 
            this.lblUPago.AutoSize = true;
            this.lblUPago.Location = new System.Drawing.Point(30, 287);
            this.lblUPago.Name = "lblUPago";
            this.lblUPago.Size = new System.Drawing.Size(109, 13);
            this.lblUPago.TabIndex = 19;
            this.lblUPago.Text = "Fecha de ultimo pago";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(16, 313);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(123, 13);
            this.lblTipo.TabIndex = 31;
            this.lblTipo.Text = "*Tipo de suscripción";
            // 
            // txtFB
            // 
            this.txtFB.Location = new System.Drawing.Point(143, 124);
            this.txtFB.MaxLength = 200;
            this.txtFB.Name = "txtFB";
            this.txtFB.Size = new System.Drawing.Size(201, 20);
            this.txtFB.TabIndex = 18;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(143, 46);
            this.txtNombres.MaxLength = 80;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(201, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // dtpUPago
            // 
            this.dtpUPago.Enabled = false;
            this.dtpUPago.Location = new System.Drawing.Point(143, 281);
            this.dtpUPago.Name = "dtpUPago";
            this.dtpUPago.Size = new System.Drawing.Size(201, 20);
            this.dtpUPago.TabIndex = 20;
            // 
            // dtpLimite
            // 
            this.dtpLimite.Location = new System.Drawing.Point(143, 332);
            this.dtpLimite.Name = "dtpLimite";
            this.dtpLimite.Size = new System.Drawing.Size(201, 20);
            this.dtpLimite.TabIndex = 30;
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacebook.Location = new System.Drawing.Point(8, 121);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(130, 26);
            this.lblFacebook.TabIndex = 17;
            this.lblFacebook.Text = "*Correo electronico\r\n(Para enviar la rutina)";
            this.lblFacebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(73, 75);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(63, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "*Apellidos";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(224, 22);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 21;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(34, 338);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(105, 13);
            this.lblLimite.TabIndex = 29;
            this.lblLimite.Text = "Fecha limite de pago";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(143, 150);
            this.txtDireccion.MaxLength = 200;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(201, 20);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(143, 72);
            this.txtApellidos.MaxLength = 80;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(201, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(79, 182);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(60, 13);
            this.lblNacimiento.TabIndex = 22;
            this.lblNacimiento.Text = "Nacimiento";
            // 
            // cmbRutina
            // 
            this.cmbRutina.FormattingEnabled = true;
            this.cmbRutina.Location = new System.Drawing.Point(143, 228);
            this.cmbRutina.Name = "cmbRutina";
            this.cmbRutina.Size = new System.Drawing.Size(201, 21);
            this.cmbRutina.TabIndex = 28;
            // 
            // txtTelefonos
            // 
            this.txtTelefonos.Location = new System.Drawing.Point(143, 98);
            this.txtTelefonos.MaxLength = 10;
            this.txtTelefonos.Name = "txtTelefonos";
            this.txtTelefonos.Size = new System.Drawing.Size(201, 20);
            this.txtTelefonos.TabIndex = 15;
            // 
            // lblInscripcion
            // 
            this.lblInscripcion.AutoSize = true;
            this.lblInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscripcion.Location = new System.Drawing.Point(9, 262);
            this.lblInscripcion.Name = "lblInscripcion";
            this.lblInscripcion.Size = new System.Drawing.Size(130, 13);
            this.lblInscripcion.TabIndex = 6;
            this.lblInscripcion.Text = "*Fecha de inscripción";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(95, 209);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(40, 13);
            this.lblPeso.TabIndex = 24;
            this.lblPeso.Text = "*Peso";
            // 
            // lblRutina
            // 
            this.lblRutina.AutoSize = true;
            this.lblRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutina.Location = new System.Drawing.Point(90, 236);
            this.lblRutina.Name = "lblRutina";
            this.lblRutina.Size = new System.Drawing.Size(49, 13);
            this.lblRutina.TabIndex = 27;
            this.lblRutina.Text = "*Rutina";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(87, 154);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Dirección";
            // 
            // dtpInscripcion
            // 
            this.dtpInscripcion.Location = new System.Drawing.Point(143, 255);
            this.dtpInscripcion.Name = "dtpInscripcion";
            this.dtpInscripcion.Size = new System.Drawing.Size(201, 20);
            this.dtpInscripcion.TabIndex = 7;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(143, 202);
            this.txtPeso.MaxLength = 10;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(75, 20);
            this.txtPeso.TabIndex = 25;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(143, 176);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(201, 20);
            this.dtpNacimiento.TabIndex = 26;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(73, 101);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 13);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "*Telefono";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(143, 19);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(143, 387);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 23);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tpgLista
            // 
            this.tpgLista.Controls.Add(this.tblSocios);
            this.tpgLista.Location = new System.Drawing.Point(4, 22);
            this.tpgLista.Name = "tpgLista";
            this.tpgLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpgLista.Size = new System.Drawing.Size(936, 452);
            this.tpgLista.TabIndex = 0;
            this.tpgLista.Text = "Socios";
            this.tpgLista.UseVisualStyleBackColor = true;
            // 
            // tblSocios
            // 
            this.tblSocios.ColumnCount = 1;
            this.tblSocios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSocios.Controls.Add(this.pnlPieSocio, 0, 2);
            this.tblSocios.Controls.Add(this.lstSocios, 0, 1);
            this.tblSocios.Controls.Add(this.gbxFiltros, 0, 0);
            this.tblSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSocios.Location = new System.Drawing.Point(3, 3);
            this.tblSocios.Name = "tblSocios";
            this.tblSocios.RowCount = 3;
            this.tblSocios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblSocios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSocios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tblSocios.Size = new System.Drawing.Size(930, 446);
            this.tblSocios.TabIndex = 11;
            // 
            // pnlPieSocio
            // 
            this.pnlPieSocio.Controls.Add(this.txtTodos);
            this.pnlPieSocio.Controls.Add(this.lblSocios);
            this.pnlPieSocio.Controls.Add(this.txtTotalAdeudado);
            this.pnlPieSocio.Controls.Add(this.lblActivos);
            this.pnlPieSocio.Controls.Add(this.lblTotalAdeudo);
            this.pnlPieSocio.Controls.Add(this.lblAdeudados);
            this.pnlPieSocio.Controls.Add(this.txtAdeudados);
            this.pnlPieSocio.Controls.Add(this.txtActivos);
            this.pnlPieSocio.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPieSocio.Location = new System.Drawing.Point(3, 397);
            this.pnlPieSocio.Name = "pnlPieSocio";
            this.pnlPieSocio.Size = new System.Drawing.Size(830, 46);
            this.pnlPieSocio.TabIndex = 12;
            // 
            // txtTodos
            // 
            this.txtTodos.Enabled = false;
            this.txtTodos.Location = new System.Drawing.Point(30, 3);
            this.txtTodos.Name = "txtTodos";
            this.txtTodos.Size = new System.Drawing.Size(76, 20);
            this.txtTodos.TabIndex = 7;
            // 
            // lblSocios
            // 
            this.lblSocios.AutoSize = true;
            this.lblSocios.Location = new System.Drawing.Point(6, 26);
            this.lblSocios.Name = "lblSocios";
            this.lblSocios.Size = new System.Drawing.Size(134, 13);
            this.lblSocios.TabIndex = 2;
            this.lblSocios.Text = "Total de socios en pantalla";
            // 
            // txtTotalAdeudado
            // 
            this.txtTotalAdeudado.Enabled = false;
            this.txtTotalAdeudado.Location = new System.Drawing.Point(660, 3);
            this.txtTotalAdeudado.Name = "txtTotalAdeudado";
            this.txtTotalAdeudado.Size = new System.Drawing.Size(79, 20);
            this.txtTotalAdeudado.TabIndex = 10;
            // 
            // lblActivos
            // 
            this.lblActivos.AutoSize = true;
            this.lblActivos.Location = new System.Drawing.Point(745, 26);
            this.lblActivos.Name = "lblActivos";
            this.lblActivos.Size = new System.Drawing.Size(76, 13);
            this.lblActivos.TabIndex = 3;
            this.lblActivos.Text = "Socios activos";
            // 
            // lblTotalAdeudo
            // 
            this.lblTotalAdeudo.AutoSize = true;
            this.lblTotalAdeudo.Location = new System.Drawing.Point(657, 26);
            this.lblTotalAdeudo.Name = "lblTotalAdeudo";
            this.lblTotalAdeudo.Size = new System.Drawing.Size(82, 13);
            this.lblTotalAdeudo.TabIndex = 9;
            this.lblTotalAdeudo.Text = "Total adeudado";
            // 
            // lblAdeudados
            // 
            this.lblAdeudados.AutoSize = true;
            this.lblAdeudados.Location = new System.Drawing.Point(560, 26);
            this.lblAdeudados.Name = "lblAdeudados";
            this.lblAdeudados.Size = new System.Drawing.Size(95, 13);
            this.lblAdeudados.TabIndex = 4;
            this.lblAdeudados.Text = "Socios adeudados";
            // 
            // txtAdeudados
            // 
            this.txtAdeudados.Enabled = false;
            this.txtAdeudados.Location = new System.Drawing.Point(563, 3);
            this.txtAdeudados.Name = "txtAdeudados";
            this.txtAdeudados.Size = new System.Drawing.Size(91, 20);
            this.txtAdeudados.TabIndex = 5;
            // 
            // txtActivos
            // 
            this.txtActivos.Enabled = false;
            this.txtActivos.Location = new System.Drawing.Point(745, 3);
            this.txtActivos.Name = "txtActivos";
            this.txtActivos.Size = new System.Drawing.Size(76, 20);
            this.txtActivos.TabIndex = 6;
            // 
            // lstSocios
            // 
            this.lstSocios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNombres,
            this.colApellidos,
            this.colAntiguedad,
            this.colTipo,
            this.colUPago,
            this.colDeuda,
            this.colEstatus,
            this.colActivo});
            this.lstSocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSocios.FullRowSelect = true;
            this.lstSocios.GridLines = true;
            this.lstSocios.HideSelection = false;
            this.lstSocios.Location = new System.Drawing.Point(3, 50);
            this.lstSocios.MultiSelect = false;
            this.lstSocios.Name = "lstSocios";
            this.lstSocios.Size = new System.Drawing.Size(924, 341);
            this.lstSocios.SmallImageList = this.imlEstatus;
            this.lstSocios.TabIndex = 1;
            this.lstSocios.UseCompatibleStateImageBehavior = false;
            this.lstSocios.View = System.Windows.Forms.View.Details;
            this.lstSocios.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstSocios_ColumnClick);
            this.lstSocios.DoubleClick += new System.EventHandler(this.lstSocios_DoubleClick);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 88;
            // 
            // colNombres
            // 
            this.colNombres.Text = "Nombres";
            this.colNombres.Width = 179;
            // 
            // colApellidos
            // 
            this.colApellidos.Text = "Apellidos";
            this.colApellidos.Width = 153;
            // 
            // colAntiguedad
            // 
            this.colAntiguedad.Text = "Antiguedad";
            this.colAntiguedad.Width = 68;
            // 
            // colTipo
            // 
            this.colTipo.Text = "Tipo";
            this.colTipo.Width = 97;
            // 
            // colUPago
            // 
            this.colUPago.Text = "Ultimo pago";
            this.colUPago.Width = 122;
            // 
            // colDeuda
            // 
            this.colDeuda.Text = "Deuda";
            this.colDeuda.Width = 77;
            // 
            // colEstatus
            // 
            this.colEstatus.Text = "Estatus";
            this.colEstatus.Width = 76;
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
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.chkInactivos);
            this.gbxFiltros.Controls.Add(this.btnDesactivar);
            this.gbxFiltros.Controls.Add(this.btnActivar);
            this.gbxFiltros.Controls.Add(this.btnBuscar);
            this.gbxFiltros.Controls.Add(this.lblBuscar);
            this.gbxFiltros.Controls.Add(this.txtCriterio);
            this.gbxFiltros.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxFiltros.Location = new System.Drawing.Point(3, 3);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(830, 41);
            this.gbxFiltros.TabIndex = 8;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // chkInactivos
            // 
            this.chkInactivos.AutoSize = true;
            this.chkInactivos.Location = new System.Drawing.Point(516, 16);
            this.chkInactivos.Name = "chkInactivos";
            this.chkInactivos.Size = new System.Drawing.Size(106, 17);
            this.chkInactivos.TabIndex = 18;
            this.chkInactivos.Text = "Mostrar inactivos";
            this.chkInactivos.UseVisualStyleBackColor = true;
            this.chkInactivos.CheckedChanged += new System.EventHandler(this.chkInactivos_CheckedChanged);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(748, 10);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(73, 23);
            this.btnDesactivar.TabIndex = 16;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(693, 10);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(55, 23);
            this.btnActivar.TabIndex = 17;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(629, 10);
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
            this.txtCriterio.Size = new System.Drawing.Size(452, 20);
            this.txtCriterio.TabIndex = 0;
            // 
            // tpgPagos
            // 
            this.tpgPagos.Controls.Add(this.tblPagos);
            this.tpgPagos.Location = new System.Drawing.Point(4, 22);
            this.tpgPagos.Name = "tpgPagos";
            this.tpgPagos.Size = new System.Drawing.Size(936, 452);
            this.tpgPagos.TabIndex = 1;
            this.tpgPagos.Text = "Pagos";
            this.tpgPagos.UseVisualStyleBackColor = true;
            // 
            // tblPagos
            // 
            this.tblPagos.ColumnCount = 1;
            this.tblPagos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPagos.Controls.Add(this.lstPagos, 0, 1);
            this.tblPagos.Controls.Add(this.pnlPiePagos, 0, 2);
            this.tblPagos.Controls.Add(this.gbxSocio, 0, 0);
            this.tblPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPagos.Location = new System.Drawing.Point(0, 0);
            this.tblPagos.Name = "tblPagos";
            this.tblPagos.RowCount = 3;
            this.tblPagos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblPagos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPagos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblPagos.Size = new System.Drawing.Size(936, 452);
            this.tblPagos.TabIndex = 6;
            // 
            // lstPagos
            // 
            this.lstPagos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPagoID,
            this.colFecha,
            this.colLimite,
            this.colConcepto,
            this.colEstatusPago,
            this.colCantidad,
            this.colImporte,
            this.colTipoPago});
            this.lstPagos.ContextMenuStrip = this.mnuOpciones;
            this.lstPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPagos.FullRowSelect = true;
            this.lstPagos.GridLines = true;
            this.lstPagos.HideSelection = false;
            this.lstPagos.Location = new System.Drawing.Point(3, 53);
            this.lstPagos.MultiSelect = false;
            this.lstPagos.Name = "lstPagos";
            this.lstPagos.Size = new System.Drawing.Size(930, 362);
            this.lstPagos.SmallImageList = this.imlEstatus;
            this.lstPagos.TabIndex = 1;
            this.lstPagos.UseCompatibleStateImageBehavior = false;
            this.lstPagos.View = System.Windows.Forms.View.Details;
            this.lstPagos.DoubleClick += new System.EventHandler(this.lstPagos_DoubleClick);
            // 
            // colPagoID
            // 
            this.colPagoID.Text = "ID";
            this.colPagoID.Width = 88;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 142;
            // 
            // colLimite
            // 
            this.colLimite.Text = "Fecha Limite";
            this.colLimite.Width = 134;
            // 
            // colConcepto
            // 
            this.colConcepto.Text = "Concepto";
            this.colConcepto.Width = 223;
            // 
            // colEstatusPago
            // 
            this.colEstatusPago.Text = "Estatus";
            this.colEstatusPago.Width = 114;
            // 
            // colCantidad
            // 
            this.colCantidad.Text = "Cantidad";
            this.colCantidad.Width = 70;
            // 
            // colImporte
            // 
            this.colImporte.Text = "Importe";
            this.colImporte.Width = 55;
            // 
            // colTipoPago
            // 
            this.colTipoPago.Text = "Tipo";
            this.colTipoPago.Width = 131;
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCambiar,
            this.mnuEliminar});
            this.mnuOpciones.Name = "Menu";
            this.mnuOpciones.Size = new System.Drawing.Size(165, 48);
            // 
            // mnuCambiar
            // 
            this.mnuCambiar.Name = "mnuCambiar";
            this.mnuCambiar.Size = new System.Drawing.Size(164, 22);
            this.mnuCambiar.Text = "Cambiar Importe";
            this.mnuCambiar.Click += new System.EventHandler(this.mnuCambiar_Click);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(164, 22);
            this.mnuEliminar.Text = "Eliminar";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // pnlPiePagos
            // 
            this.pnlPiePagos.Controls.Add(this.chkPendientes);
            this.pnlPiePagos.Controls.Add(this.txtSaldo);
            this.pnlPiePagos.Controls.Add(this.lblSaldo);
            this.pnlPiePagos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPiePagos.Location = new System.Drawing.Point(3, 421);
            this.pnlPiePagos.Name = "pnlPiePagos";
            this.pnlPiePagos.Size = new System.Drawing.Size(821, 28);
            this.pnlPiePagos.TabIndex = 5;
            // 
            // chkPendientes
            // 
            this.chkPendientes.AutoSize = true;
            this.chkPendientes.Location = new System.Drawing.Point(5, 6);
            this.chkPendientes.Name = "chkPendientes";
            this.chkPendientes.Size = new System.Drawing.Size(111, 17);
            this.chkPendientes.TabIndex = 4;
            this.chkPendientes.Text = "Pagos pendientes";
            this.chkPendientes.UseVisualStyleBackColor = true;
            this.chkPendientes.CheckedChanged += new System.EventHandler(this.chkPendientes_CheckedChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(716, 4);
            this.txtSaldo.MaxLength = 10;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(676, 7);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo";
            // 
            // gbxSocio
            // 
            this.gbxSocio.Controls.Add(this.btnGenerarCobro);
            this.gbxSocio.Controls.Add(this.lblSocio);
            this.gbxSocio.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxSocio.Location = new System.Drawing.Point(3, 3);
            this.gbxSocio.Name = "gbxSocio";
            this.gbxSocio.Size = new System.Drawing.Size(818, 44);
            this.gbxSocio.TabIndex = 0;
            this.gbxSocio.TabStop = false;
            this.gbxSocio.Text = "Socio";
            // 
            // btnGenerarCobro
            // 
            this.btnGenerarCobro.Location = new System.Drawing.Point(656, 11);
            this.btnGenerarCobro.Name = "btnGenerarCobro";
            this.btnGenerarCobro.Size = new System.Drawing.Size(156, 23);
            this.btnGenerarCobro.TabIndex = 1;
            this.btnGenerarCobro.Text = "Generar cobro de servicio";
            this.btnGenerarCobro.UseVisualStyleBackColor = true;
            this.btnGenerarCobro.Click += new System.EventHandler(this.btnGenerarCobro_Click);
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Location = new System.Drawing.Point(16, 16);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(138, 13);
            this.lblSocio.TabIndex = 0;
            this.lblSocio.Text = "Nombre + Apellido del socio";
            // 
            // tpgInteraccion
            // 
            this.tpgInteraccion.Controls.Add(this.lstInteraccion);
            this.tpgInteraccion.Location = new System.Drawing.Point(4, 22);
            this.tpgInteraccion.Name = "tpgInteraccion";
            this.tpgInteraccion.Padding = new System.Windows.Forms.Padding(3);
            this.tpgInteraccion.Size = new System.Drawing.Size(936, 452);
            this.tpgInteraccion.TabIndex = 3;
            this.tpgInteraccion.Text = "Interacción";
            this.tpgInteraccion.UseVisualStyleBackColor = true;
            // 
            // lstInteraccion
            // 
            this.lstInteraccion.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDInteraccion,
            this.colFechaInteraccion,
            this.colAccion});
            this.lstInteraccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInteraccion.FullRowSelect = true;
            this.lstInteraccion.GridLines = true;
            this.lstInteraccion.HideSelection = false;
            this.lstInteraccion.Location = new System.Drawing.Point(3, 3);
            this.lstInteraccion.Name = "lstInteraccion";
            this.lstInteraccion.Size = new System.Drawing.Size(930, 446);
            this.lstInteraccion.SmallImageList = this.imlEstatus;
            this.lstInteraccion.TabIndex = 0;
            this.lstInteraccion.UseCompatibleStateImageBehavior = false;
            this.lstInteraccion.View = System.Windows.Forms.View.Details;
            // 
            // colIDInteraccion
            // 
            this.colIDInteraccion.Text = "ID";
            this.colIDInteraccion.Width = 59;
            // 
            // colFechaInteraccion
            // 
            this.colFechaInteraccion.Text = "Fecha";
            this.colFechaInteraccion.Width = 200;
            // 
            // colAccion
            // 
            this.colAccion.Text = "Accion";
            this.colAccion.Width = 374;
            // 
            // tpgAsistencias
            // 
            this.tpgAsistencias.Controls.Add(this.splitContainer1);
            this.tpgAsistencias.Location = new System.Drawing.Point(4, 22);
            this.tpgAsistencias.Name = "tpgAsistencias";
            this.tpgAsistencias.Size = new System.Drawing.Size(936, 452);
            this.tpgAsistencias.TabIndex = 4;
            this.tpgAsistencias.Text = "Asistencias";
            this.tpgAsistencias.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlAsistencia);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstAsistencia);
            this.splitContainer1.Size = new System.Drawing.Size(936, 452);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlAsistencia
            // 
            this.pnlAsistencia.Controls.Add(this.txtTotalAsistencia);
            this.pnlAsistencia.Controls.Add(this.lblTotalAsistencia);
            this.pnlAsistencia.Controls.Add(this.dtpFecha);
            this.pnlAsistencia.Controls.Add(this.lblDescripcion);
            this.pnlAsistencia.Controls.Add(this.lblTitulo);
            this.pnlAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAsistencia.Location = new System.Drawing.Point(0, 0);
            this.pnlAsistencia.Name = "pnlAsistencia";
            this.pnlAsistencia.Size = new System.Drawing.Size(311, 452);
            this.pnlAsistencia.TabIndex = 0;
            // 
            // txtTotalAsistencia
            // 
            this.txtTotalAsistencia.Location = new System.Drawing.Point(192, 133);
            this.txtTotalAsistencia.Name = "txtTotalAsistencia";
            this.txtTotalAsistencia.Size = new System.Drawing.Size(51, 20);
            this.txtTotalAsistencia.TabIndex = 5;
            // 
            // lblTotalAsistencia
            // 
            this.lblTotalAsistencia.AutoSize = true;
            this.lblTotalAsistencia.Location = new System.Drawing.Point(91, 136);
            this.lblTotalAsistencia.Name = "lblTotalAsistencia";
            this.lblTotalAsistencia.Size = new System.Drawing.Size(95, 13);
            this.lblTotalAsistencia.TabIndex = 4;
            this.lblTotalAsistencia.Text = "Total de personas:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(43, 107);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(5, 33);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(301, 51);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Este formulario le permite ver las asistencias de los socios por cada dia, para e" +
    "mpezar, seleccione la fecha.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(5, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(160, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Asistencias de los usuarios";
            // 
            // lstAsistencia
            // 
            this.lstAsistencia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHora,
            this.colNombre,
            this.colApellido});
            this.lstAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAsistencia.GridLines = true;
            this.lstAsistencia.HideSelection = false;
            this.lstAsistencia.Location = new System.Drawing.Point(0, 0);
            this.lstAsistencia.Name = "lstAsistencia";
            this.lstAsistencia.Size = new System.Drawing.Size(621, 452);
            this.lstAsistencia.TabIndex = 0;
            this.lstAsistencia.UseCompatibleStateImageBehavior = false;
            this.lstAsistencia.View = System.Windows.Forms.View.Details;
            // 
            // colHora
            // 
            this.colHora.Text = "Hora";
            this.colHora.Width = 112;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 237;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            this.colApellido.Width = 293;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(107, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(102, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo socio";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tblGeneral
            // 
            this.tblGeneral.ColumnCount = 1;
            this.tblGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGeneral.Controls.Add(this.pnlControles, 0, 1);
            this.tblGeneral.Controls.Add(this.tbcSocios, 0, 0);
            this.tblGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGeneral.Location = new System.Drawing.Point(0, 0);
            this.tblGeneral.Name = "tblGeneral";
            this.tblGeneral.RowCount = 2;
            this.tblGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tblGeneral.Size = new System.Drawing.Size(950, 519);
            this.tblGeneral.TabIndex = 16;
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.btnNuevo);
            this.pnlControles.Controls.Add(this.btnCancelar);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControles.Location = new System.Drawing.Point(725, 487);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(222, 29);
            this.pnlControles.TabIndex = 17;
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 519);
            this.Controls.Add(this.tblGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.frmSocios_Load);
            this.tbcSocios.ResumeLayout(false);
            this.tpgNuevo.ResumeLayout(false);
            this.tblEdicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.gbxNuevo.ResumeLayout(false);
            this.gbxNuevo.PerformLayout();
            this.tpgLista.ResumeLayout(false);
            this.tblSocios.ResumeLayout(false);
            this.pnlPieSocio.ResumeLayout(false);
            this.pnlPieSocio.PerformLayout();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
            this.tpgPagos.ResumeLayout(false);
            this.tblPagos.ResumeLayout(false);
            this.mnuOpciones.ResumeLayout(false);
            this.pnlPiePagos.ResumeLayout(false);
            this.pnlPiePagos.PerformLayout();
            this.gbxSocio.ResumeLayout(false);
            this.gbxSocio.PerformLayout();
            this.tpgInteraccion.ResumeLayout(false);
            this.tpgAsistencias.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAsistencia.ResumeLayout(false);
            this.pnlAsistencia.PerformLayout();
            this.tblGeneral.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        //    lvwColumnSorter = new ListViewColumnSorter();
        //    this.lstSocios.ListViewItemSorter = lvwColumnSorter;

        #endregion

        private System.Windows.Forms.TabControl tbcSocios;
        private System.Windows.Forms.TabPage tpgLista;
        private System.Windows.Forms.ListView lstSocios;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNombres;
        private System.Windows.Forms.ColumnHeader colApellidos;
        private System.Windows.Forms.ColumnHeader colTipo;
        private System.Windows.Forms.ColumnHeader colEstatus;
        private System.Windows.Forms.TabPage tpgPagos;
        private System.Windows.Forms.GroupBox gbxSocio;
        private System.Windows.Forms.TabPage tpgNuevo;
        private System.Windows.Forms.GroupBox gbxNuevo;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.DateTimePicker dtpInscripcion;
        private System.Windows.Forms.Label lblInscripcion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtTodos;
        private System.Windows.Forms.TextBox txtActivos;
        private System.Windows.Forms.TextBox txtAdeudados;
        private System.Windows.Forms.Label lblAdeudados;
        private System.Windows.Forms.Label lblActivos;
        private System.Windows.Forms.Label lblSocios;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ListView lstPagos;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colConcepto;
        private System.Windows.Forms.ColumnHeader colEstatusPago;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ColumnHeader colImporte;
        private System.Windows.Forms.TextBox txtFB;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefonos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.DateTimePicker dtpUPago;
        private System.Windows.Forms.Label lblUPago;
        private System.Windows.Forms.ColumnHeader colAntiguedad;
        private System.Windows.Forms.ColumnHeader colUPago;
        private System.Windows.Forms.ColumnHeader colCantidad;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.ImageList imlEstatus;
        private System.Windows.Forms.ColumnHeader colDeuda;
        private System.Windows.Forms.CheckBox chkPendientes;
        private System.Windows.Forms.TextBox txtTotalAdeudado;
        private System.Windows.Forms.Label lblTotalAdeudo;
        private System.Windows.Forms.ColumnHeader colPagoID;
        private System.Windows.Forms.ColumnHeader colTipoPago;
        private System.Windows.Forms.TableLayoutPanel tblSocios;
        private System.Windows.Forms.TableLayoutPanel tblGeneral;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Panel pnlPieSocio;
        private System.Windows.Forms.Panel pnlPiePagos;
        private System.Windows.Forms.TableLayoutPanel tblPagos;
        private System.Windows.Forms.ContextMenuStrip mnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuCambiar;
        private System.Windows.Forms.TableLayoutPanel tblEdicion;
        private System.Windows.Forms.ComboBox cmbRutina;
        private System.Windows.Forms.Label lblRutina;
        private System.Windows.Forms.DateTimePicker dtpLimite;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.Button btnGenerarCobro;
        private System.Windows.Forms.ColumnHeader colLimite;
        private System.Windows.Forms.TabPage tpgInteraccion;
        private System.Windows.Forms.ListView lstInteraccion;
        private System.Windows.Forms.ColumnHeader colIDInteraccion;
        private System.Windows.Forms.ColumnHeader colFechaInteraccion;
        private System.Windows.Forms.ColumnHeader colAccion;
        private System.Windows.Forms.CheckBox chkInactivos;
        private System.Windows.Forms.ColumnHeader colActivo;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TabPage tpgAsistencias;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlAsistencia;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListView lstAsistencia;
        private System.Windows.Forms.ColumnHeader colHora;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtTotalAsistencia;
        private System.Windows.Forms.Label lblTotalAsistencia;
    }
}