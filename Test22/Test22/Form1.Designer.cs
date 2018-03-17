namespace Test22
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
            this.On_btn = new System.Windows.Forms.Button();
            this.Off_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.On_btn2 = new System.Windows.Forms.Button();
            this.Off_btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // On_btn
            // 
            this.On_btn.Location = new System.Drawing.Point(131, 82);
            this.On_btn.Name = "On_btn";
            this.On_btn.Size = new System.Drawing.Size(75, 23);
            this.On_btn.TabIndex = 0;
            this.On_btn.Text = "ON";
            this.On_btn.UseVisualStyleBackColor = true;
            this.On_btn.Click += new System.EventHandler(this.On_btn_Click);
            // 
            // Off_btn
            // 
            this.Off_btn.Location = new System.Drawing.Point(392, 82);
            this.Off_btn.Name = "Off_btn";
            this.Off_btn.Size = new System.Drawing.Size(75, 23);
            this.Off_btn.TabIndex = 1;
            this.Off_btn.Text = "OFF";
            this.Off_btn.UseVisualStyleBackColor = true;
            this.Off_btn.Click += new System.EventHandler(this.Off_btn_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "COM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // On_btn2
            // 
            this.On_btn2.Location = new System.Drawing.Point(131, 179);
            this.On_btn2.Name = "On_btn2";
            this.On_btn2.Size = new System.Drawing.Size(75, 23);
            this.On_btn2.TabIndex = 4;
            this.On_btn2.Text = "ON";
            this.On_btn2.UseVisualStyleBackColor = true;
            this.On_btn2.Click += new System.EventHandler(this.On_btn2_Click);
            // 
            // Off_btn2
            // 
            this.Off_btn2.Location = new System.Drawing.Point(392, 179);
            this.Off_btn2.Name = "Off_btn2";
            this.Off_btn2.Size = new System.Drawing.Size(75, 23);
            this.Off_btn2.TabIndex = 5;
            this.Off_btn2.Text = "OFF";
            this.Off_btn2.UseVisualStyleBackColor = true;
            this.Off_btn2.Click += new System.EventHandler(this.Off_btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 258);
            this.Controls.Add(this.Off_btn2);
            this.Controls.Add(this.On_btn2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Off_btn);
            this.Controls.Add(this.On_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button On_btn;
        private System.Windows.Forms.Button Off_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button On_btn2;
        private System.Windows.Forms.Button Off_btn2;
    }
}

