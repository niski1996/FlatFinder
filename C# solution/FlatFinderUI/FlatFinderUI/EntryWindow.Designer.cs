namespace FlatFinderUI
{
    partial class EntryWindow
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
            this.EWSearchButton = new System.Windows.Forms.Button();
            this.EWSeeSavedButton = new System.Windows.Forms.Button();
            this.EWWelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EWSearchButton
            // 
            this.EWSearchButton.Location = new System.Drawing.Point(78, 275);
            this.EWSearchButton.Name = "EWSearchButton";
            this.EWSearchButton.Size = new System.Drawing.Size(160, 20);
            this.EWSearchButton.TabIndex = 2;
            this.EWSearchButton.Text = "wyszukaj";
            this.EWSearchButton.UseVisualStyleBackColor = true;
            // 
            // EWSeeSavedButton
            // 
            this.EWSeeSavedButton.Location = new System.Drawing.Point(546, 275);
            this.EWSeeSavedButton.Name = "EWSeeSavedButton";
            this.EWSeeSavedButton.Size = new System.Drawing.Size(160, 20);
            this.EWSeeSavedButton.TabIndex = 3;
            this.EWSeeSavedButton.Text = "zobacz zapisane";
            this.EWSeeSavedButton.UseVisualStyleBackColor = true;
            // 
            // EWWelcomeLabel
            // 
            this.EWWelcomeLabel.AutoSize = true;
            this.EWWelcomeLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EWWelcomeLabel.Location = new System.Drawing.Point(13, 13);
            this.EWWelcomeLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.EWWelcomeLabel.Name = "EWWelcomeLabel";
            this.EWWelcomeLabel.Size = new System.Drawing.Size(35, 13);
            this.EWWelcomeLabel.TabIndex = 4;
            this.EWWelcomeLabel.Text = "label1";
            // 
            // EntryWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EWWelcomeLabel);
            this.Controls.Add(this.EWSeeSavedButton);
            this.Controls.Add(this.EWSearchButton);
            this.Name = "EntryWindow";
            this.Text = "FlatFinder";
            this.Load += new System.EventHandler(this.EntryWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EWSearchButton;
        private System.Windows.Forms.Button EWSeeSavedButton;
        private System.Windows.Forms.Label EWWelcomeLabel;
    }
}

