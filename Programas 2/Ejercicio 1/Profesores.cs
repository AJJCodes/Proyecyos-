using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas.Forms
{
    class Profesores
    {
        //Campos
        private string Nombres;
        private string Apellidos;
        private int Año;
        private string Sexo;

        public string EONombres
        {
            set { Nombres = value; }
            get { return Nombres; }
        }

        public string EOApellidos
        {
            set { Apellidos = value; }
            get { return Apellidos; }
        }

        public int EOAño
        {
            set { Año = value; }
            get { return Año; }
        }

        public int Edad(int N)
        {
            return DateTime.Now.Year - N;
        }

        public string EOSexo
        {
            set { Sexo = value; }
            get { return Sexo; }
        }

        public string Imprimir()
        {
            return Nombres + "\t" + Apellidos + "\t" + Sexo;
        }

        //Metodos

        public void Media(int suma, int promedio)
        {
            promedio = suma / promedio;
        }

        public void Menor(int Prueba2, int Pequeño, int i)
        {
            Pequeño = Prueba2;
        }

        public void Grande(int Prueba1, int Grande, int i)
        {
            Grande = Prueba1;
        }
    }
}
