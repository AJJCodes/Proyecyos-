
namespace Solexamen
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
            this.dgprint = new System.Windows.Forms.DataGridView();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btncod = new System.Windows.Forms.Button();
            this.cbnivel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbfacultad = new System.Windows.Forms.ComboBox();
            this.dtpFechareg = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnbuscas = new System.Windows.Forms.Button();
            this.dtencon = new System.Windows.Forms.DataGridView();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprint)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtencon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgprint);
            this.tabPage1.Controls.Add(this.btnregistrar);
            this.tabPage1.Controls.Add(this.btncod);
            this.tabPage1.Controls.Add(this.cbnivel);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cbCat);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbfacultad);
            this.tabPage1.Controls.Add(this.dtpFechareg);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtpnacimiento);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtapellido);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcarrera);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgprint
            // 
            this.dgprint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprint.Location = new System.Drawing.Point(267, 21);
            this.dgprint.Name = "dgprint";
            this.dgprint.RowTemplate.Height = 25;
            this.dgprint.Size = new System.Drawing.Size(484, 390);
            this.dgprint.TabIndex = 21;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnregistrar.Location = new System.Drawing.Point(414, 426);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(184, 36);
            this.btnregistrar.TabIndex = 20;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btncod
            // 
            this.btncod.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncod.Location = new System.Drawing.Point(132, 26);
            this.btncod.Name = "btncod";
            this.btncod.Size = new System.Drawing.Size(83, 36);
            this.btncod.TabIndex = 19;
            this.btncod.Text = "Generar";
            this.btncod.UseVisualStyleBackColor = true;
            this.btncod.Click += new System.EventHandler(this.btncod_Click);
            // 
            // cbnivel
            // 
            this.cbnivel.FormattingEnabled = true;
            this.cbnivel.Location = new System.Drawing.Point(13, 439);
            this.cbnivel.Name = "cbnivel";
            this.cbnivel.Size = new System.Drawing.Size(138, 23);
            this.cbnivel.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nivel academico";
            // 
            // cbCat
            // 
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(13, 388);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(138, 23);
            this.cbCat.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Facultad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Categoria";
            // 
            // cbfacultad
            // 
            this.cbfacultad.FormattingEnabled = true;
            this.cbfacultad.Location = new System.Drawing.Point(13, 338);
            this.cbfacultad.Name = "cbfacultad";
            this.cbfacultad.Size = new System.Drawing.Size(138, 23);
            this.cbfacultad.TabIndex = 13;
            // 
            // dtpFechareg
            // 
            this.dtpFechareg.Location = new System.Drawing.Point(13, 288);
            this.dtpFechareg.Name = "dtpFechareg";
            this.dtpFechareg.Size = new System.Drawing.Size(224, 23);
            this.dtpFechareg.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de registro";
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.Location = new System.Drawing.Point(13, 238);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.Size = new System.Drawing.Size(224, 23);
            this.dtpnacimiento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(13, 135);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 23);
            this.txtapellido.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Carrera";
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(13, 184);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(100, 23);
            this.txtcarrera.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(13, 35);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 23);
            this.txtcodigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(13, 85);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnbuscas);
            this.tabPage2.Controls.Add(this.dtencon);
            this.tabPage2.Controls.Add(this.cbbuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnbuscas
            // 
            this.btnbuscas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbuscas.Location = new System.Drawing.Point(262, 40);
            this.btnbuscas.Name = "btnbuscas";
            this.btnbuscas.Size = new System.Drawing.Size(285, 31);
            this.btnbuscas.TabIndex = 2;
            this.btnbuscas.Text = "Buscar";
            this.btnbuscas.UseVisualStyleBackColor = true;
            this.btnbuscas.Click += new System.EventHandler(this.btnbuscas_Click);
            // 
            // dtencon
            // 
            this.dtencon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtencon.Location = new System.Drawing.Point(3, 80);
            this.dtencon.Name = "dtencon";
            this.dtencon.RowTemplate.Height = 25;
            this.dtencon.Size = new System.Drawing.Size(762, 416);
            this.dtencon.TabIndex = 1;
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Location = new System.Drawing.Point(19, 9);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(190, 23);
            this.cbbuscar.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprint)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtencon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgprint;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btncod;
        private System.Windows.Forms.ComboBox cbnivel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbfacultad;
        private System.Windows.Forms.DateTimePicker dtpFechareg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpnacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnbuscas;
        private System.Windows.Forms.DataGridView dtencon;
        private System.Windows.Forms.ComboBox cbbuscar;
    }
}

