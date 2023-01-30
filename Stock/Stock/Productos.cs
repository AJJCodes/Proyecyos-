using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stock
{
    public partial class Productos1 : Form
    {
        public Productos1()
        {
            InitializeComponent();
            Pros.Items.Add("Codigo" + "\t");
        }
        Cosas instancia;
        /*Cosas[] inventario;*/
        List<Cosas> lol = new List<Cosas>();/*Inicializacion de la lista*/
        int i;
   
        Eliminacion elim = new Eliminacion();/*Instancia de form eliminar*/

        void limpieza()
        {
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtmarca.Clear();
            txtprec_compra.Clear();
            txtprec_venta.Clear();
            txtmayoreo.Clear();
            txtmin.Clear();
            txtmax.Clear();
            txtexist.Clear();
            txtvenc.Clear();
        }

        void imprimir()
        {
            Pros.Items.Clear();
           /* for(i=0;i< inventario.Length; i++)
            {
                Pros.Items.Add(inventario[i].Codigos);
            }*/
           foreach(var Reg in lol)
            {
                Pros.Items.Add(Reg.imprimir());/*Impresion*/
            }
        }

       
        private void brnañadir_Click(object sender, EventArgs e)
        {
            //Array.Resize(ref inventario, i + 1);

            instancia = new Cosas();
            instancia.Codigos = int.Parse(txtcodigo.Text);
            /*instancia.Marcas = txtmarca.Text;
            instancia.Descripcion = txtdescripcion.Text;
            instancia.Precio_de_compra = float.Parse(txtprec_compra.Text);
            instancia.Precio_de_venta = float.Parse(txtprec_compra.Text);
            instancia.Precio_por_mayor = float.Parse(txtmayoreo.Text);
            instancia.Stock_actual = int.Parse(txtexist.Text);
            instancia.Stock_minimo = int.Parse(txtmin.Text); 
            instancia.Stock_maximo = int.Parse(txtmax.Text);*/
            lol.Add(instancia);/*añadimos a la lista*/
            i++;
            limpieza();
            
        }

        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //elim.Show();
            imprimir();
        }

    }
}
