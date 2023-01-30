
namespace Lab3II
{
    partial class Registro_Profe
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtañolect = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtapell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbsemestre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btningresarr = new System.Windows.Forms.Button();
            this.dtgprofesores = new System.Windows.Forms.DataGridView();
            this.cbasignatura = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbgrupo = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgprofesores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(11, 34);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(104, 23);
            this.txtnombre.TabIndex = 1;
            // 
            // txtañolect
            // 
            this.txtañolect.Location = new System.Drawing.Point(231, 34);
            this.txtañolect.Name = "txtañolect";
            this.txtañolect.Size = new System.Drawing.Size(104, 23);
            this.txtañolect.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(231, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año lectivo";
            // 
            // txtapell
            // 
            this.txtapell.Location = new System.Drawing.Point(121, 34);
            this.txtapell.Name = "txtapell";
            this.txtapell.Size = new System.Drawing.Size(104, 23);
            this.txtapell.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(121, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(484, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Semestre";
            // 
            // cbsemestre
            // 
            this.cbsemestre.FormattingEnabled = true;
            this.cbsemestre.Location = new System.Drawing.Point(484, 34);
            this.cbsemestre.Name = "cbsemestre";
            this.cbsemestre.Size = new System.Drawing.Size(121, 23);
            this.cbsemestre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(611, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grupo";
            // 
            // btningresarr
            // 
            this.btningresarr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btningresarr.Location = new System.Drawing.Point(9, 77);
            this.btningresarr.Name = "btningresarr";
            this.btningresarr.Size = new System.Drawing.Size(185, 42);
            this.btningresarr.TabIndex = 10;
            this.btningresarr.Text = "ingresar";
            this.btningresarr.UseVisualStyleBackColor = true;
            this.btningresarr.Click += new System.EventHandler(this.btningresarr_Click);
            // 
            // dtgprofesores
            // 
            this.dtgprofesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgprofesores.Location = new System.Drawing.Point(9, 138);
            this.dtgprofesores.Name = "dtgprofesores";
            this.dtgprofesores.RowTemplate.Height = 25;
            this.dtgprofesores.Size = new System.Drawing.Size(723, 280);
            this.dtgprofesores.TabIndex = 11;
            // 
            // cbasignatura
            // 
            this.cbasignatura.FormattingEnabled = true;
            this.cbasignatura.Location = new System.Drawing.Point(357, 34);
            this.cbasignatura.Name = "cbasignatura";
            this.cbasignatura.Size = new System.Drawing.Size(121, 23);
            this.cbasignatura.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(359, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Asignatura";
            // 
            // cbgrupo
            // 
            this.cbgrupo.FormattingEnabled = true;
            this.cbgrupo.Location = new System.Drawing.Point(611, 34);
            this.cbgrupo.Name = "cbgrupo";
            this.cbgrupo.Size = new System.Drawing.Size(121, 23);
            this.cbgrupo.TabIndex = 14;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.Location = new System.Drawing.Point(211, 77);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(189, 42);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "Volver";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Registro_Profe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.cbgrupo);
            this.Controls.Add(this.cbasignatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgprofesores);
            this.Controls.Add(this.btningresarr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbsemestre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtapell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtañolect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "Registro_Profe";
            this.Text = "Registro_Profe";
            ((System.ComponentModel.ISupportInitialize)(this.dtgprofesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtañolect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtapell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbsemestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btningresarr;
        private System.Windows.Forms.DataGridView dtgprofesores;
        private System.Windows.Forms.ComboBox cbasignatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbgrupo;
        private System.Windows.Forms.Button btnexit;
    }
}