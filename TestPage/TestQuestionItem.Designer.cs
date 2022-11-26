namespace FlashCards.TestPage
{
    partial class TestQuestionItem
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
            this.lblTermTitle = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTermTitle
            // 
            this.lblTermTitle.AutoSize = true;
            this.lblTermTitle.Location = new System.Drawing.Point(14, 17);
            this.lblTermTitle.Name = "lblTermTitle";
            this.lblTermTitle.Size = new System.Drawing.Size(42, 20);
            this.lblTermTitle.TabIndex = 0;
            this.lblTermTitle.Text = "Term";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTerm.Location = new System.Drawing.Point(14, 55);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(119, 31);
            this.lblTerm.TabIndex = 1;
            this.lblTerm.Text = "TermValue";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(24, 179);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 2);
            this.panel1.TabIndex = 2;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnswer1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer1.Location = new System.Drawing.Point(24, 198);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(275, 60);
            this.btnAnswer1.TabIndex = 3;
            this.btnAnswer1.Text = "button1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnswer2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer2.Location = new System.Drawing.Point(318, 198);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(275, 60);
            this.btnAnswer2.TabIndex = 4;
            this.btnAnswer2.Text = "button2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer2_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnswer3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer3.Location = new System.Drawing.Point(24, 274);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(275, 60);
            this.btnAnswer3.TabIndex = 5;
            this.btnAnswer3.Text = "button3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer3_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnswer4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer4.Location = new System.Drawing.Point(318, 274);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(275, 60);
            this.btnAnswer4.TabIndex = 6;
            this.btnAnswer4.Text = "button4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer4_Click);
            // 
            // TestQuestionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblTermTitle);
            this.Name = "TestQuestionItem";
            this.Size = new System.Drawing.Size(616, 354);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTermTitle;
        private Label lblTerm;
        private Panel panel1;
        private Button btnAnswer1;
        private Button btnAnswer2;
        private Button btnAnswer3;
        private Button btnAnswer4;
    }
}
