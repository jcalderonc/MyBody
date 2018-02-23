using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace MyBody
{
    public partial class frmInventario : Form
    {
        public Usuarios Usuario { get; set; }
        Productos Producto = new Productos();
        Suscripciones Suscripcion = new Suscripciones();
        Ventas Venta = new Ventas();
        private ListViewColumnSorter lvwColumnSorterVentas;
        private ListViewColumnSorter lvwColumnSorterProductos;

        public frmInventario()
        {
            InitializeComponent();

            lvwColumnSorterVentas = new ListViewColumnSorter();
            this.lstVenta.ListViewItemSorter = lvwColumnSorterVentas;

            lvwColumnSorterProductos = new ListViewColumnSorter();
            this.lstInventario.ListViewItemSorter = lvwColumnSorterProductos;
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            ComprobarImagen();

            tbcInventario.SelectedIndex = 1;     
      
            dtpInicioVenta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFinVenta.Value = DateTime.Now;

            dtpInicioServicios.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFinServicios.Value = DateTime.Now;

            ListaMarca();
            ListaCorte();
            ListaPresentacion();
            btnNuevo_Click(null, null);


            
        }
        public void ComprobarImagen()
        {
            //Colocar personalizacion.
            try
            {
                this.pnlLogo.BackgroundImage = Image.FromFile(MyBody.Default.PRODUCTS_PIC);
                this.pnlLogo.Refresh();
            }
            catch
            {
                MessageBox.Show("Puede personalizar el menu del programa, seleccione un archivo.");
                btnPicture_Click(null, null);

            }
        }


        private void ListaPresentacion()
        {
            Producto.presentacion = new Productos.Presentaciones();
            cmbPresentacion.DataSource = Producto.presentacion.Buffer.Copy();
            cmbPresentacion.DisplayMember = "nombre";
            cmbPresentacion.ValueMember = "ID";
        }

        private void ListaMarca()
        {
            Producto.marca = new Productos.Marcas();
            cmbMarca.DataSource = Producto.marca.Buffer.Copy();
            cmbMarca.DisplayMember = "nombre";
            cmbMarca.ValueMember = "ID";
        }
        private void ListaCorte()
        {
            Ventas.Cortes Corte = new Ventas.Cortes();
            if (Corte.Lista())
            {
                cmbCorte.DataSource = Corte.Buffer.Copy();
                cmbCorte.DisplayMember = "nombre";
                cmbCorte.ValueMember = "ID";
                cmbCorte.SelectedValue = "0";

            }
    
        }

        private void ListaSuscripcion()
        {
            if (Suscripcion.Lista())
            {
                DataTable Lista=Suscripcion.Buffer.Copy();
                DataRow Fila = Lista.NewRow();
                Fila["ID"] = 0;
                Fila["nombre"] = "Todos";
                Lista.Rows.Add(Fila);
                DataView Tipos = new DataView(Lista);
                Tipos.Sort = "ID ASC";

                cmbTipo.DataSource = Tipos;
                cmbTipo.DisplayMember = "nombre";
                cmbTipo.ValueMember = "ID";

                
            }
        }

        private void Lista()
        {

            Producto.Criterio = txtCriterio.Text;

            lstInventario.Items.Clear();
            if (Producto.Lista())
            {
                    
                for (int i = 0; i < Producto.Buffer.Rows.Count; i++)
                {
                    
                    string Estatus=string.Empty;
                    
                    int Mostrador=int.Parse(Producto.Buffer.Rows[i]["mostrador"].ToString());
                    int Almacenado=int.Parse(Producto.Buffer.Rows[i]["almacenado"].ToString());

                    decimal PiezasCaja = decimal.Parse(Producto.Buffer.Rows[i]["piezacaja"].ToString());
                    decimal PrecioCompra = decimal.Parse(Producto.Buffer.Rows[i]["compra"].ToString());
                    decimal PrecioVenta= decimal.Parse(Producto.Buffer.Rows[i]["venta"].ToString());

                    bool Activo = bool.Parse(Producto.Buffer.Rows[i]["activo"].ToString());
                    bool Retornable = bool.Parse(Producto.Buffer.Rows[i]["retornable"].ToString());

                    int Semaforo = 1;
                    if (Almacenado == 0)
                    {
                        if (Mostrador == 0)
                        {
                            Estatus = "Producto agotado.";
                            Semaforo = 0;
                        }
                        else
                        {
                            Estatus = "Solo queda mostrador.";
                            Semaforo = 2;
                        }
                    }
                    else
                    {
                        if (Mostrador == 0)
                        {
                            Estatus = "Pasar productos al mostrador.";
                            Semaforo = 2;
                        }
                        else
                        {
                            Estatus = "Suficiente producto.";
                            Semaforo = 1;
                        }
                    }
                    if (!Activo)
                    {
                        Estatus = "Producto desactivado.";
                        Semaforo = 0;
                    }
                    
                    //ID, marca, presentacion, clave, cb, nombre, estatus, piezas, compra, venta, almacen, mostrador, existencia, retornable, activo
                    string[] Data = { Producto.Buffer.Rows[i]["ID"].ToString(),
                        Producto.Buffer.Rows[i]["ID_marcas"].ToString(),
                        Producto.Buffer.Rows[i]["ID_presentaciones"].ToString(),
                        Producto.Buffer.Rows[i]["clave"].ToString(),
                        Producto.Buffer.Rows[i]["codigobarras"].ToString(),
                        Producto.Buffer.Rows[i]["nombre"].ToString(),
                        Estatus,
                        PiezasCaja.ToString("N"),
                        PrecioCompra.ToString("N2"),
                        PrecioVenta.ToString("N2"),
                        Almacenado.ToString(),
                        Mostrador.ToString(),
                        (Almacenado+Mostrador).ToString(),
                        Retornable?"SI":"NO",
                        Activo?"SI":"NO"
                                    };
                    lstInventario.Items.Add(new ListViewItem(Data, Semaforo));
                }

             
            }
            else
            {
                MessageBox.Show("No se encontro ningun producto.");
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length>0 && 
                txtNombre.Text.Length > 0 &&
                txtCompra.Text.Length > 0 &&
                txtVenta.Text.Length > 0 &&
                txtPiezas.Text.Length>0)
            {
                float fltCompra = 0;
                float fltVenta=0;
                int intPiezas = 0;

                float.TryParse(txtCompra.Text, out fltCompra);
                float.TryParse(txtVenta.Text, out fltVenta);
                int.TryParse(txtPiezas.Text, out intPiezas);

                if (fltCompra == 0 || fltVenta==0 || intPiezas == 0)
                {
                    MessageBox.Show("El precio de compra, venta o la cantidad de piezas por caja puede ser incorrecto.");
                    return;
                }
                else
                {
                    GetControls();
                }


                if (Producto.Guardar())
                {
                    MessageBox.Show("Listo.");
                    tbcInventario.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación.");
                }
            }
            else
            {
                MessageBox.Show("El formulario está incompleto. Para generar un nuevo producto haga clic en el botón nuevo producto.");
            }
        }
        public void SetControls()
        {
            txtID.Text = Producto.ID.ToString();
            txtNombre.Text = Producto.nombre;
            txtClave.Text = Producto.clave_alterna;
            txtBarras.Text = Producto.codigo_barra;

            cmbMarca.SelectedValue = Producto.marca==null?0: Producto.marca.ID;
            cmbPresentacion.SelectedValue = Producto.presentacion==null?0: Producto.presentacion.ID;

            txtPiezas.Text = Producto.piezas_caja.ToString();
            txtCompra.Text = Producto.precio_compra.ToString("N2");
            txtVenta.Text = Producto.precio_venta.ToString("N2");
           
            txtAlmacen.Text = Producto.almacenado.ToString();
            txtMostrador.Text = Producto.mostrador.ToString();
            txtCantidad.Text = (Producto.almacenado + Producto.mostrador).ToString();
            txtMonto.Text = ((Producto.almacenado + Producto.mostrador) * Producto.precio_venta).ToString("N2");

            cbxRetornable.Checked = Producto.retornable;
            cbxActivo.Checked = Producto.activo;
         
        }
        public void GetControls()
        {
            Producto.nombre = txtNombre.Text;
            Producto.clave_alterna = txtClave.Text;
            Producto.codigo_barra = txtBarras.Text;
            Producto.precio_venta = float.Parse(txtVenta.Text);
            Producto.precio_compra = float.Parse(txtCompra.Text);
            Producto.piezas_caja = int.Parse(txtPiezas.Text);
            Producto.marca = new Productos.Marcas(int.Parse(cmbMarca.SelectedValue.ToString()));
            Producto.presentacion = new Productos.Presentaciones(int.Parse(cmbPresentacion.SelectedValue.ToString()));
            Producto.activo = cbxActivo.Checked;
            Producto.retornable = cbxRetornable.Checked;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Lista();
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            if (Producto.ID != 0)
            {
                ALMACENAR:
                int iValor = 0;
                string sValor = string.Empty;
                if (InputBox.Show("Alimentar almacen", "Escriba la cantidad de producto que ingresa al almacen.", ref sValor) == System.Windows.Forms.DialogResult.OK)
                {
                    int.TryParse(sValor, out iValor);
                    if (iValor == 0)
                    {
                        MessageBox.Show("Debe escribir un valor numerico.");
                        goto ALMACENAR;
                    
                    }
                    else
                    {
                        Producto.almacenado += iValor;
                        if (Producto.MoverProductos())
                        {
                            MessageBox.Show("El almacen fue alimentado.");
                            SetControls();
                        }
                    }
                }
            }
        }

        private void btnMostrador_Click(object sender, EventArgs e)
        {
            if (Producto.ID != 0)
            {
                CIRCULAR:
                int iValor = 0;
                string sValor = string.Empty;
                if (InputBox.Show("Mover al mostrador", "Escriba la cantidad de producto que desea mover al mostrador.", ref sValor) == System.Windows.Forms.DialogResult.OK)
                {
                    int.TryParse(sValor, out iValor);
                    if (iValor == 0)
                    {
                        MessageBox.Show("Debe escribir un valor numerico.");
                        goto CIRCULAR;
                    }
                    else
                    {
                        if (iValor > Producto.almacenado)
                        {
                            MessageBox.Show("No hay suficiente producto para hacer ese movimiento.");
                        }
                        else
                        {
                            Producto.almacenado -= iValor;
                            Producto.mostrador += iValor;
                            if (Producto.MoverProductos())
                            {
                                MessageBox.Show("El producto fue movido al mostrador.");
                                SetControls();
                            }
                        }
                    }
                }
            }
        }
        public void Abrir()
        {
            if (Producto.Abrir(Productos.Query.KeyType.Identifier,lstInventario.SelectedItems[0].SubItems[0].Text.ToString()))
            {
                SetControls();
                tbcInventario.SelectedIndex = 0;
                ((Control)tpgProductos).Enabled = Producto.activo;
                gbxInventario.Enabled = true;
            }
        }

        private void lstInventario_DoubleClick(object sender, EventArgs e)
        {
            if (lstInventario.SelectedItems.Count > 0)
            {
                Abrir();
            }
            else
            {
                MessageBox.Show("Seleccione el usuario.");
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
            if (lstInventario.SelectedItems.Count>0)
            {
                if (Producto.Activar(int.Parse(lstInventario.SelectedItems[0].SubItems[0].Text.ToString()), _Active))
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
                MessageBox.Show("Seleccione el producto.");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Producto = new Productos();
            Producto.ID = Producto.LlavePrimaria();
            Producto.ID_usuario = Usuario.ID;
            Producto.activo = true;
            Producto.fecha = DateTime.Now;
            SetControls();
            tbcInventario.SelectedIndex = 0;
            ((Control)tpgProductos).Enabled = Producto.activo;
            gbxInventario.Enabled = false;
        }

        private void tbcInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbcInventario.SelectedIndex)
            {
                case 1: { Lista(); }
                    break;

                case 2: { ListaSuscripcion(); }
                    break;
            }
        }

  

        public void Buscar()
        {
            int Valor = 0;
            int.TryParse(cmbTipo.SelectedValue.ToString(), out Valor);

            if (Valor > 0)
            {
                Suscripcion.Abrir(Valor);
                
            }
            else
            {
                Suscripcion.ID = 0;
                Suscripcion.Costo = 0;
            }

            txtPrecioServicio.Text = Suscripcion.Costo.ToString("N2");
            btnPrecioServicio.Enabled = Suscripcion.ID > 0;
            Suscripcion.FInicio = dtpInicioServicios.Value;
            Suscripcion.FFin = dtpFinServicios.Value;
            lstServicios.Items.Clear();
            
            if (Suscripcion.Pagos())
            {
                decimal TotalCobrado = 0;
                for (int i = 0; i < Suscripcion.Buffer.Rows.Count; i++)
                {
                    string Estatus = string.Empty;
                    string NombreSuscripcion = Suscripcion.Buffer.Rows[i]["suscripcion"].ToString();
                    decimal MontoCobrado = decimal.Parse(Suscripcion.Buffer.Rows[i]["cobrado"].ToString());
                    TotalCobrado += MontoCobrado;

                    decimal MontoTotal = decimal.Parse(Suscripcion.Buffer.Rows[i]["total"].ToString());

                    DateTime UPago = DateTime.Parse(Suscripcion.Buffer.Rows[i]["ultimopago"].ToString());


                    bool Pendiente = bool.Parse(Suscripcion.Buffer.Rows[i]["pendiente"].ToString());

                   

                    //Opcion de vencido
                    bool Vencido = false;
                    switch(NombreSuscripcion)
                    {
                        case "Mensual":
                            {
                                if (UPago.AddMonths(1) < DateTime.Now)
                                {
                                    Vencido = true;
                                }
                            }break;
                        case "Quincenal":
                            {
                                if (UPago.AddDays(14) < DateTime.Now)
                                {
                                    Vencido = true;
                                }
 
                            } break;
                        case "Semanal":
                            {
                                if (UPago.AddDays(7) < DateTime.Now)
                                {
                                    Vencido = true;
                                }
 
                            } break;
                        case "Visita":
                            {
                                if (UPago.AddDays(1) < DateTime.Now)
                                {
                                    Vencido = true;
                                }

                            } break;
                    }



                    int Semaforo = 1;
                    if (Pendiente)
                    {
                        if (Vencido)
                        {
                            Estatus = "Vencido.";
                            Semaforo = 0;
                        }
                        else
                        {
                            Estatus = "Pendiente.";
                            Semaforo = 2;
                        }
                    }
                    else
                    {
                        Estatus = "Pagado.";
                        Semaforo = 1;
                    }

                    string[] Data = { Suscripcion.Buffer.Rows[i]["ID"].ToString(),
                                      Suscripcion.Buffer.Rows[i]["socio"].ToString(),
                                      NombreSuscripcion,
                                       MontoTotal.ToString("N2"),
                                       MontoCobrado.ToString("N2"),
                                       Estatus,
                                       DateTime.Parse(Suscripcion.Buffer.Rows[i]["fecha"].ToString()).ToShortDateString()
                                    };
                    lstServicios.Items.Add(new ListViewItem(Data, Semaforo));
                }

                txtMontoServicio.Text = TotalCobrado.ToString("N2");

            }
        }

        private void btnBuscarServicio_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnPrecioServicio_Click(object sender, EventArgs e)
        {
            if (Suscripcion.ID != 0)
            {
            CAMBIAR:
                int iValor = 0;
                string sValor = string.Empty;
                if (InputBox.Show("Cambiar el costo", "Escriba el nuevo costo, de ésta suscripción.", ref sValor) == System.Windows.Forms.DialogResult.OK)
                {
                    int.TryParse(sValor, out iValor);
                    if (iValor == 0)
                    {
                        MessageBox.Show("Debe escribir un valor numerico.");
                        goto CAMBIAR;

                    }
                    else
                    {
                        Suscripcion.Costo = iValor;
                        if (Suscripcion.CambiarCosto())
                        {
                            MessageBox.Show("El costo fue modificado con exito.");
                            cmbTipo.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
            lstVenta.Items.Clear();
            if (Venta.Vendido(dtpInicioVenta.Value,dtpFinVenta.Value, int.Parse(cmbCorte.SelectedValue.ToString())))
            {
                decimal SumMargen = 0;
                decimal SumVenta = 0;
                decimal SumSaldo = 0;
                for (int i = 0; i < Venta.Buffer.Rows.Count; i++)
                {

                    string Producto = Venta.Buffer.Rows[i]["producto"].ToString();
                    string Socio= Venta.Buffer.Rows[i]["socio"].ToString();
                    string Usuario = Venta.Buffer.Rows[i]["usuario"].ToString();
                    int Cantidad=int.Parse(Venta.Buffer.Rows[i]["cantidad"].ToString());

                    decimal Precio = decimal.Parse(Venta.Buffer.Rows[i]["punitario"].ToString());
                    decimal Total = decimal.Parse(Venta.Buffer.Rows[i]["total"].ToString());
                    decimal Cobrado = decimal.Parse(Venta.Buffer.Rows[i]["cobrado"].ToString());
                    decimal Saldo = decimal.Parse(Venta.Buffer.Rows[i]["saldo"].ToString());
                    string Fecha = DateTime.Parse(Venta.Buffer.Rows[i]["fecha"].ToString()).ToShortDateString();
                    string Hora = DateTime.Parse(Venta.Buffer.Rows[i]["fecha"].ToString()).ToShortTimeString();

                    decimal Margen = decimal.Parse(Venta.Buffer.Rows[i]["ganancia"].ToString());


                    SumVenta += Cobrado;
                    SumSaldo += Saldo;
                    SumMargen += Margen;

                    int Semaforo = 1;
                    if (Cobrado==Total)
                    {
                        Semaforo = 1;
                    }
                    else if (Cobrado==0)
                    {
                        Semaforo = 0;
                    }
                    else if(Cobrado>0)
                    {
                        Semaforo=2;
                    }
                    
                    string[] Data = { Usuario, Socio, Producto, Fecha, Hora, Cantidad.ToString(), Precio.ToString("N2"), Total.ToString("N2"), Cobrado.ToString("N2"), Saldo.ToString("N2"), Margen.ToString("N2")};
                    lstVenta.Items.Add(new ListViewItem(Data, Semaforo));
                }
                txtVendido.Text = SumVenta.ToString("N2");
                txtSaldo.Text = SumSaldo.ToString("N2");
                txtMargen.Text = SumMargen.ToString("N2");

            }
            else
            {
                MessageBox.Show("No se vendio nada en esas fechas.");
            }
        }

        private void lstVenta_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorterVentas.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorterVentas.Order == SortOrder.Ascending)
                {
                    lvwColumnSorterVentas.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorterVentas.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorterVentas.SortColumn = e.Column;
                lvwColumnSorterVentas.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lstVenta.Sort();
			
        }

        private void lstInventario_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorterProductos.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorterProductos.Order == SortOrder.Ascending)
                {
                    lvwColumnSorterProductos.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorterProductos.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorterProductos.SortColumn = e.Column;
                lvwColumnSorterProductos.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lstInventario.Sort();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "Imagenes (*.bmp)|*.bmp";
            if (File.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pnlLogo.BackgroundImage = Image.FromFile(File.FileName);
                MyBody.Default.PRODUCTS_PIC = File.FileName;
                MyBody.Default.Save();
            }
        }

        private void btnCortes_Click(object sender, EventArgs e)
        {
            Cortes Crear = new Cortes();
            Crear.ShowDialog();
            ListaCorte();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
