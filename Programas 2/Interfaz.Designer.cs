
namespace Programas
{
    partial class Interfaz
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCalificaciones = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.PanelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TituloFormHijo = new System.Windows.Forms.Label();
            this.IconoFormHijoActual = new FontAwesome.Sharp.IconPictureBox();
            this.PanelShadow = new System.Windows.Forms.Panel();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.PanelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoFormHijoActual)).BeginInit();
            this.PanelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnCalificaciones);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 522);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalificaciones.FlatAppearance.BorderSize = 0;
            this.btnCalificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalificaciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalificaciones.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnCalificaciones.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCalificaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalificaciones.IconSize = 32;
            this.btnCalificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificaciones.Location = new System.Drawing.Point(0, 140);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCalificaciones.Size = new System.Drawing.Size(220, 60);
            this.btnCalificaciones.TabIndex = 1;
            this.btnCalificaciones.Text = "Maestros";
            this.btnCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalificaciones.UseVisualStyleBackColor = true;
            this.btnCalificaciones.Click += new System.EventHandler(this.btnCalificaciones_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.Image = global::Programas.Properties.Resources.icons8_cráneo_lindo_64;
            this.btnHome.Location = new System.Drawing.Point(47, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 134);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // PanelTitulo
            // 
            this.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PanelTitulo.Controls.Add(this.pictureBox3);
            this.PanelTitulo.Controls.Add(this.pictureBox2);
            this.PanelTitulo.Controls.Add(this.pictureBox1);
            this.PanelTitulo.Controls.Add(this.TituloFormHijo);
            this.PanelTitulo.Controls.Add(this.IconoFormHijoActual);
            this.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitulo.Location = new System.Drawing.Point(220, 0);
            this.PanelTitulo.Name = "PanelTitulo";
            this.PanelTitulo.Size = new System.Drawing.Size(532, 75);
            this.PanelTitulo.TabIndex = 1;
            this.PanelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TittleBar_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Programas.Properties.Resources.icons8_minimizar_la_ventana_32;
            this.pictureBox3.Location = new System.Drawing.Point(446, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Programas.Properties.Resources.icons8_maximizar_la_ventana_50;
            this.pictureBox2.Location = new System.Drawing.Point(475, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Programas.Properties.Resources.icons8_cerrar_ventana_50;
            this.pictureBox1.Location = new System.Drawing.Point(503, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TituloFormHijo
            // 
            this.TituloFormHijo.AutoSize = true;
            this.TituloFormHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.TituloFormHijo.Location = new System.Drawing.Point(75, 33);
            this.TituloFormHijo.Name = "TituloFormHijo";
            this.TituloFormHijo.Size = new System.Drawing.Size(32, 13);
            this.TituloFormHijo.TabIndex = 1;
            this.TituloFormHijo.Text = "Inicio";
            // 
            // IconoFormHijoActual
            // 
            this.IconoFormHijoActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconoFormHijoActual.ForeColor = System.Drawing.Color.MediumPurple;
            this.IconoFormHijoActual.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconoFormHijoActual.IconColor = System.Drawing.Color.MediumPurple;
            this.IconoFormHijoActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoFormHijoActual.Location = new System.Drawing.Point(37, 24);
            this.IconoFormHijoActual.Name = "IconoFormHijoActual";
            this.IconoFormHijoActual.Size = new System.Drawing.Size(32, 32);
            this.IconoFormHijoActual.TabIndex = 0;
            this.IconoFormHijoActual.TabStop = false;
            // 
            // PanelShadow
            // 
            this.PanelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.PanelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelShadow.Location = new System.Drawing.Point(220, 75);
            this.PanelShadow.Name = "PanelShadow";
            this.PanelShadow.Size = new System.Drawing.Size(532, 9);
            this.PanelShadow.TabIndex = 2;
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.PanelDesktop.Controls.Add(this.pictureBox4);
            this.PanelDesktop.Controls.Add(this.label1);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(220, 84);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(532, 438);
            this.PanelDesktop.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Programas.Properties.Resources.logo_uni;
            this.pictureBox4.Location = new System.Drawing.Point(89, 59);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(356, 303);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNIVERSIDAD NACIONAL DE INGENIERIA.";
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 522);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.PanelShadow);
            this.Controls.Add(this.PanelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Name = "Interfaz";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.PanelTitulo.ResumeLayout(false);
            this.PanelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconoFormHijoActual)).EndInit();
            this.PanelDesktop.ResumeLayout(false);
            this.PanelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnCalificaciones;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel PanelTitulo;
        private FontAwesome.Sharp.IconPictureBox IconoFormHijoActual;
        private System.Windows.Forms.Label TituloFormHijo;
        private System.Windows.Forms.Panel PanelShadow;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

