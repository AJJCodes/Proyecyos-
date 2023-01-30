
namespace estudiantespromedio
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtmate = new System.Windows.Forms.TextBox();
            this.estudiante = new System.Windows.Forms.ListBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnpoo = new System.Windows.Forms.Button();
            this.btnsocio = new System.Windows.Forms.Button();
            this.btnmatD = new System.Windows.Forms.Button();
            this.EXITS = new System.Windows.Forms.Button();
            this.txtSociologia = new System.Windows.Forms.TextBox();
            this.txtPOO = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmatd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(59, 28);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 0;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(194, 28);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 23);
            this.txtapellido.TabIndex = 1;
            // 
            // txtmate
            // 
            this.txtmate.Location = new System.Drawing.Point(19, 28);
            this.txtmate.Name = "txtmate";
            this.txtmate.Size = new System.Drawing.Size(100, 23);
            this.txtmate.TabIndex = 2;
            // 
            // estudiante
            // 
            this.estudiante.FormattingEnabled = true;
            this.estudiante.ItemHeight = 15;
            this.estudiante.Location = new System.Drawing.Point(59, 143);
            this.estudiante.Name = "estudiante";
            this.estudiante.Size = new System.Drawing.Size(543, 109);
            this.estudiante.TabIndex = 4;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnimprimir.Location = new System.Drawing.Point(59, 85);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(111, 41);
            this.btnimprimir.TabIndex = 5;
            this.btnimprimir.Text = "Mostrar";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnagregar.Location = new System.Drawing.Point(194, 85);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(111, 41);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmate
            // 
            this.btnmate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmate.Location = new System.Drawing.Point(59, 276);
            this.btnmate.Name = "btnmate";
            this.btnmate.Size = new System.Drawing.Size(144, 36);
            this.btnmate.TabIndex = 7;
            this.btnmate.Text = "Matematicas";
            this.btnmate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(59, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Matematica";
            // 
            // btnpoo
            // 
            this.btnpoo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpoo.Location = new System.Drawing.Point(209, 276);
            this.btnpoo.Name = "btnpoo";
            this.btnpoo.Size = new System.Drawing.Size(144, 36);
            this.btnpoo.TabIndex = 11;
            this.btnpoo.Text = "P.O.O";
            this.btnpoo.UseVisualStyleBackColor = true;
            // 
            // btnsocio
            // 
            this.btnsocio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsocio.Location = new System.Drawing.Point(359, 276);
            this.btnsocio.Name = "btnsocio";
            this.btnsocio.Size = new System.Drawing.Size(144, 36);
            this.btnsocio.TabIndex = 12;
            this.btnsocio.Text = "Sociologia";
            this.btnsocio.UseVisualStyleBackColor = true;
            // 
            // btnmatD
            // 
            this.btnmatD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmatD.Location = new System.Drawing.Point(509, 276);
            this.btnmatD.Name = "btnmatD";
            this.btnmatD.Size = new System.Drawing.Size(142, 59);
            this.btnmatD.TabIndex = 13;
            this.btnmatD.Text = "Matematicas Discretas";
            this.btnmatD.UseVisualStyleBackColor = true;
            // 
            // EXITS
            // 
            this.EXITS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EXITS.Location = new System.Drawing.Point(282, 387);
            this.EXITS.Name = "EXITS";
            this.EXITS.Size = new System.Drawing.Size(144, 36);
            this.EXITS.TabIndex = 14;
            this.EXITS.Text = "Salir";
            this.EXITS.UseVisualStyleBackColor = true;
            this.EXITS.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSociologia
            // 
            this.txtSociologia.Location = new System.Drawing.Point(263, 28);
            this.txtSociologia.Name = "txtSociologia";
            this.txtSociologia.Size = new System.Drawing.Size(100, 23);
            this.txtSociologia.TabIndex = 15;
            // 
            // txtPOO
            // 
            this.txtPOO.Location = new System.Drawing.Point(140, 28);
            this.txtPOO.Name = "txtPOO";
            this.txtPOO.Size = new System.Drawing.Size(100, 23);
            this.txtPOO.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmatd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPOO);
            this.groupBox1.Controls.Add(this.txtSociologia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmate);
            this.groupBox1.Location = new System.Drawing.Point(334, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 123);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "P.O.O";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(263, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sociologia";
            // 
            // txtmatd
            // 
            this.txtmatd.Location = new System.Drawing.Point(369, 28);
            this.txtmatd.Name = "txtmatd";
            this.txtmatd.Size = new System.Drawing.Size(100, 23);
            this.txtmatd.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(378, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 63);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mat\r\nDiscreta\r\n ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EXITS);
            this.Controls.Add(this.btnmatD);
            this.Controls.Add(this.btnsocio);
            this.Controls.Add(this.btnpoo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmate);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.estudiante);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Name = "Form1";
            this.Text = "Sistema de notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtmate;
        private System.Windows.Forms.ListBox estudiante;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnpoo;
        private System.Windows.Forms.Button btnsocio;
        private System.Windows.Forms.Button btnmatD;
        private System.Windows.Forms.Button EXITS;
        private System.Windows.Forms.TextBox txtSociologia;
        private System.Windows.Forms.TextBox txtPOO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmatd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

