using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_uni_demen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNumero.Enabled = false;
            btningresar.Enabled = false;
            mayor.Enabled = false;
            Menors.Enabled = false;
        }

        int []Numero;
        int Contador, Mayor,Menor;

        private void Menors_Click(object sender, EventArgs e)
        {
            Menor = Numero[0];
            for (int i = 1; i < Contador; i++)
            {
                if (Numero[i] < Menor)
                {
                    Menor = Numero[i];
                }
            }
            MessageBox.Show("El numero menor es : " + " " + Menor, "sistema");
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (Contador < Numero.Length)
            {
                Numero[Contador] = int.Parse(txtNumero.Text);
                Contador++;
                txtNumero.Text = " ";
            }
            else
            {
                txtNumero.Text = " ";
                MessageBox.Show("Ya no hay espacio ", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Enabled = false;
            }
        }

        private void mayor_Click(object sender, EventArgs e)
        {
            Mayor = Numero[0];
            for(int i = 1; i < Contador; i++)
            {
                if (Numero[i]>Mayor)
                {
                    Mayor = Numero[i];
                }
            }
            MessageBox.Show("El numero mayor es : " + " " + Mayor, "sistema");
        }

        private void btnguard_Click(object sender, EventArgs e)
        {
            int Tamaño;
            try
            {
                Tamaño = int.Parse(txtTamaño.Text);
                Numero = new int[Tamaño];
                txtNumero.Enabled = true;
                btningresar.Enabled = true;
                mayor.Enabled = true;
                Menors.Enabled = true;
                txtTamaño.Enabled = false;
                Contador = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
