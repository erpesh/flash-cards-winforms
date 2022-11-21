namespace FlashCards
{
    partial class MainForm
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
            this.headerBg = new System.Windows.Forms.Label();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnLearnPage = new System.Windows.Forms.Button();
            this.learnPage1 = new FlashCards.LearnPage.LearnPage();
            this.mainPage1 = new FlashCards.MainPage.MainPage();
            this.btnTestPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerBg
            // 
            this.headerBg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerBg.Location = new System.Drawing.Point(-3, -2);
            this.headerBg.Name = "headerBg";
            this.headerBg.Size = new System.Drawing.Size(937, 53);
            this.headerBg.TabIndex = 0;
            // 
            // btnMainPage
            // 
            this.btnMainPage.Location = new System.Drawing.Point(402, 12);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(141, 39);
            this.btnMainPage.TabIndex = 1;
            this.btnMainPage.Text = "Main";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnLearnPage
            // 
            this.btnLearnPage.Location = new System.Drawing.Point(559, 12);
            this.btnLearnPage.Name = "btnLearnPage";
            this.btnLearnPage.Size = new System.Drawing.Size(134, 39);
            this.btnLearnPage.TabIndex = 2;
            this.btnLearnPage.Text = "Learn";
            this.btnLearnPage.UseVisualStyleBackColor = true;
            this.btnLearnPage.Click += new System.EventHandler(this.btnLearnPage_Click);
            // 
            // learnPage1
            // 
            this.learnPage1.Location = new System.Drawing.Point(-3, 54);
            this.learnPage1.Name = "learnPage1";
            this.learnPage1.Size = new System.Drawing.Size(937, 494);
            this.learnPage1.TabIndex = 3;
            // 
            // mainPage1
            // 
            this.mainPage1.CardsSet = null;
            this.mainPage1.Location = new System.Drawing.Point(-3, 54);
            this.mainPage1.MainForm = null;
            this.mainPage1.Name = "mainPage1";
            this.mainPage1.Size = new System.Drawing.Size(937, 494);
            this.mainPage1.TabIndex = 3;
            // 
            // btnTestPage
            // 
            this.btnTestPage.Location = new System.Drawing.Point(708, 12);
            this.btnTestPage.Name = "btnTestPage";
            this.btnTestPage.Size = new System.Drawing.Size(134, 39);
            this.btnTestPage.TabIndex = 4;
            this.btnTestPage.Text = "Test";
            this.btnTestPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 546);
            this.Controls.Add(this.btnTestPage);
            this.Controls.Add(this.mainPage1);
            this.Controls.Add(this.learnPage1);
            this.Controls.Add(this.btnLearnPage);
            this.Controls.Add(this.btnMainPage);
            this.Controls.Add(this.headerBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Flash Cards";
            this.ResumeLayout(false);

        }

        #endregion

        private Label headerBg;
        private Button btnMainPage;
        private Button btnLearnPage;
        private LearnPage.LearnPage learnPage1;
        private MainPage.MainPage mainPage1;
        private Button btnTestPage;
    }
}