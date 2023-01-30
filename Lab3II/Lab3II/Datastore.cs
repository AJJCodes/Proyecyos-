using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3II
{
    public static class Datastore
    {
        //Lista de las clases
        public static List<Estudiante> Listaestudiantes = new List<Estudiante>();
        public static List<Consulta> Listadeconsulta = new List<Consulta>();
        public static List<Profesores> Listaprofes = new List<Profesores>();
        public static List<Asignatura> Listasdeasignaturas = new List<Asignatura>();
        //de los forms
        public static Registro_Estudiante Restu = new Registro_Estudiante();
        public static Registro_Profe Reprofe = new Registro_Profe();
    }
}
