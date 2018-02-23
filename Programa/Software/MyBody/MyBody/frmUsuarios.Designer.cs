namespace MyBody
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.pblAcceso = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkSocios = new System.Windows.Forms.CheckBox();
            this.chkVenta = new System.Windows.Forms.CheckBox();
            this.chkInventario = new System.Windows.Forms.CheckBox();
            this.chkAcceso = new System.Windows.Forms.CheckBox();
            this.tbcUsuarios = new System.Windows.Forms.TabControl();
            this.tpgCambios = new System.Windows.Forms.TabPage();
            this.chkRutina = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.tpgUsuarios = new System.Windows.Forms.TabPage();
            this.btnActivar = new System.Windows.Forms.Button();
            this.lblDouble = new System.Windows.Forms.Label();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.tpgConfiguraciones = new System.Windows.Forms.TabPage();
            this.gbxSMTP = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblSMTP = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.lblSMTP_Pwd = new System.Windows.Forms.Label();
            this.btnSMTP = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblSMTP_User = new System.Windows.Forms.Label();
            this.gpbBaseDatos = new System.Windows.Forms.GroupBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblGymName = new System.Windows.Forms.Label();
            this.txtGymName = new System.Windows.Forms.TextBox();
            this.tbcUsuarios.SuspendLayout();
            this.tpgCambios.SuspendLayout();
            this.tpgUsuarios.SuspendLayout();
            this.tpgConfiguraciones.SuspendLayout();
            this.gbxSMTP.SuspendLayout();
            this.gpbBaseDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pblAcceso
            // 
            this.pblAcceso.BackgroundImage = global::MyBody.Properties.Resources.Acceso;
            this.pblAcceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblAcceso.Dock = System.Windows.Forms.DockStyle.Left;
            this.pblAcceso.Location = new System.Drawing.Point(0, 0);
            this.pblAcceso.Name = "pblAcceso";
            this.pblAcceso.Size = new System.Drawing.Size(433, 319);
            this.pblAcceso.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(686, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(12, 61);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(83, 32);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(184, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(83, 58);
            this.txtContraseña.MaxLength = 10;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(184, 20);
            this.txtContraseña.TabIndex = 6;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(83, 84);
            this.txtConfirmar.MaxLength = 10;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(184, 20);
            this.txtConfirmar.TabIndex = 8;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(22, 87);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(51, 13);
            this.lblConfirmar.TabIndex = 7;
            this.lblConfirmar.Text = "Confirmar";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 114);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 111);
            this.txtNombre.MaxLength = 80;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // chkSocios
            // 
            this.chkSocios.AutoSize = true;
            this.chkSocios.Location = new System.Drawing.Point(83, 137);
            this.chkSocios.Name = "chkSocios";
            this.chkSocios.Size = new System.Drawing.Size(58, 17);
            this.chkSocios.TabIndex = 11;
            this.chkSocios.Text = "Socios";
            this.chkSocios.UseVisualStyleBackColor = true;
            // 
            // chkVenta
            // 
            this.chkVenta.AutoSize = true;
            this.chkVenta.Location = new System.Drawing.Point(83, 160);
            this.chkVenta.Name = "chkVenta";
            this.chkVenta.Size = new System.Drawing.Size(54, 17);
            this.chkVenta.TabIndex = 12;
            this.chkVenta.Text = "Venta";
            this.chkVenta.UseVisualStyleBackColor = true;
            // 
            // chkInventario
            // 
            this.chkInventario.AutoSize = true;
            this.chkInventario.Location = new System.Drawing.Point(83, 183);
            this.chkInventario.Name = "chkInventario";
            this.chkInventario.Size = new System.Drawing.Size(73, 17);
            this.chkInventario.TabIndex = 13;
            this.chkInventario.Text = "Inventario";
            this.chkInventario.UseVisualStyleBackColor = true;
            // 
            // chkAcceso
            // 
            this.chkAcceso.AutoSize = true;
            this.chkAcceso.Location = new System.Drawing.Point(83, 228);
            this.chkAcceso.Name = "chkAcceso";
            this.chkAcceso.Size = new System.Drawing.Size(62, 17);
            this.chkAcceso.TabIndex = 14;
            this.chkAcceso.Text = "Acceso";
            this.chkAcceso.UseVisualStyleBackColor = true;
            // 
            // tbcUsuarios
            // 
            this.tbcUsuarios.Controls.Add(this.tpgCambios);
            this.tbcUsuarios.Controls.Add(this.tpgUsuarios);
            this.tbcUsuarios.Controls.Add(this.tpgConfiguraciones);
            this.tbcUsuarios.Location = new System.Drawing.Point(439, 6);
            this.tbcUsuarios.Name = "tbcUsuarios";
            this.tbcUsuarios.SelectedIndex = 0;
            this.tbcUsuarios.Size = new System.Drawing.Size(335, 281);
            this.tbcUsuarios.TabIndex = 15;
            this.tbcUsuarios.SelectedIndexChanged += new System.EventHandler(this.tbcUsuarios_SelectedIndexChanged);
            // 
            // tpgCambios
            // 
            this.tpgCambios.Controls.Add(this.chkRutina);
            this.tpgCambios.Controls.Add(this.btnGuardar);
            this.tpgCambios.Controls.Add(this.lblID);
            this.tpgCambios.Controls.Add(this.txtID);
            this.tpgCambios.Controls.Add(this.chkActivo);
            this.tpgCambios.Controls.Add(this.lblUsuario);
            this.tpgCambios.Controls.Add(this.chkAcceso);
            this.tpgCambios.Controls.Add(this.lblContraseña);
            this.tpgCambios.Controls.Add(this.chkInventario);
            this.tpgCambios.Controls.Add(this.txtUsuario);
            this.tpgCambios.Controls.Add(this.chkVenta);
            this.tpgCambios.Controls.Add(this.txtContraseña);
            this.tpgCambios.Controls.Add(this.chkSocios);
            this.tpgCambios.Controls.Add(this.lblConfirmar);
            this.tpgCambios.Controls.Add(this.txtNombre);
            this.tpgCambios.Controls.Add(this.txtConfirmar);
            this.tpgCambios.Controls.Add(this.lblNombre);
            this.tpgCambios.Location = new System.Drawing.Point(4, 22);
            this.tpgCambios.Name = "tpgCambios";
            this.tpgCambios.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCambios.Size = new System.Drawing.Size(327, 255);
            this.tpgCambios.TabIndex = 0;
            this.tpgCambios.Text = "Edición";
            this.tpgCambios.UseVisualStyleBackColor = true;
            // 
            // chkRutina
            // 
            this.chkRutina.AutoSize = true;
            this.chkRutina.Location = new System.Drawing.Point(83, 205);
            this.chkRutina.Name = "chkRutina";
            this.chkRutina.Size = new System.Drawing.Size(57, 17);
            this.chkRutina.TabIndex = 20;
            this.chkRutina.Text = "Rutina";
            this.chkRutina.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(243, 222);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(55, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(83, 6);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(73, 20);
            this.txtID.TabIndex = 17;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(168, 8);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 15;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // tpgUsuarios
            // 
            this.tpgUsuarios.Controls.Add(this.btnActivar);
            this.tpgUsuarios.Controls.Add(this.lblDouble);
            this.tpgUsuarios.Controls.Add(this.btnDesactivar);
            this.tpgUsuarios.Controls.Add(this.lstUsuarios);
            this.tpgUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpgUsuarios.Name = "tpgUsuarios";
            this.tpgUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpgUsuarios.Size = new System.Drawing.Size(327, 255);
            this.tpgUsuarios.TabIndex = 1;
            this.tpgUsuarios.Text = "Usuarios";
            this.tpgUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(162, 207);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 18;
            this.btnActivar.Text = "Activar";
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(6, 4);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(187, 13);
            this.lblDouble.TabIndex = 17;
            this.lblDouble.Text = "Doble clic sobre el usuario para editar.";
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(243, 207);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(73, 23);
            this.btnDesactivar.TabIndex = 16;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(6, 19);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(315, 186);
            this.lstUsuarios.TabIndex = 0;
            this.lstUsuarios.DoubleClick += new System.EventHandler(this.lstUsuarios_DoubleClick);
            // 
            // tpgConfiguraciones
            // 
            this.tpgConfiguraciones.Controls.Add(this.gbxSMTP);
            this.tpgConfiguraciones.Controls.Add(this.gpbBaseDatos);
            this.tpgConfiguraciones.Location = new System.Drawing.Point(4, 22);
            this.tpgConfiguraciones.Name = "tpgConfiguraciones";
            this.tpgConfiguraciones.Size = new System.Drawing.Size(327, 255);
            this.tpgConfiguraciones.TabIndex = 2;
            this.tpgConfiguraciones.Text = "Configuracion";
            this.tpgConfiguraciones.UseVisualStyleBackColor = true;
            // 
            // gbxSMTP
            // 
            this.gbxSMTP.Controls.Add(this.txtGymName);
            this.gbxSMTP.Controls.Add(this.lblGymName);
            this.gbxSMTP.Controls.Add(this.txtPort);
            this.gbxSMTP.Controls.Add(this.lblSMTP);
            this.gbxSMTP.Controls.Add(this.txtPass);
            this.gbxSMTP.Controls.Add(this.txtSMTP);
            this.gbxSMTP.Controls.Add(this.lblSMTP_Pwd);
            this.gbxSMTP.Controls.Add(this.btnSMTP);
            this.gbxSMTP.Controls.Add(this.txtCorreo);
            this.gbxSMTP.Controls.Add(this.lblSMTP_User);
            this.gbxSMTP.Location = new System.Drawing.Point(3, 90);
            this.gbxSMTP.Name = "gbxSMTP";
            this.gbxSMTP.Size = new System.Drawing.Size(321, 151);
            this.gbxSMTP.TabIndex = 1;
            this.gbxSMTP.TabStop = false;
            this.gbxSMTP.Text = "SMTP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(182, 32);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(52, 20);
            this.txtPort.TabIndex = 10;
            // 
            // lblSMTP
            // 
            this.lblSMTP.AutoSize = true;
            this.lblSMTP.Location = new System.Drawing.Point(6, 16);
            this.lblSMTP.Name = "lblSMTP";
            this.lblSMTP.Size = new System.Drawing.Size(101, 13);
            this.lblSMTP.TabIndex = 3;
            this.lblSMTP.Text = "SMTP Server / Port";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(120, 73);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(101, 20);
            this.txtPass.TabIndex = 9;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(9, 32);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(167, 20);
            this.txtSMTP.TabIndex = 4;
            // 
            // lblSMTP_Pwd
            // 
            this.lblSMTP_Pwd.AutoSize = true;
            this.lblSMTP_Pwd.Location = new System.Drawing.Point(117, 57);
            this.lblSMTP_Pwd.Name = "lblSMTP_Pwd";
            this.lblSMTP_Pwd.Size = new System.Drawing.Size(86, 13);
            this.lblSMTP_Pwd.TabIndex = 8;
            this.lblSMTP_Pwd.Text = "SMTP Password";
            // 
            // btnSMTP
            // 
            this.btnSMTP.Location = new System.Drawing.Point(240, 106);
            this.btnSMTP.Name = "btnSMTP";
            this.btnSMTP.Size = new System.Drawing.Size(75, 35);
            this.btnSMTP.TabIndex = 5;
            this.btnSMTP.Text = "Cambiar SMTP";
            this.btnSMTP.UseVisualStyleBackColor = true;
            this.btnSMTP.Click += new System.EventHandler(this.btnSMTP_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(6, 73);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(101, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // lblSMTP_User
            // 
            this.lblSMTP_User.AutoSize = true;
            this.lblSMTP_User.Location = new System.Drawing.Point(6, 57);
            this.lblSMTP_User.Name = "lblSMTP_User";
            this.lblSMTP_User.Size = new System.Drawing.Size(62, 13);
            this.lblSMTP_User.TabIndex = 6;
            this.lblSMTP_User.Text = "SMTP User";
            // 
            // gpbBaseDatos
            // 
            this.gpbBaseDatos.Controls.Add(this.txtUbicacion);
            this.gpbBaseDatos.Controls.Add(this.lblUbicacion);
            this.gpbBaseDatos.Controls.Add(this.btnCambiar);
            this.gpbBaseDatos.Location = new System.Drawing.Point(3, 3);
            this.gpbBaseDatos.Name = "gpbBaseDatos";
            this.gpbBaseDatos.Size = new System.Drawing.Size(321, 81);
            this.gpbBaseDatos.TabIndex = 0;
            this.gpbBaseDatos.TabStop = false;
            this.gpbBaseDatos.Text = "Base de datos";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Enabled = false;
            this.txtUbicacion.Location = new System.Drawing.Point(9, 36);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(225, 20);
            this.txtUbicacion.TabIndex = 2;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(6, 20);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 1;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(240, 31);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 36);
            this.btnCambiar.TabIndex = 0;
            this.btnCambiar.Text = "Cambiar ubicación";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(579, 293);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(101, 23);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Nuevo usuario";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblGymName
            // 
            this.lblGymName.AutoSize = true;
            this.lblGymName.Location = new System.Drawing.Point(6, 99);
            this.lblGymName.Name = "lblGymName";
            this.lblGymName.Size = new System.Drawing.Size(68, 13);
            this.lblGymName.TabIndex = 11;
            this.lblGymName.Text = "Nombre Gym";
            // 
            // txtGymName
            // 
            this.txtGymName.Location = new System.Drawing.Point(6, 115);
            this.txtGymName.Name = "txtGymName";
            this.txtGymName.Size = new System.Drawing.Size(215, 20);
            this.txtGymName.TabIndex = 12;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(779, 319);
            this.Controls.Add(this.tbcUsuarios);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pblAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion del sistema";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.tbcUsuarios.ResumeLayout(false);
            this.tpgCambios.ResumeLayout(false);
            this.tpgCambios.PerformLayout();
            this.tpgUsuarios.ResumeLayout(false);
            this.tpgUsuarios.PerformLayout();
            this.tpgConfiguraciones.ResumeLayout(false);
            this.gbxSMTP.ResumeLayout(false);
            this.gbxSMTP.PerformLayout();
            this.gpbBaseDatos.ResumeLayout(false);
            this.gpbBaseDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pblAcceso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkSocios;
        private System.Windows.Forms.CheckBox chkVenta;
        private System.Windows.Forms.CheckBox chkInventario;
        private System.Windows.Forms.CheckBox chkAcceso;
        private System.Windows.Forms.TabControl tbcUsuarios;
        private System.Windows.Forms.TabPage tpgCambios;
        private System.Windows.Forms.TabPage tpgUsuarios;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.TabPage tpgConfiguraciones;
        private System.Windows.Forms.GroupBox gpbBaseDatos;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.CheckBox chkRutina;
        private System.Windows.Forms.Button btnSMTP;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.Label lblSMTP;
        private System.Windows.Forms.Label lblSMTP_User;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblSMTP_Pwd;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.GroupBox gbxSMTP;
        private System.Windows.Forms.TextBox txtGymName;
        private System.Windows.Forms.Label lblGymName;
    }
}