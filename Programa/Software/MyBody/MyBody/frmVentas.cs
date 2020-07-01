using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBody
{
    public partial class frmVentas : Form
    {
        public Usuarios Usuario { get; set; }
        Ventas Venta = new Ventas();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (txtTotal.Text.Length > 0 &&
                txtSocio.Text.Length > 0 &&
                lstProductos.Items.Count > 0)
            {
                Venta.ID_usuario = Usuario.ID;
                Venta.ID_socio = Socio.ID;


                if (MessageBox.Show("El total de venta es: $" + txtTotal.Text, "¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                {
                    return;
                }


                string Vendidos = string.Empty;
                for (int i = 0; i < lstProductos.Items.Count; i++)
                {
                    if (Producto.Abrir(Productos.Query.KeyType.Identifier, lstProductos.Items[i].SubItems[0].Text))
                    {
                        Venta.ID_producto = Producto.ID;
                        Venta.cantidad = int.Parse(lstProductos.Items[i].SubItems[3].Text);
                        Venta.punitario = float.Parse(lstProductos.Items[i].SubItems[4].Text);
                        Venta.total = float.Parse(lstProductos.Items[i].SubItems[5].Text);
                        Venta.pendiente = lstProductos.Items[i].Checked;
                        if (Venta.pendiente)
                        {
                            Venta.cobrado = 0;
                        }
                        else
                        {
                            Venta.cobrado = Venta.total;
                        }

                        Venta.fecha = DateTime.Now;

                        if (Venta.cantidad <= Producto.mostrador)
                        {
                            //Descontar del almacen
                            if (Venta.Guardar())
                            {
                                Venta.Descontar();
                            }

                            Vendidos += lstProductos.Items[i].SubItems[1].Text+ "\n\r";
                            
                        }
                        else
                        {
                            //if (MessageBox.Show("Segun los datos del programa, no hay producto suficiente para realizar la venta de:" + lstProductos.Items[i].SubItems[1].Text + ". \n\rDebe pasar mas productos al mostrador en el menu de inventario ¿Desea guardar de todos modos?", "Producto insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            //{
                                //Descontar del almacen
                                if (Venta.Guardar())
                                {
                                    Venta.Descontar();
                                }

                                Vendidos += "(*) "+lstProductos.Items[i].SubItems[1].Text + "\n\r";
                            //}
                        }
                    }
                }

                lblUltimo.Text = "Se vendieron los siguientes productos:\n\r" + Vendidos;
                //MessageBox.Show();
                Reiniciar();
            }
            else
            {
                MessageBox.Show("El formulario de venta esta incompleto.");
            }
        }
        public void Reiniciar()
        {
            lstProductos.Items.Clear();
            txtEntrega.Text = (0).ToString("N2");
            txtVuelto.Text = (0).ToString("N2");
            Calcular();
        }

        public void ComprobarImagen()
        {
            //Colocar personalizacion.
            try
            {
                this.pnlFoto.BackgroundImage = Image.FromFile(MyBody.Default.SALES_PIC);
                this.pnlFoto.Refresh();
            }
            catch
            {
                MessageBox.Show("Puede personalizar el menu del programa, seleccione un archivo.");
                btnPicture_Click(null, null);

            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            ComprobarImagen();

            Venta.Socios();
            Sugerencias(txtSocio, Venta.Buffer.Copy());

            //Venta.Productos();
            //Sugerencias(txtProducto, Venta.Buffer.Copy());

            Tiempo.Start();
        }

        public void Sugerencias(TextBox _campo, DataTable _valores)
        {
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            for (int i = 0; i < _valores.Rows.Count; i++)
            {
                Collection.Add(_valores.Rows[i]["sugerencia"].ToString());
            }
            _campo.AutoCompleteMode = AutoCompleteMode.Suggest;
            _campo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _campo.AutoCompleteCustomSource = Collection;
        }





        Socios Socio = new Socios();
        private void txtSocio_TextChanged(object sender, EventArgs e)
        {
            if (txtSocio.Text.Contains("|"))
            {
                int Clave = 0;
                int.TryParse(txtSocio.Text.Split('|')[1].Trim(), out Clave);
                if (Clave == 0)
                {
                    return;
                }
                else
                {
                    //Consultar el socio.

                    if (Socio.Abrir(Clave))
                    {
                        if (Producto.ID != 0)
                        {
                            btnAceptar.Enabled = true;
                        }
                    }
                }
            }
        }

        public void Calcular()
        {
            decimal GTotal = 0;
            for (int i = 0; i < lstProductos.Items.Count; i++)
            {
                GTotal += decimal.Parse(lstProductos.Items[i].SubItems[5].Text);
            }
            txtTotal.Text = GTotal.ToString("N2");
            txtEntrega_TextChanged(null, null);
        }

        Productos Producto = new Productos();
        private void Tiempo_Tick(object sender, EventArgs e)
        {
            if (txtCB.Text.Length > 0)
            {
                if (Producto.Abrir(Productos.Query.KeyType.BarCode, txtCB.Text))
                {
                    lstProductos.Items.Add(new ListViewItem(new string[]
                    {
                            Producto.ID.ToString(),
                            Producto.nombre,
                            Producto.retornable?"SI":"NO",
                            (1).ToString(),
                            Producto.precio_venta.ToString("N2"),
                            (1*Producto.precio_venta).ToString("N2")
                    }));

                    txtCB.Text = string.Empty;
                    Calcular();
                }
            }
            else
            {
                if (txtSocio.Focused ||  txtEntrega.Focused || lstProductos.Focused || optCantidadValor.Focused || optImporteValor.Focused)
                {
                    //No enfocar: Enfocar en 10 segundos
                }
                else
                { txtCB.Focus(); }
            }

        }

        private void txtEntrega_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal Total = decimal.Parse(txtTotal.Text);
                decimal Entregado= decimal.Parse(txtEntrega.Text);
                txtVuelto.Text =  (Entregado - Total).ToString("N2");
            }
            catch
            {
                return;
            }
        }

        private void optCantidadValor_TextChanged(object sender, EventArgs e)
        {
            if(lstProductos.SelectedItems.Count>0)
            {
                
                int Cantidad = 1;
                int.TryParse(optCantidadValor.Text, out Cantidad);

                lstProductos.SelectedItems[0].SubItems[3].Text = Cantidad.ToString();
                lstProductos.SelectedItems[0].SubItems[5].Text =
                    (int.Parse(lstProductos.SelectedItems[0].SubItems[3].Text)
                    *
                    decimal.Parse(lstProductos.SelectedItems[0].SubItems[4].Text)).ToString("N2");
                    Calcular();

                
            }
        }

        private void optEliminar_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedItems.Count > 0)
            {
                lstProductos.SelectedItems[0].Remove();
                Calcular();
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductos.SelectedItems.Count > 0)
            {
                optCantidadValor.Text = lstProductos.SelectedItems[0].SubItems[3].Text;
                optImporteValor.Text = lstProductos.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void optImporteValor_TextChanged(object sender, EventArgs e)
        {
            if (lstProductos.SelectedItems.Count > 0)
            {

                decimal Importe = 1;
                decimal.TryParse(optImporteValor.Text, out Importe);

                lstProductos.SelectedItems[0].SubItems[4].Text = Importe.ToString();
                lstProductos.SelectedItems[0].SubItems[5].Text =
                    (int.Parse(lstProductos.SelectedItems[0].SubItems[3].Text)
                    *
                    decimal.Parse(lstProductos.SelectedItems[0].SubItems[4].Text)).ToString("N2");
                Calcular();


            }
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "Imagenes (*.bmp)|*.bmp";
            if (File.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pnlFoto.BackgroundImage = Image.FromFile(File.FileName);
                MyBody.Default.SALES_PIC = File.FileName;
                MyBody.Default.Save();
            }
        }

        private void lstProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case ' ':
                    {
                        btnAceptar_Click(sender, e);
                    }
                    break;
                case '\b':
                    { 
                        optEliminar_Click(sender, e);
                    }
                    break;
                case '-':
                    {
                        if (int.Parse(optCantidadValor.Text) == 1)
                        {
                            optEliminar_Click(sender, e);
                        }
                        else
                        {
                            int Resta = int.Parse(optCantidadValor.Text) - 1;
                            optCantidadValor.Text = Resta.ToString();
                        }
                    }
                    break;
                    case '+':
                    {
                        
                            int Suma = int.Parse(optCantidadValor.Text) + 1;
                            optCantidadValor.Text = Suma.ToString();
                        
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optPendiente_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedItems.Count > 0)
            {
                lstProductos.SelectedItems[0].Checked = true;
            }
        }
    }
}

