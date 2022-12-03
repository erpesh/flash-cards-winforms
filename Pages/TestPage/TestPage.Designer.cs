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
            this.components = new System.ComponentModel.Container();
            this.lblQuestionsList = new System.Windows.Forms.Label();
            this.testQuestionItem = new FlashCards.TestPage.TestQuestionItem();
            this.btnSubmitTest = new System.Windows.Forms.Button();
            this.btnPrevQuestion = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.lblTimerTitle = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lstQuestions = new System.Windows.Forms.ListBox();
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
            this.testQuestionItem.Location = new System.Drawing.Point(158, 44);
            this.testQuestionItem.Name = "testQuestionItem";
            this.testQuestionItem.Size = new System.Drawing.Size(616, 354);
            this.testQuestionItem.TabIndex = 2;
            this.testQuestionItem.TestQuestion = null;
            // 
            // btnSubmitTest
            // 
            this.btnSubmitTest.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitTest.Location = new System.Drawing.Point(634, 421);
            this.btnSubmitTest.Name = "btnSubmitTest";
            this.btnSubmitTest.Size = new System.Drawing.Size(203, 50);
            this.btnSubmitTest.TabIndex = 4;
            this.btnSubmitTest.Text = "Submit Test";
            this.btnSubmitTest.UseVisualStyleBackColor = true;
            this.btnSubmitTest.Visible = false;
            this.btnSubmitTest.Click += new System.EventHandler(this.btnSubmitTest_Click);
            // 
            // btnPrevQuestion
            // 
            this.btnPrevQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevQuestion.Location = new System.Drawing.Point(90, 421);
            this.btnPrevQuestion.Name = "btnPrevQuestion";
            this.btnPrevQuestion.Size = new System.Drawing.Size(203, 50);
            this.btnPrevQuestion.TabIndex = 5;
            this.btnPrevQuestion.Text = "Prev Question";
            this.btnPrevQuestion.UseVisualStyleBackColor = true;
            this.btnPrevQuestion.Visible = false;
            this.btnPrevQuestion.Click += new System.EventHandler(this.btnPrevQuestion_Click);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNextQuestion.Location = new System.Drawing.Point(634, 421);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(203, 50);
            this.btnNextQuestion.TabIndex = 6;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // lblTimerTitle
            // 
            this.lblTimerTitle.AutoSize = true;
            this.lblTimerTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimerTitle.Location = new System.Drawing.Point(805, 13);
            this.lblTimerTitle.Name = "lblTimerTitle";
            this.lblTimerTitle.Size = new System.Drawing.Size(126, 37);
            this.lblTimerTitle.TabIndex = 7;
            this.lblTimerTitle.Text = "Time Left";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(839, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 30);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "03:12";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lstQuestions
            // 
            this.lstQuestions.BackColor = System.Drawing.SystemColors.Control;
            this.lstQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstQuestions.FormattingEnabled = true;
            this.lstQuestions.ItemHeight = 20;
            this.lstQuestions.Location = new System.Drawing.Point(23, 51);
            this.lstQuestions.Name = "lstQuestions";
            this.lstQuestions.Size = new System.Drawing.Size(35, 320);
            this.lstQuestions.TabIndex = 9;
            this.lstQuestions.SelectedIndexChanged += new System.EventHandler(this.lstQuestions_SelectedIndexChanged);
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstQuestions);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimerTitle);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnPrevQuestion);
            this.Controls.Add(this.btnSubmitTest);
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
        private Button btnSubmitTest;
        private Button btnPrevQuestion;
        private Button btnNextQuestion;
        private Label lblTimerTitle;
        private Label lblTime;
        private System.Windows.Forms.Timer timer;
        private ListBox lstQuestions;
    }
}
