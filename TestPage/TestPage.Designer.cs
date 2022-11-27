namespace FlashCards.TestPage
{
    partial class TestPage
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
            this.lblQuestionsList = new System.Windows.Forms.Label();
            this.testQuestionItem = new FlashCards.TestPage.TestQuestionItem();
            this.lstQuestions = new System.Windows.Forms.ListView();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnPrevQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionsList
            // 
            this.lblQuestionsList.AutoSize = true;
            this.lblQuestionsList.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuestionsList.Location = new System.Drawing.Point(0, 23);
            this.lblQuestionsList.Name = "lblQuestionsList";
            this.lblQuestionsList.Size = new System.Drawing.Size(92, 25);
            this.lblQuestionsList.TabIndex = 1;
            this.lblQuestionsList.Text = "Questions";
            // 
            // testQuestionItem
            // 
            this.testQuestionItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.testQuestionItem.Location = new System.Drawing.Point(206, 23);
            this.testQuestionItem.Name = "testQuestionItem";
            this.testQuestionItem.Size = new System.Drawing.Size(616, 354);
            this.testQuestionItem.TabIndex = 2;
            this.testQuestionItem.TestQuestion = null;
            // 
            // lstQuestions
            // 
            this.lstQuestions.BackColor = System.Drawing.SystemColors.Control;
            this.lstQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstQuestions.Location = new System.Drawing.Point(20, 60);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(45, 424);
            this.lstQuestions.TabIndex = 3;
            this.lstQuestions.UseCompatibleStateImageBehavior = false;
            this.lstQuestions.View = System.Windows.Forms.View.List;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.QuestionsList_IndexChange);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextQuestion.Location = new System.Drawing.Point(692, 404);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(203, 50);
            this.btnNextQuestion.TabIndex = 4;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnPrevQuestion
            // 
            this.btnPrevQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevQuestion.Location = new System.Drawing.Point(135, 404);
            this.btnPrevQuestion.Name = "btnPrevQuestion";
            this.btnPrevQuestion.Size = new System.Drawing.Size(203, 50);
            this.btnPrevQuestion.TabIndex = 5;
            this.btnPrevQuestion.Text = "Prev Question";
            this.btnPrevQuestion.UseVisualStyleBackColor = true;
            this.btnPrevQuestion.Click += new System.EventHandler(this.btnPrevQuestion_Click);
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrevQuestion);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.testQuestionItem);
            this.Controls.Add(this.lblQuestionsList);
            this.Name = "TestPage";
            this.Size = new System.Drawing.Size(952, 487);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblQuestionsList;
        private TestQuestionItem testQuestionItem;
        private ListView lstQuestions;
        private Button btnNextQuestion;
        private Button btnPrevQuestion;
    }
}
