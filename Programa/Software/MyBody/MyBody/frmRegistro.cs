using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyBody
{
    public partial class frmRegistro : Form, DPFP.Capture.EventHandler
    {
        private UI_Support.AppData Data;
        private UI_Support.EnrollmentForm Enroller;
        private UI_Support.VerificationForm Verifier;

        private DPFP.Capture.Capture Capturer;
        protected void IniciarLectura()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    Escribir("Use el lector de huella digital para reconocer su huella.");
                }
                catch
                {
                    Escribir("No se ha logrado iniciar la lectura!");
                }
            }
        }
        protected virtual void PrepararLector()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    Escribir("No se ha logrado iniciar la operación de lectura!");
            }
            catch
            {
                MessageBox.Show("No se ha logrado iniciar la operación de lectura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected void DetenerLectura()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    Escribir("No se puede detener la lectura!");
                }
            }
        }

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            Escribir("La huella fue capturada.");
            DPFP.Verification.Verification Verificator = new DPFP.Verification.Verification();

            DPFP.FeatureSet Features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            DPFP.Verification.Verification.Result Result = new DPFP.Verification.Verification.Result();


            Socio = new Socios();
            if (Socio.Huellas())
            {
                DataTable Huellas = Socio.Buffer.Copy();
                //recorrer todas las huellas
                for (int i = 0; i < Huellas.Rows.Count; i++)
                {
                    int ID = int.Parse(Huellas.Rows[i]["ID_socios"].ToString());
                    string KeyName = Huellas.Rows[i]["huella"].ToString();
                    string FileName = Application.StartupPath + "/Huellas/" + KeyName;


                    //convertir de string a template
                    try
                    {
                        FileStream fs = File.OpenRead(FileName);
                        DPFP.Template Template = new DPFP.Template(fs);
                        fs.Close();
                        //verificar
                        Verificator.Verify(Features, Template, ref Result);
                        if (Result.Verified)
                        {
                            Escribir("La huella del socio fue encontrada.");
                            MostrarDatos(ID);
                            break;
                        }
                        else
                        {
                            Escribir("La huella no fue encontrada.");
                        }
                    }
                    catch
                    {
                        Escribir("Error al leer la huella digital grabada.");
                    }
                }
            }
        }
        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();	// Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);			// TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }



        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            Escribir("El dedo fue removido del lector.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            Escribir("El lector fue tocado.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            Escribir("El lector esta conectado.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            Escribir("El lector esta desconectado.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                Escribir("La calidad de la huella es buena.");
            else
                Escribir("La calidad de la huella es mala.");
        }
        #endregion




        public frmRegistro()
        {
            

            InitializeComponent();
            Data = new UI_Support.AppData();// Create the application data object
            Data.OnChange += delegate { ExchangeData(false); };// Track data changes to keep the form synchronized
            Enroller = new UI_Support.EnrollmentForm(Data);
            Verifier = new UI_Support.VerificationForm(Data);
            ExchangeData(false);

        }

        // Simple dialog data exchange (DDX) implementation.
        private void ExchangeData(bool read)
        {
            if (read)
            {	// read values from the form's controls to the data object
                Data.EnrolledFingersMask = 0;
                Data.MaxEnrollFingerCount = 1;
                Data.IsEventHandlerSucceeds = true;
                Data.Update();
            }
            else
            {	// read valuse from the data object to the form's controls
                VerifyButton.Enabled = Data.EnrolledFingersMask > 0;
            }
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {

            DetenerLectura();
            ExchangeData(true);// transfer values from the main form to the data object
        Leer:
            if (Enroller.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Verificar si se capturo el dedo correcto
                if (Data.Templates[1] == null)
                {
                    MessageBox.Show("Debe seleccionar el dedo indice de la mano derecha.", "Huella", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto Leer;
                }
                else
                {
                    try
                    {
                        //Guardar el template en un directorio.
                        string KeyName = Socio.ID.ToString().PadLeft(6, '0') + ".fpt";
                        string FileName = Application.StartupPath + "/Huellas/" + KeyName;
                        FileInfo FI = new FileInfo(FileName);
                        if (FI.Exists)
                        {
                            Escribir("La huella digital ya existe.");
                            FI.Delete();
                            Escribir("La huella existente fue borrada.");
                        }

                        FileStream FpStreaming = File.Open(FileName, FileMode.Create, FileAccess.Write);
                        Data.Templates[1].Serialize(FpStreaming);
                        FpStreaming.Close();

                        Escribir("La huella digital se ha guardado en :" + FileName);

                        if (Socio.GuardarHuella(KeyName))
                        {
                            Escribir("Se guardo la huella del socio : " + Socio.nombre.ToUpper() + " " + Socio.apellido.ToUpper());
                        }
                    }
                    catch(Exception ex)
                    {
                        Escribir("Ha fallado la grabación de la huella, Causa : " + ex.Message);
                    }
                    
                }
            }
            IniciarLectura();

        }

        private void VerifyButton_Click(object sender, EventArgs e)
        {
            DetenerLectura();
            ExchangeData(true);// transfer values from the main form to the data object
            Verifier.ShowDialog();// process verification
            IniciarLectura();
        }
        delegate void Function();	// a simple delegate for marshalling calls from event handlers to the GUI thread
        private void Escribir(string Texto)
        {
            this.Invoke(new Function(delegate()
            {
                lstLog.Items.Add(DateTime.Now.ToShortTimeString() + ":" + Texto);
                //Ir hasta abajo.
                int visibleItems = lstLog.ClientSize.Height / lstLog.ItemHeight;
                lstLog.TopIndex = Math.Max(lstLog.Items.Count - visibleItems + 1, 0);

            }));
        }
        public void Dias()
        {
            Rutinas Rutina = new Rutinas();
            cmbDia.DataSource = Rutina.ListaDias().Copy();
            cmbDia.DisplayMember = "nombre";
            cmbDia.ValueMember = "id";

            cmbDia.SelectedValue = (int)DateTime.Now.DayOfWeek;

        }



        private void frmRegistro_Load(object sender, EventArgs e)
        {
            Dias();
            PrepararLector();
            IniciarLectura();
            Temporizador.Start();


            //Colocar personalizacion.
            try
            {
                this.pnlEncabezado.BackgroundImage = Image.FromFile(MyBody.Default.SMALL_LOGO);
                this.pnlEncabezado.Refresh();
            }
            catch
            {
                MessageBox.Show("Puede establecer el logotipo del gimnasio en el inicio de sesión.");
                
            }
        }

        public void MostrarDatos(int ID)
        {
            this.Invoke(new Function(delegate()
            {
                Socio = new Socios();
                //Buscar datos en la base
                if (Socio.Abrir(ID))
                {
                    Socio.GuardarInteraccion();
                    long Ticks = Socio.limitepago.Ticks - DateTime.Now.Ticks;
                    TimeSpan Diferencia = new TimeSpan(Ticks);

                    System.IO.FileInfo Foto = new System.IO.FileInfo(Application.StartupPath + "/Fotos/" + Socio.ID.ToString().PadLeft(6, '0') + ".jpeg");
                    if (Foto.Exists)
                    {
                        System.IO.FileStream File = new System.IO.FileStream(Foto.FullName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        pbxFoto.Image = (Image)(Image.FromStream(File));
                        File.Close();
                    }
                    else
                    {
                        pbxFoto.Image = pbxFoto.InitialImage;
                    }

                    lblTituloPagos.Text = "Quedan " + Math.Truncate(Diferencia.TotalDays) + " Dias para tu fecha limite de pago : " + Socio.limitepago.ToShortDateString().ToUpper();
                    lblSocio.Text = Socio.nombre.ToUpper() + " " + Socio.apellido.ToUpper()+ " ("+ID+") ";
                    lblSaludo.Text =
                        ((Socio.nacimiento.Month == DateTime.Now.Month) &&
                        (Socio.nacimiento.Day == DateTime.Now.Day)) ? "Feliz cumpleaños!!! :)" : "Bienvenido";

                    dtpAsistencias.Value = DateTime.Now;
                    Asistencias(ID,DateTime.Now.Month,DateTime.Now.Year);
                    Pagos(ID, true);
                    

                    if (Socio.ID_rutinas == 0)
                    {
                        MessageBox.Show("Aun no esta asignada tu rutina, solicitala al entrenador.", "Rutina", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Escribir("No ha sido configurada una rutina para el socio.");
                    }
                    else
                    {
                        cmbDia.SelectedValue = (int)DateTime.Now.DayOfWeek;
                        Rutinas(Socio.ID_rutinas);
                    }
                }
            }));
        }

        string HTMLRutina = string.Empty;
        private void Rutinas(int _IDRutina)
        {
            //Generar el HTML con la rutina.
            string HTML_HEAD =
            @"<html> 
            <body bgcolor='#000000' text='#FFFFFF'>
            <table>
            <tr>
                <td colspan='4'>
                    <b>"+MyBody.Default.GYMNAME+@"</b>
                </td>
            </tr>   
            <tr>
                <td colspan='4'>
                    Hola "+Socio.nombre.ToUpper()+@" te enviamos tu rutina completa :) <br/>
                </td>
            </tr>
            ";
            string HTML_FOOT =
            @"
            <tr>
                <td colspan='4'>
                <b>"+MyBody.Default.GYMNAME+@"</b> | Esta rutina es personal, La copia o reproducción de esta rutina esta prohibida.<br />
                <b>Desarrollo de sistemas</b> | Haga clic <a href='mailto:jccc50@hotmail.com'>aqui</a> para contactar al desarrollador.
                </td>
            </tr>
            </table></body></html>";



            Ejercicios ObjEjercicio = new Ejercicios();
            pnlEjercicios.Controls.Clear();
            int XValue = 10;
            int YValue = 10;
            if (ObjEjercicio.Lista(_IDRutina))
            {
                string HTML_Content = @"
                        <tr bgcolor='#BF0F04'>
                        <td>Dia</td>
                        <td>Ejercicio</td>
                        <td>Series</td>
                        <td>Repeticiones</td>
                        </tr>";
                DataView dvEjercicios = new DataView(ObjEjercicio.Buffer.Copy());
                for (int i = 0; i < dvEjercicios.Count; i++)
                {
                    
                    Rutinas Rutina = new Rutinas();
                    HTML_Content += @"
                        <tr bgcolor='#999999'>
                        <td>" + Rutina.EspWeek((DayOfWeek)(int.Parse(dvEjercicios[i]["dia"].ToString()))) + @"</td>
                        <td>" + dvEjercicios[i]["nombre"].ToString() + @"</td>
                        <td>" + dvEjercicios[i]["series"].ToString() + @"</td>
                        <td>" + dvEjercicios[i]["repeticiones"].ToString() + @"</td>
                        </tr>";
                }

                HTMLRutina = HTML_HEAD + HTML_Content + HTML_FOOT;
                dvEjercicios.RowFilter = "dia='" + cmbDia.SelectedValue.ToString() + "'";
                if (dvEjercicios.Count == 0)
                {
                    MessageBox.Show("Tu rutina no contiene ejercicios para este dia.");
                }
                else
                {
                    for (int i = 0; i < dvEjercicios.Count; i++)
                    {
                        Ejercicio Control = new Ejercicio();
                        Control.lblTitulo.Text = dvEjercicios[i]["nombre"].ToString();
                        Control.lblSeries.Text = dvEjercicios[i]["series"].ToString();
                        Control.lblRepeticiones.Text = dvEjercicios[i]["repeticiones"].ToString();
                        Control.Width = pnlEjercicios.Width - 40;
                        Control.Location = new Point(XValue, YValue);
                        YValue = YValue + Control.Height + 10;
                        pnlEjercicios.Controls.Add(Control);
                    }
                }
            }
        }

       

        private void Asistencias(int _IDSocio, int _Mes, int _Año)
        {
            lstAsistencias.Items.Clear();
            lstAsistencias.Columns.Clear();
            lstAsistencias.Columns.AddRange(
                new ColumnHeader[] 
                        {
                            new ColumnHeader(), new ColumnHeader(), new ColumnHeader() 
                        }
                
                );

            if (Socio.Asistencias(_IDSocio, _Mes, _Año))
            {
                
                DataView DiasAsistidos = new DataView(Socio.Buffer);
                int TotalDiasEnMes = DateTime.DaysInMonth(_Año, _Mes);

                
                for (int i = 0; i < TotalDiasEnMes; i++)
                {
                    string Dia=(i+1).ToString().PadLeft(2,'0');
                    DiasAsistidos.RowFilter="dia='"+Dia+"'";

                    DateTime FechaEspecifica = new DateTime(_Año, _Mes, (i+1));
                    Rutinas Rutina = new Rutinas();

                    ListViewItem Item = new ListViewItem(new string[] 
                    {Dia,

                     Rutina.EspWeek(FechaEspecifica.DayOfWeek).Remove(3).ToUpper(), 
                     (DiasAsistidos.Count>0?"SI":"NO")},

                    (DateTime.Now>FechaEspecifica?
                        (DiasAsistidos.Count > 0 ? 1 : 0) : (-1)
                    )
                   
                    );
                    lstAsistencias.Items.Add(Item);
               }




            }
        }


        private void Pagos(int _IDSocio, bool _Pendiente)
        {
            lstPagos.Items.Clear();
            decimal Deuda = 0;

            if (Socio.Pagos(_IDSocio, _Pendiente))
            {
                for (int i = 0; i < Socio.Buffer.Rows.Count; i++)
                {
                    Socios.Estatus ObjEstatus = new Socios.Estatus();

                    Socios.TipoPago ObjTipo = new Socios.TipoPago();
                    ObjTipo = (int.Parse(Socio.Buffer.Rows[i]["producto"].ToString()) == 1) ? Socios.TipoPago.Producto : Socios.TipoPago.Servicio;


                    DateTime FechaInicio = DateTime.Parse(Socio.Buffer.Rows[i]["fecha"].ToString());
                    int Dias = int.Parse(Socio.Buffer.Rows[i]["dias"].ToString());
                    DateTime FechaFin = FechaInicio.AddDays(Dias);


                    bool Pendiente = bool.Parse(Socio.Buffer.Rows[i]["pendiente"].ToString());
                    string Concepto = Socio.Buffer.Rows[i]["nombre"].ToString();


                    //Opcion servicio de vencido
                    int Semaforo = 1;
                    decimal Importe = 0;
                    bool Vencido = false;
                    if (Pendiente)
                    {

                        Importe = decimal.Parse(Socio.Buffer.Rows[i]["deuda"].ToString());
                        Deuda += Importe;


                        if (FechaFin < DateTime.Now)
                        {
                            Vencido = true;
                        }



                        if (Vencido)
                        {
                            ObjEstatus = Socios.Estatus.Vencido;
                            Semaforo = 0;
                        }
                        else
                        {
                            ObjEstatus = Socios.Estatus.Pendiente;
                            Semaforo = 2;
                        }


                    }
                    else
                    {
                        ObjEstatus = Socios.Estatus.Pagado;
                        Semaforo = 1;
                        Importe = decimal.Parse(Socio.Buffer.Rows[i]["total"].ToString());
                    }




                    string[] Data ={
                                        Socio.Buffer.Rows[i]["ID"].ToString(),
                                        FechaInicio.ToShortDateString(),
                                        FechaFin.ToShortDateString(),
                                        Concepto,
                                        ObjEstatus.ToString(),
                                        Socio.Buffer.Rows[i]["cantidad"].ToString(),
                                        Importe.ToString("N2"),
                                        (ObjTipo.ToString())
                                      };
                    lstPagos.Items.Add(new ListViewItem(Data, Semaforo));
                }
                txtSaldo.Text = "$" + Deuda.ToString("N2");
            }
        }

        Socios Socio;
        private void txtID_Leave(object sender, EventArgs e)
        {
            int ID = 0;
            int.TryParse(txtID.Text, out ID);
            if (ID > 0)
            {
                MostrarDatos(ID);
            }
            else
            {
                Socio = null;
            }


            EnrollButton.Enabled = (Socio != null) && (Socio.ID > 0);

        }


        private void BorrarDatos()
        {
            lblSocio.Text = "COLOCA TU DEDO EN EL LECTOR.";
            lstPagos.Items.Clear();
            lstAsistencias.Items.Clear();
            pnlEjercicios.Controls.Clear();
            pbxFoto.Image = pbxFoto.InitialImage;
            txtSaldo.Text = string.Empty;
            lblTituloPagos.Text = "Para mostrar tu lista de pendientes.";
            
        }
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm tt").ToUpper();
            //BorrarDatos();
            
        }

        private void frmRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DetenerLectura();
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Socio != null && Socio.ID != 0 && Socio.ID_rutinas != 0)
            {
                Rutinas(Socio.ID_rutinas);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Socio.facebook.Length == 0 || (!Socio.facebook.Contains("@")))
                {
                    MessageBox.Show("La siguiente dirección de correo electronico es invalida : "+Socio.facebook);
                }
                else
                {
                    EnviarMensaje(HTMLRutina, Socio.facebook);
                    MessageBox.Show("La rutina fue enviada al correo : "+ Socio.facebook);
                }
            }
            catch(Exception ex)
            {

                if (MessageBox.Show("Error al enviar la rutina por correo, solicite al administrador revisar tu dirección electrónica, la conexión de internet o la conexión del servidor de mensajeria. ¿Desea ver mas información sobre el error?", "Enviar la rutina",  MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void EnviarMensaje(string _HTMLBody, string _Destino)
        {
            System.Net.Mail.MailMessage Mensaje = new System.Net.Mail.MailMessage();
            Mensaje.Priority = System.Net.Mail.MailPriority.High;
            Mensaje.IsBodyHtml = true;
            Mensaje.Body = _HTMLBody;

            System.Net.Mail.SmtpClient Cliente = new System.Net.Mail.SmtpClient(MyBody.Default.SMTP_SERVER, MyBody.Default.SMTP_PORT)
            {
                Credentials = new System.Net.NetworkCredential(MyBody.Default.SMTP_MAIL, MyBody.Default.SMTP_PWD),
                EnableSsl=true              
            };
            
            Mensaje.Subject = "Rutina - "+MyBody.Default.GYMNAME;
            Mensaje.From = new System.Net.Mail.MailAddress(MyBody.Default.SMTP_MAIL);
            Mensaje.To.Add(new System.Net.Mail.MailAddress(_Destino));
            Cliente.Send(Mensaje);
            Mensaje.To.Clear();
        }

        private void dtpAsistencias_ValueChanged(object sender, EventArgs e)
        {
            if (Socio != null && Socio.ID != 0)
            {
                Asistencias(Socio.ID, dtpAsistencias.Value.Month, dtpAsistencias.Value.Year);
            }
        }

        
    }
}
