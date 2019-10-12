namespace SimpleMysqlManagement
{
    partial class AddColumn
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.optionLabel = new System.Windows.Forms.Label();
            this.optionTextBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.addColumnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameLabel.Location = new System.Drawing.Point(51, 109);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(203, 50);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "nameLabel";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameTextBox.Location = new System.Drawing.Point(373, 109);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(302, 57);
            this.nameTextBox.TabIndex = 1;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.typeLabel.Location = new System.Drawing.Point(56, 206);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(183, 50);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "typeLabel";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.typeTextBox.Location = new System.Drawing.Point(373, 206);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(302, 57);
            this.typeTextBox.TabIndex = 3;
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.optionLabel.Location = new System.Drawing.Point(56, 301);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(219, 50);
            this.optionLabel.TabIndex = 4;
            this.optionLabel.Text = "optionLabel";
            // 
            // optionTextBox
            // 
            this.optionTextBox.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.optionTextBox.Location = new System.Drawing.Point(373, 301);
            this.optionTextBox.Name = "optionTextBox";
            this.optionTextBox.Size = new System.Drawing.Size(304, 57);
            this.optionTextBox.TabIndex = 5;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enterBtn.Location = new System.Drawing.Point(299, 377);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(144, 61);
            this.enterBtn.TabIndex = 6;
            this.enterBtn.Text = "enterBtn";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // addColumnLabel
            // 
            this.addColumnLabel.AutoSize = true;
            this.addColumnLabel.Font = new System.Drawing.Font("맑은 고딕", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addColumnLabel.Location = new System.Drawing.Point(323, 39);
            this.addColumnLabel.Name = "addColumnLabel";
            this.addColumnLabel.Size = new System.Drawing.Size(368, 59);
            this.addColumnLabel.TabIndex = 7;
            this.addColumnLabel.Text = "addColumnLabel";
            // 
            // AddColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addColumnLabel);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.optionTextBox);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddColumn";
            this.Text = "AddColumn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.TextBox optionTextBox;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label addColumnLabel;
    }
}