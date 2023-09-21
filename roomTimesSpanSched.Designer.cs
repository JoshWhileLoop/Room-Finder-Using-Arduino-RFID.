namespace RoomFinder_1
{
    partial class roomTimesSpanSched
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_usethis = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.roomCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_usethis
            // 
            this.btn_usethis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(166)))), ((int)(((byte)(45)))));
            this.btn_usethis.FlatAppearance.BorderSize = 0;
            this.btn_usethis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_usethis.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usethis.Location = new System.Drawing.Point(297, 63);
            this.btn_usethis.Name = "btn_usethis";
            this.btn_usethis.Size = new System.Drawing.Size(77, 32);
            this.btn_usethis.TabIndex = 0;
            this.btn_usethis.Text = "use this";
            this.btn_usethis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_usethis.UseVisualStyleBackColor = false;
            this.btn_usethis.Visible = false;
            this.btn_usethis.Click += new System.EventHandler(this.btn_usethis_Click);
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(94, 31);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(200, 22);
            this.Clock.TabIndex = 1;
            this.Clock.Text = "00:00 pm - 00:00 pm";
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.Location = new System.Drawing.Point(20, 71);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(120, 22);
            this.teacher.TabIndex = 2;
            this.teacher.Text = "00:00 00:00";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(158, 7);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(73, 19);
            this.Status.TabIndex = 3;
            this.Status.Text = "Available";
            // 
            // roomCode
            // 
            this.roomCode.AutoSize = true;
            this.roomCode.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCode.Location = new System.Drawing.Point(316, 4);
            this.roomCode.Name = "roomCode";
            this.roomCode.Size = new System.Drawing.Size(30, 22);
            this.roomCode.TabIndex = 4;
            this.roomCode.Text = "00";
            this.roomCode.Visible = false;
            // 
            // roomTimesSpanSched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(190)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.roomCode);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.btn_usethis);
            this.Name = "roomTimesSpanSched";
            this.Size = new System.Drawing.Size(388, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_usethis;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Label teacher;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label roomCode;
    }
}
