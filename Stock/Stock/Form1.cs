using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Productos1 pro1 = new Productos1();
        private void button1_Click(object sender, EventArgs e)
        {
            pro1.Show();
        }

        private void btncomprar_Click(object sender, EventArgs e)
        {

        }
    }
}
