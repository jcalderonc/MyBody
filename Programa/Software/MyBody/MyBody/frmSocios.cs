using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBody
{
    public partial class frmSocios : Form
    {
        public Usuarios Usuario { get; set; }
        Socios Socio = new Socios();
        Suscripciones Suscripcion = new Suscripciones();
        Rutinas Rutina = new Rutinas();
        private ListViewColumnSorter lvwColumnSorter;
        public frmSocios()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.lstSocios.ListViewItemSorter = lvwColumnSorter;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Socio = new Socios();
            Socio.Filtro = string.Empty;
            Socio.ID = Socio.LlavePrimaria();
            Socio.ID_usuarios = Usuario.ID;
            Socio.activo = true;

            Socio.fecharegistro = DateTime.Now;
            Socio.inscripcion = DateTime.Now;
            Socio.ultimopago = DateTime.Now;
            Socio.nacimiento = DateTime.Now;
            Socio.limitepago = DateTime.Now;

            SetControls();
            tbcSocios.SelectedIndex = 0;
            ((Control)tpgNuevo).Enabled = Socio.activo;
            
        }

        public void SetControls()
        {
            txtID.Text = Socio.ID.ToString();
            txtNombres.Text = Socio.nombre;
            txtApellidos.Text = Socio.apellido;
            txtTelefonos.Text = Socio.telefono;
            txtFB.Text = Socio.facebook;
            txtDireccion.Text = Socio.direccion;
            dtpNacimiento.Value = Socio.nacimiento;
            txtPeso.Text = Socio.peso.ToString();
            cmbTipo.SelectedValue = Socio.ID_suscripciones;
            cmbRutina.SelectedValue = Socio.ID_rutinas;
            dtpInscripcion.Value = Socio.inscripcion;
            dtpUPago.Value = Socio.ultimopago;
            dtpLimite.Value = Socio.limitepago;
            chkActivo.Checked = Socio.activo;
            System.IO.FileInfo Foto=new System.IO.FileInfo(Application.StartupPath+"/Fotos/"+Socio.ID.ToString().PadLeft(6,'0')+".jpeg");
            if (Foto.Exists)
            {
                System.IO.FileStream File = new System.IO.FileStream(Foto.FullName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                imgVideo.Image = (Image)(Image.FromStream(File));
                File.Close();
            }
            else
            {
                imgVideo.Image = imgVideo.InitialImage;
            }
        }
        public void GetControls()
        {          
             Socio.nombre = txtNombres.Text;
             Socio.apellido = txtApellidos.Text;
             Socio.telefono = txtTelefonos.Text;
             Socio.facebook = txtFB.Text;
             Socio.direccion = txtDireccion.Text;
             Socio.nacimiento = dtpNacimiento.Value;
             Socio.peso = int.Parse(txtPeso.Text);
             Socio.ID_suscripciones = int.Parse(cmbTipo.SelectedValue.ToString());
             Socio.ID_rutinas = int.Parse(cmbRutina.SelectedValue.ToString());
             Socio.inscripcion = dtpInscripcion.Value;
             Socio.ultimopago = dtpUPago.Value;
             Socio.limitepago = dtpLimite.Value;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0 &&
               txtNombres.Text.Length > 0 &&
               txtApellidos.Text.Length > 0 &&
               txtPeso.Text.Length > 0 &&
               txtTelefonos.Text.Length > 0 &&
               txtFB.Text.Length > 0 &&

                cmbTipo.SelectedIndex>(-1) &&
                cmbRutina.SelectedIndex>(-1))
            {
                int Salida = 0;
                int.TryParse(txtPeso.Text, out Salida);
                if (Salida == 0)
                {
                    MessageBox.Show("Es necesario especificar el peso del socio.");
                    return;
                }
                else
                {
                    GetControls();
                }


                if (Socio.Guardar())
                {
                    MessageBox.Show("Listo.");
                    tbcSocios.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación.");
                }
            }
            else
            {
                MessageBox.Show("El formulario está incompleto. Para generar un nuevo socio haga clic en el botón nuevo socio.");
            }
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
            if (lstSocios.SelectedItems.Count > 0)
            {
                if (Socio.Activar(int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString()), _Active))
                {
                    MessageBox.Show("Listo.");

                    Abrir();
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione el socio.");
            }
        }
        public void Abrir()
        {
            if (Socio.Abrir(int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString())))
            {
                SetControls();
                tbcSocios.SelectedIndex = 2;
                lblSocio.Text = Socio.nombre.ToUpper() + " " + Socio.apellido.ToUpper();
                ((Control)tpgNuevo).Enabled = Socio.activo;
                                
                Pagos(int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString()),chkPendientes.Checked);
                Interacciones(int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString()));
            }
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txtTotalAsistencia.Text = "0";
            lstAsistencia.Items.Clear();
            if (Socio.Asistencias(dtpFecha.Value))
            {
                for (int i = 0; i < Socio.Buffer.Rows.Count; i++)
                {
                    string[] Datos = { DateTime.Parse(Socio.Buffer.Rows[i]["hora"].ToString()).ToLongTimeString(), Socio.Buffer.Rows[i]["nombre"].ToString(), Socio.Buffer.Rows[i]["apellido"].ToString() };
                    lstAsistencia.Items.Add(new ListViewItem(Datos, 1));
                }
                txtTotalAsistencia.Text = Socio.Buffer.Rows.Count.ToString();
            }


        }


        private void Interacciones(int _IDSocio)
        {
            lstInteraccion.Items.Clear();

            if (Socio.Interacciones(_IDSocio))
            {
                for (int i = 0; i < Socio.Buffer.Rows.Count; i++)
                {
                    string[] Datos = { Socio.Buffer.Rows[i]["ID"].ToString(), DateTime.Parse(Socio.Buffer.Rows[i]["fecha"].ToString()).ToString("yyyy-MM-dd HH:mm:ss"), "Coloco su dedo en el lector." };
                    lstInteraccion.Items.Add(new ListViewItem(Datos,1));
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
                txtSaldo.Text = "$"+Deuda.ToString("N2");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Socio.Filtro = txtCriterio.Text.ToLower().Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u");
            Lista();
        }

        void Lista()
        {
            lstSocios.Items.Clear();
            if (Socio.Lista(chkInactivos.Checked))
            {
                int NumTodos = 0;
                int NumActivos = 0;
                int NumAdeudados = 0;


                decimal TotalAdeudado=0;
                for (int i = 0; i < Socio.Buffer.Rows.Count; i++)
                {
                    
                    NumTodos++;

                    string Estatus = string.Empty;
                    
                    bool Activo = bool.Parse(Socio.Buffer.Rows[i]["activo"].ToString());
                    
                    int Pendientes = int.Parse(Socio.Buffer.Rows[i]["pendientes"].ToString());
                    
                    decimal Deuda = decimal.Parse(Socio.Buffer.Rows[i]["montos"].ToString());
                    TotalAdeudado+=Deuda;



                    
                    long Ticks=DateTime.Now.Ticks-DateTime.Parse(Socio.Buffer.Rows[i]["inscripcion"].ToString()).Ticks;
                    TimeSpan Diferencia = new TimeSpan(Ticks);
                    
                    int Semaforo = 1;
                                      

                    if (!Activo)
                    {
                        Estatus = "Socio desactivado.";
                        Semaforo = 0;
                    }
                    else
                    {
                        NumActivos++;
                        Estatus = "Socio activado.";
                        Semaforo = 1;
                    }

                    if (Pendientes > 0)
                    {
                        NumAdeudados++;
                        Estatus = "Socio adeudado.";
                        Semaforo = 2;
                    }



                    string[] Data = { Socio.Buffer.Rows[i]["ID"].ToString().PadLeft(4,'0'),
                                      Socio.Buffer.Rows[i]["nombre"].ToString(),
                                      Socio.Buffer.Rows[i]["apellido"].ToString(),
                                      Math.Truncate(Diferencia.TotalDays)+" Dias",
                                      Socio.Buffer.Rows[i]["suscripcion"].ToString(),
                                      DateTime.Parse(Socio.Buffer.Rows[i]["ultimopago"].ToString()).ToShortDateString(),
                                      Deuda.ToString("N2"),
                                      Estatus,
                                      (Activo?"Si":"No")
                                    };
                    lstSocios.Items.Add(new ListViewItem(Data, Semaforo));
                }

                txtTodos.Text=NumTodos.ToString();
                txtActivos.Text=NumActivos.ToString();
                txtAdeudados.Text = NumAdeudados.ToString();
                txtTotalAdeudado.Text = "$"+TotalAdeudado.ToString("N2");

            }
            else
            {
                MessageBox.Show("No se encontro ningun socio.");
            }
        }


        
        private void frmSocios_Load(object sender, EventArgs e)
        {
            Socio.Filtro = string.Empty;
            tbcSocios.SelectedIndex = 1;
            if (Suscripcion.Lista())
            {
                cmbTipo.DataSource = Suscripcion.Buffer.Copy();
                cmbTipo.DisplayMember = "nombre";
                cmbTipo.ValueMember = "ID";
            }
            if (Rutina.Lista())
            {
                cmbRutina.DataSource = Rutina.Buffer.Copy();
                cmbRutina.DisplayMember = "nombre";
                cmbRutina.ValueMember = "ID";
            }         
           
        }

        private void tbcSocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcSocios.SelectedIndex == 1)
            {
                Lista();
            }

        }

        private void lstSocios_DoubleClick(object sender, EventArgs e)
        {
            if (lstSocios.SelectedItems.Count > 0)
            {
                Abrir();
            }
            else
            {
                MessageBox.Show("Seleccione el usuario.");
            }
        }

        private void chkPendientes_CheckedChanged(object sender, EventArgs e)
        {
            if (lstSocios.SelectedItems.Count > 0)
            {
                Pagos(int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString()), chkPendientes.Checked);
            }
            else
            {
                MessageBox.Show("Seleccione el usuario.");
            }
        }

        private void lstPagos_DoubleClick(object sender, EventArgs e)
        {
            if (lstPagos.SelectedItems.Count > 0)
            {

                if (lstPagos.SelectedItems[0].SubItems[4].Text == Socios.Estatus.Pendiente.ToString() ||
                    lstPagos.SelectedItems[0].SubItems[4].Text == Socios.Estatus.Vencido.ToString())
                {
                    frmPagar Pagar = new frmPagar();
                    Pagar.Concepto = lstPagos.SelectedItems[0].SubItems[3].Text;
                    Pagar.Importe = decimal.Parse(lstPagos.SelectedItems[0].SubItems[6].Text) * -1;
                    Socios.TipoPago Tipo = (lstPagos.SelectedItems[0].SubItems[7].Text == Socios.TipoPago.Producto.ToString()) ?
                    Socios.TipoPago.Producto :
                    Socios.TipoPago.Servicio;

                    if (Pagar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Socio.Pagar(Tipo, int.Parse(lstPagos.SelectedItems[0].SubItems[0].Text), Pagar.Importe))
                        {
                            if (lstSocios.SelectedItems.Count > 0)
                            {
                                Pagos(int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString()), chkPendientes.Checked);
                                MessageBox.Show("Listo.");
                            }
                            else
                            {
                                tbcSocios.SelectedIndex = 1;
                            }
                        }
                    }
                }
            }
        }

        private void mnuCambiar_Click(object sender, EventArgs e)
        {
            if (lstPagos.SelectedItems.Count > 0)
            {

                if (lstPagos.SelectedItems[0].SubItems[4].Text == Socios.Estatus.Pendiente.ToString() ||
                    lstPagos.SelectedItems[0].SubItems[4].Text == Socios.Estatus.Vencido.ToString())
                {

                CAMBIAR:
                    decimal iValor = 0;
                    string sValor = string.Empty;
                    if (InputBox.Show("Cambiar el importe", "Escriba el nuevo importe", ref sValor) == System.Windows.Forms.DialogResult.OK)
                    {
                        decimal.TryParse(sValor, out iValor);
                        if (iValor == 0)
                        {
                            MessageBox.Show("Debe escribir un valor monetario valido.");
                            goto CAMBIAR;

                        }
                        else
                        {
                            Socios.TipoPago Tipo = (lstPagos.SelectedItems[0].SubItems[7].Text == Socios.TipoPago.Producto.ToString()) ?
                            Socios.TipoPago.Producto :
                            Socios.TipoPago.Servicio;


                             if (Socio.Cambiar(Tipo, int.Parse(lstPagos.SelectedItems[0].SubItems[0].Text), iValor))
                             {
                                 if (lstSocios.SelectedItems.Count > 0)
                                 {
                                     Pagos(int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString()), chkPendientes.Checked);
                                     MessageBox.Show("Listo.");
                                 }
                                 else
                                 {
                                     tbcSocios.SelectedIndex = 1;
                                 }
                             } 
                        }
                    }
                }
            }
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            if (lstPagos.SelectedItems.Count > 0)
            {

                if (lstPagos.SelectedItems[0].SubItems[4].Text == Socios.Estatus.Pendiente.ToString() ||
                    lstPagos.SelectedItems[0].SubItems[4].Text == Socios.Estatus.Vencido.ToString())
                {

                
                    Socios.TipoPago Tipo = (lstPagos.SelectedItems[0].SubItems[7].Text == Socios.TipoPago.Producto.ToString()) ?
                    Socios.TipoPago.Producto :
                    Socios.TipoPago.Servicio;

                    if(Tipo== Socios.TipoPago.Servicio)
                    {
                        if (MessageBox.Show("Eliminar pago de servicios", "¿Desea eliminar este pago?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (Socio.EliminarServicios(int.Parse(lstPagos.SelectedItems[0].SubItems[0].Text)))
                            {
                                if (lstSocios.SelectedItems.Count > 0)
                                {
                                    Pagos(int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString()), chkPendientes.Checked);
                                    MessageBox.Show("Listo.");
                                }
                                else
                                {
                                    tbcSocios.SelectedIndex = 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo se pueden eliminar pagos de servicios.");
                    }
                }
            }
        }

        private void btnGenerarCobro_Click(object sender, EventArgs e)
        {
            if (lstSocios.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Cobrar servicio", "¿Desea generar manualmente el cobro de servicios para este socios?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    int ID=int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString());
                    if (Socio.CobrarSuscripcion(DateTime.Now, ID, Usuario.ID))
                    {
                        Pagos(int.Parse(lstSocios.SelectedItems[0].SubItems[0].Text.ToString()), chkPendientes.Checked);
                        
                        if (Socio.ActualizarFechaLimite(ID, DateTime.Now))
                        {
                            MessageBox.Show("Se ha generado el cobro del servicio, el socio debe pagar en este momento.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione el usuario.");
            }
        }

        private void chkInactivos_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }
        
        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (Socio != null && Socio.ID > 0)
            {
                //LLamar programa externo de camara.
                
                using (System.Diagnostics.Process exeProcess = System.Diagnostics.Process.Start(Application.StartupPath+"/WinFormWebCam.exe",Socio.ID.ToString()))
                {
                    exeProcess.WaitForExit();
                }
                SetControls();
                
            }
            else
            {
                MessageBox.Show("Seleccione al socio primeramente.");
            }
        }

        private void lstSocios_ColumnClick(object sender, ColumnClickEventArgs e)
        {
      
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lstSocios.Sort();
            
        }

 

       

        
    }
}
