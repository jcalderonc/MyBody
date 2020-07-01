using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management; 

namespace MyBody
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int Intentos = 0;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                Usuarios ObjUsuarios = new Usuarios();
                ObjUsuarios.username = txtUsuario.Text;
                ObjUsuarios.password = txtPassword.Text;

                if (ObjUsuarios.Login())
                {
                    this.Hide();
                    if (chbKiosco.Checked)
                    {
                        frmRegistro Registro = new frmRegistro();
                        Registro.ShowDialog();
                        Application.Exit();
                    }
                    else
                    {
                        frmMenu Menu = new frmMenu();
                        Menu.Usuario = ObjUsuarios;
                        Menu.ShowDialog();
                        Application.Exit();
                        
                    }
                    
                }
                else
                {
                    Intentos++;
                    if (Intentos >= 3)
                    {
                        MessageBox.Show("Demaciados intentos.");
                        btnIniciar.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Escriba el nombre de usuario y contraseña.");
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmUsuarios Usuarios = new frmUsuarios();
            Usuarios.ConfigureDBOnly = true;
            Usuarios.ShowDialog();
        }


        private void ComprobarImagen()
        {
            //Colocar personalizacion.
            try
            {
                this.BackgroundImage = Image.FromFile(MyBody.Default.SMALL_LOGO);
            }
            catch
            {
                MessageBox.Show("Puede escoger una imagen de su compuadora para utilizar como logotipo del programa, usted puede cambiar esto en cualquier momento. Seleccione una imagen.");
                btnPicture_Click(null, null);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

            ComprobarImagen();    
            //Verificar la clave de activacion.
            //Al colocar la serie del propietario eliminar del alert
            bool Validar = true;
            if (Validar)
            {
                string Serie=GetMBSN();
                if (Serie.Contains("058321098769912211310221811527720761722070047084381144144317365") || Serie.Contains("303066330424667487084597432330842009973080819573036510134799525"))
                {
                    return;
                }
                else
                {
                    MessageBox.Show(@"La reproduccion de este software constituye un delito.

El derecho de autor se basa en la idea de un derecho personal del autor, fundado en una forma de identidad entre el autor y su creación. El derecho moral está constituido como emanación de la persona del autor: reconoce que la obra es expresión de la persona del autor y así se le protege.

La protección del copyright se limita estrictamente a la obra, sin considerar atributos morales del autor en relación con su obra, excepto la paternidad; no lo considera como un autor propiamente tal, pero tiene derechos que determinan las modalidades de utilización de una obra.

ID:"+Serie, "Copia no autorizada", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    System.Windows.Forms.Clipboard.SetText(Serie);


                    Application.Exit();
                }
            }
        }


        public static string GetMBSN()
        {
            ManagementScope Scope;
            Scope = new ManagementScope("\\\\.\\ROOT\\cimv2");
            Scope.Connect();
            ObjectQuery Query = new ObjectQuery("SELECT OfflineInstallationId FROM SoftwareLicensingProduct");
            ManagementObjectSearcher Searcher = new ManagementObjectSearcher(Scope, Query);

            foreach (ManagementObject WmiObject in Searcher.Get())
            {
                if (WmiObject["OfflineInstallationId"] != null)
                    return WmiObject["OfflineInstallationId"].ToString();
            }
            return ""; //Making the compiler happy.
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "Imagenes (*.bmp)|*.bmp";
            if (File.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(File.FileName);
                MyBody.Default.SMALL_LOGO = File.FileName;
                MyBody.Default.Save();
            }
        } 

    }
}
