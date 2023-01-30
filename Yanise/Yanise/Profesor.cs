using System;
using System.Collections.Generic;
using System.Text;

namespace Yanise
{
    class Profesor:Persona
    {
        private string Facultad;
        private double Salario;
        List<string> Lista = new List<string>();/*Declaramos lista*/
        /*Obtencion de facultad*/
        public string Faculty
        {
           set{Facultad=value;}
           get {return Facultad;}
        }
        /*Obtencion de salario*/
        public double Salary
        {
            set {Salario=value;}
            get {return Salario;}
        }
        /*Le devolvemos la lista*/
        public List<string> Olista()
        {
            return Lista;
        }

        /*Facultades de los profesores*/
        public  Profesor()
        {
            Lista.Add("FEC");
            Lista.Add("FARQ");
            Lista.Add("FIQ");
        }

    }
}
