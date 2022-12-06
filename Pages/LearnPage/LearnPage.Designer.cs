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
            this.pctrStar = new System.Windows.Forms.PictureBox();
            this.lblCardSide = new System.Windows.Forms.Label();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBg
            // 
            this.cardBg.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cardBg.Location = new System.Drawing.Point(192, 78);
            this.cardBg.Name = "cardBg";
            this.cardBg.Size = new System.Drawing.Size(533, 335);
            this.cardBg.TabIndex = 0;
            this.cardBg.Click += new System.EventHandler(this.Card_Click);
            this.cardBg.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LearnPage_KeyDown);
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 26.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(192, 78);
            this.lblText.MaximumSize = new System.Drawing.Size(533, 335);
            this.lblText.Name = "lblText";
            this.lblText.Padding = new System.Windows.Forms.Padding(30);
            this.lblText.Size = new System.Drawing.Size(533, 335);
            this.lblText.TabIndex = 1;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText.Click += new System.EventHandler(this.Card_Click);
            // 
            // pctrStar
            // 
            this.pctrStar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pctrStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrStar.Location = new System.Drawing.Point(682, 93);
            this.pctrStar.Name = "pctrStar";
            this.pctrStar.Size = new System.Drawing.Size(24, 24);
            this.pctrStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrStar.TabIndex = 4;
            this.pctrStar.TabStop = false;
            this.pctrStar.Click += new System.EventHandler(this.pctrStar_Click);
            // 
            // lblCardSide
            // 
            this.lblCardSide.AutoSize = true;
            this.lblCardSide.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCardSide.Location = new System.Drawing.Point(213, 93);
            this.lblCardSide.Name = "lblCardSide";
            this.lblCardSide.Size = new System.Drawing.Size(71, 20);
            this.lblCardSide.TabIndex = 5;
            this.lblCardSide.Text = "Card side";
            // 
            // pbLeft
            // 
            this.pbLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLeft.Location = new System.Drawing.Point(83, 189);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(94, 97);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft.TabIndex = 6;
            this.pbLeft.TabStop = false;
            this.pbLeft.Click += new System.EventHandler(this.Left_Click);
            // 
            // pbRight
            // 
            this.pbRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRight.Location = new System.Drawing.Point(743, 189);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(94, 97);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight.TabIndex = 7;
            this.pbRight.TabStop = false;
            this.pbRight.Click += new System.EventHandler(this.Right_Click);
            // 
            // pbInfo
            // 
            this.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfo.Location = new System.Drawing.Point(19, 17);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(27, 27);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInfo.TabIndex = 8;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.pbInfo_Click);
            // 
            // LearnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbInfo);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.lblCardSide);
            this.Controls.Add(this.pctrStar);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.cardBg);
            this.Name = "LearnPage";
            this.Size = new System.Drawing.Size(952, 593);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LearnPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctrStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label cardBg;
        private Label lblText;
        private PictureBox pctrStar;
        private Label lblCardSide;
        private PictureBox pbLeft;
        private PictureBox pbRight;
        private PictureBox pbInfo;
    }
}