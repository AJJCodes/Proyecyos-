
namespace Programas.Forms
{
    partial class Maestros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RBMujer = new System.Windows.Forms.RadioButton();
            this.RBHombre = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMayor = new System.Windows.Forms.Label();
            this.txtJoven = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbImprimir = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RBMujer);
            this.groupBox1.Controls.Add(this.RBHombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(9, 153);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFecha_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(9, 97);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 7;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(9, 53);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 6;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Elija Un sexo";
            // 
            // RBMujer
            // 
            this.RBMujer.AutoSize = true;
            this.RBMujer.Location = new System.Drawing.Point(111, 210);
            this.RBMujer.Name = "RBMujer";
            this.RBMujer.Size = new System.Drawing.Size(51, 17);
            this.RBMujer.TabIndex = 4;
            this.RBMujer.TabStop = true;
            this.RBMujer.Text = "Mujer";
            this.RBMujer.UseVisualStyleBackColor = true;
            // 
            // RBHombre
            // 
            this.RBHombre.AutoSize = true;
            this.RBHombre.Location = new System.Drawing.Point(9, 210);
            this.RBHombre.Name = "RBHombre";
            this.RBHombre.Size = new System.Drawing.Size(62, 17);
            this.RBHombre.TabIndex = 3;
            this.RBHombre.TabStop = true;
            this.RBHombre.Text = "Hombre";
            this.RBHombre.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año De Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMayor);
            this.groupBox2.Controls.Add(this.txtJoven);
            this.groupBox2.Controls.Add(this.txtMedia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cálculos";
            // 
            // txtMayor
            // 
            this.txtMayor.AutoSize = true;
            this.txtMayor.Location = new System.Drawing.Point(381, 66);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(0, 13);
            this.txtMayor.TabIndex = 5;
            // 
            // txtJoven
            // 
            this.txtJoven.AutoSize = true;
            this.txtJoven.Location = new System.Drawing.Point(206, 66);
            this.txtJoven.Name = "txtJoven";
            this.txtJoven.Size = new System.Drawing.Size(0, 13);
            this.txtJoven.TabIndex = 4;
            // 
            // txtMedia
            // 
            this.txtMedia.AutoSize = true;
            this.txtMedia.Location = new System.Drawing.Point(12, 67);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(0, 13);
            this.txtMedia.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Profesor Más Viejo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Profesor Más Joven";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Promedio De Edad";
            // 
            // lbImprimir
            // 
            this.lbImprimir.FormattingEnabled = true;
            this.lbImprimir.Location = new System.Drawing.Point(197, 25);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(201, 225);
            this.lbImprimir.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(411, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(411, 72);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(411, 101);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Maestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(242)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(516, 399);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Maestros";
            this.Text = "Maestros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RBMujer;
        private System.Windows.Forms.RadioButton RBHombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtMayor;
        private System.Windows.Forms.Label txtJoven;
        private System.Windows.Forms.Label txtMedia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbImprimir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCalcular;
    }
}