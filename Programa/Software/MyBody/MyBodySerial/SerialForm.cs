using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyBody;

namespace MyBodySerial
{
    public partial class SerialForm : Form
    {
        public SerialForm()
        {
            InitializeComponent();
        }

        private void SerialForm_Load(object sender, EventArgs e)
        {
            lblSerial.Text = MyBody.frmLogin.GetMBSN();
        
        }
    }
}
