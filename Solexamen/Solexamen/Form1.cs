using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solexamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Profesores A = new Profesores();
            txtcodigo.Text = A.EoNumero.ToString();
            cbfacultad.DataSource = A.Ofacultad;
            cbCat.DataSource = A.Ocategoria;
            cbnivel.DataSource = A.Onivel;
            cbbuscar.DataSource = A.Ofacultad;
        }
        List<Profesores> Profe = new List<Profesores>();
        List<Profesores> Buscar = new List<Profesores>();

        void limpiar() {
            txtapellido.Clear();
            txtcarrera.Clear();
            txtcodigo.Clear();
            txtnombre.Clear();
        }
        private void btncod_Click(object sender, EventArgs e)
        {
            Profesores A = new Profesores();
            txtcodigo.Text = A.EoNumero.ToString();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Profe.Add(new Profesores(int.Parse(txtcodigo.Text),txtnombre.Text,txtapellido.Text,DateTime.Parse(dtpnacimiento.Text),cbCat.Text,cbnivel.Text,cbfacultad.Text,DateTime.Parse(dtpFechareg.Text),txtcarrera.Text));
            dgprint.DataSource = null;
            dgprint.DataSource = Profe;
            limpiar();
        }

        private void btnbuscas_Click(object sender, EventArgs e)
        {
            Buscar.Clear();
            foreach (var S in Profe)
            {
                if (S.EOfacultad == cbbuscar.Text)
                {
                    Buscar.Add(S);
                }
            }
            dtencon.DataSource = null;
            dtencon.DataSource = Buscar;
        }
    }
}
