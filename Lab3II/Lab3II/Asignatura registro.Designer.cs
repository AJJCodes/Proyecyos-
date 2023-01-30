
namespace Lab3II
{
    partial class Asignatura_registro
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
            this.txtasignaturas = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.dtgasignaturas = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgasignaturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignatura";
            // 
            // txtasignaturas
            // 
            this.txtasignaturas.Location = new System.Drawing.Point(9, 38);
            this.txtasignaturas.Name = "txtasignaturas";
            this.txtasignaturas.Size = new System.Drawing.Size(122, 23);
            this.txtasignaturas.TabIndex = 1;
            // 
            // btningresar
            // 
            this.btningresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btningresar.Location = new System.Drawing.Point(389, 25);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(145, 36);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // dtgasignaturas
            // 
            this.dtgasignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgasignaturas.Location = new System.Drawing.Point(6, 74);
            this.dtgasignaturas.Name = "dtgasignaturas";
            this.dtgasignaturas.RowTemplate.Height = 25;
            this.dtgasignaturas.Size = new System.Drawing.Size(782, 364);
            this.dtgasignaturas.TabIndex = 3;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.Location = new System.Drawing.Point(540, 25);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(145, 36);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Regresar";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtgrupo
            // 
            this.txtgrupo.Location = new System.Drawing.Point(147, 38);
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(122, 23);
            this.txtgrupo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(147, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grupo";
            // 
            // Asignatura_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgrupo);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dtgasignaturas);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtasignaturas);
            this.Controls.Add(this.label1);
            this.Name = "Asignatura_registro";
            this.Text = "Asignatura_registro";
            ((System.ComponentModel.ISupportInitialize)(this.dtgasignaturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtasignaturas;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.DataGridView dtgasignaturas;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.Label label2;
    }
}