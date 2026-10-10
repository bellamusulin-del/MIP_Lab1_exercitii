namespace Lab1_MIP_ex7
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
            this.buttonPiros = new System.Windows.Forms.Button();
            this.buttonKek = new System.Windows.Forms.Button();
            this.buttonFelkover = new System.Windows.Forms.Button();
            this.buttonDolt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAMPLE";
            // 
            // buttonPiros
            // 
            this.buttonPiros.Location = new System.Drawing.Point(632, 91);
            this.buttonPiros.Name = "buttonPiros";
            this.buttonPiros.Size = new System.Drawing.Size(117, 57);
            this.buttonPiros.TabIndex = 1;
            this.buttonPiros.Text = "PIROS";
            this.buttonPiros.UseVisualStyleBackColor = true;
            this.buttonPiros.Click += new System.EventHandler(this.buttonPiros_Click);
            // 
            // buttonKek
            // 
            this.buttonKek.Location = new System.Drawing.Point(632, 171);
            this.buttonKek.Name = "buttonKek";
            this.buttonKek.Size = new System.Drawing.Size(117, 55);
            this.buttonKek.TabIndex = 2;
            this.buttonKek.Text = "KEK";
            this.buttonKek.UseVisualStyleBackColor = true;
            this.buttonKek.Click += new System.EventHandler(this.buttonKek_Click);
            // 
            // buttonFelkover
            // 
            this.buttonFelkover.Location = new System.Drawing.Point(632, 243);
            this.buttonFelkover.Name = "buttonFelkover";
            this.buttonFelkover.Size = new System.Drawing.Size(117, 57);
            this.buttonFelkover.TabIndex = 3;
            this.buttonFelkover.Text = "BOLD";
            this.buttonFelkover.UseVisualStyleBackColor = true;
            this.buttonFelkover.Click += new System.EventHandler(this.buttonFelkovert_Click);
            // 
            // buttonDolt
            // 
            this.buttonDolt.Location = new System.Drawing.Point(632, 324);
            this.buttonDolt.Name = "buttonDolt";
            this.buttonDolt.Size = new System.Drawing.Size(117, 56);
            this.buttonDolt.TabIndex = 4;
            this.buttonDolt.Text = "DOLT";
            this.buttonDolt.UseVisualStyleBackColor = true;
            this.buttonDolt.Click += new System.EventHandler(this.buttonDolt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDolt);
            this.Controls.Add(this.buttonFelkover);
            this.Controls.Add(this.buttonKek);
            this.Controls.Add(this.buttonPiros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPiros;
        private System.Windows.Forms.Button buttonKek;
        private System.Windows.Forms.Button buttonFelkover;
        private System.Windows.Forms.Button buttonDolt;
    }
}

