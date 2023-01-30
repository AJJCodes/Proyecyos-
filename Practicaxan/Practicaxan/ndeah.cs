using System;
using System.Collections.Generic;
using System.Text;

namespace Practicaxan
{
    class ndeah
    {
        private string nombre;
        private int ID;
        private DateTime edad;
        public static List<String> DataList = new List<String>();
        private List<int> Lista2 = new List<int>();//IDs
        //Metodo par añadir
        public void added(string n)
        {
            DataList.Add(n);
        }

        public string Eonombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public int EoID
        {
            set { ID = value; }
            get { return ID; }
        }

        public int Edad(int N)
        {
            return DateTime.Now.Year - N;
        }

        //Retornamos la lista
        public List<string> GetList()
        {
            return DataList;
        }

        public string finditem(string a)
        {
            if (DataList.Contains(a))
            {
                string lol = "Johnny";
                return lol;
            }
           return a;//Lo retorna si pasa a ser falso
        }
    }
}
