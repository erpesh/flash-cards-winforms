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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.cardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCardSetName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ttipAddButton = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(69, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(334, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD CARD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(215, 161);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(188, 27);
            this.txtDefinition.TabIndex = 10;
            this.txtDefinition.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(215, 97);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(188, 27);
            this.txtTerm.TabIndex = 9;
            this.txtTerm.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDefinition.Location = new System.Drawing.Point(69, 152);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(123, 35);
            this.lblDefinition.TabIndex = 8;
            this.lblDefinition.Text = "Definition";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTerm.Location = new System.Drawing.Point(69, 89);
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
            this.cardsPanel.Size = new System.Drawing.Size(383, 452);
            this.cardsPanel.TabIndex = 6;
            this.cardsPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.MainPage_ControlRemoved);
            // 
            // lblCardSetName
            // 
            this.lblCardSetName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCardSetName.Location = new System.Drawing.Point(24, 22);
            this.lblCardSetName.Name = "lblCardSetName";
            this.lblCardSetName.Size = new System.Drawing.Size(451, 55);
            this.lblCardSetName.TabIndex = 12;
            this.lblCardSetName.Text = "Card Set Name";
            this.lblCardSetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(69, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(334, 44);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE CARD SET";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblCardSetName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblDefinition);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.cardsPanel);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(952, 487);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
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
        private Label lblCardSetName;
        private Button btnDelete;
        private ToolTip ttipAddButton;
    }
}
