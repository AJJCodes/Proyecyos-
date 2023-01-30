using System;
using System.Collections.Generic;
using System.Text;

namespace Solexamen
{
    class Datos
    {
        private DateTime FechaRegistro;
        private string Carrera;
        public DateTime EoFecharegis
        {
            set {FechaRegistro=value;}
            get {return FechaRegistro;}
        }

        public string Eocarrera
        {
            set {Carrera=value;}
            get{return Carrera;}
        }
    }
}
