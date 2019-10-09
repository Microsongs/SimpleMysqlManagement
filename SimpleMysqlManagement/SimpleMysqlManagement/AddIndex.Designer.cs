namespace SimpleMysqlManagement
{
    partial class AddIndex
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
            this.addLabel = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addLabel.Location = new System.Drawing.Point(198, 13);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(54, 21);
            this.addLabel.TabIndex = 0;
            this.addLabel.Text = "label1";
            // 
            // enterBtn
            // 
            this.enterBtn.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.enterBtn.Location = new System.Drawing.Point(202, 209);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(110, 46);
            this.enterBtn.TabIndex = 1;
            this.enterBtn.Text = "enterBtn";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // AddIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 303);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.addLabel);
            this.Name = "AddIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddIndex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Button enterBtn;
    }
}