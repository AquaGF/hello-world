namespace rex2
{
    partial class Form2
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
            this.Rights = new System.Windows.Forms.Label();
            this.Wrongs = new System.Windows.Forms.Label();
            this.StarsPlused = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rights
            // 
            this.Rights.AutoSize = true;
            this.Rights.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rights.Location = new System.Drawing.Point(28, 63);
            this.Rights.Name = "Rights";
            this.Rights.Size = new System.Drawing.Size(70, 28);
            this.Rights.TabIndex = 0;
            this.Rights.Text = "Right:";
            // 
            // Wrongs
            // 
            this.Wrongs.AutoSize = true;
            this.Wrongs.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wrongs.Location = new System.Drawing.Point(28, 91);
            this.Wrongs.Name = "Wrongs";
            this.Wrongs.Size = new System.Drawing.Size(84, 28);
            this.Wrongs.TabIndex = 0;
            this.Wrongs.Text = "Wrong:";
            // 
            // StarsPlused
            // 
            this.StarsPlused.AutoSize = true;
            this.StarsPlused.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarsPlused.Location = new System.Drawing.Point(28, 119);
            this.StarsPlused.Name = "StarsPlused";
            this.StarsPlused.Size = new System.Drawing.Size(152, 28);
            this.StarsPlused.TabIndex = 0;
            this.StarsPlused.Text = "Stars Added : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StarsPlused);
            this.Controls.Add(this.Wrongs);
            this.Controls.Add(this.Rights);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rights;
        private System.Windows.Forms.Label Wrongs;
        private System.Windows.Forms.Label StarsPlused;
        private System.Windows.Forms.Button button1;
    }
}