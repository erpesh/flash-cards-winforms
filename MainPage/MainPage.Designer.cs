namespace FlashCards.MainPage
{
    partial class MainPage
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.cardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(152, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(215, 143);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(188, 27);
            this.txtDefinition.TabIndex = 10;
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(215, 79);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(188, 27);
            this.txtTerm.TabIndex = 9;
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDefinition.Location = new System.Drawing.Point(69, 134);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(123, 35);
            this.lblDefinition.TabIndex = 8;
            this.lblDefinition.Text = "Definition";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTerm.Location = new System.Drawing.Point(69, 71);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(70, 35);
            this.lblTerm.TabIndex = 7;
            this.lblTerm.Text = "Term";
            // 
            // cardsPanel
            // 
            this.cardsPanel.AllowDrop = true;
            this.cardsPanel.AutoScroll = true;
            this.cardsPanel.Location = new System.Drawing.Point(519, 22);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(390, 452);
            this.cardsPanel.TabIndex = 6;
            this.cardsPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.MainPage_ControlRemoved);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.cardsPanel);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(952, 487);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private TextBox txtDefinition;
        private TextBox txtTerm;
        private Label lblDefinition;
        private Label lblTerm;
        private FlowLayoutPanel cardsPanel;
    }
}
