
namespace Stock
{
    partial class Eliminacion
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
            this.txtcodigos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btneliminaral = new System.Windows.Forms.Button();
            this.Productosactual = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtcodigos
            // 
            this.txtcodigos.Location = new System.Drawing.Point(13, 50);
            this.txtcodigos.Name = "txtcodigos";
            this.txtcodigos.Size = new System.Drawing.Size(100, 23);
            this.txtcodigos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // btneliminaral
            // 
            this.btneliminaral.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btneliminaral.Location = new System.Drawing.Point(139, 39);
            this.btneliminaral.Name = "btneliminaral";
            this.btneliminaral.Size = new System.Drawing.Size(105, 34);
            this.btneliminaral.TabIndex = 3;
            this.btneliminaral.Text = "Eliminar";
            this.btneliminaral.UseVisualStyleBackColor = true;
            this.btneliminaral.Click += new System.EventHandler(this.btneliminaral_Click);
            // 
            // Productosactual
            // 
            this.Productosactual.FormattingEnabled = true;
            this.Productosactual.ItemHeight = 15;
            this.Productosactual.Location = new System.Drawing.Point(14, 94);
            this.Productosactual.Name = "Productosactual";
            this.Productosactual.Size = new System.Drawing.Size(714, 214);
            this.Productosactual.TabIndex = 4;
            // 
            // Eliminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Productosactual);
            this.Controls.Add(this.btneliminaral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcodigos);
            this.Name = "Eliminacion";
            this.Text = "Eliminacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneliminaral;
        private System.Windows.Forms.ListBox Productosactual;
    }
}