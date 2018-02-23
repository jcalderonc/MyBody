namespace MyBody
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.gbxRegistrar = new System.Windows.Forms.GroupBox();
            this.tblLog = new System.Windows.Forms.TableLayoutPanel();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.pnlRegistroHuella = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.EnrollButton = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.tbcRegistro = new System.Windows.Forms.TabControl();
            this.tpgPago = new System.Windows.Forms.TabPage();
            this.tblPagos = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPiePagos = new System.Windows.Forms.Panel();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.pnlDeudas = new System.Windows.Forms.Panel();
            this.lblSocio = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblTituloPagos = new System.Windows.Forms.Label();
            this.pnlPagosAsistencia = new System.Windows.Forms.SplitContainer();
            this.tbcPerfil = new System.Windows.Forms.TabControl();
            this.tpgFoto = new System.Windows.Forms.TabPage();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.tpgAsistencia = new System.Windows.Forms.TabPage();
            this.tblAsistencia = new System.Windows.Forms.TableLayoutPanel();
            this.dtpAsistencias = new System.Windows.Forms.DateTimePicker();
            this.lstAsistencias = new System.Windows.Forms.ListView();
            this.imlEstatus = new System.Windows.Forms.ImageList(this.components);
            this.lstPagos = new System.Windows.Forms.ListView();
            this.colPagoID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLimite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colConcepto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstatusPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipoPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpgRutina = new System.Windows.Forms.TabPage();
            this.tblRutina = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDia = new System.Windows.Forms.Panel();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlEjercicios = new System.Windows.Forms.Panel();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.pnlFondo.SuspendLayout();
            this.gbxRegistrar.SuspendLayout();
            this.tblLog.SuspendLayout();
            this.pnlRegistroHuella.SuspendLayout();
            this.tbcRegistro.SuspendLayout();
            this.tpgPago.SuspendLayout();
            this.tblPagos.SuspendLayout();
            this.pnlPiePagos.SuspendLayout();
            this.pnlDeudas.SuspendLayout();
            this.pnlPagosAsistencia.Panel1.SuspendLayout();
            this.pnlPagosAsistencia.Panel2.SuspendLayout();
            this.pnlPagosAsistencia.SuspendLayout();
            this.tbcPerfil.SuspendLayout();
            this.tpgFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.tpgAsistencia.SuspendLayout();
            this.tblAsistencia.SuspendLayout();
            this.tpgRutina.SuspendLayout();
            this.tblRutina.SuspendLayout();
            this.pnlDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.Black;
            this.pnlFondo.Controls.Add(this.gbxRegistrar);
            this.pnlFondo.Controls.Add(this.pnlEncabezado);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1076, 139);
            this.pnlFondo.TabIndex = 11;
            // 
            // gbxRegistrar
            // 
            this.gbxRegistrar.BackColor = System.Drawing.Color.Black;
            this.gbxRegistrar.Controls.Add(this.tblLog);
            this.gbxRegistrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxRegistrar.ForeColor = System.Drawing.Color.White;
            this.gbxRegistrar.Location = new System.Drawing.Point(427, 0);
            this.gbxRegistrar.Name = "gbxRegistrar";
            this.gbxRegistrar.Size = new System.Drawing.Size(649, 139);
            this.gbxRegistrar.TabIndex = 1;
            this.gbxRegistrar.TabStop = false;
            this.gbxRegistrar.Text = "¿Aun no haz registrado tu huella?";
            // 
            // tblLog
            // 
            this.tblLog.ColumnCount = 2;
            this.tblLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tblLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLog.Controls.Add(this.lstLog, 1, 0);
            this.tblLog.Controls.Add(this.pnlRegistroHuella, 0, 0);
            this.tblLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLog.Location = new System.Drawing.Point(3, 16);
            this.tblLog.Name = "tblLog";
            this.tblLog.RowCount = 1;
            this.tblLog.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLog.Size = new System.Drawing.Size(643, 120);
            this.tblLog.TabIndex = 10;
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.Black;
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.ForeColor = System.Drawing.Color.White;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(190, 3);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(450, 114);
            this.lstLog.TabIndex = 11;
            // 
            // pnlRegistroHuella
            // 
            this.pnlRegistroHuella.Controls.Add(this.lblNumero);
            this.pnlRegistroHuella.Controls.Add(this.EnrollButton);
            this.pnlRegistroHuella.Controls.Add(this.txtID);
            this.pnlRegistroHuella.Controls.Add(this.VerifyButton);
            this.pnlRegistroHuella.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistroHuella.Location = new System.Drawing.Point(3, 3);
            this.pnlRegistroHuella.Name = "pnlRegistroHuella";
            this.pnlRegistroHuella.Size = new System.Drawing.Size(181, 114);
            this.pnlRegistroHuella.TabIndex = 11;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(3, 14);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(89, 13);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "Numero del socio";
            // 
            // EnrollButton
            // 
            this.EnrollButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(175)))), ((int)(((byte)(31)))));
            this.EnrollButton.Enabled = false;
            this.EnrollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnrollButton.Location = new System.Drawing.Point(6, 41);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Size = new System.Drawing.Size(167, 23);
            this.EnrollButton.TabIndex = 6;
            this.EnrollButton.Text = "Registrar Huella";
            this.EnrollButton.UseVisualStyleBackColor = false;
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(98, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 9;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(175)))), ((int)(((byte)(31)))));
            this.VerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyButton.Location = new System.Drawing.Point(6, 70);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(167, 23);
            this.VerifyButton.TabIndex = 7;
            this.VerifyButton.Text = "Verificar Huella";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Black;
            this.pnlEncabezado.BackgroundImage = global::MyBody.Properties.Resources.Encabezado;
            this.pnlEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(427, 139);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Red;
            this.lblHora.Location = new System.Drawing.Point(277, 47);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 19);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "00:00:00";
            // 
            // tbcRegistro
            // 
            this.tbcRegistro.Controls.Add(this.tpgPago);
            this.tbcRegistro.Controls.Add(this.tpgRutina);
            this.tbcRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRegistro.Location = new System.Drawing.Point(0, 139);
            this.tbcRegistro.Name = "tbcRegistro";
            this.tbcRegistro.SelectedIndex = 0;
            this.tbcRegistro.Size = new System.Drawing.Size(1076, 526);
            this.tbcRegistro.TabIndex = 1;
            // 
            // tpgPago
            // 
            this.tpgPago.Controls.Add(this.tblPagos);
            this.tpgPago.Location = new System.Drawing.Point(4, 22);
            this.tpgPago.Name = "tpgPago";
            this.tpgPago.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPago.Size = new System.Drawing.Size(1068, 500);
            this.tpgPago.TabIndex = 1;
            this.tpgPago.Text = "Pagos";
            this.tpgPago.UseVisualStyleBackColor = true;
            // 
            // tblPagos
            // 
            this.tblPagos.ColumnCount = 1;
            this.tblPagos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPagos.Controls.Add(this.pnlPiePagos, 0, 2);
            this.tblPagos.Controls.Add(this.pnlDeudas, 0, 0);
            this.tblPagos.Controls.Add(this.pnlPagosAsistencia, 0, 1);
            this.tblPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPagos.Location = new System.Drawing.Point(3, 3);
            this.tblPagos.Name = "tblPagos";
            this.tblPagos.RowCount = 3;
            this.tblPagos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPagos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPagos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblPagos.Size = new System.Drawing.Size(1062, 494);
            this.tblPagos.TabIndex = 7;
            // 
            // pnlPiePagos
            // 
            this.pnlPiePagos.Controls.Add(this.txtSaldo);
            this.pnlPiePagos.Controls.Add(this.lblSaldo);
            this.pnlPiePagos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPiePagos.Location = new System.Drawing.Point(908, 463);
            this.pnlPiePagos.Name = "pnlPiePagos";
            this.pnlPiePagos.Size = new System.Drawing.Size(151, 28);
            this.pnlPiePagos.TabIndex = 5;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(43, 3);
            this.txtSaldo.MaxLength = 10;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(3, 6);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo";
            // 
            // pnlDeudas
            // 
            this.pnlDeudas.Controls.Add(this.lblSocio);
            this.pnlDeudas.Controls.Add(this.lblSaludo);
            this.pnlDeudas.Controls.Add(this.lblTituloPagos);
            this.pnlDeudas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeudas.Location = new System.Drawing.Point(3, 3);
            this.pnlDeudas.Name = "pnlDeudas";
            this.pnlDeudas.Size = new System.Drawing.Size(1056, 64);
            this.pnlDeudas.TabIndex = 6;
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.BackColor = System.Drawing.Color.Transparent;
            this.lblSocio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.ForeColor = System.Drawing.Color.Black;
            this.lblSocio.Location = new System.Drawing.Point(6, 23);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(239, 16);
            this.lblSocio.TabIndex = 13;
            this.lblSocio.Text = "COLOCA TU DEDO EN EL LECTOR.";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(6, 6);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(102, 17);
            this.lblSaludo.TabIndex = 14;
            this.lblSaludo.Text = "Buenos dias.";
            // 
            // lblTituloPagos
            // 
            this.lblTituloPagos.AutoSize = true;
            this.lblTituloPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPagos.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTituloPagos.Location = new System.Drawing.Point(6, 39);
            this.lblTituloPagos.Name = "lblTituloPagos";
            this.lblTituloPagos.Size = new System.Drawing.Size(233, 17);
            this.lblTituloPagos.TabIndex = 6;
            this.lblTituloPagos.Text = "Para mostrar tu lista de pendientes.";
            // 
            // pnlPagosAsistencia
            // 
            this.pnlPagosAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPagosAsistencia.Location = new System.Drawing.Point(3, 73);
            this.pnlPagosAsistencia.Name = "pnlPagosAsistencia";
            // 
            // pnlPagosAsistencia.Panel1
            // 
            this.pnlPagosAsistencia.Panel1.Controls.Add(this.tbcPerfil);
            // 
            // pnlPagosAsistencia.Panel2
            // 
            this.pnlPagosAsistencia.Panel2.Controls.Add(this.lstPagos);
            this.pnlPagosAsistencia.Size = new System.Drawing.Size(1056, 384);
            this.pnlPagosAsistencia.SplitterDistance = 352;
            this.pnlPagosAsistencia.TabIndex = 7;
            // 
            // tbcPerfil
            // 
            this.tbcPerfil.Controls.Add(this.tpgFoto);
            this.tbcPerfil.Controls.Add(this.tpgAsistencia);
            this.tbcPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPerfil.Location = new System.Drawing.Point(0, 0);
            this.tbcPerfil.Name = "tbcPerfil";
            this.tbcPerfil.SelectedIndex = 0;
            this.tbcPerfil.Size = new System.Drawing.Size(352, 384);
            this.tbcPerfil.TabIndex = 3;
            // 
            // tpgFoto
            // 
            this.tpgFoto.Controls.Add(this.pbxFoto);
            this.tpgFoto.Location = new System.Drawing.Point(4, 22);
            this.tpgFoto.Name = "tpgFoto";
            this.tpgFoto.Padding = new System.Windows.Forms.Padding(3);
            this.tpgFoto.Size = new System.Drawing.Size(344, 358);
            this.tpgFoto.TabIndex = 0;
            this.tpgFoto.Text = "Foto";
            this.tpgFoto.UseVisualStyleBackColor = true;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxFoto.InitialImage = global::MyBody.Properties.Resources.Nuevos;
            this.pbxFoto.Location = new System.Drawing.Point(3, 3);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(338, 352);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 0;
            this.pbxFoto.TabStop = false;
            // 
            // tpgAsistencia
            // 
            this.tpgAsistencia.Controls.Add(this.tblAsistencia);
            this.tpgAsistencia.Location = new System.Drawing.Point(4, 22);
            this.tpgAsistencia.Name = "tpgAsistencia";
            this.tpgAsistencia.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAsistencia.Size = new System.Drawing.Size(344, 358);
            this.tpgAsistencia.TabIndex = 1;
            this.tpgAsistencia.Text = "Asistencia";
            this.tpgAsistencia.UseVisualStyleBackColor = true;
            // 
            // tblAsistencia
            // 
            this.tblAsistencia.ColumnCount = 1;
            this.tblAsistencia.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAsistencia.Controls.Add(this.dtpAsistencias, 0, 0);
            this.tblAsistencia.Controls.Add(this.lstAsistencias, 0, 1);
            this.tblAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAsistencia.Location = new System.Drawing.Point(3, 3);
            this.tblAsistencia.Name = "tblAsistencia";
            this.tblAsistencia.RowCount = 2;
            this.tblAsistencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblAsistencia.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAsistencia.Size = new System.Drawing.Size(338, 352);
            this.tblAsistencia.TabIndex = 2;
            // 
            // dtpAsistencias
            // 
            this.dtpAsistencias.CustomFormat = "MMMM/yyyy";
            this.dtpAsistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpAsistencias.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAsistencias.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAsistencias.Location = new System.Drawing.Point(3, 3);
            this.dtpAsistencias.Name = "dtpAsistencias";
            this.dtpAsistencias.ShowUpDown = true;
            this.dtpAsistencias.Size = new System.Drawing.Size(332, 22);
            this.dtpAsistencias.TabIndex = 1;
            this.dtpAsistencias.ValueChanged += new System.EventHandler(this.dtpAsistencias_ValueChanged);
            // 
            // lstAsistencias
            // 
            this.lstAsistencias.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstAsistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAsistencias.FullRowSelect = true;
            this.lstAsistencias.GridLines = true;
            this.lstAsistencias.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstAsistencias.LargeImageList = this.imlEstatus;
            this.lstAsistencias.Location = new System.Drawing.Point(3, 33);
            this.lstAsistencias.Name = "lstAsistencias";
            this.lstAsistencias.Size = new System.Drawing.Size(332, 316);
            this.lstAsistencias.TabIndex = 0;
            this.lstAsistencias.TileSize = new System.Drawing.Size(55, 45);
            this.lstAsistencias.UseCompatibleStateImageBehavior = false;
            this.lstAsistencias.View = System.Windows.Forms.View.Tile;
            // 
            // imlEstatus
            // 
            this.imlEstatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlEstatus.ImageStream")));
            this.imlEstatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imlEstatus.Images.SetKeyName(0, "RJO.jpg");
            this.imlEstatus.Images.SetKeyName(1, "VRD.jpg");
            this.imlEstatus.Images.SetKeyName(2, "AMR.jpg");
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
            this.lstPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPagos.FullRowSelect = true;
            this.lstPagos.GridLines = true;
            this.lstPagos.Location = new System.Drawing.Point(0, 0);
            this.lstPagos.MultiSelect = false;
            this.lstPagos.Name = "lstPagos";
            this.lstPagos.Size = new System.Drawing.Size(700, 384);
            this.lstPagos.SmallImageList = this.imlEstatus;
            this.lstPagos.TabIndex = 1;
            this.lstPagos.UseCompatibleStateImageBehavior = false;
            this.lstPagos.View = System.Windows.Forms.View.Details;
            // 
            // colPagoID
            // 
            this.colPagoID.Text = "ID";
            this.colPagoID.Width = 24;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 112;
            // 
            // colLimite
            // 
            this.colLimite.Text = "Fecha Limite";
            this.colLimite.Width = 114;
            // 
            // colConcepto
            // 
            this.colConcepto.Text = "Concepto";
            this.colConcepto.Width = 169;
            // 
            // colEstatusPago
            // 
            this.colEstatusPago.Text = "Estatus";
            this.colEstatusPago.Width = 78;
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
            this.colTipoPago.Width = 69;
            // 
            // tpgRutina
            // 
            this.tpgRutina.Controls.Add(this.tblRutina);
            this.tpgRutina.Location = new System.Drawing.Point(4, 22);
            this.tpgRutina.Name = "tpgRutina";
            this.tpgRutina.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRutina.Size = new System.Drawing.Size(1068, 500);
            this.tpgRutina.TabIndex = 0;
            this.tpgRutina.Text = "Rutina";
            this.tpgRutina.UseVisualStyleBackColor = true;
            // 
            // tblRutina
            // 
            this.tblRutina.ColumnCount = 1;
            this.tblRutina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRutina.Controls.Add(this.pnlDia, 0, 0);
            this.tblRutina.Controls.Add(this.pnlEjercicios, 0, 1);
            this.tblRutina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRutina.Location = new System.Drawing.Point(3, 3);
            this.tblRutina.Name = "tblRutina";
            this.tblRutina.RowCount = 2;
            this.tblRutina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tblRutina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRutina.Size = new System.Drawing.Size(1062, 494);
            this.tblRutina.TabIndex = 2;
            // 
            // pnlDia
            // 
            this.pnlDia.Controls.Add(this.cmbDia);
            this.pnlDia.Controls.Add(this.lblDia);
            this.pnlDia.Controls.Add(this.lblEnviar);
            this.pnlDia.Controls.Add(this.lblHora);
            this.pnlDia.Controls.Add(this.btnEnviar);
            this.pnlDia.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDia.Location = new System.Drawing.Point(3, 3);
            this.pnlDia.Name = "pnlDia";
            this.pnlDia.Size = new System.Drawing.Size(993, 110);
            this.pnlDia.TabIndex = 3;
            // 
            // cmbDia
            // 
            this.cmbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(9, 43);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(262, 28);
            this.cmbDia.TabIndex = 1;
            this.cmbDia.SelectedIndexChanged += new System.EventHandler(this.cmbDia_SelectedIndexChanged);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.Maroon;
            this.lblDia.Location = new System.Drawing.Point(6, 23);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(265, 17);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "¿La rutina de que día quieres visualizar?";
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviar.ForeColor = System.Drawing.Color.Maroon;
            this.lblEnviar.Location = new System.Drawing.Point(56, 83);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(176, 17);
            this.lblEnviar.TabIndex = 10;
            this.lblEnviar.Text = "Enviar mi rutina por correo";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.BackgroundImage = global::MyBody.Properties.Resources.Mail;
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviar.Location = new System.Drawing.Point(9, 77);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(41, 29);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pnlEjercicios
            // 
            this.pnlEjercicios.AutoScroll = true;
            this.pnlEjercicios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlEjercicios.BackColor = System.Drawing.Color.White;
            this.pnlEjercicios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEjercicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEjercicios.Location = new System.Drawing.Point(3, 119);
            this.pnlEjercicios.Name = "pnlEjercicios";
            this.pnlEjercicios.Size = new System.Drawing.Size(1056, 372);
            this.pnlEjercicios.TabIndex = 4;
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 60000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::MyBody.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1076, 665);
            this.Controls.Add(this.tbcRegistro);
            this.Controls.Add(this.pnlFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de socios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegistro_FormClosing);
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.pnlFondo.ResumeLayout(false);
            this.gbxRegistrar.ResumeLayout(false);
            this.tblLog.ResumeLayout(false);
            this.pnlRegistroHuella.ResumeLayout(false);
            this.pnlRegistroHuella.PerformLayout();
            this.tbcRegistro.ResumeLayout(false);
            this.tpgPago.ResumeLayout(false);
            this.tblPagos.ResumeLayout(false);
            this.pnlPiePagos.ResumeLayout(false);
            this.pnlPiePagos.PerformLayout();
            this.pnlDeudas.ResumeLayout(false);
            this.pnlDeudas.PerformLayout();
            this.pnlPagosAsistencia.Panel1.ResumeLayout(false);
            this.pnlPagosAsistencia.Panel2.ResumeLayout(false);
            this.pnlPagosAsistencia.ResumeLayout(false);
            this.tbcPerfil.ResumeLayout(false);
            this.tpgFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.tpgAsistencia.ResumeLayout(false);
            this.tblAsistencia.ResumeLayout(false);
            this.tpgRutina.ResumeLayout(false);
            this.tblRutina.ResumeLayout(false);
            this.pnlDia.ResumeLayout(false);
            this.pnlDia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.TabControl tbcRegistro;
        private System.Windows.Forms.TabPage tpgRutina;
        private System.Windows.Forms.TabPage tpgPago;
        private System.Windows.Forms.GroupBox gbxRegistrar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.Button EnrollButton;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.TableLayoutPanel tblPagos;
        private System.Windows.Forms.ListView lstPagos;
        private System.Windows.Forms.ColumnHeader colPagoID;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colLimite;
        private System.Windows.Forms.ColumnHeader colConcepto;
        private System.Windows.Forms.ColumnHeader colEstatusPago;
        private System.Windows.Forms.ColumnHeader colCantidad;
        private System.Windows.Forms.ColumnHeader colImporte;
        private System.Windows.Forms.ColumnHeader colTipoPago;
        private System.Windows.Forms.Panel pnlPiePagos;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTituloPagos;
        private System.Windows.Forms.ImageList imlEstatus;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Panel pnlDia;
        private System.Windows.Forms.TableLayoutPanel tblRutina;
        private System.Windows.Forms.Panel pnlEjercicios;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.TableLayoutPanel tblLog;
        private System.Windows.Forms.Panel pnlRegistroHuella;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.Panel pnlDeudas;
        private System.Windows.Forms.SplitContainer pnlPagosAsistencia;
        private System.Windows.Forms.ListView lstAsistencias;
        private System.Windows.Forms.DateTimePicker dtpAsistencias;
        private System.Windows.Forms.TableLayoutPanel tblAsistencia;
        private System.Windows.Forms.TabControl tbcPerfil;
        private System.Windows.Forms.TabPage tpgFoto;
        private System.Windows.Forms.TabPage tpgAsistencia;
        private System.Windows.Forms.PictureBox pbxFoto;
    }
}