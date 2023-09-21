namespace RoomFinder_1
{
    partial class OpeningLoad
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
            this.LabelLoadText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelLoadText
            // 
            this.LabelLoadText.AutoSize = true;
            this.LabelLoadText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoadText.Location = new System.Drawing.Point(88, 65);
            this.LabelLoadText.Name = "LabelLoadText";
            this.LabelLoadText.Size = new System.Drawing.Size(72, 21);
            this.LabelLoadText.TabIndex = 0;
            this.LabelLoadText.Text = "Loading";
            // 
            // OpeningLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 151);
            this.Controls.Add(this.LabelLoadText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpeningLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpeningLoad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLoadText;
    }
}