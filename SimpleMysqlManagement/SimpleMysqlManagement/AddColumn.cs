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
    public partial class AddColumn : Form
    {
        private MainForm mainForm;
        public AddColumn(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Init();
        }

        private void Init(){
            LanguageSetting();

        }
        private void LanguageSetting()
        {
            switch (mainForm.getLang())
            {
                case Language.english:
                    this.Text = "Add Column";
                    addColumnLabel.Text = "Add Column";
                    nameLabel.Text = "Name : ";
                    typeLabel.Text = "Type : ";
                    optionLabel.Text = "Option : ";
                    enterBtn.Text = "Enter";
                    break;

                case Language.korean:
                    this.Text = "컬럼 추가";
                    addColumnLabel.Text = "컬럼 추가";
                    nameLabel.Text = "이름 : ";
                    typeLabel.Text = "타입 : ";
                    optionLabel.Text = "옵션: ";
                    enterBtn.Text = "입력";
                    break;

                case Language.japanese:
                    this.Text = "列を追加";
                    addColumnLabel.Text = "列を追加";
                    nameLabel.Text = "名前 : ";
                    typeLabel.Text = "タイプ : ";
                    optionLabel.Text = "オプション : ";
                    enterBtn.Text = "入力";
                    break;
            }
            addColumnLabel.Location = new Point(this.Width / 2 - addColumnLabel.Width / 2, 10);
            nameLabel.Location = new Point(this.Width / 5, addColumnLabel.Height + addColumnLabel.Location.Y + 10);
            nameTextBox.Location = new Point(nameLabel.Width + nameLabel.Location.X + 50, nameLabel.Location.Y);

            typeLabel.Location = new Point(this.Width / 5, nameLabel.Height + nameLabel.Location.Y + 10);
            typeTextBox.Location = new Point(nameTextBox.Location.X, typeLabel.Location.Y);

            optionLabel.Location = new Point(this.Width / 5, typeLabel.Height + typeLabel.Location.Y + 10);
            optionTextBox.Location = new Point(nameTextBox.Location.X, optionLabel.Location.Y);

            enterBtn.Location = new Point(this.Width / 2 - enterBtn.Width / 2, optionLabel.Location.Y + optionLabel.Height + 10);
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            mainForm.getConnection().Close();
            string insertQuery = "alter table " + mainForm.getTable() + " add ";
            insertQuery += nameTextBox.Text + " " +typeTextBox.Text + " " + optionTextBox.Text;
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
                            MessageBox.Show("add Fail");
                            break;

                        case Language.korean:
                            MessageBox.Show("컬럼 추가 실패");
                            break;

                        case Language.japanese:
                            MessageBox.Show("追加失敗");
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
