namespace WindowsFormsApp1
{
    partial class GamePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePage));
            this.button1 = new System.Windows.Forms.Button();
            this.mapString = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.手动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.snackLength = new System.Windows.Forms.Label();
            this.Pause = new System.Windows.Forms.Button();
            this.reach = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(688, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // mapString
            // 
            this.mapString.AutoSize = true;
            this.mapString.BackColor = System.Drawing.SystemColors.Window;
            this.mapString.Location = new System.Drawing.Point(72, 185);
            this.mapString.Name = "mapString";
            this.mapString.Size = new System.Drawing.Size(58, 24);
            this.mapString.TabIndex = 3;
            this.mapString.Text = "    ";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.难度ToolStripMenuItem,
            this.模式ToolStripMenuItem,
            this.ToolStripMenuItemRecords});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 48);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 难度ToolStripMenuItem
            // 
            this.难度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem4,
            this.sToolStripMenuItem3,
            this.sToolStripMenuItem2,
            this.sToolStripMenuItem,
            this.sToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.难度ToolStripMenuItem.Name = "难度ToolStripMenuItem";
            this.难度ToolStripMenuItem.Size = new System.Drawing.Size(82, 44);
            this.难度ToolStripMenuItem.Text = "难度";
            // 
            // sToolStripMenuItem4
            // 
            this.sToolStripMenuItem4.Name = "sToolStripMenuItem4";
            this.sToolStripMenuItem4.Size = new System.Drawing.Size(214, 44);
            this.sToolStripMenuItem4.Text = "0.1s";
            this.sToolStripMenuItem4.Click += new System.EventHandler(this.SToolStripMenuItem4_Click);
            // 
            // sToolStripMenuItem3
            // 
            this.sToolStripMenuItem3.Name = "sToolStripMenuItem3";
            this.sToolStripMenuItem3.Size = new System.Drawing.Size(214, 44);
            this.sToolStripMenuItem3.Text = "0.3s";
            this.sToolStripMenuItem3.Click += new System.EventHandler(this.SToolStripMenuItem3_Click);
            // 
            // sToolStripMenuItem2
            // 
            this.sToolStripMenuItem2.Name = "sToolStripMenuItem2";
            this.sToolStripMenuItem2.Size = new System.Drawing.Size(214, 44);
            this.sToolStripMenuItem2.Text = "0.5s";
            this.sToolStripMenuItem2.Click += new System.EventHandler(this.SToolStripMenuItem2_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.sToolStripMenuItem.Text = "1s";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.SToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem1
            // 
            this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            this.sToolStripMenuItem1.Size = new System.Drawing.Size(214, 44);
            this.sToolStripMenuItem1.Text = "2s";
            this.sToolStripMenuItem1.Click += new System.EventHandler(this.SToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(214, 44);
            this.toolStripMenuItem2.Text = "10*10";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(214, 44);
            this.toolStripMenuItem3.Text = "15*15";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(214, 44);
            this.toolStripMenuItem4.Text = "20*20";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // 模式ToolStripMenuItem
            // 
            this.模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAuto,
            this.手动ToolStripMenuItem});
            this.模式ToolStripMenuItem.Name = "模式ToolStripMenuItem";
            this.模式ToolStripMenuItem.Size = new System.Drawing.Size(82, 44);
            this.模式ToolStripMenuItem.Text = "模式";
            // 
            // ToolStripMenuItemAuto
            // 
            this.ToolStripMenuItemAuto.Name = "ToolStripMenuItemAuto";
            this.ToolStripMenuItemAuto.Size = new System.Drawing.Size(243, 44);
            this.ToolStripMenuItemAuto.Text = "自动寻路";
            this.ToolStripMenuItemAuto.Click += new System.EventHandler(this.ToolStripMenuItemAuto_Click);
            // 
            // 手动ToolStripMenuItem
            // 
            this.手动ToolStripMenuItem.Name = "手动ToolStripMenuItem";
            this.手动ToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.手动ToolStripMenuItem.Text = "手动开始";
            this.手动ToolStripMenuItem.Click += new System.EventHandler(this.手动ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemRecords
            // 
            this.ToolStripMenuItemRecords.Name = "ToolStripMenuItemRecords";
            this.ToolStripMenuItemRecords.Size = new System.Drawing.Size(82, 44);
            this.ToolStripMenuItemRecords.Text = "记录";
            this.ToolStripMenuItemRecords.Click += new System.EventHandler(this.ToolStripMenuItemRecords_Click);
            // 
            // snackLength
            // 
            this.snackLength.AutoSize = true;
            this.snackLength.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.snackLength.Location = new System.Drawing.Point(638, 258);
            this.snackLength.Name = "snackLength";
            this.snackLength.Size = new System.Drawing.Size(151, 41);
            this.snackLength.TabIndex = 8;
            this.snackLength.Text = "   Length";
            this.snackLength.Click += new System.EventHandler(this.SnackLength_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.SystemColors.Window;
            this.Pause.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pause.Location = new System.Drawing.Point(688, 554);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(155, 67);
            this.Pause.TabIndex = 9;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // reach
            // 
            this.reach.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reach.Location = new System.Drawing.Point(638, 344);
            this.reach.Name = "reach";
            this.reach.Size = new System.Drawing.Size(224, 99);
            this.reach.TabIndex = 11;
            this.reach.Text = "   Blocks";
            this.reach.Click += new System.EventHandler(this.Reach_Click);
            // 
            // playerName
            // 
            this.playerName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playerName.Location = new System.Drawing.Point(328, 77);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(178, 50);
            this.playerName.TabIndex = 12;
            this.playerName.Text = "player1";
            this.playerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(128, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Window;
            this.back.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back.Location = new System.Drawing.Point(690, 642);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(155, 117);
            this.back.TabIndex = 15;
            this.back.Text = "Back To Menu";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(874, 829);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.reach);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.snackLength);
            this.Controls.Add(this.mapString);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GamePage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "丑陋版贪吃蛇2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label mapString;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 难度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem3;
        private System.Windows.Forms.Label snackLength;
        private System.Windows.Forms.ToolStripMenuItem 模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAuto;
        private System.Windows.Forms.ToolStripMenuItem 手动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRecords;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem4;
        private System.Windows.Forms.Label reach;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button back;
    }
}