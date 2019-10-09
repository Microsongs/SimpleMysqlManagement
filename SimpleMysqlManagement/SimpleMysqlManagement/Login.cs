using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SimpleMysqlManagement
{
    public partial class Login : Form
    {
        MainForm mainform;
        public Login(MainForm main)
        {
            InitializeComponent();
            mainform = main;
            Init();
        }
        private void Init()
        {
            loginLabel.Location = new Point(this.Width / 2 - loginLabel.Width / 2, 10);
            serverLabel.Location = new Point(100, loginLabel.Location.Y + loginLabel.Height + 10);
            serverTextbox.Location = new Point(serverLabel.Location.X + serverLabel.Width + 30, serverLabel.Location.Y);
            databaseLabel.Location = new Point(100, serverLabel.Location.Y + serverLabel.Height + 10);
            databaseTextbox.Location = new Point(serverLabel.Location.X + serverLabel.Width + 30, databaseLabel.Location.Y);
            userIDLabel.Location = new Point(100, databaseLabel.Location.Y + databaseLabel.Height + 10);
            userIDTextbox.Location = new Point(serverLabel.Location.X + serverLabel.Width + 30, userIDLabel.Location.Y);
            passwordLabel.Location = new Point(100, userIDLabel.Location.Y + userIDLabel.Height + 10);
            passwordTextbox.Location = new Point(serverLabel.Location.X + serverLabel.Width + 30, passwordLabel.Location.Y);

            saveButton.Location = new Point(serverTextbox.Location.X + serverTextbox.Width + 20, serverTextbox.Location.Y);
            loadButton.Location = new Point(saveButton.Location.X, saveButton.Location.Y + saveButton.Height + 20);

            azureCheckbox.Location = new Point(this.Width / 2 - azureCheckbox.Width / 2, passwordLabel.Location.Y + passwordLabel.Height + 10);
            loginButton.Location = new Point(this.Width / 2 - loginButton.Width / 2, azureCheckbox.Location.Y + azureCheckbox.Height + 20);
            azureCheckbox.Checked = true;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(azureCheckbox.Checked == true)
            {
                try
                {
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
                    {
                        Server = serverTextbox.Text,
                        Database = databaseTextbox.Text,
                        UserID = userIDTextbox.Text,
                        Password = passwordTextbox.Text,
                        SslMode = MySqlSslMode.Required,
                    };
                    MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
                    connection.Open();
                    Debug.WriteLine("오픈");
                    connection.Close();
                    Debug.WriteLine("종료");

                    mainform.setConnection(connection);
                    MessageBox.Show("Login Success!");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection("Server=" + serverTextbox.Text + ";Database=" + databaseTextbox.Text + ";Uid=" + userIDTextbox.Text + ";Pwd=" + passwordTextbox.Text + ";");
                    connection.Open();
                    connection.Close();

                    mainform.setConnection(connection);
                    MessageBox.Show("Login Success!");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string sDirPath = @"C:\temp";
            DirectoryInfo di = new DirectoryInfo(sDirPath);
            if (di.Exists == false)
                di.Create();

            using (StreamWriter outputFile = new StreamWriter(@"C:\temp\loginData.dat"))
            {
                outputFile.WriteLine(serverTextbox.Text);
                outputFile.WriteLine(databaseTextbox.Text);
                outputFile.WriteLine(userIDTextbox.Text);
                outputFile.WriteLine(passwordTextbox.Text);
                MessageBox.Show("저장 완료!");
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] loadFile = File.ReadAllLines(@"C:\temp\loginData.dat");
                serverTextbox.Text = loadFile[0];
                databaseTextbox.Text = loadFile[1];
                userIDTextbox.Text = loadFile[2];
                passwordTextbox.Text = loadFile[3];
                MessageBox.Show("불러오기 완료");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
