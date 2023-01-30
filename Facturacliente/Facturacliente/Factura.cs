using System;
using System.Collections.Generic;
using System.Text;

namespace Facturacliente
{
    class Factura
    {
        private double total;
        private double Iva;
        private double totaliva;
        private int Nfactura;

        public Factura()
        {
            total = 0;
            Iva = 0.15;
            Random r = new Random();
            Nfactura = r.Next(0,100);
        }

        /*Aplicamos el polimorfismo*/
        /*Primer metdo para calcular el total*/
        public Factura(double Sub_Total)
        {
            total = 0;
            Iva = 0.15;
            Eototal =Sub_Total;
            totaliva = Iva * Sub_Total;
            total = Sub_Total + totaliva;
        }

        public int OEnumero
        {
            get {return Nfactura;}
        }

        public double Eototaliva
        {
            get {return totaliva;}
        }

        public double Eototal
        {
            set {total=value;}
            get {return total;}
        }

        public double EoIva
        {
            get {return Iva;}
        }

        /*Metodo 2 para calcular el total*/
        public void Calcular_total(double Sub_total)
        {
            totaliva = Iva * Sub_total;
            total = Sub_total + totaliva;
        }


    }
}
