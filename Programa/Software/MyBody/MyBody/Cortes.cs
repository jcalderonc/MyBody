using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyBody
{
    public partial class Cortes : Form
    {
        public Cortes()
        {
            InitializeComponent();
        }
        Ventas.Cortes Corte = new Ventas.Cortes();
        Productos Producto = new Productos();

        private void Cortes_Load(object sender, EventArgs e)
        {
            ListaProductos();
            ListaCorte();
        }
        private void ListaCorte()
        {
            if (Corte.Lista())
            {
                cmbCorte.DataSource = Corte.Buffer.Copy();
                cmbCorte.DisplayMember = "nombre";
                cmbCorte.ValueMember = "ID";
                cmbCorte.SelectedValue = "0";
                cmbCorte_SelectedIndexChanged(null, null);
            }
        }
        private void ListaProductos()
        {
            if (Producto.Lista())
            {
                ((ListBox)cbxProductos).DataSource = Producto.Buffer.Copy();
                ((ListBox)cbxProductos).ValueMember = "ID";
                ((ListBox)cbxProductos).DisplayMember = "nombre";
            }
        }
        
        private void Todo(bool Todo)
        {
            for (int i = 0; i < cbxProductos.Items.Count; i++)
            {
                cbxProductos.SetItemChecked(i, Todo);
            }
        }
        private void cmbCorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CorteID = (-1);
            int.TryParse(cmbCorte.SelectedValue.ToString(), out CorteID);

            cbxProductos.Enabled = false;
            Todo(true);
            
            
            if(CorteID > (0))
            {
                cbxProductos.Enabled = true;
                Todo(false);

                if (Corte.ProductosXCorte(CorteID))
                {
                    DataView SeleccionGuardada = new DataView(Corte.Buffer.Copy());
                    for (int i = 0; i < cbxProductos.Items.Count; i++)
                    {
                        int CurrentIDProducto = int.Parse(((DataRowView)cbxProductos.Items[i]).Row.ItemArray[0].ToString());
                        SeleccionGuardada.RowFilter = "ID_producto='" + CurrentIDProducto + "'";
                        if (SeleccionGuardada.Count > 0)
                        {
                            cbxProductos.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Nombre = Microsoft.VisualBasic.Interaction.InputBox("¿Como se llama el corte?", "Nuevo corte", "");
            if (Corte.Agregar(Nombre))
            {
                MessageBox.Show("Corte agregado, ahora seleccione el corte y los productos que le corresponden.");
                ListaCorte();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cmbCorte.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("No se puede eliminar este corte.");
            }
            else
            {
                if (MessageBox.Show("¿Desea eliminar el corte?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (Corte.Eliminar(int.Parse(cmbCorte.SelectedValue.ToString())))
                    {
                        MessageBox.Show("Corte eliminado, se elimina toda la relacion con los productos.");
                        ListaCorte();
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            Application.DoEvents();
            int ID_Corte = int.Parse(cmbCorte.SelectedValue.ToString());
            if (ID_Corte > 0)
            {
                for (int i = 0; i < cbxProductos.Items.Count; i++)
                {
                    int ID_Producto = int.Parse(((DataRowView)cbxProductos.Items[i]).Row.ItemArray[0].ToString());
                    if (cbxProductos.GetItemCheckState(i) == CheckState.Checked)
                    {
                        Corte.Asociar(ID_Corte, ID_Producto);
                    }
                    else
                    {
                        Corte.Desasociar(ID_Corte, ID_Producto);
                    }
                }
            }
            Close();
        }
    }
}
