namespace WindowsFormsApp1
{
    partial class startPage
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
            this.Start = new System.Windows.Forms.Button();
            this.Playername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoStart = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.White;
            this.Start.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.Location = new System.Drawing.Point(107, 424);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(305, 99);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Playername
            // 
            this.Playername.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Playername.Location = new System.Drawing.Point(370, 244);
            this.Playername.Name = "Playername";
            this.Playername.Size = new System.Drawing.Size(304, 71);
            this.Playername.TabIndex = 1;
            this.Playername.Text = "Player1";
            this.Playername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(99, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(178, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 72);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gluttonous Snack";
            // 
            // AutoStart
            // 
            this.AutoStart.BackColor = System.Drawing.Color.White;
            this.AutoStart.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AutoStart.Location = new System.Drawing.Point(107, 569);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(305, 99);
            this.AutoStart.TabIndex = 4;
            this.AutoStart.Text = "Auto Start";
            this.AutoStart.UseVisualStyleBackColor = false;
            this.AutoStart.Click += new System.EventHandler(this.AutoStart_Click);
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.White;
            this.size.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.size.Location = new System.Drawing.Point(562, 424);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(211, 99);
            this.size.TabIndex = 5;
            this.size.Text = "Size";
            this.size.UseVisualStyleBackColor = false;
            this.size.Click += new System.EventHandler(this.Size_Click);
            // 
            // Record
            // 
            this.Record.BackColor = System.Drawing.Color.White;
            this.Record.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Record.Location = new System.Drawing.Point(562, 569);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(211, 99);
            this.Record.TabIndex = 6;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = false;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(418, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 7;
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 779);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.size);
            this.Controls.Add(this.AutoStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Playername);
            this.Controls.Add(this.Start);
            this.Name = "startPage";
            this.Text = "startPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Playername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AutoStart;
        private System.Windows.Forms.Button size;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Panel panel1;
    }
}