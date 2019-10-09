using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimpleMysqlManagement
{
    public partial class MainForm : Form
    {
        private MySqlConnection connection;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }
        // 위치, 이름 등 설정
        private void Init()
        {
            Login login = new Login(this);
            login.ShowDialog();

            dbNameLabel.Text = "Database : " + connection.Database.ToString();
            dbNameLabel.Location = new Point(this.Width / 2 - dbNameLabel.Width / 2, 10);

            dbDataGridView.Location = new Point(this.Width / 2 - dbDataGridView.Width / 2, dbNameLabel.Location.Y + dbNameLabel.Height + 10);


            // langComboBox
            lang_Combobox.Location = new Point(dbDataGridView.Location.X + dbDataGridView.Width - 10, 10);
            lang_Combobox.Items.Add("English");
            lang_Combobox.Items.Add("한국어");
            lang_Combobox.Items.Add("日本語");
            lang_Combobox.SelectedIndex = 0;

            // tableLabel
            tableLabel.Location = new Point(5, 5);
            TableInit();
            tableComboBox.Location = new Point(tableLabel.Location.X + tableLabel.Width + 5, tableLabel.Location.Y);
        }

        // 테이블의 초기화
        private void TableInit()
        {
            string insertQuery = "select table_name from information_schema.tables where table_schema = '" +connection.Database.ToString() + "';";
            Debug.WriteLine(insertQuery);
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            connection.Open();
            MySqlDataReader rdr = command.ExecuteReader();
            while(rdr.Read())
            {
                tableComboBox.Items.Add(rdr[0].ToString());
            }
            tableComboBox.SelectedIndex = 0;
            rdr.Close();
            connection.Close();
        }

        // 커넥션 연결
        public void setConnection(MySqlConnection connection)
        {
            this.connection = connection;
        }
        // 콤보박스 세팅
        private void Lang_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lang_Combobox.SelectedIndex)
            {
                case Language.english:
                    dbNameLabel.Text = "Database : " + connection.Database.ToString();
                    break;
                case Language.korean:
                    dbNameLabel.Text = "데이터베이스 : " + connection.Database.ToString();
                    break;
                case Language.japanese:
                    dbNameLabel.Text = "データベース : " + connection.Database.ToString();
                    break;
            }
            // 위치 재설정
            dbNameLabel.Location = new Point(this.Width / 2 - dbNameLabel.Width / 2, 10);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
