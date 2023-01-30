using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3II
{
    public partial class Consultas_registro : Form
    {
        public Consultas_registro()
        {
            Consulta Con = new Consulta();
            Asignatura Asig = new Asignatura();
            InitializeComponent();
            actualizarcb();
            cbasignatura.DropDownStyle = ComboBoxStyle.DropDownList;
            cbañolec.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdocente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbgrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            /*
            cbestudiante1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestudiante2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbestudiante3.DropDownStyle = ComboBoxStyle.DropDownList;*/
            cbgrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnumero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtipocon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnumero.DataSource = Con.Olistasemana;
            cbtipocon.DataSource = Con.Olistatipo;
            //listbox estudiantes
            /*
            ((ListBox)lbestudiantess).DataSource = Datastore.Listaestudiantes;
            ((ListBox)lbestudiantess).DisplayMember = "Name";
            ((ListBox)lbestudiantess).ValueMember = "Name";*/
            /*
            lbestudiantes.DataSource = Datastore.Listaestudiantes;
            lbestudiantes.DisplayMember = "Nombre";
            lbestudiantes.ValueMember = "Nombre";*/
            cbapellido.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        //Lista temportal
        
        void limpiar()
        {
            txthoradecon.Clear();
            txtobservaciones.Clear();
            txttema.Clear();
            
        }

        void actualizarcb()
        {
            foreach (var P in Datastore.Listaestudiantes) { lbestudiantess.Items.Add(P.Carnet +" "+ P.Nombre + " " + P.Apellido + " " + P.Grupo); }
            //TODOS LOS combo box
            cbasignatura.DataSource = null;
            cbgrupo.DataSource = null;
            cbdocente.DataSource = null;
            cbnumero.DataSource = null;//Numero de semana
            /*
            cbestudiante1.DataSource = null;
            cbestudiante2.DataSource = null;
            cbestudiante3.DataSource = null;*/
            cbtipocon.DataSource = null;
            //Source de datos
            cbasignatura.DataSource = Datastore.Listaprofes;
            cbgrupo.DataSource = Datastore.Listaprofes;
            cbdocente.DataSource = Datastore.Listaprofes;
            cbañolec.DataSource = Datastore.Listaprofes;
            //Combo box estudiante
            /*
            cbestudiante1.DataSource = Datastore.Listaestudiantes;
            cbestudiante2.DataSource = Datastore.Listaestudiantes;
            cbestudiante3.DataSource = Datastore.Listaestudiantes;*/
            //Combo de asignatura
            cbasignatura.DisplayMember = "Asignatura";
            cbasignatura.ValueMember = "Asignatura";
            //combo de grupo
            cbgrupo.DisplayMember = "Grupo";
            cbgrupo.ValueMember = "Grupo";
            //Combo de profesores 
            cbdocente.DisplayMember = "Nombre";
            cbdocente.ValueMember = "Nombre";
            //Combo de estudiantes
            /*
            cbestudiante1.DisplayMember = "Nombre";
            cbestudiante2.DisplayMember = "Nombre";
            cbestudiante3.DisplayMember = "Nombre";
            cbestudiante1.ValueMember = "Nombre";
            cbestudiante2.ValueMember = "Nombre";
            cbestudiante3.ValueMember = "Nombre";*/
            //año lectivo
            cbañolec.DisplayMember = "Añolectivo";
            cbañolec.ValueMember = "Añolectivo";
            //
            cbsemestre.DataSource = null;
            cbsemestre.DataSource = Datastore.Listaprofes;
            cbsemestre.DisplayMember = "Semestre";
            cbsemestre.ValueMember = "Semestre";

            cbapellido.DataSource = null;
            cbapellido.DataSource = Datastore.Listaprofes;
            cbapellido.DisplayMember = "Apellido";
            cbapellido.ValueMember = "Apellido";
        }

        private void Consultas_registro_Load(object sender, EventArgs e)
        {

        }

        List<string> temp = new List<String>();
        string str1;
        private void btningresar_Click(object sender, EventArgs e)
        {
            temp.Clear();
            //Capturamos los checked
            //foreach(var A in lbestudiantess.CheckedItems) { str1 = Convert.ToString(A); temp.Add(str1); }
            temp = lbestudiantess.CheckedItems.OfType<string>().ToList();

            Datastore.Listadeconsulta.Add(new Consulta(cbdocente.Text,cbapellido.Text,cbasignatura.Text, DateTime.Parse(dtphora.Text),int.Parse(cbsemestre.Text),cbgrupo.Text,temp,int.Parse(txthoradecon.Text),txtobservaciones.Text,cbtipocon.Text,txttema.Text,int.Parse(cbnumero.Text)));
            limpiar();
            MessageBox.Show("Registro ingresado con exito");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
