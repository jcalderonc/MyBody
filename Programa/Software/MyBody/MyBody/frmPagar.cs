using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBody
{
    public partial class frmPagar : Form
    {
        
        public string Concepto { set { lblConcepto.Text = value.Trim(); } }
        public decimal Importe { set { txtMonto.Text = value.ToString("N2"); }
            get
            {
                decimal Respuesta = 0;
                decimal.TryParse(txtMonto.Text, out Respuesta);
                return Respuesta;
            }
        }
        public frmPagar()
        {
            InitializeComponent();
        }
    }
}
