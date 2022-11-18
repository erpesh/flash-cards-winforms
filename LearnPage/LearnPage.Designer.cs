namespace FlashCards.LearnPage
{
    partial class LearnPage
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
            this.cardBg = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cardBg
            // 
            this.cardBg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cardBg.Location = new System.Drawing.Point(192, 78);
            this.cardBg.Name = "cardBg";
            this.cardBg.Size = new System.Drawing.Size(533, 335);
            this.cardBg.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(287, 226);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 38);
            this.lblText.TabIndex = 1;
            // 
            // LearnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.cardBg);
            this.Name = "LearnPage";
            this.Size = new System.Drawing.Size(952, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cardBg;
        private Label lblText;
    }
}
