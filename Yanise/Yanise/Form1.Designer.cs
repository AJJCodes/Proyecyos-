
namespace Yanise
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dgestudiante = new System.Windows.Forms.DataGridView();
            this.btningresarE = new System.Windows.Forms.Button();
            this.cbBeca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgprofesores = new System.Windows.Forms.DataGridView();
            this.btnIngresarP = new System.Windows.Forms.Button();
            this.cbfacultad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttelefonos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtañonacs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgestudiante)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprofesores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(790, 424);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dgestudiante);
            this.tabPage1.Controls.Add(this.btningresarE);
            this.tabPage1.Controls.Add(this.cbBeca);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtcarrera);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtapellido);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txttelefono);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtaño);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(782, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dgestudiante
            // 
            this.Dgestudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgestudiante.Location = new System.Drawing.Point(7, 159);
            this.Dgestudiante.Name = "Dgestudiante";
            this.Dgestudiante.RowTemplate.Height = 25;
            this.Dgestudiante.Size = new System.Drawing.Size(744, 150);
            this.Dgestudiante.TabIndex = 13;
            // 
            // btningresarE
            // 
            this.btningresarE.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btningresarE.Location = new System.Drawing.Point(308, 94);
            this.btningresarE.Name = "btningresarE";
            this.btningresarE.Size = new System.Drawing.Size(120, 39);
            this.btningresarE.TabIndex = 12;
            this.btningresarE.Text = "Ingresar";
            this.btningresarE.UseVisualStyleBackColor = true;
            this.btningresarE.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBeca
            // 
            this.cbBeca.FormattingEnabled = true;
            this.cbBeca.Location = new System.Drawing.Point(630, 35);
            this.cbBeca.Name = "cbBeca";
            this.cbBeca.Size = new System.Drawing.Size(121, 23);
            this.cbBeca.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(630, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Beca";
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(505, 35);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(100, 23);
            this.txtcarrera.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(505, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Carrera";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(132, 35);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 23);
            this.txtapellido.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(132, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(246, 35);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 23);
            this.txttelefono.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(246, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(380, 35);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(100, 23);
            this.txtaño.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(380, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año Nac";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(6, 35);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgprofesores);
            this.tabPage2.Controls.Add(this.btnIngresarP);
            this.tabPage2.Controls.Add(this.cbfacultad);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtSalario);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtapellidos);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txttelefonos);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtañonacs);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtnombres);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgprofesores
            // 
            this.dgprofesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprofesores.Location = new System.Drawing.Point(12, 170);
            this.dgprofesores.Name = "dgprofesores";
            this.dgprofesores.RowTemplate.Height = 25;
            this.dgprofesores.Size = new System.Drawing.Size(744, 150);
            this.dgprofesores.TabIndex = 27;
            // 
            // btnIngresarP
            // 
            this.btnIngresarP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarP.Location = new System.Drawing.Point(313, 105);
            this.btnIngresarP.Name = "btnIngresarP";
            this.btnIngresarP.Size = new System.Drawing.Size(120, 39);
            this.btnIngresarP.TabIndex = 26;
            this.btnIngresarP.Text = "Ingresar";
            this.btnIngresarP.UseVisualStyleBackColor = true;
            this.btnIngresarP.Click += new System.EventHandler(this.btnIngresarP_Click);
            // 
            // cbfacultad
            // 
            this.cbfacultad.FormattingEnabled = true;
            this.cbfacultad.Location = new System.Drawing.Point(635, 46);
            this.cbfacultad.Name = "cbfacultad";
            this.cbfacultad.Size = new System.Drawing.Size(121, 23);
            this.cbfacultad.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(635, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "Facultad";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(510, 46);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 23);
            this.txtSalario.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(510, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Salario";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(137, 46);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(100, 23);
            this.txtapellidos.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(137, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Apellido";
            // 
            // txttelefonos
            // 
            this.txttelefonos.Location = new System.Drawing.Point(251, 46);
            this.txttelefonos.Name = "txttelefonos";
            this.txttelefonos.Size = new System.Drawing.Size(100, 23);
            this.txttelefonos.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(251, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Telefono";
            // 
            // txtañonacs
            // 
            this.txtañonacs.Location = new System.Drawing.Point(385, 46);
            this.txtañonacs.Name = "txtañonacs";
            this.txtañonacs.Size = new System.Drawing.Size(100, 23);
            this.txtañonacs.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(385, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "Año Nac";
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(11, 46);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(100, 23);
            this.txtnombres.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(11, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgestudiante)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprofesores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Dgestudiante;
        private System.Windows.Forms.Button btningresarE;
        private System.Windows.Forms.ComboBox cbBeca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgprofesores;
        private System.Windows.Forms.Button btnIngresarP;
        private System.Windows.Forms.ComboBox cbfacultad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttelefonos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtañonacs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label12;
    }
}

