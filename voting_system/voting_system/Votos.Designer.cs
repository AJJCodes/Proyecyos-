
namespace voting_system
{
    partial class Votos
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
            this.cbbachis = new System.Windows.Forms.ComboBox();
            this.votcont = new System.Windows.Forms.Button();
            this.Candis = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbachis
            // 
            this.cbbachis.FormattingEnabled = true;
            this.cbbachis.Location = new System.Drawing.Point(41, 26);
            this.cbbachis.Name = "cbbachis";
            this.cbbachis.Size = new System.Drawing.Size(121, 23);
            this.cbbachis.TabIndex = 0;
            // 
            // votcont
            // 
            this.votcont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.votcont.Location = new System.Drawing.Point(41, 141);
            this.votcont.Name = "votcont";
            this.votcont.Size = new System.Drawing.Size(121, 43);
            this.votcont.TabIndex = 2;
            this.votcont.Text = "Votar";
            this.votcont.UseVisualStyleBackColor = true;
            this.votcont.Click += new System.EventHandler(this.button1_Click);
            // 
            // Candis
            // 
            this.Candis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Candis.Location = new System.Drawing.Point(201, 26);
            this.Candis.Name = "Candis";
            this.Candis.Size = new System.Drawing.Size(121, 43);
            this.Candis.TabIndex = 3;
            this.Candis.Text = "Candidatos";
            this.Candis.UseVisualStyleBackColor = true;
            this.Candis.Click += new System.EventHandler(this.Candis_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(201, 249);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(121, 43);
            this.exit.TabIndex = 4;
            this.exit.Text = "Volver";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Votos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Candis);
            this.Controls.Add(this.votcont);
            this.Controls.Add(this.cbbachis);
            this.Name = "Votos";
            this.Text = "Votos";
            this.Load += new System.EventHandler(this.Votos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbachis;
        private System.Windows.Forms.Button votcont;
        private System.Windows.Forms.Button Candis;
        private System.Windows.Forms.Button exit;
    }
}