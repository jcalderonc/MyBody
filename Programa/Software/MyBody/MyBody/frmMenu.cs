using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBody
{
    public partial class frmMenu : Form
    {
        public Usuarios Usuario { get; set; }

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            frmSocios Socios = new frmSocios();
            Socios.Usuario = Usuario;
            Socios.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas Venta = new frmVentas();
            Venta.Usuario = Usuario;
            Venta.Show();
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventario Inventario = new frmInventario();
            Inventario.Usuario = Usuario;
            Inventario.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios Usuarios = new frmUsuarios();
            Usuarios.ShowDialog();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        public void ComprobarImagen()
        {
            //Colocar personalizacion.
            try
            {
                this.pnlEncabezado.BackgroundImage = Image.FromFile(MyBody.Default.LARGE_LOGO);
                this.pnlEncabezado.Refresh();
            }
            catch
            {
                MessageBox.Show("Puede personalizar el menu del programa, seleccione un archivo.");
                btnPicture_Click(null, null);

            }
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {

            ComprobarImagen();

            lblFecha.Text = DateTime.Now.ToLongDateString().ToUpper();
            lblHora.Text = DateTime.Now.ToString("hh:mm tt");
            lblUsuario.Text = Usuario.nombre.ToUpper();


            btnSocios.Enabled = Usuario.socios;
            btnVentas.Enabled = Usuario.ventas;
            btnInventario.Enabled = Usuario.inventarios;
            btnUsuarios.Enabled = Usuario.usuarios;
            btnRutina.Enabled = Usuario.rutinas;

            Temporizador.Start();

           
        }

        Suscripciones Suscripcion = new Suscripciones();
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString().ToUpper();
            lblHora.Text = DateTime.Now.ToString("hh:mm tt");

            Socios Socio = new Socios();
            Socio.Filtro = string.Empty;
            if (Socio.Lista(false))
            {
                DataTable RegistrosSocios = Socio.Buffer.Copy();
                for (int i = 0; i < RegistrosSocios.Rows.Count; i++)
                {
                    int IDSocio = int.Parse(RegistrosSocios.Rows[i]["ID"].ToString());
                    if (IDSocio != 0)
                    {
                        int Dias = int.Parse(RegistrosSocios.Rows[i]["dias"].ToString());

                        int IDSuscripcion = int.Parse(RegistrosSocios.Rows[i]["ID_suscripciones"].ToString());
                        string Nombre = RegistrosSocios.Rows[i]["nombre"].ToString();
                        string Apellido = RegistrosSocios.Rows[i]["apellido"].ToString();
                        bool Activo = bool.Parse(RegistrosSocios.Rows[i]["activo"].ToString());
                        DateTime FechaLimite = DateTime.Parse(RegistrosSocios.Rows[i]["limitepago"].ToString());
                        DateTime InicioPeriodo;
                        //Determinacion de la fecha inicial, antes de la modificación del limite de pago
                        if (Dias == 30)
                        {
                            InicioPeriodo = FechaLimite.AddMonths(-1);
                        }
                        else
                        {
                            InicioPeriodo = FechaLimite.AddDays(Dias * (-1));
                        }



                        if (FechaLimite <= DateTime.Now)
                        {
                            //Modificación de la nueva fecha limite de pago y en consecuencia la modificacion del inicio del periodo.
                            if (Dias == 30)
                            {
                                FechaLimite = FechaLimite.AddMonths(1);
                                InicioPeriodo = FechaLimite.AddMonths(-1);
                            }
                            else
                            {
                                FechaLimite = FechaLimite.AddDays(Dias);
                                InicioPeriodo = FechaLimite.AddDays(Dias * (-1));
                            }


                            if (Socio.ActualizarFechaLimite(IDSocio, FechaLimite))
                            {
                                Escribir("Se cambio la fecha limite de pago para el socio : " + Nombre.ToUpper() + " " + Apellido.ToUpper() + ", Nueva fecha limite :  " + FechaLimite.AddDays(Dias));
                            }
                        }



                        if (!Socio.SuscripcionesCobradas(InicioPeriodo, FechaLimite, IDSuscripcion, IDSocio))
                        {

                            //Insertar cobro
                            if (Dias == 1)
                            {
                                //Se cobran manualmente las visitas.
                            }
                            else
                            {
                                if (Activo)
                                {
                                    if (Socio.CobrarSuscripcion(InicioPeriodo, IDSocio, 0))
                                    {
                                        Escribir("Se genero el cobro de servicios para el socio: " + Nombre.ToUpper() + " " + Apellido.ToUpper());
                                    }
                                }
                            }
                        }
                    }
                }//FOR
            }
        }

        private void Escribir(string Texto)
        {
            lstLog.Items.Add(DateTime.Now.ToShortTimeString() + ":" + Texto);
            //Ir hasta abajo.
            int visibleItems = lstLog.ClientSize.Height / lstLog.ItemHeight;
            lstLog.TopIndex = Math.Max(lstLog.Items.Count - visibleItems + 1, 0);
        }

        private void btnRutina_Click(object sender, EventArgs e)
        {
            frmRutinas Rutina = new frmRutinas();
            Rutina.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro Registro = new frmRegistro();
            try
            {
                Registro.Show();
            }
            catch
            {
                MessageBox.Show("Asegurece de instalar el software de controlador del lector de huellas digitales", "Driver",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAbout Acerca = new frmAbout();
            Acerca.ShowDialog();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "Imagenes (*.bmp)|*.bmp";
            if (File.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pnlEncabezado.BackgroundImage = Image.FromFile(File.FileName);
                MyBody.Default.LARGE_LOGO = File.FileName;
                MyBody.Default.Save();
            }
        }
    }
}
