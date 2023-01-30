using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3II
{
    public partial class Asignatura_registro : Form
    {
        public Asignatura_registro()
        {
            InitializeComponent();
        }

        void Limpiar()
        {
            txtasignaturas.Clear();
            txtgrupo.Clear();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Datastore.Listasdeasignaturas.Add(new Asignatura(txtasignaturas.Text,txtgrupo.Text));
            dtgasignaturas.DataSource = null;
            dtgasignaturas.DataSource = Datastore.Listasdeasignaturas;
            Limpiar();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
