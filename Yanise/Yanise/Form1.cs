using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yanise
{
    public partial class Form1 : Form
    {
        /*Instancia de las clases*/
        Estudiante instancia;
        Profesor instancia2;
        /*Lista de estudiantes */
        List<Estudiante> Lista_De_estudiantes = new List<Estudiante>();
        List<Profesor> Lista_De_profesores = new List<Profesor>();
        public Form1()
        {
            instancia = new Estudiante();
            instancia2 = new Profesor();
            InitializeComponent();
            cbBeca.DataSource = instancia.Ollista();
            cbfacultad.DataSource = instancia2.Olista();
        }

        void imprimirE1()
        {
            Dgestudiante.DataSource = null;
            Dgestudiante.DataSource = Lista_De_estudiantes;
        }

        void imprimirE2()
        {
            dgprofesores.DataSource = null;
            dgprofesores.DataSource = Lista_De_profesores;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            instancia.EoNombre = txtnombre.Text;
            instancia.EOapellido =txtapellido.Text;
            instancia.EoTelefono = int.Parse(txttelefono.Text);
            instancia.EoCarrera = txtcarrera.Text;
            instancia.EoBeca = cbBeca.Text;
            instancia.Eoaño = int.Parse(txtaño.Text);
            Lista_De_estudiantes.Add(instancia);
            imprimirE1();
        }

        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            instancia2.EoNombre = txtnombres.Text;
            instancia2.EOapellido = txtapellidos.Text;
            instancia2.EoTelefono = int.Parse(txttelefonos.Text);
            instancia2.Faculty = cbfacultad.Text;
            instancia2.Salary = double.Parse(txtSalario.Text);
            instancia2.Eoaño = int.Parse(txtañonacs.Text);
            Lista_De_profesores.Add(instancia2);
            imprimirE2();
        }
    }
}
