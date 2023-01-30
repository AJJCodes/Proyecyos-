
namespace Lab3II
{
    partial class Consulta_Docente
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
            this.cbdocente = new System.Windows.Forms.ComboBox();
            this.cbañolec = new System.Windows.Forms.ComboBox();
            this.cbasignatura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbgrupo = new System.Windows.Forms.ComboBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dtgcosas = new System.Windows.Forms.DataGridView();
            this.Listboxfin = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcosas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Docente";
            // 
            // cbdocente
            // 
            this.cbdocente.FormattingEnabled = true;
            this.cbdocente.Location = new System.Drawing.Point(10, 39);
            this.cbdocente.Name = "cbdocente";
            this.cbdocente.Size = new System.Drawing.Size(121, 23);
            this.cbdocente.TabIndex = 1;
            // 
            // cbañolec
            // 
            this.cbañolec.FormattingEnabled = true;
            this.cbañolec.Location = new System.Drawing.Point(264, 39);
            this.cbañolec.Name = "cbañolec";
            this.cbañolec.Size = new System.Drawing.Size(121, 23);
            this.cbañolec.TabIndex = 2;
            // 
            // cbasignatura
            // 
            this.cbasignatura.FormattingEnabled = true;
            this.cbasignatura.Location = new System.Drawing.Point(137, 39);
            this.cbasignatura.Name = "cbasignatura";
            this.cbasignatura.Size = new System.Drawing.Size(121, 23);
            this.cbasignatura.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año lectivo";
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.texto.Location = new System.Drawing.Point(137, 9);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(93, 21);
            this.texto.TabIndex = 5;
            this.texto.Text = "Asignatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(391, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grupo";
            // 
            // cbgrupo
            // 
            this.cbgrupo.FormattingEnabled = true;
            this.cbgrupo.Location = new System.Drawing.Point(391, 39);
            this.cbgrupo.Name = "cbgrupo";
            this.cbgrupo.Size = new System.Drawing.Size(121, 23);
            this.cbgrupo.TabIndex = 6;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbuscar.Location = new System.Drawing.Point(518, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(128, 47);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.Location = new System.Drawing.Point(652, 26);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(128, 47);
            this.btnsalir.TabIndex = 9;
            this.btnsalir.Text = "Volver";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dtgcosas
            // 
            this.dtgcosas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcosas.Location = new System.Drawing.Point(10, 100);
            this.dtgcosas.Name = "dtgcosas";
            this.dtgcosas.RowTemplate.Height = 25;
            this.dtgcosas.Size = new System.Drawing.Size(778, 338);
            this.dtgcosas.TabIndex = 10;
            // 
            // Listboxfin
            // 
            this.Listboxfin.FormattingEnabled = true;
            this.Listboxfin.ItemHeight = 15;
            this.Listboxfin.Location = new System.Drawing.Point(823, 100);
            this.Listboxfin.Name = "Listboxfin";
            this.Listboxfin.Size = new System.Drawing.Size(263, 334);
            this.Listboxfin.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(897, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estudiantes";
            // 
            // Consulta_Docente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Listboxfin);
            this.Controls.Add(this.dtgcosas);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbgrupo);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbasignatura);
            this.Controls.Add(this.cbañolec);
            this.Controls.Add(this.cbdocente);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_Docente";
            this.Text = "Consulta_Docente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgcosas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbdocente;
        private System.Windows.Forms.ComboBox cbañolec;
        private System.Windows.Forms.ComboBox cbasignatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbgrupo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dtgcosas;
        private System.Windows.Forms.ListBox Listboxfin;
        private System.Windows.Forms.Label label3;
    }
}