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
            this.lblError = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbUseStarred = new System.Windows.Forms.CheckBox();
            this.cbStarCorrect = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumberOfQuestions
            // 
            this.nudNumberOfQuestions.Location = new System.Drawing.Point(26, 71);
            this.nudNumberOfQuestions.Name = "nudNumberOfQuestions";
            this.nudNumberOfQuestions.Size = new System.Drawing.Size(55, 27);
            this.nudNumberOfQuestions.TabIndex = 0;
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(97, 71);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(202, 28);
            this.lblNumberOfQuestions.TabIndex = 1;
            this.lblNumberOfQuestions.Text = "Number Of Questions";
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
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 205);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(12, 246);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(282, 47);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbUseStarred
            // 
            this.cbUseStarred.AutoSize = true;
            this.cbUseStarred.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbUseStarred.Location = new System.Drawing.Point(26, 161);
            this.cbUseStarred.Name = "cbUseStarred";
            this.cbUseStarred.Size = new System.Drawing.Size(272, 32);
            this.cbUseStarred.TabIndex = 7;
            this.cbUseStarred.Text = "Use Only Starred Questions";
            this.cbUseStarred.UseVisualStyleBackColor = true;
            // 
            // cbStarCorrect
            // 
            this.cbStarCorrect.AutoSize = true;
            this.cbStarCorrect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStarCorrect.Location = new System.Drawing.Point(26, 114);
            this.cbStarCorrect.Name = "cbStarCorrect";
            this.cbStarCorrect.Size = new System.Drawing.Size(238, 32);
            this.cbStarCorrect.TabIndex = 8;
            this.cbStarCorrect.Text = "To Star Correct Answers";
            this.cbStarCorrect.UseVisualStyleBackColor = true;
            // 
            // TestSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 305);
            this.Controls.Add(this.cbStarCorrect);
            this.Controls.Add(this.cbUseStarred);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblNumberOfQuestions);
            this.Controls.Add(this.nudNumberOfQuestions);
            this.Name = "TestSettings";
            this.Text = "Test Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudNumberOfQuestions;
        private Label lblNumberOfQuestions;
        private Label lblFormTitle;
        private Label lblError;
        private Button btnSubmit;
        private CheckBox cbUseStarred;
        private CheckBox cbStarCorrect;
    }
}