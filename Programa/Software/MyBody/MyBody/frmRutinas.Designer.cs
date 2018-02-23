namespace MyBody
{
    partial class frmRutinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRutinas));
            this.tbcRutinas = new System.Windows.Forms.TabControl();
            this.tpgRutina = new System.Windows.Forms.TabPage();
            this.lstRutinas = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRenombrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tpgEjercicios = new System.Windows.Forms.TabPage();
            this.tblEjercicios = new System.Windows.Forms.TableLayoutPanel();
            this.lstEjercicios = new System.Windows.Forms.ListView();
            this.colIDEjercicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEjercicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSeries = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRepeticiones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxEjercicio = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRepeticiones = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.txtRepeticiones = new System.Windows.Forms.TextBox();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.pblFoto = new System.Windows.Forms.Panel();
            this.tblRutina = new System.Windows.Forms.TableLayoutPanel();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.tbcRutinas.SuspendLayout();
            this.tpgRutina.SuspendLayout();
            this.mnuOpciones.SuspendLayout();
            this.tpgEjercicios.SuspendLayout();
            this.tblEjercicios.SuspendLayout();
            this.gbxEjercicio.SuspendLayout();
            this.tblRutina.SuspendLayout();
            this.pnlControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRutinas
            // 
            this.tbcRutinas.Controls.Add(this.tpgRutina);
            this.tbcRutinas.Controls.Add(this.tpgEjercicios);
            this.tbcRutinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRutinas.Location = new System.Drawing.Point(3, 3);
            this.tbcRutinas.Name = "tbcRutinas";
            this.tbcRutinas.SelectedIndex = 0;
            this.tbcRutinas.Size = new System.Drawing.Size(545, 466);
            this.tbcRutinas.TabIndex = 1;
            // 
            // tpgRutina
            // 
            this.tpgRutina.Controls.Add(this.lstRutinas);
            this.tpgRutina.Location = new System.Drawing.Point(4, 22);
            this.tpgRutina.Name = "tpgRutina";
            this.tpgRutina.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRutina.Size = new System.Drawing.Size(537, 440);
            this.tpgRutina.TabIndex = 0;
            this.tpgRutina.Text = "Rutinas";
            this.tpgRutina.UseVisualStyleBackColor = true;
            // 
            // lstRutinas
            // 
            this.lstRutinas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNombre,
            this.colFecha});
            this.lstRutinas.ContextMenuStrip = this.mnuOpciones;
            this.lstRutinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRutinas.FullRowSelect = true;
            this.lstRutinas.GridLines = true;
            this.lstRutinas.Location = new System.Drawing.Point(3, 3);
            this.lstRutinas.MultiSelect = false;
            this.lstRutinas.Name = "lstRutinas";
            this.lstRutinas.Size = new System.Drawing.Size(531, 434);
            this.lstRutinas.TabIndex = 0;
            this.lstRutinas.UseCompatibleStateImageBehavior = false;
            this.lstRutinas.View = System.Windows.Forms.View.Details;
            this.lstRutinas.DoubleClick += new System.EventHandler(this.lstRutinas_DoubleClick);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 62;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 313;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 121;
            // 
            // mnuOpciones
            // 
            this.mnuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEliminar,
            this.mnuRenombrar});
            this.mnuOpciones.Name = "Menu";
            this.mnuOpciones.Size = new System.Drawing.Size(165, 48);
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.Size = new System.Drawing.Size(164, 22);
            this.mnuEliminar.Text = "Eliminar";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // mnuRenombrar
            // 
            this.mnuRenombrar.Name = "mnuRenombrar";
            this.mnuRenombrar.Size = new System.Drawing.Size(164, 22);
            this.mnuRenombrar.Text = "Cambiar nombre";
            this.mnuRenombrar.Click += new System.EventHandler(this.mnuRenombrar_Click);
            // 
            // tpgEjercicios
            // 
            this.tpgEjercicios.Controls.Add(this.tblEjercicios);
            this.tpgEjercicios.Location = new System.Drawing.Point(4, 22);
            this.tpgEjercicios.Name = "tpgEjercicios";
            this.tpgEjercicios.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEjercicios.Size = new System.Drawing.Size(537, 440);
            this.tpgEjercicios.TabIndex = 1;
            this.tpgEjercicios.Text = "Ejercicios";
            this.tpgEjercicios.UseVisualStyleBackColor = true;
            // 
            // tblEjercicios
            // 
            this.tblEjercicios.ColumnCount = 1;
            this.tblEjercicios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEjercicios.Controls.Add(this.lstEjercicios, 0, 0);
            this.tblEjercicios.Controls.Add(this.gbxEjercicio, 0, 1);
            this.tblEjercicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEjercicios.Location = new System.Drawing.Point(3, 3);
            this.tblEjercicios.Name = "tblEjercicios";
            this.tblEjercicios.RowCount = 2;
            this.tblEjercicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblEjercicios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tblEjercicios.Size = new System.Drawing.Size(531, 434);
            this.tblEjercicios.TabIndex = 2;
            // 
            // lstEjercicios
            // 
            this.lstEjercicios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDEjercicio,
            this.colDia,
            this.colEjercicio,
            this.colSeries,
            this.colRepeticiones});
            this.lstEjercicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEjercicios.FullRowSelect = true;
            this.lstEjercicios.GridLines = true;
            this.lstEjercicios.Location = new System.Drawing.Point(3, 3);
            this.lstEjercicios.MultiSelect = false;
            this.lstEjercicios.Name = "lstEjercicios";
            this.lstEjercicios.Size = new System.Drawing.Size(525, 322);
            this.lstEjercicios.TabIndex = 0;
            this.lstEjercicios.UseCompatibleStateImageBehavior = false;
            this.lstEjercicios.View = System.Windows.Forms.View.Details;
            this.lstEjercicios.SelectedIndexChanged += new System.EventHandler(this.lstEjercicios_SelectedIndexChanged);
            // 
            // colIDEjercicio
            // 
            this.colIDEjercicio.Text = "ID";
            this.colIDEjercicio.Width = 39;
            // 
            // colDia
            // 
            this.colDia.Text = "Dia";
            // 
            // colEjercicio
            // 
            this.colEjercicio.Text = "Ejercicio";
            this.colEjercicio.Width = 147;
            // 
            // colSeries
            // 
            this.colSeries.Text = "Serie";
            this.colSeries.Width = 88;
            // 
            // colRepeticiones
            // 
            this.colRepeticiones.Text = "Repeticiones";
            this.colRepeticiones.Width = 84;
            // 
            // gbxEjercicio
            // 
            this.gbxEjercicio.Controls.Add(this.btnBorrar);
            this.gbxEjercicio.Controls.Add(this.btnActualizar);
            this.gbxEjercicio.Controls.Add(this.btnAdd);
            this.gbxEjercicio.Controls.Add(this.lblRepeticiones);
            this.gbxEjercicio.Controls.Add(this.lblSeries);
            this.gbxEjercicio.Controls.Add(this.lblNombre);
            this.gbxEjercicio.Controls.Add(this.lblDia);
            this.gbxEjercicio.Controls.Add(this.txtRepeticiones);
            this.gbxEjercicio.Controls.Add(this.txtSeries);
            this.gbxEjercicio.Controls.Add(this.txtNombre);
            this.gbxEjercicio.Controls.Add(this.cmbDia);
            this.gbxEjercicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxEjercicio.Location = new System.Drawing.Point(3, 331);
            this.gbxEjercicio.Name = "gbxEjercicio";
            this.gbxEjercicio.Size = new System.Drawing.Size(525, 100);
            this.gbxEjercicio.TabIndex = 1;
            this.gbxEjercicio.TabStop = false;
            this.gbxEjercicio.Text = "Agregar, editar y borrar ejercicios";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(426, 71);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(108, 71);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 23);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRepeticiones
            // 
            this.lblRepeticiones.AutoSize = true;
            this.lblRepeticiones.Location = new System.Drawing.Point(423, 21);
            this.lblRepeticiones.Name = "lblRepeticiones";
            this.lblRepeticiones.Size = new System.Drawing.Size(69, 13);
            this.lblRepeticiones.TabIndex = 8;
            this.lblRepeticiones.Text = "Repeticiones";
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(329, 21);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(36, 13);
            this.lblSeries.TabIndex = 7;
            this.lblSeries.Text = "Series";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(95, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(6, 21);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(23, 13);
            this.lblDia.TabIndex = 5;
            this.lblDia.Text = "Dia";
            // 
            // txtRepeticiones
            // 
            this.txtRepeticiones.Location = new System.Drawing.Point(426, 40);
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.Size = new System.Drawing.Size(93, 20);
            this.txtRepeticiones.TabIndex = 3;
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(332, 40);
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(88, 20);
            this.txtSeries.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(6, 40);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(86, 21);
            this.cmbDia.TabIndex = 0;
            // 
            // pblFoto
            // 
            this.pblFoto.BackgroundImage = global::MyBody.Properties.Resources.GymMaster;
            this.pblFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pblFoto.Location = new System.Drawing.Point(0, 0);
            this.pblFoto.Name = "pblFoto";
            this.pblFoto.Size = new System.Drawing.Size(240, 508);
            this.pblFoto.TabIndex = 0;
            // 
            // tblRutina
            // 
            this.tblRutina.ColumnCount = 1;
            this.tblRutina.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRutina.Controls.Add(this.pnlControles, 0, 1);
            this.tblRutina.Controls.Add(this.tbcRutinas, 0, 0);
            this.tblRutina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRutina.Location = new System.Drawing.Point(240, 0);
            this.tblRutina.Name = "tblRutina";
            this.tblRutina.RowCount = 2;
            this.tblRutina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRutina.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblRutina.Size = new System.Drawing.Size(551, 508);
            this.tblRutina.TabIndex = 2;
            // 
            // pnlControles
            // 
            this.pnlControles.Controls.Add(this.btnCerrar);
            this.pnlControles.Controls.Add(this.btnNueva);
            this.pnlControles.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControles.Location = new System.Drawing.Point(345, 475);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(203, 30);
            this.pnlControles.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(94, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(3, 4);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(88, 23);
            this.btnNueva.TabIndex = 0;
            this.btnNueva.Text = "Nueva Rutina";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // frmRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(791, 508);
            this.Controls.Add(this.tblRutina);
            this.Controls.Add(this.pblFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRutinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutinas";
            this.Load += new System.EventHandler(this.frmRutinas_Load);
            this.tbcRutinas.ResumeLayout(false);
            this.tpgRutina.ResumeLayout(false);
            this.mnuOpciones.ResumeLayout(false);
            this.tpgEjercicios.ResumeLayout(false);
            this.tblEjercicios.ResumeLayout(false);
            this.gbxEjercicio.ResumeLayout(false);
            this.gbxEjercicio.PerformLayout();
            this.tblRutina.ResumeLayout(false);
            this.pnlControles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pblFoto;
        private System.Windows.Forms.TabControl tbcRutinas;
        private System.Windows.Forms.TabPage tpgRutina;
        private System.Windows.Forms.TableLayoutPanel tblRutina;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.ListView lstRutinas;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.TabPage tpgEjercicios;
        private System.Windows.Forms.ContextMenuStrip mnuOpciones;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripMenuItem mnuRenombrar;
        private System.Windows.Forms.TableLayoutPanel tblEjercicios;
        private System.Windows.Forms.ListView lstEjercicios;
        private System.Windows.Forms.ColumnHeader colIDEjercicio;
        private System.Windows.Forms.ColumnHeader colDia;
        private System.Windows.Forms.ColumnHeader colEjercicio;
        private System.Windows.Forms.ColumnHeader colSeries;
        private System.Windows.Forms.ColumnHeader colRepeticiones;
        private System.Windows.Forms.GroupBox gbxEjercicio;
        private System.Windows.Forms.Label lblRepeticiones;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtRepeticiones;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
    }
}