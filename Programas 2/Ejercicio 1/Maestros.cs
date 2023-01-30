using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programas.Ejercicio_1;

namespace Programas.Forms
{
    public partial class Maestros : Form
    {
        public Maestros()
        {
            InitializeComponent();
        }

        Profesores[] Ghost;
        
        int i, Edad;
        int suma, promedio;
        int Pequeño, Grande,
            Prueba1, Prueba2;

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Promedio De Edades****************************
            for (int i = 0; i < Ghost.Length; i++)
            {
                suma = suma + Ghost[i].Edad((Ghost[i].EOAño));
            }
            promedio = suma / Ghost.Length;

            txtMedia.Text = promedio.ToString();

            //Menos Edad************************+
            Pequeño = Ghost[0].EOAño;
            for (int i = 1; i < Ghost.Length; i++)
            {
                if (Ghost[i].Edad((Ghost[i].EOAño)) < Pequeño)
                {
                    Prueba2 = i;

                }
            }
            txtJoven.Text = Ghost[Prueba2].EONombres;

            //Mayor Edad
            Grande = Ghost[0].EOAño;
            for (int i = 1; i < Ghost.Length; i++)
            {
                if (Ghost[i].Edad(Ghost[i].EOAño) > Grande)
                {

                    Prueba1 = i;
                }
            }

            txtMayor.Text = Ghost[Prueba1].EONombres;
        }

        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (RBHombre.Checked == true)
            {
                Sexo = RBHombre.Text;

            }
            if (RBMujer.Checked == true)
            {
                Sexo = RBMujer.Text;
            }

            lbImprimir.Items.Clear();
            lbImprimir.Items.Add("Nombre" + "\t" + "Apellido" + "\t" + "Edad" + "\t" + "Sexo");
            for (int i = 0; i < Ghost.Length; i++)
            {
                Edad = Ghost[i].Edad(Ghost[i].EOAño);
                lbImprimir.Items.Add(Ghost[i].Imprimir() + Edad + "\t" + Sexo);
            }
        }

        string Sexo;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Array.Resize(ref Ghost, i + 1);
            {
                Ghost[i] = new Profesores();
                Ghost[i].EONombres = txtNombres.Text;
                Ghost[i].EOApellidos = txtApellidos.Text;
                Ghost[i].EOAño = int.Parse(txtFecha.Text);
                //Ghost[i].EOSexo = cbSexo.Text;
                i++;
            }

            txtNombres.Clear();
            txtApellidos.Clear();
            txtFecha.Clear();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
    }
}
