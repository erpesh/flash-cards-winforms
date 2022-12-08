namespace FlashCards.Pages.TestPage
{
    partial class TestSettings
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
            this.nudNumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbUseUnstarred = new System.Windows.Forms.CheckBox();
            this.cbStarCorrect = new System.Windows.Forms.CheckBox();
            this.cbUseTimer = new System.Windows.Forms.CheckBox();
            this.nudTimeInMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeInMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumberOfQuestions
            // 
            this.nudNumberOfQuestions.Location = new System.Drawing.Point(26, 71);
            this.nudNumberOfQuestions.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumberOfQuestions.Name = "nudNumberOfQuestions";
            this.nudNumberOfQuestions.Size = new System.Drawing.Size(55, 27);
            this.nudNumberOfQuestions.TabIndex = 0;
            this.nudNumberOfQuestions.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumberOfQuestions.ValueChanged += new System.EventHandler(this.nudNumberOfQuestions_ValueChanged);
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(97, 71);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(196, 28);
            this.lblNumberOfQuestions.TabIndex = 1;
            this.lblNumberOfQuestions.Text = "Number of questions";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormTitle.Location = new System.Drawing.Point(74, 20);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(153, 35);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = "Test Settings";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(18, 289);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(282, 47);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbUseUnstarred
            // 
            this.cbUseUnstarred.AutoSize = true;
            this.cbUseUnstarred.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbUseUnstarred.Location = new System.Drawing.Point(26, 161);
            this.cbUseUnstarred.Name = "cbUseUnstarred";
            this.cbUseUnstarred.Size = new System.Drawing.Size(248, 32);
            this.cbUseUnstarred.TabIndex = 7;
            this.cbUseUnstarred.Text = "Use only unstarred cards";
            this.cbUseUnstarred.UseVisualStyleBackColor = true;
            this.cbUseUnstarred.CheckedChanged += new System.EventHandler(this.cbUseStarred_CheckedChanged);
            // 
            // cbStarCorrect
            // 
            this.cbStarCorrect.AutoSize = true;
            this.cbStarCorrect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStarCorrect.Location = new System.Drawing.Point(26, 114);
            this.cbStarCorrect.Name = "cbStarCorrect";
            this.cbStarCorrect.Size = new System.Drawing.Size(230, 32);
            this.cbStarCorrect.TabIndex = 8;
            this.cbStarCorrect.Text = "To star correct answers";
            this.cbStarCorrect.UseVisualStyleBackColor = true;
            this.cbStarCorrect.CheckedChanged += new System.EventHandler(this.cbStarCorrect_CheckedChanged);
            // 
            // cbUseTimer
            // 
            this.cbUseTimer.AutoSize = true;
            this.cbUseTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbUseTimer.Location = new System.Drawing.Point(26, 208);
            this.cbUseTimer.Name = "cbUseTimer";
            this.cbUseTimer.Size = new System.Drawing.Size(116, 32);
            this.cbUseTimer.TabIndex = 9;
            this.cbUseTimer.Text = "Set Timer";
            this.cbUseTimer.UseVisualStyleBackColor = true;
            this.cbUseTimer.CheckedChanged += new System.EventHandler(this.cbUseTimer_CheckedChanged);
            // 
            // nudTimeInMinutes
            // 
            this.nudTimeInMinutes.Enabled = false;
            this.nudTimeInMinutes.Location = new System.Drawing.Point(58, 246);
            this.nudTimeInMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimeInMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeInMinutes.Name = "nudTimeInMinutes";
            this.nudTimeInMinutes.Size = new System.Drawing.Size(61, 27);
            this.nudTimeInMinutes.TabIndex = 10;
            this.nudTimeInMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimeInMinutes.ValueChanged += new System.EventHandler(this.nudTimeInMinutes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(134, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time in minutes";
            // 
            // TestSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTimeInMinutes);
            this.Controls.Add(this.cbUseTimer);
            this.Controls.Add(this.cbStarCorrect);
            this.Controls.Add(this.cbUseUnstarred);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblNumberOfQuestions);
            this.Controls.Add(this.nudNumberOfQuestions);
            this.Name = "TestSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimeInMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudNumberOfQuestions;
        private Label lblNumberOfQuestions;
        private Label lblFormTitle;
        private Button btnSubmit;
        private CheckBox cbUseUnstarred;
        private CheckBox cbStarCorrect;
        private CheckBox cbUseTimer;
        private NumericUpDown nudTimeInMinutes;
        private Label label1;
    }
}