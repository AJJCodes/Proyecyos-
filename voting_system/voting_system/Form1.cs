using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voting_system
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        /*Llamando a los forms*/
        Candidatos candis = new Candidatos();
        Votos vot = new Votos();
        Resultados resuls = new Resultados();

        private void btncandi_Click(object sender, EventArgs e)
        {
            candis.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnvotar_Click(object sender, EventArgs e)
        {
            vot.Show();
        }

        private void btnresul_Click(object sender, EventArgs e)
        { 
            resuls.Show();
        }
    }
}
