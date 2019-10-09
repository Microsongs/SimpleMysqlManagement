using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimpleMysqlManagement
{
    public partial class AddIndex : Form
    {
        private MainForm mainForm;
        List<Label> labelList = new List<Label>();
        List<TextBox> textboxList = new List<TextBox>();
        public AddIndex(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
            init();
        }

        private void addLabelLang()
        {
            switch (mainForm.getLang())
            {
                case Language.english:
                    addLabel.Text = "Add Itmes";
                    break;
                case Language.korean:
                    addLabel.Text = "아이템 추가";
                    break;

                case Language.japanese:
                    addLabel.Text = "アイテムを追加";
                    break;
            }
            addLabel.Location = new Point(this.Width / 2 - addLabel.Width / 2, 10);
        }

        private void enterBtnLang()
        {
            switch (mainForm.getLang())
            {
                case Language.english:
                    enterBtn.Text = "Enter";
                    break;
                case Language.korean:
                    enterBtn.Text = "입력";
                    break;
                case Language.japanese:
                    enterBtn.Text = "入力";
                    break;
            }
            enterBtn.Location = new Point(this.Width / 2 - enterBtn.Width / 2, labelList[labelList.Count - 1].Location.Y + labelList[labelList.Count - 1].Height + 20);
        }
        private void init()
        {
            addLabelLang();

            mainForm.getConnection().Close();
            
            string insertQuery = "show full columns from " + mainForm.getTable();

            MySqlCommand command = new MySqlCommand(insertQuery, mainForm.getConnection());
            mainForm.getConnection().Open();
            MySqlDataReader rdr = command.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                labelList.Add(new Label());
                labelList[i].Text = rdr[0].ToString();
                i++;
            }
            rdr.Close();
            System.Diagnostics.Debug.WriteLine(labelList.Count);

            // 0번째 요소 추가
            textboxList.Add(new TextBox());
            labelList[0].Location = new Point(this.Width / 3, addLabel.Location.Y + addLabel.Height + 10);
            textboxList[0].Location = new Point(labelList[0].Location.X + labelList[0].Width + 20, labelList[0].Location.Y);
            this.Controls.Add(labelList[0]);
            this.Controls.Add(textboxList[0]);

            // n번째 요소 추가
            for(int j=1; j<labelList.Count; j++)
            {
                System.Diagnostics.Debug.WriteLine("d");
                labelList[j].Location = new Point(this.Width / 3, labelList[j-1].Location.Y + labelList[j-1].Height + 10);
                textboxList.Add(new TextBox());
                textboxList[j].Location = new Point(labelList[0].Location.X + labelList[0].Width + 20, labelList[j].Location.Y);
                this.Controls.Add(labelList[j]);
                this.Controls.Add(textboxList[j]);
            }
            enterBtnLang();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            mainForm.getConnection().Close();
            string insertQuery = "INSERT INTO " + mainForm.getTable() + "(";
            for(int i=0; i<labelList.Count; i++)
            {
                if (i == labelList.Count - 1)
                    insertQuery += labelList[i].Text + ") ";
                else
                    insertQuery += labelList[i].Text + ", ";
            }

            insertQuery += " VALUES (";
            for(int i=0; i<textboxList.Count; i++)
            {
                if (i == textboxList.Count - 1)
                {
                    insertQuery += textboxList[i].Text + ")";
                }
                else {
                    insertQuery += textboxList[i].Text + ", ";
                }
            }

            System.Diagnostics.Debug.WriteLine(insertQuery);
            mainForm.getConnection().Open();
            MySqlCommand command = new MySqlCommand(insertQuery, mainForm.getConnection());
            try
            {
                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("추가 성공");
                }
                else
                {
                    MessageBox.Show("추가 실패");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mainForm.getConnection().Close();

            this.Close();
        }
    }
}
