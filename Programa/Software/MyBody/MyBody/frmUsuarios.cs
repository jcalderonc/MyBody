using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBody
{
    public partial class frmUsuarios : Form
    {
        private Usuarios Usuario=new Usuarios();
        
        public frmUsuarios()
        {
            InitializeComponent();
        }
        public bool ConfigureDBOnly { get; set; }

        void Lista()
        {
            if (Usuario.Lista())
            {
                lstUsuarios.DataSource = Usuario.Buffer;
                lstUsuarios.DisplayMember = "nombre_estatus";
                lstUsuarios.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("No existe ningun usuario del sistema.");
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            txtUbicacion.Text = MyBody.Default.SQLLiteFile;
            txtSMTP.Text = MyBody.Default.SMTP_SERVER;
            txtCorreo.Text = MyBody.Default.SMTP_MAIL;
            txtPass.Text = MyBody.Default.SMTP_PWD;
            txtPort.Text = MyBody.Default.SMTP_PORT.ToString();
            txtGymName.Text = MyBody.Default.GYMNAME;
            if (ConfigureDBOnly)
            {
                ((Control)tpgCambios).Enabled = false;
                ((Control)tpgUsuarios).Enabled = false;
                btnNuevo.Enabled = false;

                tbcUsuarios.SelectedIndex = 2;
            }
            else
            {                
                tbcUsuarios.SelectedIndex = 1;
            }
        }
        public void SetControls()
        {
            txtID.Text = Usuario.ID.ToString();
            txtUsuario.Text = Usuario.username;
            txtContraseña.Text = Usuario.password;
            txtConfirmar.Text = Usuario.password;
            txtNombre.Text = Usuario.nombre;
            chkActivo.Checked = Usuario.activo;
            chkSocios.Checked = Usuario.socios;
            chkVenta.Checked = Usuario.ventas;
            chkInventario.Checked = Usuario.inventarios;
            chkAcceso.Checked = Usuario.usuarios;
            chkRutina.Checked = Usuario.rutinas;
            
        }
        public void GetControls()
        {
            Usuario.username=txtUsuario.Text;
            Usuario.password=txtContraseña.Text;
            Usuario.password=txtConfirmar.Text;
            Usuario.nombre=txtNombre.Text;
            
            Usuario.socios=chkSocios.Checked;
            Usuario.ventas=chkVenta.Checked;
            Usuario.inventarios=chkInventario.Checked;
            Usuario.usuarios=chkAcceso.Checked;
            Usuario.rutinas = chkRutina.Checked;
        }

        

        private void btnActivar_Click(object sender, EventArgs e)
        {
            Activacion(true);
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            Activacion(false);
        }
        
        void Activacion(bool _Active)
        {
            if (lstUsuarios.SelectedIndex != (-1))
            {
                if (Usuario.Activar(int.Parse(lstUsuarios.SelectedValue.ToString()), _Active))
                {
                    MessageBox.Show("Listo.");

                    if (Usuario.Abrir(int.Parse(lstUsuarios.SelectedValue.ToString())))
                    {
                        SetControls();
                        tbcUsuarios.SelectedIndex = 0;
                        ((Control)tpgCambios).Enabled = Usuario.activo;
                    }                                     
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el usuario.");
            }
        }


        private void lstUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex != (-1))
            {
                if (Usuario.Abrir(int.Parse(lstUsuarios.SelectedValue.ToString())))
                {
                    SetControls();
                    tbcUsuarios.SelectedIndex = 0;
                    ((Control)tpgCambios).Enabled = Usuario.activo;
                }
            }
            else
            {
                MessageBox.Show("Seleccione el usuario.");
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Usuario = new Usuarios();
            Usuario.ID = Usuario.LlavePrimaria();
            Usuario.activo = true;
            Usuario.fecha = DateTime.Now;
            SetControls();
            tbcUsuarios.SelectedIndex = 0;
            ((Control)tpgCambios).Enabled = Usuario.activo;
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length>0 &&
                txtUsuario.Text.Length > 0 &&
                txtContraseña.Text.Length > 0 &&
                (txtContraseña.Text == txtConfirmar.Text) &&
                txtNombre.Text.Length > 0)
            {
                GetControls();
                if (Usuario.Guardar())
                {
                    MessageBox.Show("Listo.");
                    tbcUsuarios.SelectedIndex = 1;                    
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación.");
                }
            }
            else
            {
                MessageBox.Show("El formulario está incompleto, su contraseña debe coincidir. Para generar un nuevo usuario haga clic en el botón nuevo usuario.");
            }
        }

        private void tbcUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcUsuarios.SelectedIndex == 1)
            {
                Lista();
            }
        }

        private void btnSMTP_Click(object sender, EventArgs e)
        {
            MyBody.Default.SMTP_SERVER = txtSMTP.Text;
            MyBody.Default.SMTP_PWD = txtPass.Text;
            MyBody.Default.SMTP_MAIL = txtCorreo.Text;
            MyBody.Default.GYMNAME = txtGymName.Text;
            int Valor = 0;
            int.TryParse(txtPort.Text, out Valor);
            MyBody.Default.SMTP_PORT = Valor;



            MyBody.Default.Save();
            MessageBox.Show("Listo");
        }
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "SQLLite DB|*.sqlite";

            if (File.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtUbicacion.Text = File.FileName;
                MyBody.Default.SQLLiteFile = File.FileName;
                MyBody.Default.Save();

                BaseDatos DB = new BaseDatos();
                if (DB.Conectar())
                {
                    MessageBox.Show("Base de datos conectada.");
                }
                else
                {
                    MyBody.Default.SQLLiteFile = string.Empty;
                    MyBody.Default.Save();
                    MessageBox.Show("Base de datos invalida.");
                }
            }
        }



     
 

    }
}
