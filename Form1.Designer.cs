namespace Lab1_MIP_ex6
{
    partial class Form1
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
            this.buttonFel = new System.Windows.Forms.Button();
            this.buttonLe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minta";
            // 
            // buttonFel
            // 
            this.buttonFel.Location = new System.Drawing.Point(337, 102);
            this.buttonFel.Name = "buttonFel";
            this.buttonFel.Size = new System.Drawing.Size(137, 69);
            this.buttonFel.TabIndex = 1;
            this.buttonFel.Text = "Fel";
            this.buttonFel.UseVisualStyleBackColor = true;
            this.buttonFel.Click += new System.EventHandler(this.buttonFel_Click);
            // 
            // buttonLe
            // 
            this.buttonLe.Location = new System.Drawing.Point(337, 255);
            this.buttonLe.Name = "buttonLe";
            this.buttonLe.Size = new System.Drawing.Size(143, 71);
            this.buttonLe.TabIndex = 2;
            this.buttonLe.Text = "Le";
            this.buttonLe.UseVisualStyleBackColor = true;
            this.buttonLe.Click += new System.EventHandler(this.buttonLe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLe);
            this.Controls.Add(this.buttonFel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFel;
        private System.Windows.Forms.Button buttonLe;
    }
}

