
namespace Arreglos_uni_demen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.btnguard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.Menors = new System.Windows.Forms.Button();
            this.mayor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de numeros a ingresar";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(222, 23);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(38, 23);
            this.txtTamaño.TabIndex = 1;
            // 
            // btnguard
            // 
            this.btnguard.Location = new System.Drawing.Point(301, 22);
            this.btnguard.Name = "btnguard";
            this.btnguard.Size = new System.Drawing.Size(75, 23);
            this.btnguard.TabIndex = 2;
            this.btnguard.Text = "Guardar";
            this.btnguard.UseVisualStyleBackColor = true;
            this.btnguard.Click += new System.EventHandler(this.btnguard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(160, 67);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 4;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(301, 67);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 5;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Menors
            // 
            this.Menors.Location = new System.Drawing.Point(277, 123);
            this.Menors.Name = "Menors";
            this.Menors.Size = new System.Drawing.Size(131, 23);
            this.Menors.TabIndex = 6;
            this.Menors.Text = "Mostrar Menor";
            this.Menors.UseVisualStyleBackColor = true;
            this.Menors.Click += new System.EventHandler(this.Menors_Click);
            // 
            // mayor
            // 
            this.mayor.Location = new System.Drawing.Point(54, 123);
            this.mayor.Name = "mayor";
            this.mayor.Size = new System.Drawing.Size(133, 23);
            this.mayor.TabIndex = 7;
            this.mayor.Text = "Mostrar Mayor";
            this.mayor.UseVisualStyleBackColor = true;
            this.mayor.Click += new System.EventHandler(this.mayor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 185);
            this.Controls.Add(this.mayor);
            this.Controls.Add(this.Menors);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguard);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Button btnguard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button Menors;
        private System.Windows.Forms.Button mayor;
    }
}

