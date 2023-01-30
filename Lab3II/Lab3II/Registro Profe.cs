using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3II
{
    public partial class Registro_Profe : Form
    {
        public Registro_Profe()
        {
            Asignatura A = new Asignatura();
            InitializeComponent();
            actualizando();
            cbasignatura.DropDownStyle= ComboBoxStyle.DropDownList;
            cbsemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsemestre.DataSource = null;
            cbsemestre.DataSource = A.Olistasem;//Agregamos el semestre
            cbgrupo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void limpiar()
        {
            txtapell.Clear();
            txtañolect.Clear();
            txtnombre.Clear();
        }

        void actualizando()
        {
            cbasignatura.DataSource = null;
            cbgrupo.DataSource = null;
            cbasignatura.DataSource = Datastore.Listasdeasignaturas;
            cbgrupo.DataSource = Datastore.Listasdeasignaturas;
            cbasignatura.DisplayMember = "OEasignatura";
            cbasignatura.ValueMember = "OEasignatura";
            cbgrupo.DisplayMember = "OEgrupo";
            cbgrupo.ValueMember = "OEgrupo";
        }
        private void btningresarr_Click(object sender, EventArgs e)
        {
            //actualizarcombo();
            Datastore.Listaprofes.Add(new Profesores(txtnombre.Text,txtapell.Text,cbasignatura.Text,int.Parse(txtañolect.Text),cbsemestre.Text,cbgrupo.Text));
            dtgprofesores.DataSource = null;
            dtgprofesores.DataSource = Datastore.Listaprofes;
            limpiar();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
