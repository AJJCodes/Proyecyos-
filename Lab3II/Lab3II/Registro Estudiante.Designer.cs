
namespace Lab3II
{
    partial class Registro_Estudiante
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
            this.btnIngresar1 = new System.Windows.Forms.Button();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbasignatura1 = new System.Windows.Forms.ComboBox();
            this.dtgcosas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbgrupos = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcosas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carné";
            // 
            // btnIngresar1
            // 
            this.btnIngresar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar1.Location = new System.Drawing.Point(12, 89);
            this.btnIngresar1.Name = "btnIngresar1";
            this.btnIngresar1.Size = new System.Drawing.Size(221, 41);
            this.btnIngresar1.TabIndex = 1;
            this.btnIngresar1.Text = "Ingresar";
            this.btnIngresar1.UseVisualStyleBackColor = true;
            this.btnIngresar1.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(6, 46);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(108, 23);
            this.txtCarnet.TabIndex = 2;
            // 
            // txtapellido1
            // 
            this.txtapellido1.Location = new System.Drawing.Point(234, 46);
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(108, 23);
            this.txtapellido1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(234, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // txtnombre1
            // 
            this.txtnombre1.Location = new System.Drawing.Point(120, 46);
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(108, 23);
            this.txtnombre1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(120, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(348, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asignatura";
            // 
            // cbasignatura1
            // 
            this.cbasignatura1.FormattingEnabled = true;
            this.cbasignatura1.Location = new System.Drawing.Point(348, 46);
            this.cbasignatura1.Name = "cbasignatura1";
            this.cbasignatura1.Size = new System.Drawing.Size(135, 23);
            this.cbasignatura1.TabIndex = 8;
            this.cbasignatura1.SelectedIndexChanged += new System.EventHandler(this.cbasignatura1_SelectedIndexChanged);
            // 
            // dtgcosas
            // 
            this.dtgcosas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcosas.Location = new System.Drawing.Point(12, 301);
            this.dtgcosas.Name = "dtgcosas";
            this.dtgcosas.RowTemplate.Height = 25;
            this.dtgcosas.Size = new System.Drawing.Size(975, 174);
            this.dtgcosas.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbgrupos);
            this.groupBox1.Controls.Add(this.cbasignatura1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnIngresar1);
            this.groupBox1.Controls.Add(this.txtnombre1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtapellido1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 254);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiante";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(489, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grupo";
            // 
            // cbgrupos
            // 
            this.cbgrupos.FormattingEnabled = true;
            this.cbgrupos.Location = new System.Drawing.Point(489, 46);
            this.cbgrupos.Name = "cbgrupos";
            this.cbgrupos.Size = new System.Drawing.Size(135, 23);
            this.cbgrupos.TabIndex = 9;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.Location = new System.Drawing.Point(239, 89);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(221, 41);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Volver";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Registro_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgcosas);
            this.Name = "Registro_Estudiante";
            this.Text = "Registro_Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dtgcosas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresar1;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbasignatura1;
        private System.Windows.Forms.DataGridView dtgcosas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbgrupos;
        private System.Windows.Forms.Button btnexit;
    }
}