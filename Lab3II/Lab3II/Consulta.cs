using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3II
{
    public class Consulta
    { 
        //Listas basicas
        public List<int> Semana = new List<int>();
        public List<string> Consuls = new List<string>();
        //Datos asignatura
        public int Horas_Consulta { get; set; }//La hora en que hizo la consulta
        public string Observaciones { get; set; }//obvio
        public string Tipoconsult { get; set; }//Tipo de consulta
        public string Temacons { get; set; }//Tema de la consulta importante
        public DateTime fechaconsul { get; set; }//Fecha de la consulta
        public int numseman { get; set; }/*numero de semana*/
        //Datos relacionados con el estudiante
        public string Carnets { get; set; }/*Carnet de estudiantes*/
        public string Estudiantecon { get; set; }/*Nombre del estudiante consultando*/
        public List<string>Consultadores { get; set; }


        //Datos de profesor
        public string Nombredocente { get; set; }
        public string apellidodocente { get; set; }
        public string asignaturadocente { get; set; }
        public int semendecon { get; set; }
        public string grupocon { get; set; }

        

        public Consulta()
        {
            //Añadimos i de 1 al 14
            int i;
            for (i = 1; i <= 14; i++)
            {
                Semana.Add(i);
            }
            
            //Esto too

            Consuls.Add("En linea");
            Consuls.Add("Presencial");
        }

        //Funciones que retornan
        public List<int> Olistasemana
        {
            get { return Semana; }
        }

        public List<string> Olistatipo
        {
            get { return Consuls;}
        }
        //Nombre profe,apellido,Asignatura de consulta
        //Año de consulta,Semestre de consulta , grupo de consulta
        //Nombre de estudiante de consulta ,carnet
        //Datos relacionados con la consulta
        //hora de consulta, observaciones ,tipo de consulta, Tema de consutla, numero de semana
        public Consulta(string NP, string AP, string ASP, DateTime FCS, int SEMC, string GC, List<string> EC, int Hora, string Obs, string tipo, string Tema, int Semana)
        {
            Nombredocente = NP; apellidodocente = AP;
            asignaturadocente = ASP;/*Importante*/
            semendecon = SEMC; grupocon = GC;
            Consultadores = EC;//Carnets=Carne;
            fechaconsul = FCS;
            //lol
            Horas_Consulta = Hora; Observaciones = Obs;
            Tipoconsult = tipo;
            Temacons = Tema;
            numseman = Semana;

        }
    }
}
