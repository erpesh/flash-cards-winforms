namespace FlashCards.StartForm
{
    partial class StartForm
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
            this.lbCardSets = new System.Windows.Forms.ListBox();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.btnCreateSet = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGoToSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCardSets
            // 
            this.lbCardSets.FormattingEnabled = true;
            this.lbCardSets.ItemHeight = 20;
            this.lbCardSets.Location = new System.Drawing.Point(357, 32);
            this.lbCardSets.Name = "lbCardSets";
            this.lbCardSets.Size = new System.Drawing.Size(150, 224);
            this.lbCardSets.TabIndex = 0;
            this.lbCardSets.SelectedIndexChanged += new System.EventHandler(this.CardSetsList_SelectedChanged);
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(397, 9);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(71, 20);
            this.lblListTitle.TabIndex = 1;
            this.lblListTitle.Text = "Card Sets";
            // 
            // btnCreateSet
            // 
            this.btnCreateSet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateSet.Location = new System.Drawing.Point(12, 73);
            this.btnCreateSet.Name = "btnCreateSet";
            this.btnCreateSet.Size = new System.Drawing.Size(324, 86);
            this.btnCreateSet.TabIndex = 2;
            this.btnCreateSet.Text = "Create New Card Set";
            this.btnCreateSet.UseVisualStyleBackColor = true;
            this.btnCreateSet.Click += new System.EventHandler(this.btnCreateSet_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(87, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 46);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Flash Cards";
            // 
            // btnGoToSelected
            // 
            this.btnGoToSelected.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoToSelected.Location = new System.Drawing.Point(12, 165);
            this.btnGoToSelected.Name = "btnGoToSelected";
            this.btnGoToSelected.Size = new System.Drawing.Size(324, 91);
            this.btnGoToSelected.TabIndex = 4;
            this.btnGoToSelected.Text = "Go To Selected Set";
            this.btnGoToSelected.UseVisualStyleBackColor = true;
            this.btnGoToSelected.Click += new System.EventHandler(this.btnGoToSelected_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 264);
            this.Controls.Add(this.btnGoToSelected);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreateSet);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.lbCardSets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.Text = "Start Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbCardSets;
        private Label lblListTitle;
        private Button btnCreateSet;
        private Label lblTitle;
        private Button btnGoToSelected;
    }
}