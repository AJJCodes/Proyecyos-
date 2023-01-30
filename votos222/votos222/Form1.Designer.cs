
namespace votos222
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vot1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vot2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vot3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vot4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vot1,
            this.vot2,
            this.vot3,
            this.vot4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vot1
            // 
            this.vot1.Image = global::votos222.Properties.Resources._3;
            this.vot1.Name = "vot1";
            this.vot1.Size = new System.Drawing.Size(28, 35);
            this.vot1.Text = "I";
            this.vot1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // vot2
            // 
            this.vot2.Image = global::votos222.Properties.Resources._2;
            this.vot2.Name = "vot2";
            this.vot2.Size = new System.Drawing.Size(28, 35);
            this.vot2.Text = "II";
            this.vot2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // vot3
            // 
            this.vot3.Name = "vot3";
            this.vot3.Size = new System.Drawing.Size(28, 35);
            this.vot3.Text = "III";
            // 
            // vot4
            // 
            this.vot4.Name = "vot4";
            this.vot4.Size = new System.Drawing.Size(29, 35);
            this.vot4.Text = "IV";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(125, 35);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vot1;
        private System.Windows.Forms.ToolStripMenuItem vot2;
        private System.Windows.Forms.ToolStripMenuItem vot3;
        private System.Windows.Forms.ToolStripMenuItem vot4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}

