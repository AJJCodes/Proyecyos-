
namespace Lab3II
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsultas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEstudiante = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAsignatura = new System.Windows.Forms.Button();
            this.btnCondo = new System.Windows.Forms.Button();
            this.btnconsuestu = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultas
            // 
            this.btnConsultas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultas.Location = new System.Drawing.Point(6, 196);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(241, 45);
            this.btnConsultas.TabIndex = 0;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(328, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de consultas";
            // 
            // BtnEstudiante
            // 
            this.BtnEstudiante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEstudiante.Location = new System.Drawing.Point(7, 94);
            this.BtnEstudiante.Name = "BtnEstudiante";
            this.BtnEstudiante.Size = new System.Drawing.Size(241, 45);
            this.BtnEstudiante.TabIndex = 2;
            this.BtnEstudiante.Text = "Estudiante";
            this.BtnEstudiante.UseVisualStyleBackColor = true;
            this.BtnEstudiante.Click += new System.EventHandler(this.BtnEstudiante_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDocentes.Location = new System.Drawing.Point(7, 43);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(241, 45);
            this.btnDocentes.TabIndex = 3;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAsignatura);
            this.groupBox1.Controls.Add(this.btnDocentes);
            this.groupBox1.Controls.Add(this.btnConsultas);
            this.groupBox1.Controls.Add(this.BtnEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(5, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 256);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros";
            // 
            // BtnAsignatura
            // 
            this.BtnAsignatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAsignatura.Location = new System.Drawing.Point(7, 145);
            this.BtnAsignatura.Name = "BtnAsignatura";
            this.BtnAsignatura.Size = new System.Drawing.Size(241, 45);
            this.BtnAsignatura.TabIndex = 4;
            this.BtnAsignatura.Text = "Asignatura";
            this.BtnAsignatura.UseVisualStyleBackColor = true;
            this.BtnAsignatura.Click += new System.EventHandler(this.BtnAsignatura_Click);
            // 
            // btnCondo
            // 
            this.btnCondo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCondo.Location = new System.Drawing.Point(297, 40);
            this.btnCondo.Name = "btnCondo";
            this.btnCondo.Size = new System.Drawing.Size(241, 45);
            this.btnCondo.TabIndex = 5;
            this.btnCondo.Text = "Consultas docente";
            this.btnCondo.UseVisualStyleBackColor = true;
            this.btnCondo.Click += new System.EventHandler(this.btnCondo_Click);
            // 
            // btnconsuestu
            // 
            this.btnconsuestu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnconsuestu.Location = new System.Drawing.Point(297, 91);
            this.btnconsuestu.Name = "btnconsuestu";
            this.btnconsuestu.Size = new System.Drawing.Size(241, 45);
            this.btnconsuestu.TabIndex = 6;
            this.btnconsuestu.Text = "Consultas Estudiante";
            this.btnconsuestu.UseVisualStyleBackColor = true;
            this.btnconsuestu.Click += new System.EventHandler(this.btnconsuestu_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.SystemColors.Info;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsalir.Location = new System.Drawing.Point(297, 142);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(241, 45);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnconsuestu);
            this.Controls.Add(this.btnCondo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEstudiante;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAsignatura;
        private System.Windows.Forms.Button btnCondo;
        private System.Windows.Forms.Button btnconsuestu;
        private System.Windows.Forms.Button btnsalir;
    }
}

