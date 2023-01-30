using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dtcosas.Columns.Add("","Cantidad");
            Dtcosas.Columns.Add("", "Descripción");
            Dtcosas.Columns.Add("","P/total");
            txtFactura.Text = Convert.ToString(Venta.OEnumero);
        }

        double st;
        double Precio;
        int i;
        Factura Venta=new Factura();

        void limpiar()
        {
            txtDescrip.Clear();
            txtPrecio.Clear();
            txtdireccion.Clear();
            txtcantidad.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btncalcu_Click(object sender, EventArgs e)
        {
            /*Dgfactura.row.count para calcular las filas de un datagrid*/
            st = 0;
            for (int a=0;a<i;a++)
            {
                Precio = double.Parse(Dtcosas.Rows[a].Cells[2].Value.ToString());
                st = st + Precio;
            }

            txtsub.Text = Convert.ToString(st);
            Factura instancia = new Factura(st);
            txtIVA.Text = Convert.ToString(instancia.Eototaliva);
            txtTotal.Text = Convert.ToString(instancia.Eototal);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Dtcosas.Rows.Add();
            Dtcosas.Rows[i].Cells[0].Value = txtcantidad.Text;
            Dtcosas.Rows[i].Cells[1].Value = txtDescrip.Text;
            Dtcosas.Rows[i].Cells[2].Value = int.Parse(txtPrecio.Text)*int.Parse(txtcantidad.Text);
            i++;
            limpiar();
        }
    }
}
