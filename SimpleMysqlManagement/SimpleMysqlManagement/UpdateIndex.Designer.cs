namespace SimpleMysqlManagement
{
    partial class UpdateIndex
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
            this.updateLabel = new System.Windows.Forms.Label();
            this.setLabel = new System.Windows.Forms.Label();
            this.whereLabel = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.setTextBox = new System.Windows.Forms.TextBox();
            this.whereTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updateLabel.Location = new System.Drawing.Point(148, 9);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(195, 30);
            this.updateLabel.TabIndex = 0;
            this.updateLabel.Text = "업데이트 조건 입력";
            // 
            // setLabel
            // 
            this.setLabel.AutoSize = true;
            this.setLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.setLabel.Location = new System.Drawing.Point(62, 67);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(76, 19);
            this.setLabel.TabIndex = 1;
            this.setLabel.Text = "setLabel";
            // 
            // whereLabel
            // 
            this.whereLabel.AutoSize = true;
            this.whereLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.whereLabel.Location = new System.Drawing.Point(37, 116);
            this.whereLabel.Name = "whereLabel";
            this.whereLabel.Size = new System.Drawing.Size(101, 19);
            this.whereLabel.TabIndex = 2;
            this.whereLabel.Text = "whereLabel";
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enterBtn.Location = new System.Drawing.Point(169, 181);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(118, 57);
            this.enterBtn.TabIndex = 3;
            this.enterBtn.Text = "enterBtn";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // setTextBox
            // 
            this.setTextBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.setTextBox.Location = new System.Drawing.Point(186, 63);
            this.setTextBox.Name = "setTextBox";
            this.setTextBox.Size = new System.Drawing.Size(172, 29);
            this.setTextBox.TabIndex = 4;
            // 
            // whereTextBox
            // 
            this.whereTextBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.whereTextBox.Location = new System.Drawing.Point(186, 114);
            this.whereTextBox.Name = "whereTextBox";
            this.whereTextBox.Size = new System.Drawing.Size(172, 29);
            this.whereTextBox.TabIndex = 5;
            // 
            // UpdateIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 307);
            this.Controls.Add(this.whereTextBox);
            this.Controls.Add(this.setTextBox);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.whereLabel);
            this.Controls.Add(this.setLabel);
            this.Controls.Add(this.updateLabel);
            this.Name = "UpdateIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateIndex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label setLabel;
        private System.Windows.Forms.Label whereLabel;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox setTextBox;
        private System.Windows.Forms.TextBox whereTextBox;
    }
}