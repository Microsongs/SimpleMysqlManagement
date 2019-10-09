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
            lang_Combobox.Location = new Point(this.Width - lang_Combobox.Width - 30, 10);
            lang_Combobox.Items.Add("English");
            lang_Combobox.Items.Add("한국어");
            lang_Combobox.Items.Add("日本語");
            lang_Combobox.SelectedIndex = 0;

            // tableLabel
            tableLabel.Location = new Point(5, 5);
            TableInit();
            tableComboBox.Location = new Point(tableLabel.Location.X + tableLabel.Width + 5, tableLabel.Location.Y);

            // 버튼의 위치 초기화
            addBtn.Location = new Point(this.Width / 2 - addBtn.Width - 20, dbDataGridView.Height + dbDataGridView.Location.Y + 20);
            delBtn.Location = new Point(addBtn.Location.X + addBtn.Width + 30, dbDataGridView.Height + dbDataGridView.Location.Y + 20);
            updateBtn.Location = new Point(delBtn.Location.X + delBtn.Width + 30, dbDataGridView.Height + dbDataGridView.Location.Y + 20);
        }

        // 테이블의 초기화
        private void TableInit()
        {
            connection.Close();
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

        // 데이터그리드뷰 초기화
        private void DBdataGridViewInit()
        {
            connection.Close();
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from " + tableComboBox.SelectedItem, connection);
            
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            //dbDataGridView.DataSource = dataset.Tables[tableComboBox.SelectedIndex];
            dbDataGridView.DataSource = dataset.Tables[0];
        }

        // 커넥션 연결
        public void setConnection(MySqlConnection connection)
        {
            this.connection = connection;
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        // 콤보박스 세팅
        private void Lang_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lang_Combobox.SelectedIndex)
            {
                case Language.english:
                    dbNameLabel.Text = "Database : " + connection.Database.ToString();
                    addBtn.Text = "Add";
                    delBtn.Text = "Delete";
                    updateBtn.Text = "Update";
                    break;
                case Language.korean:
                    dbNameLabel.Text = "데이터베이스 : " + connection.Database.ToString();
                    addBtn.Text = "추가";
                    delBtn.Text = "삭제";
                    updateBtn.Text = "변경";
                    break;
                case Language.japanese:
                    dbNameLabel.Text = "データベース : " + connection.Database.ToString();
                    addBtn.Text = "追加";
                    delBtn.Text = "削除";
                    updateBtn.Text = "変更";
                    break;
            }
            // 위치 재설정
            dbNameLabel.Location = new Point(this.Width / 2 - dbNameLabel.Width / 2, 10);
        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBdataGridViewInit();
        }

        // 데이터그리드뷰 업데이트
        private void DbDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            connection.Close();
            connection.Open();
            DataTable changes = ((DataTable)dbDataGridView.DataSource).GetChanges();
            MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from " + tableComboBox.SelectedItem, connection);
            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                adapter.UpdateCommand = mcb.GetUpdateCommand();
                adapter.Update(changes);
                ((DataTable)dbDataGridView.DataSource).AcceptChanges();
            }
            connection.Close();
        }

        public int getLang()
        {
            return lang_Combobox.SelectedIndex;
        }
        public string getTable()
        {
            return (String)tableComboBox.SelectedItem;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddIndex addindex = new AddIndex(this);
            addindex.ShowDialog();
            DBdataGridViewInit();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            DeleteIndex deleteIndex = new DeleteIndex(this);
            deleteIndex.ShowDialog();
            DBdataGridViewInit();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateIndex updateIndex = new UpdateIndex(this);
            updateIndex.ShowDialog();
            DBdataGridViewInit();
        }
    }
}
