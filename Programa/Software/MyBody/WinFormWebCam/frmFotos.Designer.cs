namespace WinFormWebCam
{
    //Design by Pongsakorn Poosankam
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.bntStart = new System.Windows.Forms.Button();
            this.bntStop = new System.Windows.Forms.Button();
            this.bntContinue = new System.Windows.Forms.Button();
            this.bntCapture = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.tblCamaras = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.pnlCamara = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            this.tblCamaras.SuspendLayout();
            this.pnlFoto.SuspendLayout();
            this.pnlCamara.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgVideo
            // 
            this.imgVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgVideo.Location = new System.Drawing.Point(3, 3);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(362, 318);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // imgCapture
            // 
            this.imgCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCapture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgCapture.Location = new System.Drawing.Point(371, 3);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(362, 318);
            this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCapture.TabIndex = 1;
            this.imgCapture.TabStop = false;
            // 
            // bntStart
            // 
            this.bntStart.Location = new System.Drawing.Point(9, 5);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(58, 23);
            this.bntStart.TabIndex = 2;
            this.bntStart.Text = "Iniciar";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // bntStop
            // 
            this.bntStop.Location = new System.Drawing.Point(73, 5);
            this.bntStop.Name = "bntStop";
            this.bntStop.Size = new System.Drawing.Size(67, 23);
            this.bntStop.TabIndex = 3;
            this.bntStop.Text = "Detener";
            this.bntStop.UseVisualStyleBackColor = true;
            this.bntStop.Click += new System.EventHandler(this.bntStop_Click);
            // 
            // bntContinue
            // 
            this.bntContinue.Location = new System.Drawing.Point(148, 5);
            this.bntContinue.Name = "bntContinue";
            this.bntContinue.Size = new System.Drawing.Size(61, 23);
            this.bntContinue.TabIndex = 4;
            this.bntContinue.Text = "Continuar";
            this.bntContinue.UseVisualStyleBackColor = true;
            this.bntContinue.Click += new System.EventHandler(this.bntContinue_Click);
            // 
            // bntCapture
            // 
            this.bntCapture.Location = new System.Drawing.Point(186, 5);
            this.bntCapture.Name = "bntCapture";
            this.bntCapture.Size = new System.Drawing.Size(85, 23);
            this.bntCapture.TabIndex = 5;
            this.bntCapture.Text = "Capturar";
            this.bntCapture.UseVisualStyleBackColor = true;
            this.bntCapture.Click += new System.EventHandler(this.bntCapture_Click);
            // 
            // bntSave
            // 
            this.bntSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bntSave.Location = new System.Drawing.Point(277, 5);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(79, 23);
            this.bntSave.TabIndex = 6;
            this.bntSave.Text = "Guardar";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // tblCamaras
            // 
            this.tblCamaras.ColumnCount = 2;
            this.tblCamaras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCamaras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCamaras.Controls.Add(this.pnlFoto, 1, 1);
            this.tblCamaras.Controls.Add(this.imgVideo, 0, 0);
            this.tblCamaras.Controls.Add(this.pnlCamara, 0, 1);
            this.tblCamaras.Controls.Add(this.imgCapture, 1, 0);
            this.tblCamaras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCamaras.Location = new System.Drawing.Point(0, 0);
            this.tblCamaras.Name = "tblCamaras";
            this.tblCamaras.RowCount = 2;
            this.tblCamaras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCamaras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblCamaras.Size = new System.Drawing.Size(736, 362);
            this.tblCamaras.TabIndex = 8;
            // 
            // pnlFoto
            // 
            this.pnlFoto.Controls.Add(this.bntSave);
            this.pnlFoto.Controls.Add(this.bntCapture);
            this.pnlFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFoto.Location = new System.Drawing.Point(371, 327);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(362, 32);
            this.pnlFoto.TabIndex = 10;
            // 
            // pnlCamara
            // 
            this.pnlCamara.Controls.Add(this.bntStart);
            this.pnlCamara.Controls.Add(this.bntStop);
            this.pnlCamara.Controls.Add(this.bntContinue);
            this.pnlCamara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCamara.Location = new System.Drawing.Point(3, 327);
            this.pnlCamara.Name = "pnlCamara";
            this.pnlCamara.Size = new System.Drawing.Size(362, 32);
            this.pnlCamara.TabIndex = 9;
            // 
            // mainWinForm
            // 
            this.AcceptButton = this.bntSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(736, 362);
            this.Controls.Add(this.tblCamaras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotografiar al socio.";
            this.Load += new System.EventHandler(this.mainWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            this.tblCamaras.ResumeLayout(false);
            this.pnlFoto.ResumeLayout(false);
            this.pnlCamara.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Button bntStop;
        private System.Windows.Forms.Button bntContinue;
        private System.Windows.Forms.Button bntCapture;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.TableLayoutPanel tblCamaras;
        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.Panel pnlCamara;
    }
}

