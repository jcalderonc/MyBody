namespace MyBody
{
    partial class Ejercicio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblRepeticiones = new System.Windows.Forms.Label();
            this.cntSeries = new System.Windows.Forms.SplitContainer();
            this.pnlTitulo.SuspendLayout();
            this.cntSeries.Panel1.SuspendLayout();
            this.cntSeries.Panel2.SuspendLayout();
            this.cntSeries.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(717, 51);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(41)))), ((int)(((byte)(19)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(717, 51);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ejercicio";
            // 
            // lblSeries
            // 
            this.lblSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.lblSeries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.ForeColor = System.Drawing.Color.White;
            this.lblSeries.Location = new System.Drawing.Point(0, 0);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(239, 66);
            this.lblSeries.TabIndex = 2;
            this.lblSeries.Text = "Series";
            // 
            // lblRepeticiones
            // 
            this.lblRepeticiones.BackColor = System.Drawing.Color.Transparent;
            this.lblRepeticiones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRepeticiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRepeticiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeticiones.ForeColor = System.Drawing.Color.Black;
            this.lblRepeticiones.Location = new System.Drawing.Point(0, 0);
            this.lblRepeticiones.Name = "lblRepeticiones";
            this.lblRepeticiones.Size = new System.Drawing.Size(474, 66);
            this.lblRepeticiones.TabIndex = 3;
            this.lblRepeticiones.Text = "Repeticiones";
            // 
            // cntSeries
            // 
            this.cntSeries.BackColor = System.Drawing.Color.White;
            this.cntSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntSeries.Location = new System.Drawing.Point(0, 51);
            this.cntSeries.Name = "cntSeries";
            // 
            // cntSeries.Panel1
            // 
            this.cntSeries.Panel1.Controls.Add(this.lblSeries);
            // 
            // cntSeries.Panel2
            // 
            this.cntSeries.Panel2.Controls.Add(this.lblRepeticiones);
            this.cntSeries.Size = new System.Drawing.Size(717, 66);
            this.cntSeries.SplitterDistance = 239;
            this.cntSeries.TabIndex = 4;
            // 
            // Ejercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cntSeries);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "Ejercicio";
            this.Size = new System.Drawing.Size(717, 117);
            this.pnlTitulo.ResumeLayout(false);
            this.cntSeries.Panel1.ResumeLayout(false);
            this.cntSeries.Panel2.ResumeLayout(false);
            this.cntSeries.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.SplitContainer cntSeries;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lblSeries;
        public System.Windows.Forms.Label lblRepeticiones;
    }
}
