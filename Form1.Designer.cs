namespace RoomFinder_1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Clock = new System.Windows.Forms.Label();
            this.TimeTick = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.room3Time = new System.Windows.Forms.Label();
            this.room2Time = new System.Windows.Forms.Label();
            this.room1Time = new System.Windows.Forms.Label();
            this.Room6 = new System.Windows.Forms.Button();
            this.Room5 = new System.Windows.Forms.Button();
            this.Room4 = new System.Windows.Forms.Button();
            this.Room3 = new System.Windows.Forms.Button();
            this.Room2 = new System.Windows.Forms.Button();
            this.Room1 = new System.Windows.Forms.Button();
            this.room4Time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1423, 20);
            this.panel1.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(1406, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(17, 20);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(20)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.Clock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1126, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 770);
            this.panel2.TabIndex = 1;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(82, 21);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(134, 32);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "00:00:00";
            // 
            // TimeTick
            // 
            this.TimeTick.Interval = 1000;
            this.TimeTick.Tick += new System.EventHandler(this.TimeTick_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.room4Time);
            this.panel3.Controls.Add(this.room3Time);
            this.panel3.Controls.Add(this.room2Time);
            this.panel3.Controls.Add(this.room1Time);
            this.panel3.Controls.Add(this.Room6);
            this.panel3.Controls.Add(this.Room5);
            this.panel3.Controls.Add(this.Room4);
            this.panel3.Controls.Add(this.Room3);
            this.panel3.Controls.Add(this.Room2);
            this.panel3.Controls.Add(this.Room1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1126, 770);
            this.panel3.TabIndex = 2;
            // 
            // room3Time
            // 
            this.room3Time.AutoSize = true;
            this.room3Time.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room3Time.Location = new System.Drawing.Point(752, 72);
            this.room3Time.Name = "room3Time";
            this.room3Time.Size = new System.Drawing.Size(135, 19);
            this.room3Time.TabIndex = 13;
            this.room3Time.Text = "Time: 00:00:00";
            // 
            // room2Time
            // 
            this.room2Time.AutoSize = true;
            this.room2Time.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room2Time.Location = new System.Drawing.Point(425, 72);
            this.room2Time.Name = "room2Time";
            this.room2Time.Size = new System.Drawing.Size(135, 19);
            this.room2Time.TabIndex = 12;
            this.room2Time.Text = "Time: 00:00:00";
            // 
            // room1Time
            // 
            this.room1Time.AutoSize = true;
            this.room1Time.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room1Time.Location = new System.Drawing.Point(95, 72);
            this.room1Time.Name = "room1Time";
            this.room1Time.Size = new System.Drawing.Size(135, 19);
            this.room1Time.TabIndex = 1;
            this.room1Time.Text = "Time: 00:00:00";
            // 
            // Room6
            // 
            this.Room6.Location = new System.Drawing.Point(756, 433);
            this.Room6.Name = "Room6";
            this.Room6.Size = new System.Drawing.Size(255, 197);
            this.Room6.TabIndex = 11;
            this.Room6.UseVisualStyleBackColor = true;
            // 
            // Room5
            // 
            this.Room5.Location = new System.Drawing.Point(429, 433);
            this.Room5.Name = "Room5";
            this.Room5.Size = new System.Drawing.Size(255, 197);
            this.Room5.TabIndex = 10;
            this.Room5.UseVisualStyleBackColor = true;
            // 
            // Room4
            // 
            this.Room4.Location = new System.Drawing.Point(99, 433);
            this.Room4.Name = "Room4";
            this.Room4.Size = new System.Drawing.Size(255, 197);
            this.Room4.TabIndex = 9;
            this.Room4.UseVisualStyleBackColor = true;
            this.Room4.Click += new System.EventHandler(this.Room4_Click);
            // 
            // Room3
            // 
            this.Room3.Location = new System.Drawing.Point(756, 94);
            this.Room3.Name = "Room3";
            this.Room3.Size = new System.Drawing.Size(255, 197);
            this.Room3.TabIndex = 8;
            this.Room3.UseVisualStyleBackColor = true;
            this.Room3.Click += new System.EventHandler(this.Room3_Click);
            // 
            // Room2
            // 
            this.Room2.Location = new System.Drawing.Point(429, 94);
            this.Room2.Name = "Room2";
            this.Room2.Size = new System.Drawing.Size(255, 197);
            this.Room2.TabIndex = 7;
            this.Room2.UseVisualStyleBackColor = true;
            this.Room2.Click += new System.EventHandler(this.Room2_Click);
            // 
            // Room1
            // 
            this.Room1.Location = new System.Drawing.Point(99, 94);
            this.Room1.Name = "Room1";
            this.Room1.Size = new System.Drawing.Size(255, 197);
            this.Room1.TabIndex = 6;
            this.Room1.UseVisualStyleBackColor = true;
            this.Room1.Click += new System.EventHandler(this.Room1_Click);
            // 
            // room4Time
            // 
            this.room4Time.AutoSize = true;
            this.room4Time.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room4Time.Location = new System.Drawing.Point(95, 411);
            this.room4Time.Name = "room4Time";
            this.room4Time.Size = new System.Drawing.Size(135, 19);
            this.room4Time.TabIndex = 14;
            this.room4Time.Text = "Time: 00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 790);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer TimeTick;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button Room6;
        public System.Windows.Forms.Button Room5;
        public System.Windows.Forms.Button Room4;
        public System.Windows.Forms.Button Room3;
        public System.Windows.Forms.Button Room2;
        public System.Windows.Forms.Button Room1;
        private System.Windows.Forms.Label room1Time;
        private System.Windows.Forms.Label room2Time;
        private System.Windows.Forms.Label room3Time;
        private System.Windows.Forms.Label room4Time;
    }
}

