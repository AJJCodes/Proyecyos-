using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace voting_system
{
    public partial class Votos : Form
    {
        public Votos()
        {
            InitializeComponent();
            for (int a=1;a<=12;a++)
            {
                cbbachis.Items.Add(Convert.ToString(a));
            }
        }
         /*Llamada a los forms*/
        /*lista de cantidatos*/
        Candidatos bachis = new Candidatos();
        
        private void cbbachis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Votos_Load(object sender, EventArgs e)
        {

        }

        private void Candis_Click(object sender, EventArgs e)
        {
            bachis.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbbachis.SelectedIndex == -1) {
                MessageBox.Show("Por favor ingrese un candidato");
            }
            else {
                int voto = int.Parse(cbbachis.SelectedItem.ToString());
                Declarmod.contador[voto] = Declarmod.contador[voto] + 1;
                MessageBox.Show("Usted voto por el candidato numero: " + Convert.ToString(voto));
            }

        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
