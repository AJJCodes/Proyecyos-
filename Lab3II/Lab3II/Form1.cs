using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnAsignatura_Click(object sender, EventArgs e)
        {
            Asignatura_registro AR = new Asignatura_registro();
            AR.ShowDialog();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            Registro_Profe RP = new Registro_Profe();
            RP.ShowDialog();
        }

        private void BtnEstudiante_Click(object sender, EventArgs e)
        {
            Registro_Estudiante RE = new Registro_Estudiante();
            RE.ShowDialog();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Consultas_registro CR = new Consultas_registro();
            CR.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconsuestu_Click(object sender, EventArgs e)
        {
            Consultas_estudiante CE = new Consultas_estudiante();
            CE.ShowDialog();
        }

        private void btnCondo_Click(object sender, EventArgs e)
        {
            Consulta_Docente CD = new Consulta_Docente();
            CD.ShowDialog();
        }
    }
}
