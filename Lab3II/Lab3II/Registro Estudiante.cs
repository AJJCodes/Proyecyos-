using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3II
{
    public partial class Registro_Estudiante : Form
    {
        public Registro_Estudiante()
        {
            InitializeComponent();
            actualizarcb();
            cbasignatura1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbgrupos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void limpiar()
        {
            txtapellido1.Clear();
            txtCarnet.Clear();
            txtnombre1.Clear();
        }
        void actualizarcb()
        {
            cbasignatura1.DataSource = null;
            cbgrupos.DataSource = null;
            cbasignatura1.DataSource = Datastore.Listasdeasignaturas;
            cbgrupos.DataSource = Datastore.Listasdeasignaturas;
            cbgrupos.DisplayMember = "OEgrupo";
            cbgrupos.ValueMember = "OEgrupo";
            cbasignatura1.DisplayMember = "OEasignatura";
            cbasignatura1.ValueMember = "OEasignatura";
        }

        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            actualizarcb();
            Datastore.Listaestudiantes.Add(new Estudiante(txtnombre1.Text,txtapellido1.Text,cbasignatura1.Text,txtCarnet.Text,cbgrupos.Text));
            dtgcosas.DataSource = null;
            dtgcosas.DataSource = Datastore.Listaestudiantes;
            limpiar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbasignatura1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
