using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicaxan
{
    public partial class Form1 : Form
    {
        ndeah instancia;
        public Form1()
        {
            instancia = new ndeah();
            InitializeComponent();
        }
         List<ndeah> names = new List<ndeah>();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            instancia.added(txtnombre.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Nombres.Items.Add(instancia.finditem(txtIDs.Text));
        }
    }
}
