using System;
using System.Collections.Generic;
using System.Text;

namespace Yanise
{
    public class Persona
    {
        private string nombre;
        private string Apellido;
        private int Telefono;
        private int Año;

        public string EoNombre
        {
            set {nombre=value;}
            get {return nombre;}
        }
        public string EOapellido
        {
            set {Apellido= value;}
            get {return Apellido;}
        }

        public int EoTelefono
        {
            set {Telefono=value;}
            get {return Telefono;}
        }

        public int Eoaño
        {
            set {Año=value;}
            get {return Año;}
        }

        public int Edad(int N)
        {
            return DateTime.Now.Year - N;
        }
    }
}
