using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMysqlManagement
{
    public partial class DropColumn : Form
    {
        MainForm mainForm;
        public DropColumn(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            SettingLang();
        }
        private void SettingLang()
        {
            switch(mainForm.getLang()){
                case Language.english:
                    this.Text = "Drop Column";
                    titleLabel.Text = "Drop Column";
                    dropLabel.Text = "Column to Drop : ";
                    enterBtn.Text = "Enter";
                    break;

                case Language.korean:
                    this.Text = "컬럼 삭제";
                    titleLabel.Text = "컬럼 삭제";
                    dropLabel.Text = "삭제할 컬럼 : ";
                    enterBtn.Text = "확인";
                    break;
                case Language.japanese:
                    this.Text = "列を削除";
                    titleLabel.Text = "列を削除";
                    dropLabel.Text = "削除する列 : ";
                    enterBtn.Text = "確認";
                    break;

            }
            titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, 15);

            dropLabel.Location = new Point(this.Width / 10, titleLabel.Height + titleLabel.Location.Y + 15);
            dropTextBox.Location = new Point(this.Width / 2 + 5, dropLabel.Location.Y);
            enterBtn.Location = new Point(this.Width / 2 - enterBtn.Width / 2, dropLabel.Location.Y + dropLabel.Height + 15);
        }
        private void enterBtn_Click(object sender, EventArgs e)
        {
            mainForm.getConnection().Close();
            string insertQuery = "alter table " + mainForm.getTable() + " drop ";
            insertQuery += dropTextBox.Text;
            mainForm.getConnection().Open();
            System.Diagnostics.Debug.WriteLine(insertQuery);
            MySqlCommand command = new MySqlCommand(insertQuery, mainForm.getConnection());
            
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    switch (mainForm.getLang())
                    {
                        case Language.english:
                            MessageBox.Show("add Success");
                            break;

                        case Language.korean:
                            MessageBox.Show("컬럼 추가 성공");
                            break;

                        case Language.japanese:
                            MessageBox.Show("追加成功");
                            break;
                    }
                }
                else
                {
                    switch (mainForm.getLang())
                    {
                        case Language.english:
                            MessageBox.Show("drop Fail");
                            break;

                        case Language.korean:
                            MessageBox.Show("컬럼 삭제 실패");
                            break;

                        case Language.japanese:
                            MessageBox.Show("削除失敗");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                mainForm.getConnection().Close();
            }
            mainForm.getConnection().Close();

            this.Close();
        }
    }
}
