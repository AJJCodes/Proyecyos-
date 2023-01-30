using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; //Libreria de iconos  
using Programas.Forms; //Llamado de los demas forms

namespace Programas
{
    public partial class Interfaz : Form
       
    {

        //Campos Privado 

        private IconButton BotonActual; //Almacena Boton Actual ......
        private Panel BotonBordeIzquierdo;   //Borde Izquiero al boton.....
        private Form FormHijoActual;

        //constructor
        public Interfaz()
        { 
            InitializeComponent();

            BotonBordeIzquierdo = new Panel(); //Inicializacion BordeIzquierdo del Boton
            BotonBordeIzquierdo.Size = new Size(7,60);
            panelMenu.Controls.Add(BotonBordeIzquierdo); //Agregamos el Panel a los botones

            //Quitar barra de for y reducir parpadeo

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true; // Quitar movimiento statico

            //Limite del maximizado
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structura que almacena colores RGB
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24,161,251);

        }

        //Metodos

        private void BotonActivo(object senderBtn, Color color) //Tipo Vacio
        {
            if(senderBtn != null)
            {
                DesactResaltadoBtn();

                //Personalizacion del boton
                BotonActual = (IconButton)senderBtn; //Covertimos Obj al mismo tipo del btn
                BotonActual.BackColor = Color.FromArgb(37, 36, 81);
                BotonActual.ForeColor = color;
                BotonActual.TextAlign = ContentAlignment.MiddleCenter;
                BotonActual.IconColor = color;
                BotonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                BotonActual.ImageAlign = ContentAlignment.MiddleCenter;

                //Borde izquierdo del Boton
                BotonBordeIzquierdo.BackColor = color;
                BotonBordeIzquierdo.Location = new Point(0, BotonActual.Location.Y);
                BotonBordeIzquierdo.Visible = true;
                BotonBordeIzquierdo.BringToFront(); //Mostrar en el frente

                //Icocono Form Hijo actual
                IconoFormHijoActual.IconChar = BotonActual.IconChar;
                IconoFormHijoActual.IconColor = color;
            }
        }

        private void DesactResaltadoBtn()
        {
            if(BotonActual != null)
            {
                //Reotrnamos valores por defecto
                BotonActual.BackColor = Color.FromArgb(31, 30, 68);
                BotonActual.ForeColor = Color.Gainsboro;
                BotonActual.TextAlign = ContentAlignment.MiddleLeft;
                BotonActual.IconColor = Color.Gainsboro;
                BotonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                BotonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        //Pasar de un form a otro
        private void AbrirFormHijo(Form FormHijo)
        {
            if(FormHijoActual != null)
            {
                //Abrir solo un formulario
                FormHijoActual.Close();
            }
            FormHijoActual = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(FormHijo);
            PanelDesktop.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            TituloFormHijo.Text = FormHijo.Text;
        }
        //Botones con evento click
        private void btnCalificaciones_Click(object sender, EventArgs e)
        {          
            BotonActivo(sender, RGBColors.color1);
            AbrirFormHijo(new Maestros());
           
        }      
       
        private void btnHome_Click(object sender, EventArgs e)
        {
            FormHijoActual.Close();
            Reset();
        }

        private void Reset()
        {
            //Oculta visibilidad del borde izquierdo del boton
            DesactResaltadoBtn();
            BotonBordeIzquierdo.Visible = false;
            IconoFormHijoActual.IconChar = IconChar.Home;
            IconoFormHijoActual.IconColor = Color.MediumPurple;
            TituloFormHijo.Text = "Home";
        }

        //Movilidad del mouse
        //Librerias nativas de windows

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam,
            int lParam);

        private void TittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Boton cerrar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton maximinizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        //Boton Minimizar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }

        
    }
}
