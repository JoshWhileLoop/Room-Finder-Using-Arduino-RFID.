namespace RoomFinder_1
{
    partial class GetRFID
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
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.TeacherName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_yes
            // 
            this.btn_yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(117)))), ((int)(((byte)(27)))));
            this.btn_yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yes.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yes.Location = new System.Drawing.Point(191, 109);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(72, 35);
            this.btn_yes.TabIndex = 0;
            this.btn_yes.Text = "Yes";
            this.btn_yes.UseVisualStyleBackColor = false;
            this.btn_yes.Visible = false;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(143)))), ((int)(((byte)(56)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(275, 109);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(72, 35);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // TeacherName
            // 
            this.TeacherName.AutoSize = true;
            this.TeacherName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherName.Location = new System.Drawing.Point(29, 44);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(286, 46);
            this.TeacherName.TabIndex = 2;
            this.TeacherName.Text = "Hello Joven huhuhu\r\n Do you want to use this room?";
            this.TeacherName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetRFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(367, 157);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetRFID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetRFID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label TeacherName;
    }
}