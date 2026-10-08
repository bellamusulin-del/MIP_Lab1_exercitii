namespace MIP_Lab1_ex1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.txt_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(585, 162);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 0;
            this.btn_down.Text = "DOWN";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(151, 162);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 1;
            this.btn_up.Text = "UP";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(369, 306);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(75, 23);
            this.btn_left.TabIndex = 2;
            this.btn_left.Text = "LEFT";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // txt_box
            // 
            this.txt_box.Location = new System.Drawing.Point(344, 163);
            this.txt_box.Name = "txt_box";
            this.txt_box.Size = new System.Drawing.Size(100, 22);
            this.txt_box.TabIndex = 3;
            this.txt_box.Text = "Hello World!";
            this.txt_box.TextChanged += new System.EventHandler(this.txt_box_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_box);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.btn_down);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.TextBox txt_box;
    }
}

