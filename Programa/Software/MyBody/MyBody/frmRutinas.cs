using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBody
{
    public partial class frmRutinas : Form
    {
        private Rutinas Rutina = new Rutinas();
        private Ejercicios Ejercicio = new Ejercicios();
        public frmRutinas()
        {
            InitializeComponent();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            NOMBRAR:
            string sValor = string.Empty;
            if (InputBox.Show("Nombre de la rutina.", "Escriba el nombre de la nueva rutina", ref sValor) == System.Windows.Forms.DialogResult.OK)
            {
                if (sValor.Length == 0)
                {
                    MessageBox.Show("Debe escribir un nombre.");
                    goto NOMBRAR;
                }
                else
                {
                    Rutina.ID = Rutina.LlavePrimaria();
                    Rutina.Fecha = DateTime.Now;
                    Rutina.Nombre = sValor;
                    if (Rutina.Guardar())
                    {
                        MessageBox.Show("Listo.");
                        Lista();
                    }
                }
            }
        }

        private void frmRutinas_Load(object sender, EventArgs e)
        {
            Lista();
            Dias();
            Ejercicios();
        }
        private void Ejercicios()
        {
            if(Ejercicio.Lista())
            {
                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
                for (int i = 0; i <  Ejercicio.Buffer.Rows.Count; i++)
                {
                    Collection.Add(Ejercicio.Buffer.Rows[i]["sugerencia"].ToString());
                }
                txtNombre.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtNombre.AutoCompleteCustomSource = Collection;

            }
        }
        private void Lista()
        {
            lstRutinas.Items.Clear();
            if (Rutina.Lista())
            {
                for (int i = 0; i < Rutina.Buffer.Rows.Count; i++)
                {
                    string[] Datos = { 
                    Rutina.Buffer.Rows[i]["ID"].ToString(),
                    Rutina.Buffer.Rows[i]["nombre"].ToString(),
                    DateTime.Parse(Rutina.Buffer.Rows[i]["fecha"].ToString()).ToShortDateString()
                                     };
                  
                    lstRutinas.Items.Add(new ListViewItem(Datos));
                }

            }            
        }
        private void ListaEjercicios()
        {
            lstEjercicios.Items.Clear();
            if (Ejercicio.Lista(Ejercicio.ID_Rutina))
            {
                
                for (int i = 0; i < Ejercicio.Buffer.Rows.Count; i++)
                {
                    DataView Vista = new DataView(Rutina.ListaDias().Copy());

                    Vista.RowFilter = "id=" + int.Parse(Ejercicio.Buffer.Rows[i]["dia"].ToString());
                    string[] Datos ={
                                       Ejercicio.Buffer.Rows[i]["ID"].ToString(),
                                        Vista[0]["nombre"].ToString(),
                                        Ejercicio.Buffer.Rows[i]["nombre"].ToString(),
                                        Ejercicio.Buffer.Rows[i]["series"].ToString(),
                                        Ejercicio.Buffer.Rows[i]["repeticiones"].ToString()

                                       };
                    lstEjercicios.Items.Add(new ListViewItem(Datos));
                }
            }
        }

        public void Dias()
        {
            cmbDia.DataSource = Rutina.ListaDias().Copy();
            cmbDia.DisplayMember = "nombre";
            cmbDia.ValueMember = "id";
            
        }

        private void mnuRenombrar_Click(object sender, EventArgs e)
        {
            if (lstRutinas.SelectedItems.Count > 0)
            {
                int ID = int.Parse(lstRutinas.SelectedItems[0].SubItems[0].Text);
            RENOMBRAR:
                string sValor = lstRutinas.SelectedItems[0].SubItems[1].Text;
                if (InputBox.Show("Nombre de la rutina.", "Escriba el nuevo nombre de la rutina", ref sValor) == System.Windows.Forms.DialogResult.OK)
                {
                    if (sValor.Length == 0)
                    {
                        MessageBox.Show("Debe escribir un nombre.");
                        goto RENOMBRAR;

                    }
                    else
                    {
                        Rutina.ID = ID;
                        Rutina.Fecha = DateTime.Now;
                        Rutina.Nombre = sValor;
                        if (Rutina.Guardar())
                        {
                            MessageBox.Show("Listo.");
                            Lista();
                        }
                    }
                }
            }
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            if (lstRutinas.SelectedItems.Count > 0)
            {
                int ID = int.Parse(lstRutinas.SelectedItems[0].SubItems[0].Text);
                if (MessageBox.Show("¿Seguro que desea eliminar la rutina " + lstRutinas.SelectedItems[0].SubItems[1].Text + "?","Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Rutina.Eliminar(ID))
                    {
                        MessageBox.Show("Borrado.");
                        Lista();
                    }
                }
            }
        }

       



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Update(0);
        }

        private void Add_Update(int ID_Ejercicio)
        {
            if (cmbDia.SelectedIndex > (-1) &&
                Ejercicio.ID_Rutina > 0 &&
                txtNombre.Text.Length > 0 &&
                txtSeries.Text.Length > 0 &&
                txtRepeticiones.Text.Length > 0)
            {
                Ejercicio.ID = ID_Ejercicio == 0 ? (Ejercicio.LlavePrimaria()) : (ID_Ejercicio);
                Ejercicio.Dia = int.Parse(cmbDia.SelectedValue.ToString());
                Ejercicio.Nombre = txtNombre.Text.ToString();
                Ejercicio.Series = txtSeries.Text.ToString();
                Ejercicio.Repeticiones = txtRepeticiones.Text.ToString();
                if (Ejercicio.Guardar())
                {
                    txtNombre.Text = string.Empty;
                    txtSeries.Text = string.Empty;
                    txtRepeticiones.Text = string.Empty;

                    MessageBox.Show("Listo");
                    ListaEjercicios();
                }
                else
                {
                    MessageBox.Show("No se grabo el ejercicio.");
                }
            }
            else
            {
                MessageBox.Show("Asegurece de seleccionar una rutina y rellenar todos los campos.");
            }
        }

        private void lstRutinas_DoubleClick(object sender, EventArgs e)
        {
            if (lstRutinas.SelectedItems.Count > 0)
            {
                Ejercicio.ID_Rutina = int.Parse(lstRutinas.SelectedItems[0].SubItems[0].Text);
                ListaEjercicios();
                tbcRutinas.SelectedIndex = 1;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstEjercicios.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar el ejercicio " + lstEjercicios.SelectedItems[0].SubItems[2].Text + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Ejercicio.Eliminar(int.Parse(lstEjercicios.SelectedItems[0].SubItems[0].Text)))
                    {
                        ListaEjercicios();
                    }
                }
            }
        }

        private void lstEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEjercicios.SelectedItems.Count > 0)
            {
                string Dia = lstEjercicios.SelectedItems[0].SubItems[1].Text;
                string Ejercicio = lstEjercicios.SelectedItems[0].SubItems[2].Text;
                string Series = lstEjercicios.SelectedItems[0].SubItems[3].Text;
                string Repeticiones = lstEjercicios.SelectedItems[0].SubItems[4].Text;

                cmbDia.Text = Dia;
                txtNombre.Text = Ejercicio;
                txtSeries.Text = Series;
                txtRepeticiones.Text = Repeticiones;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lstEjercicios.SelectedItems.Count > 0)
            {
                Add_Update(int.Parse(lstEjercicios.SelectedItems[0].SubItems[0].Text));
            }
        }

       
    }
}
