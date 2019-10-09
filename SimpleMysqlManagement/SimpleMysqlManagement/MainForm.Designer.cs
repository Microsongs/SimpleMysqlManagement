namespace SimpleMysqlManagement
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lang_Combobox = new System.Windows.Forms.ComboBox();
            this.dbNameLabel = new System.Windows.Forms.Label();
            this.dbDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLabel = new System.Windows.Forms.Label();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lang_Combobox
            // 
            this.lang_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lang_Combobox.Font = new System.Drawing.Font("바탕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lang_Combobox.FormattingEnabled = true;
            this.lang_Combobox.Location = new System.Drawing.Point(506, 22);
            this.lang_Combobox.Name = "lang_Combobox";
            this.lang_Combobox.Size = new System.Drawing.Size(121, 27);
            this.lang_Combobox.TabIndex = 0;
            this.lang_Combobox.SelectedIndexChanged += new System.EventHandler(this.Lang_Combobox_SelectedIndexChanged);
            // 
            // dbNameLabel
            // 
            this.dbNameLabel.AutoSize = true;
            this.dbNameLabel.Font = new System.Drawing.Font("바탕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dbNameLabel.Location = new System.Drawing.Point(242, 22);
            this.dbNameLabel.Name = "dbNameLabel";
            this.dbNameLabel.Size = new System.Drawing.Size(127, 21);
            this.dbNameLabel.TabIndex = 1;
            this.dbNameLabel.Text = "Database : ";
            // 
            // dbDataGridView
            // 
            this.dbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbDataGridView.Location = new System.Drawing.Point(91, 53);
            this.dbDataGridView.Name = "dbDataGridView";
            this.dbDataGridView.RowTemplate.Height = 23;
            this.dbDataGridView.Size = new System.Drawing.Size(399, 287);
            this.dbDataGridView.TabIndex = 2;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableLabel.Location = new System.Drawing.Point(12, 9);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(73, 25);
            this.tableLabel.TabIndex = 3;
            this.tableLabel.Text = "table : ";
            // 
            // tableComboBox
            // 
            this.tableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableComboBox.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Location = new System.Drawing.Point(79, 9);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(121, 25);
            this.tableComboBox.TabIndex = 4;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.TableComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 382);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.dbDataGridView);
            this.Controls.Add(this.dbNameLabel);
            this.Controls.Add(this.lang_Combobox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MysqlManagement";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lang_Combobox;
        private System.Windows.Forms.Label dbNameLabel;
        private System.Windows.Forms.DataGridView dbDataGridView;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.ComboBox tableComboBox;
    }
}

