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
    public partial class UpdateIndex : Form
    {
        private MainForm mainForm;
        public UpdateIndex(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        private void Init()
        {
            LanguageSetting();
            updateLabel.Location = new Point(this.Width / 2 - updateLabel.Width / 2, 10);
            setLabel.Location = new Point(this.Width / 4, updateLabel.Location.Y + updateLabel.Height + 20);
            setTextBox.Location = new Point(setLabel.Location.X + setLabel.Width + 20, setLabel.Location.Y);
            whereLabel.Location = new Point(this.Width / 4, setLabel.Location.Y + setLabel.Height + 20);
            whereTextBox.Location = new Point(setLabel.Location.X + setLabel.Width + 20, whereLabel.Location.Y);
            enterBtn.Location = new Point(this.Width / 2 - enterBtn.Width / 2, whereTextBox.Location.Y + 50);
        }

        private void LanguageSetting()
        {
            switch (mainForm.getLang())
            {
                case Language.english:
                    updateLabel.Text = "update";
                    setLabel.Text = "set : ";
                    whereLabel.Text = "where : ";
                    enterBtn.Text = "Enter";
                    break;
                case Language.korean:
                    updateLabel.Text = "변경";
                    setLabel.Text = "변경 내용 : ";
                    whereLabel.Text = "조건 : ";
                    enterBtn.Text = "입력";
                    break;

                case Language.japanese:
                    updateLabel.Text = "変更";
                    setLabel.Text = "変更内容 : ";
                    whereLabel.Text = "条件 : ";
                    enterBtn.Text = "入力";
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mainForm.getConnection().Close();
            string insertQuery = "Update " + mainForm.getTable() + " set ";
            insertQuery += setTextBox.Text + " where ";
            insertQuery += whereTextBox.Text + ";";
            mainForm.getConnection().Open();
            System.Diagnostics.Debug.WriteLine(insertQuery);
            MySqlCommand command = new MySqlCommand(insertQuery, mainForm.getConnection());
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("변경 성공");
                }
                else
                {
                    MessageBox.Show("변경 실패");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mainForm.getConnection().Close();

            this.Close();
        }
    }
}
