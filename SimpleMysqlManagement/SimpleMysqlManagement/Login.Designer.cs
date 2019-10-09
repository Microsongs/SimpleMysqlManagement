namespace SimpleMysqlManagement
{
    partial class Login
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.serverTextbox = new System.Windows.Forms.TextBox();
            this.databaseTextbox = new System.Windows.Forms.TextBox();
            this.userIDTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.serverLabel = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.azureCheckbox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("바탕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginLabel.Location = new System.Drawing.Point(215, 22);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(62, 21);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // serverTextbox
            // 
            this.serverTextbox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.serverTextbox.Location = new System.Drawing.Point(203, 59);
            this.serverTextbox.Name = "serverTextbox";
            this.serverTextbox.Size = new System.Drawing.Size(165, 29);
            this.serverTextbox.TabIndex = 1;
            // 
            // databaseTextbox
            // 
            this.databaseTextbox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.databaseTextbox.Location = new System.Drawing.Point(203, 114);
            this.databaseTextbox.Name = "databaseTextbox";
            this.databaseTextbox.Size = new System.Drawing.Size(165, 29);
            this.databaseTextbox.TabIndex = 2;
            // 
            // userIDTextbox
            // 
            this.userIDTextbox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIDTextbox.Location = new System.Drawing.Point(203, 169);
            this.userIDTextbox.Name = "userIDTextbox";
            this.userIDTextbox.Size = new System.Drawing.Size(165, 29);
            this.userIDTextbox.TabIndex = 3;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordTextbox.Location = new System.Drawing.Point(203, 223);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(165, 29);
            this.passwordTextbox.TabIndex = 4;
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.serverLabel.Location = new System.Drawing.Point(103, 64);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(83, 25);
            this.serverLabel.TabIndex = 5;
            this.serverLabel.Text = "Server : ";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.databaseLabel.Location = new System.Drawing.Point(91, 117);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(110, 25);
            this.databaseLabel.TabIndex = 6;
            this.databaseLabel.Text = "Database : ";
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userIDLabel.Location = new System.Drawing.Point(102, 172);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(85, 25);
            this.userIDLabel.TabIndex = 7;
            this.userIDLabel.Text = "userID : ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.passwordLabel.Location = new System.Drawing.Point(87, 223);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(110, 25);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password : ";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginButton.Location = new System.Drawing.Point(203, 323);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(95, 54);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // azureCheckbox
            // 
            this.azureCheckbox.AutoSize = true;
            this.azureCheckbox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.azureCheckbox.Location = new System.Drawing.Point(162, 262);
            this.azureCheckbox.Name = "azureCheckbox";
            this.azureCheckbox.Size = new System.Drawing.Size(181, 29);
            this.azureCheckbox.TabIndex = 11;
            this.azureCheckbox.Text = "user Azure Mysql";
            this.azureCheckbox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.saveButton.Location = new System.Drawing.Point(429, 87);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 43);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loadButton.Location = new System.Drawing.Point(429, 157);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(83, 40);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 377);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.azureCheckbox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.serverLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.userIDTextbox);
            this.Controls.Add(this.databaseTextbox);
            this.Controls.Add(this.serverTextbox);
            this.Controls.Add(this.loginLabel);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox serverTextbox;
        private System.Windows.Forms.TextBox databaseTextbox;
        private System.Windows.Forms.TextBox userIDTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox azureCheckbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}