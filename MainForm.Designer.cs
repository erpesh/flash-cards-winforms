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
            this.components = new System.ComponentModel.Container();
            this.headerBg = new System.Windows.Forms.Label();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.btnLearnPage = new System.Windows.Forms.Button();
            this.mainPage1 = new FlashCards.MainPage.MainPage();
            this.btnTestPage = new System.Windows.Forms.Button();
            this.testPage1 = new FlashCards.TestPage.TestPage();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.ttipNavButton = new System.Windows.Forms.ToolTip(this.components);
            this.learnPage1 = new FlashCards.LearnPage.LearnPage();
            this.SuspendLayout();
            // 
            // headerBg
            // 
            this.headerBg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerBg.Location = new System.Drawing.Point(-3, -2);
            this.headerBg.Name = "headerBg";
            this.headerBg.Size = new System.Drawing.Size(937, 53);
            this.headerBg.TabIndex = 0;
            this.headerBg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            // 
            // btnMainPage
            // 
            this.btnMainPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnMainPage.Location = new System.Drawing.Point(402, 12);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(141, 39);
            this.btnMainPage.TabIndex = 1;
            this.btnMainPage.Text = "Main";
            this.btnMainPage.UseVisualStyleBackColor = false;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // btnLearnPage
            // 
            this.btnLearnPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnLearnPage.Location = new System.Drawing.Point(559, 12);
            this.btnLearnPage.Name = "btnLearnPage";
            this.btnLearnPage.Size = new System.Drawing.Size(134, 39);
            this.btnLearnPage.TabIndex = 2;
            this.btnLearnPage.Text = "Learn";
            this.btnLearnPage.UseVisualStyleBackColor = false;
            this.btnLearnPage.Click += new System.EventHandler(this.btnLearnPage_Click);
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
            this.btnTestPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnTestPage.Location = new System.Drawing.Point(708, 12);
            this.btnTestPage.Name = "btnTestPage";
            this.btnTestPage.Size = new System.Drawing.Size(134, 39);
            this.btnTestPage.TabIndex = 4;
            this.btnTestPage.Text = "Test";
            this.btnTestPage.UseVisualStyleBackColor = false;
            this.btnTestPage.Click += new System.EventHandler(this.btnTestPage_Click);
            // 
            // testPage1
            // 
            this.testPage1.Location = new System.Drawing.Point(-3, 54);
            this.testPage1.Name = "testPage1";
            this.testPage1.Size = new System.Drawing.Size(937, 494);
            this.testPage1.TabIndex = 3;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(39, 29);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // learnPage1
            // 
            this.learnPage1.Location = new System.Drawing.Point(-3, 54);
            this.learnPage1.Name = "learnPage1";
            this.learnPage1.Size = new System.Drawing.Size(937, 494);
            this.learnPage1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 546);
            this.Controls.Add(this.learnPage1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.testPage1);
            this.Controls.Add(this.btnTestPage);
            this.Controls.Add(this.mainPage1);
            this.Controls.Add(this.btnLearnPage);
            this.Controls.Add(this.btnMainPage);
            this.Controls.Add(this.headerBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Flash Cards";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private Label headerBg;
        private Button btnMainPage;
        private Button btnLearnPage;
        private MainPage.MainPage mainPage1;
        private Button btnTestPage;
        private TestPage.TestPage testPage1;
        private Button btnGoBack;
        private ToolTip ttipNavButton;
        private LearnPage.LearnPage learnPage1;
    }
}