
namespace estudiantespromedio
{
    partial class Matematicas
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
            this.maths = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MejorE = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pasados = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maths
            // 
            this.maths.FormattingEnabled = true;
            this.maths.ItemHeight = 15;
            this.maths.Location = new System.Drawing.Point(12, 27);
            this.maths.Name = "maths";
            this.maths.Size = new System.Drawing.Size(443, 94);
            this.maths.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(574, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mejores estudiante";
            // 
            // MejorE
            // 
            this.MejorE.FormattingEnabled = true;
            this.MejorE.ItemHeight = 15;
            this.MejorE.Location = new System.Drawing.Point(543, 33);
            this.MejorE.Name = "MejorE";
            this.MejorE.Size = new System.Drawing.Size(245, 94);
            this.MejorE.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aprobados";
            // 
            // Pasados
            // 
            this.Pasados.FormattingEnabled = true;
            this.Pasados.ItemHeight = 15;
            this.Pasados.Location = new System.Drawing.Point(12, 188);
            this.Pasados.Name = "Pasados";
            this.Pasados.Size = new System.Drawing.Size(443, 94);
            this.Pasados.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(543, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reprobados";
            // 
            // Matematicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pasados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MejorE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maths);
            this.Name = "Matematicas";
            this.Text = "Matematicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox maths;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox MejorE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Pasados;
        private System.Windows.Forms.Label label4;
    }
}