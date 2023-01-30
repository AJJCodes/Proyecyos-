using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudiantes66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Estudiantes.Items.Add("Nombre"+"\t"+"Apellido"+"\t"+ "P.O.O"+"\t"+"Sociologia  "+"\t"+"Matematica"+"\t"+"Matematicas Discretas"+"\t");
        }

        void limpiar()
        {
            txtapellido.Clear();
            txtmate.Clear();
            txtmateD.Clear();
            txtnombre.Clear();
            txtpoo.Clear();
            txtSocio.Clear();
        }
        /*Contadores*/
        int contador;
        int i;
        int c;
        /*Aprovados */
        int P;
        int S;
        int MD;
        int M;
        //Reprovados
        int RP;
        int RS;
        int RMD;
        int RM;
        //Index stuff
        int indexP;
        int indexM;
        int indexS;
        int indexMD;
        //Pos del mas alto
        int IneMA;
        //acumuladores  de asignatura
        float PASIG1=0;/*POO*/
        float PASIG2 = 0;/*Sociologia*/
        float PASIG3 = 0;/*Matematica*/
        float PASIG4 = 0;/*Matematica Discreta*/
        /*Promedio por asignatura*/
        float P1;
        float P2;
        float P3;
        float P4;
        public struct Datos
        {
            public int poo;
            public int Sociologia;
            public int Matematica;
            public int MatematicaD;
            public string Nombre;
            public string Apellido;
            public float promedio;
        }

        Datos[] info;



        void Mejor()
        {
            int MejorP = info[0].poo;
            for (c = 0; c < info.Length; c++)
            {
                if (info[c].poo > MejorP)
                {
                    indexP = c;
                }
                int MejorM = info[0].Matematica;
                if (info[c].Matematica > MejorM)
                {
                    indexM = c;
                }
                int MejorS = info[0].Sociologia;
                if (info[c].Sociologia > MejorS)
                {
                    indexS = c;
                }
                int MejorMD = info[0].MatematicaD;
                if (info[c].MatematicaD > MejorMD)
                {
                    indexMD = c;
                }
            }
            MessageBox.Show("El mejor estudiante es en POO es: " + info[indexP].Nombre);
            MessageBox.Show("El mejor estudiante es en Sociologia es: " + info[indexS].Nombre);
            MessageBox.Show("El mejor estudiante es en Matematica es: " + info[indexM].Nombre);
            MessageBox.Show("El mejor estudiante es en Matematica Discreta es: " + info[indexMD].Nombre);
        }/*Final de esto*/

        void Repro_y_apro()
        {
            for (c = 0; c < info.Length; c++)
            {
                if (info[c].poo > 60)
                {
                    P++;
                }

                if (info[c].Sociologia > 60)
                {
                    S++;
                }

                if (info[c].Matematica > 60)
                {
                    M++;
                }

                if (info[c].MatematicaD > 60)
                {
                    MD++;
                }

                //Reprovados
                if (info[c].poo < 60)
                {
                    RP++;
                }

                if (info[c].Sociologia < 60)
                {
                    RS++;
                }

                if (info[c].Matematica < 60)
                {
                    RM++;
                }

                if (info[c].MatematicaD < 60)
                {
                    RMD++;
                }
            }
            MessageBox.Show("El numero de aprovados en P.O.O es: "+Convert.ToString(P));
            MessageBox.Show("El numero de reprovados en P.O.O es: " + Convert.ToString(RP));
            MessageBox.Show("El numero de aprovados en Sociologia es: " + Convert.ToString(S));
            MessageBox.Show("El numero de reprovados en Sociologia es: " + Convert.ToString(RS));
            MessageBox.Show("El numero de aprovados en Matematica es: " + Convert.ToString(M));
            MessageBox.Show("El numero de reprovados en Matematica es: " + Convert.ToString(RM));
            MessageBox.Show("El numero de aprovados en Matematicas Discretas es: " + Convert.ToString(MD));
            MessageBox.Show("El numero de reprovados en Matematica Discretas es: " + Convert.ToString(RMD));
        }/*Fin de esto*/

        void promedios()
        {
            for (c = 0; c < info.Length; c++)
            {
                info[c].promedio = info[c].poo + info[c].Sociologia + info[c].Matematica + info[i].MatematicaD / 4;
            }
        }/*fin de esto*/

        void promasalto()
        {
            //Promedio mas alto
            float Promas = info[0].promedio;
            for (c = 0; c < info.Length; c++)
            {
                if (info[0].promedio > Promas)
                {
                    IneMA = c;
                }
            }
            MessageBox.Show("El promedio mas alto lo tiene: " + info[IneMA].Nombre+"y es de: "+Promas);
        }/*Fin de esto*/

        void prom_asig()
        {
            for (c = 0; c < info.Length; c++)
            {
                contador++;/*Numero de estudiantes*/
            }

            for (c = 0; c < info.Length; c++)
            {
                PASIG1 = info[c].poo + PASIG1;
                PASIG2 = info[c].Sociologia + PASIG2;
                PASIG3 = info[c].Matematica + PASIG3;
                PASIG4 = info[c].MatematicaD + PASIG4;
            }
            /*Promedio*/
            P1 = PASIG1 / contador;
            P2 = PASIG2 / contador;
            P3 = PASIG3 / contador;
            P4 = PASIG4 / contador;
            MessageBox.Show("El promedio de la asignatura de P.O.O es: " + Convert.ToString(P1)+"\t"+
                "El promedio de la asignatura de Matematica es: "+Convert.ToString(P3)+"\t"+
                "El promedio de la asignatura de Sociologia es: "+Convert.ToString(P2)+"\t"+
                "El promedio de la asignatura de Matematicas Discretas es: "+Convert.ToString(P4));
        }/*Fin de esto*/
        private void btningresar_Click(object sender, EventArgs e)
        {
            /*Asignacion de cosas*/
            Array.Resize(ref info, i + 1);
            info[i].Nombre = txtnombre.Text;
            info[i].Apellido = txtapellido.Text;
            info[i].poo = int.Parse(txtpoo.Text);
            info[i].Sociologia = int.Parse(txtSocio.Text);
            info[i].Matematica = int.Parse(txtmate.Text);
            info[i].MatematicaD = int.Parse(txtmateD.Text);
            promedios();
            limpiar();
            i++;
        }

        private void btnmejoras_Click(object sender, EventArgs e)
        {
            Mejor();
        }

        private void btnreproa_Click(object sender, EventArgs e)
        {
            Repro_y_apro();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMJRE_Click(object sender, EventArgs e)
        {
            promasalto();
        }

        private void btnasigna_Click(object sender, EventArgs e)
        {
            prom_asig();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Estudiantes.Items.Clear();
            for (c = 0; c < info.Length; c++)
            {
                Estudiantes.Items.Add(info[c].Nombre+"\t"+info[c].Apellido+"\t"+info[c].poo+"\t"+info[c].Sociologia+"\t"+info[c].Matematica+"\t"+info[c].MatematicaD
                    +"\t"+info[c].promedio);
            }
        }
    }
}
