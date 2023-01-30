using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3II
{
    public partial class Consulta_Docente : Form
    {
        public Consulta_Docente()
        {
            InitializeComponent();
            cbactua();
            cbasignatura.DropDownStyle = ComboBoxStyle.DropDownList;
            cbañolec.DropDownStyle = ComboBoxStyle.DropDownList;
            cbdocente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbgrupo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        List<Consulta> abuscar = new List<Consulta>();
        List<StringValue> abuscar2 = new List<StringValue>();

        void cbactua()
        {
            cbasignatura.DataSource = null;
            cbañolec.DataSource = null;
            cbdocente.DataSource = null;
            cbgrupo.DataSource = null;
            cbasignatura.DataSource = Datastore.Listadeconsulta;
            cbañolec.DataSource = Datastore.Listadeconsulta;
            cbdocente.DataSource = Datastore.Listadeconsulta;
            cbgrupo.DataSource = Datastore.Listadeconsulta;
            cbasignatura.DisplayMember = "asignaturadocente";
            cbasignatura.ValueMember = "asignaturadocente";
            cbañolec.DisplayMember = "fechaconsul";
            cbañolec.ValueMember = "fechaconsul";
            cbdocente.DisplayMember = "Nombredocente";
            cbdocente.ValueMember = "Nombredocente";
            cbgrupo.DisplayMember = "grupocon";
            cbgrupo.ValueMember = "grupocon";


        }
        string SS;
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            abuscar.Clear();
            foreach(var L in Datastore.Listadeconsulta)
            {
                if(L.Nombredocente== cbdocente.Text)
                {
                    abuscar.Add(L);
                }

                dtgcosas.DataSource = null;
                dtgcosas.DataSource = abuscar;
            }

            foreach (var L in Datastore.Listadeconsulta)
            {
                foreach(var P in L.Consultadores)
                {
                    if (L.Nombredocente == cbdocente.Text)
                    {
                        Listboxfin.Items.Add(P+"\t"+"\n");
                    }
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
