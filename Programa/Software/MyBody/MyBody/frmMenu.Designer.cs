namespace MyBody
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.btnPicture = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.btnRutina = new System.Windows.Forms.Button();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.tblInformacion = new System.Windows.Forms.TableLayoutPanel();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.tblIconos = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.pnlEncabezado.SuspendLayout();
            this.pnlFondo.SuspendLayout();
            this.tblInformacion.SuspendLayout();
            this.tblIconos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.Black;
            this.pnlEncabezado.BackgroundImage = global::MyBody.Properties.Resources.Encabezado;
            this.pnlEncabezado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEncabezado.Controls.Add(this.btnPicture);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(796, 139);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPicture.BackgroundImage")));
            this.btnPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPicture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Location = new System.Drawing.Point(7, 110);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(20, 20);
            this.btnPicture.TabIndex = 0;
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(3, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(186, 45);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "NOMBRE DEL USUARIO";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Red;
            this.lblHora.Location = new System.Drawing.Point(3, 82);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(75, 20);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "00:00:00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(3, 102);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(262, 37);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "NUMERO DE DIA MES Y AÑO 2013";
            // 
            // btnSocios
            // 
            this.btnSocios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSocios.BackgroundImage = global::MyBody.Properties.Resources.Socios;
            this.btnSocios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSocios.Location = new System.Drawing.Point(270, 3);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(255, 163);
            this.btnSocios.TabIndex = 1;
            this.btnSocios.Text = "Socios";
            this.btnSocios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSocios.UseVisualStyleBackColor = true;
            this.btnSocios.Click += new System.EventHandler(this.btnSocios_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVentas.BackgroundImage = global::MyBody.Properties.Resources.Ventas;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.Location = new System.Drawing.Point(5, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(255, 163);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInventario.BackgroundImage = global::MyBody.Properties.Resources.Inventario;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventario.Location = new System.Drawing.Point(5, 172);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(255, 164);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Productos";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuarios.BackgroundImage = global::MyBody.Properties.Resources.Usuarios;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.Location = new System.Drawing.Point(535, 3);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(255, 163);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Acceso";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 60000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // btnRutina
            // 
            this.btnRutina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRutina.BackgroundImage = global::MyBody.Properties.Resources.Rutina;
            this.btnRutina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRutina.Location = new System.Drawing.Point(535, 172);
            this.btnRutina.Name = "btnRutina";
            this.btnRutina.Size = new System.Drawing.Size(255, 164);
            this.btnRutina.TabIndex = 8;
            this.btnRutina.Text = "Rutinas";
            this.btnRutina.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRutina.UseVisualStyleBackColor = true;
            this.btnRutina.Click += new System.EventHandler(this.btnRutina_Click);
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.Black;
            this.pnlFondo.Controls.Add(this.tblInformacion);
            this.pnlFondo.Controls.Add(this.pnlEncabezado);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(796, 139);
            this.pnlFondo.TabIndex = 10;
            // 
            // tblInformacion
            // 
            this.tblInformacion.ColumnCount = 1;
            this.tblInformacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInformacion.Controls.Add(this.lblUsuario, 0, 1);
            this.tblInformacion.Controls.Add(this.lblHora, 0, 2);
            this.tblInformacion.Controls.Add(this.btnAcerca, 0, 0);
            this.tblInformacion.Controls.Add(this.lblFecha, 0, 3);
            this.tblInformacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.tblInformacion.Location = new System.Drawing.Point(389, 0);
            this.tblInformacion.Name = "tblInformacion";
            this.tblInformacion.RowCount = 4;
            this.tblInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblInformacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInformacion.Size = new System.Drawing.Size(407, 139);
            this.tblInformacion.TabIndex = 3;
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackgroundImage = global::MyBody.Properties.Resources.Help;
            this.btnAcerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcerca.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.Location = new System.Drawing.Point(368, 3);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(36, 31);
            this.btnAcerca.TabIndex = 3;
            this.btnAcerca.UseVisualStyleBackColor = true;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // tblIconos
            // 
            this.tblIconos.BackColor = System.Drawing.Color.Transparent;
            this.tblIconos.ColumnCount = 3;
            this.tblIconos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblIconos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblIconos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblIconos.Controls.Add(this.btnRegistro, 0, 1);
            this.tblIconos.Controls.Add(this.btnUsuarios, 2, 0);
            this.tblIconos.Controls.Add(this.btnSocios, 1, 0);
            this.tblIconos.Controls.Add(this.btnRutina, 1, 1);
            this.tblIconos.Controls.Add(this.btnVentas, 0, 0);
            this.tblIconos.Controls.Add(this.btnInventario, 0, 1);
            this.tblIconos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblIconos.ForeColor = System.Drawing.Color.White;
            this.tblIconos.Location = new System.Drawing.Point(0, 139);
            this.tblIconos.Name = "tblIconos";
            this.tblIconos.RowCount = 2;
            this.tblIconos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIconos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIconos.Size = new System.Drawing.Size(796, 339);
            this.tblIconos.TabIndex = 11;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistro.BackgroundImage = global::MyBody.Properties.Resources.FReader;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistro.ForeColor = System.Drawing.Color.Black;
            this.btnRegistro.Location = new System.Drawing.Point(270, 172);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(255, 164);
            this.btnRegistro.TabIndex = 9;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.Black;
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstLog.ForeColor = System.Drawing.Color.White;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(0, 478);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(796, 95);
            this.lstLog.TabIndex = 9;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MyBody.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(796, 573);
            this.Controls.Add(this.tblIconos);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.lstLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu del sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlFondo.ResumeLayout(false);
            this.tblInformacion.ResumeLayout(false);
            this.tblInformacion.PerformLayout();
            this.tblIconos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Button btnRutina;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.TableLayoutPanel tblIconos;
        private System.Windows.Forms.TableLayoutPanel tblInformacion;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnPicture;
    }
}