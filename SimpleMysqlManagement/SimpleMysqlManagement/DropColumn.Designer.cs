namespace SimpleMysqlManagement
{
    partial class DropColumn
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.dropLabel = new System.Windows.Forms.Label();
            this.dropTextBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("맑은 고딕", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titleLabel.Location = new System.Drawing.Point(250, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 59);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "titleLabel";
            // 
            // dropLabel
            // 
            this.dropLabel.AutoSize = true;
            this.dropLabel.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dropLabel.Location = new System.Drawing.Point(81, 169);
            this.dropLabel.Name = "dropLabel";
            this.dropLabel.Size = new System.Drawing.Size(189, 50);
            this.dropLabel.TabIndex = 1;
            this.dropLabel.Text = "dropLabel";
            // 
            // dropTextBox
            // 
            this.dropTextBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dropTextBox.Location = new System.Drawing.Point(327, 169);
            this.dropTextBox.Name = "dropTextBox";
            this.dropTextBox.Size = new System.Drawing.Size(332, 50);
            this.dropTextBox.TabIndex = 2;
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("맑은 고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enterBtn.Location = new System.Drawing.Point(284, 280);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(181, 64);
            this.enterBtn.TabIndex = 3;
            this.enterBtn.Text = "enterBtn";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // DropColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.dropTextBox);
            this.Controls.Add(this.dropLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "DropColumn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dropLabel;
        private System.Windows.Forms.TextBox dropTextBox;
        private System.Windows.Forms.Button enterBtn;
    }
}