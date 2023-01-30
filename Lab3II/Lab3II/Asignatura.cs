using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3II
{
    public class Asignatura
    {
        public List<int> Semestres = new List<int>();
        //List<Asignatura> Listasignaturas = new List<Asignatura>();
        public string OEasignatura { get; set; }
        public string OEgrupo { get; set; }
        public Asignatura(string ASIG,string Gru)
        {
            OEasignatura = ASIG;
            OEgrupo = Gru;
        }

        public Asignatura()
        {
            Semestres.Add(1);
            Semestres.Add(2);
        }

        public List<int> Olistasem
        {
            get { return Semestres; }
        }

    }
}
