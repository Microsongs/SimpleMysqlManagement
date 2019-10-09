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
    public partial class DeleteIndex : Form
    {
        private MainForm mainForm;
        public DeleteIndex(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Init();
        }
        void Init()
        {
            LanguageSetting();
            deleteLabel.Location = new Point(this.Width / 2 - deleteLabel.Width / 2, 10);
            deleteTextbox.Location = new Point(this.Width / 2 - deleteTextbox.Width / 2, deleteLabel.Location.Y + 10 + 40);
            enterBtn.Location = new Point(this.Width / 2 - enterBtn.Width / 2, deleteTextbox.Location.Y + 50);
        }

        private void LanguageSetting()
        {
            switch (mainForm.getLang())
            {
                case Language.english:
                    deleteLabel.Text = "Input Delete Condition";
                    enterBtn.Text = "Enter";
                    break;
                case Language.korean:
                    deleteLabel.Text = "삭제 조건 입력";
                    enterBtn.Text = "Enter";
                    break;

                case Language.japanese:
                    deleteLabel.Text = "削除条件入力";
                    enterBtn.Text = "入力";
                    break;
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            mainForm.getConnection().Close();
            string insertQuery = "Delete from " + mainForm.getTable() + " where ";
            insertQuery += deleteTextbox.Text + ";";
            mainForm.getConnection().Open();
            System.Diagnostics.Debug.WriteLine(insertQuery);
            MySqlCommand command = new MySqlCommand(insertQuery, mainForm.getConnection());
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제 성공");
                }
                else
                {
                    MessageBox.Show("삭제 실패");
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
