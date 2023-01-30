
namespace Lab3II
{
    partial class Consultas_estudiante
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
            this.cbasignaturas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbnaños = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbgrupos = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.dtgestudiantecon = new System.Windows.Forms.DataGridView();
            this.lbestudiantesfc = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgestudiantecon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbasignaturas
            // 
            this.cbasignaturas.FormattingEnabled = true;
            this.cbasignaturas.Location = new System.Drawing.Point(12, 33);
            this.cbasignaturas.Name = "cbasignaturas";
            this.cbasignaturas.Size = new System.Drawing.Size(121, 23);
            this.cbasignaturas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año";
            // 
            // cbnaños
            // 
            this.cbnaños.FormattingEnabled = true;
            this.cbnaños.Location = new System.Drawing.Point(139, 33);
            this.cbnaños.Name = "cbnaños";
            this.cbnaños.Size = new System.Drawing.Size(121, 23);
            this.cbnaños.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grupo";
            // 
            // cbgrupos
            // 
            this.cbgrupos.FormattingEnabled = true;
            this.cbgrupos.Location = new System.Drawing.Point(266, 33);
            this.cbgrupos.Name = "cbgrupos";
            this.cbgrupos.Size = new System.Drawing.Size(121, 23);
            this.cbgrupos.TabIndex = 4;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbuscar.Location = new System.Drawing.Point(403, 33);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(87, 36);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.Location = new System.Drawing.Point(496, 33);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(87, 36);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Volver";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // dtgestudiantecon
            // 
            this.dtgestudiantecon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgestudiantecon.Location = new System.Drawing.Point(12, 100);
            this.dtgestudiantecon.Name = "dtgestudiantecon";
            this.dtgestudiantecon.RowTemplate.Height = 25;
            this.dtgestudiantecon.Size = new System.Drawing.Size(776, 338);
            this.dtgestudiantecon.TabIndex = 8;
            // 
            // lbestudiantesfc
            // 
            this.lbestudiantesfc.FormattingEnabled = true;
            this.lbestudiantesfc.ItemHeight = 15;
            this.lbestudiantesfc.Location = new System.Drawing.Point(811, 105);
            this.lbestudiantesfc.Name = "lbestudiantesfc";
            this.lbestudiantesfc.Size = new System.Drawing.Size(217, 334);
            this.lbestudiantesfc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(845, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estudiantes";
            // 
            // Consultas_estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbestudiantesfc);
            this.Controls.Add(this.dtgestudiantecon);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbgrupos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbnaños);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbasignaturas);
            this.Name = "Consultas_estudiante";
            this.Text = "Consultas_estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dtgestudiantecon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbasignaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbnaños;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbgrupos;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView dtgestudiantecon;
        private System.Windows.Forms.ListBox lbestudiantesfc;
        private System.Windows.Forms.Label label4;
    }
}