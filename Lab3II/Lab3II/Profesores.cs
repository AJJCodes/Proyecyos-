using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3II
{
    public class Profesores:Persona
    {
        //Parametros para obtener datos
        public int Añolectivo { get; set; }
        public string Semestre { get; set; }
        public string Grupo { get; set; }
        //Sobrecargado de datos
        public Profesores(string N,string A ,string Asig,int Año ,string S,string Grupos)
        {
            Nombre = N;
            Apellido = A;
            Asignatura = Asig;
            Añolectivo = Año;
            Semestre = S;
            Grupo = Grupos;
        }
    }
}
