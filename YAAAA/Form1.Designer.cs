namespace YAAAA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FullscreenButton = new System.Windows.Forms.Button();
            this.SelectAreaButton = new System.Windows.Forms.Button();
            this.PrimaryScreenResLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FullscreenButton
            // 
            this.FullscreenButton.Location = new System.Drawing.Point(12, 12);
            this.FullscreenButton.Name = "FullscreenButton";
            this.FullscreenButton.Size = new System.Drawing.Size(75, 23);
            this.FullscreenButton.TabIndex = 0;
            this.FullscreenButton.Text = "Fullscreen";
            this.FullscreenButton.UseVisualStyleBackColor = true;
            // 
            // SelectAreaButton
            // 
            this.SelectAreaButton.Location = new System.Drawing.Point(93, 12);
            this.SelectAreaButton.Name = "SelectAreaButton";
            this.SelectAreaButton.Size = new System.Drawing.Size(75, 23);
            this.SelectAreaButton.TabIndex = 1;
            this.SelectAreaButton.Text = "Select Area";
            this.SelectAreaButton.UseVisualStyleBackColor = true;
            // 
            // PrimaryScreenResLabel
            // 
            this.PrimaryScreenResLabel.AutoSize = true;
            this.PrimaryScreenResLabel.Location = new System.Drawing.Point(12, 50);
            this.PrimaryScreenResLabel.Name = "PrimaryScreenResLabel";
            this.PrimaryScreenResLabel.Size = new System.Drawing.Size(38, 15);
            this.PrimaryScreenResLabel.TabIndex = 2;
            this.PrimaryScreenResLabel.Text = "PrimaryScreenResLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 74);
            this.Controls.Add(this.PrimaryScreenResLabel);
            this.Controls.Add(this.SelectAreaButton);
            this.Controls.Add(this.FullscreenButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "YAAAA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button FullscreenButton;
        private Button SelectAreaButton;
        private Label PrimaryScreenResLabel;
    }
}