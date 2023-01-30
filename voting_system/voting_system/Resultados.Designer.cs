
namespace voting_system
{
    partial class Resultados
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
            this.Resul = new System.Windows.Forms.ListBox();
            this.votcont = new System.Windows.Forms.Button();
            this.btngan = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resul
            // 
            this.Resul.FormattingEnabled = true;
            this.Resul.ItemHeight = 15;
            this.Resul.Location = new System.Drawing.Point(214, 26);
            this.Resul.Name = "Resul";
            this.Resul.Size = new System.Drawing.Size(375, 259);
            this.Resul.TabIndex = 0;
            this.Resul.SelectedIndexChanged += new System.EventHandler(this.Resul_SelectedIndexChanged);
            // 
            // votcont
            // 
            this.votcont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.votcont.Location = new System.Drawing.Point(214, 316);
            this.votcont.Name = "votcont";
            this.votcont.Size = new System.Drawing.Size(163, 43);
            this.votcont.TabIndex = 3;
            this.votcont.Text = "Mostrar votos";
            this.votcont.UseVisualStyleBackColor = true;
            this.votcont.Click += new System.EventHandler(this.votcont_Click);
            // 
            // btngan
            // 
            this.btngan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btngan.Location = new System.Drawing.Point(439, 316);
            this.btngan.Name = "btngan";
            this.btngan.Size = new System.Drawing.Size(150, 43);
            this.btngan.TabIndex = 4;
            this.btngan.Text = "Mostrar Ganador";
            this.btngan.UseVisualStyleBackColor = true;
            this.btngan.Click += new System.EventHandler(this.button1_Click);
            // 
            // EXIT
            // 
            this.EXIT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EXIT.Location = new System.Drawing.Point(301, 389);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(212, 37);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "Salir";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.btngan);
            this.Controls.Add(this.votcont);
            this.Controls.Add(this.Resul);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Resul;
        private System.Windows.Forms.Button votcont;
        private System.Windows.Forms.Button btngan;
        private System.Windows.Forms.Button EXIT;
    }
}