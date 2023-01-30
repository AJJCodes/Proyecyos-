using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3II
{
    public class Estudiante:Persona
    {
        public string Carnet { get; set; }
        public string Grupo { get; set; }
        public Estudiante(string N,string A , string Asig,string Car,string GR)
        {
            Nombre = N;
            Apellido = A;
            Asignatura = Asig;
            Carnet = Car;
            Grupo = GR;
        }

    }
}
