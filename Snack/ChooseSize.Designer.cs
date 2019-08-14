namespace WindowsFormsApp1
{
    partial class ChooseSize
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
            this.size1 = new System.Windows.Forms.Button();
            this.size2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // size1
            // 
            this.size1.BackColor = System.Drawing.Color.White;
            this.size1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.size1.Location = new System.Drawing.Point(135, 0);
            this.size1.Name = "size1";
            this.size1.Size = new System.Drawing.Size(211, 99);
            this.size1.TabIndex = 6;
            this.size1.Text = "10*10";
            this.size1.UseVisualStyleBackColor = false;
            this.size1.Click += new System.EventHandler(this.Size1_Click);
            // 
            // size2
            // 
            this.size2.BackColor = System.Drawing.Color.White;
            this.size2.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.size2.Location = new System.Drawing.Point(135, 105);
            this.size2.Name = "size2";
            this.size2.Size = new System.Drawing.Size(211, 99);
            this.size2.TabIndex = 7;
            this.size2.Text = "15*15";
            this.size2.UseVisualStyleBackColor = false;
            this.size2.Click += new System.EventHandler(this.Size2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(135, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 99);
            this.button2.TabIndex = 8;
            this.button2.Text = "20*20";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ChooseSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(374, 329);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.size2);
            this.Controls.Add(this.size1);
            this.Name = "ChooseSize";
            this.Text = "ChooseSize";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button size1;
        private System.Windows.Forms.Button size2;
        private System.Windows.Forms.Button button2;
    }
}