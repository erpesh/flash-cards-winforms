namespace FlashCards.StartForm
{
    partial class CardSetNameForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbCardSetName = new System.Windows.Forms.TextBox();
            this.btnCreateCardSet = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(23, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Card Set Name";
            // 
            // tbCardSetName
            // 
            this.tbCardSetName.Location = new System.Drawing.Point(23, 80);
            this.tbCardSetName.Name = "tbCardSetName";
            this.tbCardSetName.Size = new System.Drawing.Size(228, 27);
            this.tbCardSetName.TabIndex = 1;
            // 
            // btnCreateCardSet
            // 
            this.btnCreateCardSet.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateCardSet.Location = new System.Drawing.Point(23, 121);
            this.btnCreateCardSet.Name = "btnCreateCardSet";
            this.btnCreateCardSet.Size = new System.Drawing.Size(228, 46);
            this.btnCreateCardSet.TabIndex = 2;
            this.btnCreateCardSet.Text = "Create card set";
            this.btnCreateCardSet.UseVisualStyleBackColor = true;
            this.btnCreateCardSet.Click += new System.EventHandler(this.btnCreateCardSet_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(23, 170);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 3;
            // 
            // CardSetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 198);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCreateCardSet);
            this.Controls.Add(this.tbCardSetName);
            this.Controls.Add(this.lblTitle);
            this.Name = "CardSetName";
            this.Text = "Card Set Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private TextBox tbCardSetName;
        private Button btnCreateCardSet;
        private Label lblError;
    }
}