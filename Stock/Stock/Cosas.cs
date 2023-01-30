using System;
using System.Collections.Generic;
using System.Text;

namespace Stock
{
    public class Cosas
    {
        private int Codigo;
        private string Name;
        private string Marca;
        private int FechaCad;
        //Precios
        private double PC;//Precio comppra
        private double PV;//Precio venta
        private double PMYR;//Precio mayoreo
        //stocks
        private int SMin;
        private int SMax;
        private int Sactual;

        //Obtencion de codigos
        public int Codigos
        {
            set { Codigo = value; }
            get { return Codigo; }
        }
        //Obtencion de descripcion

        public string Descripcion
        {
            set { Name = value;}
            get { return Name;}
        }
        //Obtencio de marcas
        public string Marcas
        {
            set { Marca = value; }
            get { return Marca; }
        }
        //Obtencion de Precio de venta , 1 unidad
        public double Precio_de_venta
        {
            set { PV = value; }
            get { return PV; }
        }
        //Precio de compra
        public double Precio_de_compra
        {
            set { PC = value; }
            get { return PC; }
        } 
        //Obtencion de precio de compra por mayor
        public double Precio_por_mayor
        {
            set {PMYR=value;}
            get {return PMYR;}
        }
        //Obtencion de stock minimo
        public int Stock_minimo
        {
            set { SMin=value; }
            get {return SMin; }
        }
        //obtencion Stock maximo
        public int Stock_maximo
        {
            set {SMax=value;}
            get {return SMax;}
        }
        //Obtencion de stock actual
        public int Stock_actual
        {
            set {Sactual=value;}
            get {return Sactual;}
        }
        //obtencion de Fecha de caducidad
        public int Fechas
        {
            set {FechaCad= value;}
            get {return FechaCad;}
        }

        public int Restarproducto(int Producs)
        {
            return Sactual - Producs;
        }

        public string imprimir()
        {
            return Codigo + "\t";
        }
    }
}
