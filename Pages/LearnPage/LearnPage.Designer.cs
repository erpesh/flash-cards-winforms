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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.pctrStar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrStar)).BeginInit();
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
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 26.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(192, 78);
            this.lblText.MaximumSize = new System.Drawing.Size(533, 335);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(533, 335);
            this.lblText.TabIndex = 1;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText.Click += new System.EventHandler(this.Card_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeft.Location = new System.Drawing.Point(79, 189);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(94, 97);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRight.Location = new System.Drawing.Point(745, 189);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(94, 97);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pctrStar
            // 
            this.pctrStar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pctrStar.Location = new System.Drawing.Point(682, 93);
            this.pctrStar.Name = "pctrStar";
            this.pctrStar.Size = new System.Drawing.Size(24, 24);
            this.pctrStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctrStar.TabIndex = 4;
            this.pctrStar.TabStop = false;
            this.pctrStar.Click += new System.EventHandler(this.pctrStar_Click);
            // 
            // LearnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pctrStar);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.cardBg);
            this.Name = "LearnPage";
            this.Size = new System.Drawing.Size(952, 593);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LearnPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctrStar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label cardBg;
        private Label lblText;
        private Button btnLeft;
        private Button btnRight;
        private PictureBox pctrStar;
    }
}
