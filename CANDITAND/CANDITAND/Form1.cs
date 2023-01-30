using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANDITAND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Fecha
        {
            public int Dia;
            public string Mes;
            public int Año;
        }

        public struct Datos
        {
            public string Carnet;
            public string Nombres;
            public string Apellidos;
            public string Sexo;
            public Fecha FechaNac;
        }
        Datos[] info;
        int a;

        void limpiar()
        {
            txtapellido.Clear();
            txtnombre.Clear();
            txtPOO.Clear();
            txtmate.Clear();
            txtMatD.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Array.Resize(ref info, a + 1);
            {
                info[a].Apellidos = txtapellido.Text;
                info[a].Nombres = txtnombre.Text;
                limpiar();
                a++;
            }
        }

        private void btnImpri_Click(object sender, EventArgs e)
        {
            Cosas.Items.Clear();
            Cosas.Items.Add("NombreS" + "\t" + "Apellidos" + "\t" + "P.O.O" + "\t" + "Nose");
            for (int k = 0; k < info.Length; k++)
            {
                Cosas.Items.Add( "\t" + info[k].Nombres + "\t" + info[k].Apellidos);
            }
        }
    }
}
