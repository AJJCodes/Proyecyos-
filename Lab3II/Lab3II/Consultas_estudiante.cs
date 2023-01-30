using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab3II
{
    public partial class Consultas_estudiante : Form
    {
        public Consultas_estudiante()
        {
            InitializeComponent();
            cbasignaturas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbgrupos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnaños.DropDownStyle = ComboBoxStyle.DropDownList;
            actualizando();
        }
        List<Consulta> busqueda = new List<Consulta>();//Lista a imprimir
        List<StringValue> busqueda2 = new List<StringValue>();

        void actualizando()
        {
            cbasignaturas.DataSource = null;
            cbgrupos.DataSource = null;
            cbnaños.DataSource = null;
            cbasignaturas.DataSource = Datastore.Listadeconsulta;
            cbgrupos.DataSource = Datastore.Listadeconsulta;
            cbnaños.DataSource = Datastore.Listadeconsulta;
            cbasignaturas.DisplayMember = "asignaturadocente";
            cbasignaturas.ValueMember = "asignaturadocente";
            cbgrupos.DisplayMember = "grupocon";
            cbgrupos.ValueMember = "grupocon";
            cbnaños.DisplayMember = "fechaconsul";
            cbnaños.ValueMember = "fechaconsul";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            busqueda.Clear();
            foreach (var L in Datastore.Listadeconsulta)
            {
                if(L.asignaturadocente == cbasignaturas.Text)
                {
                    busqueda.Add(L);
                }
            }
            dtgestudiantecon.DataSource = null;
            dtgestudiantecon.DataSource = busqueda;

            foreach (var L in Datastore.Listadeconsulta)
            {
                foreach (var P in L.Consultadores)
                {
                    if (L.asignaturadocente == cbasignaturas.Text)
                    {
                        lbestudiantesfc.Items.Add(P + "\t" + "\n");//Añade y espacio por consulta
                    }
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
