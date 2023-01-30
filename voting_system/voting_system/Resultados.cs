using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace voting_system
{
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
            //Limpieza de la tabla
            Resul.Items.Clear();
            //Añadir eso
            Resul.Items.Add("Candidato" + "\t" + "Votos" + "\t");
        }
        //instancia de form votos
        Votos vols = new Votos();
        //contador
        int i = 1;
        //falso verdadero
        int LOL;

        int gan = Declarmod.contador[1];


    private void Resul_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Proceso de ganador
            for (i = 1; i < 12; i++)
            {
                /*Proceso ganador */
                if (Declarmod.contador[i] > gan)
                {
                    gan = i;
                }
            }
           
              MessageBox.Show("El Ganador es el candidato numero: " + Convert.ToString(gan));
            
        }
        private void votcont_Click(object sender, EventArgs e)
        {
            //Mostrar total de votos con candidatos
            while (i <= 12)
            {
                Resul.Items.Add("Candidato " + i + " "+Declarmod.contador[i]);
                i++;
            }
        }
        private void Resultados_Load(object sender, EventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
