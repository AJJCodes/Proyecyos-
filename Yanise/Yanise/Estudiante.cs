using System;
using System.Collections.Generic;
using System.Text;

namespace Yanise
{
    class Estudiante:Persona/*Heredamos*/
    {
        private string Carrera;
        private string Beca;
        List<string> lista = new List<string>();

        public string EoCarrera
        {
            set {Carrera=value;}
            get {return Carrera;}
        }

        public string EoBeca
        {
            set {Beca=value;}
            get {return Beca;}
        }

        public  Estudiante()
        {
            lista.Add("A");
            lista.Add("B");
            lista.Add("C");
        }

        public List<string> Ollista()
        {
            return lista;
        }

    }
}
