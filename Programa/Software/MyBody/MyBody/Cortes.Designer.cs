namespace MyBody
{
    partial class Cortes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cortes));
            this.cbxProductos = new System.Windows.Forms.CheckedListBox();
            this.cmbCorte = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxTodo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbxProductos
            // 
            this.cbxProductos.FormattingEnabled = true;
            this.cbxProductos.Location = new System.Drawing.Point(12, 44);
            this.cbxProductos.Name = "cbxProductos";
            this.cbxProductos.Size = new System.Drawing.Size(231, 274);
            this.cbxProductos.TabIndex = 0;
            // 
            // cmbCorte
            // 
            this.cmbCorte.FormattingEnabled = true;
            this.cmbCorte.Location = new System.Drawing.Point(12, 11);
            this.cmbCorte.Name = "cmbCorte";
            this.cmbCorte.Size = new System.Drawing.Size(194, 21);
            this.cmbCorte.TabIndex = 1;
            this.cmbCorte.SelectedIndexChanged += new System.EventHandler(this.cmbCorte_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(209, 11);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(19, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "-";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(229, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(21, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(165, 324);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Listo";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxTodo
            // 
            this.cbxTodo.AutoSize = true;
            this.cbxTodo.Location = new System.Drawing.Point(12, 324);
            this.cbxTodo.Name = "cbxTodo";
            this.cbxTodo.Size = new System.Drawing.Size(51, 17);
            this.cbxTodo.TabIndex = 6;
            this.cbxTodo.Text = "Todo";
            this.cbxTodo.UseVisualStyleBackColor = true;
            this.cbxTodo.CheckedChanged += new System.EventHandler(this.cbxTodo_CheckedChanged);
            // 
            // Cortes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 364);
            this.Controls.Add(this.cbxTodo);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.cmbCorte);
            this.Controls.Add(this.cbxProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cortes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cortes";
            this.Load += new System.EventHandler(this.Cortes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbxProductos;
        private System.Windows.Forms.ComboBox cmbCorte;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbxTodo;
    }
}