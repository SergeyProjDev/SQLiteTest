using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace WindowsFormsDatabase
{
    public partial class Form1 : Form
    {
        const string databaseName = "cyber.db";
        const string databaseTableName = "Clients";
        SQLiteConnection connection;


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //setPassword();
        }

        //public void setPassword()
        //{
        //    connection = new SQLiteConnection($"Data Source= {databaseName} ; Version=3;");
        //    connection.Open();
        //    connection.ChangePassword(password);
        //    connection.Close();
        //}

        private void button1_Click(object sender, EventArgs e) //add to db  &  toTable
        {
            addNewValues();
            readNewValues();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delSelectedID();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delAll();
        }







        public void setDataBase()
        {
             if (!File.Exists(databaseName)) SQLiteConnection.CreateFile(databaseName);
        }
        public void getDatabaseValue()
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {databaseTableName};", connection);
                SQLiteDataReader sqlDR = command.ExecuteReader();

                while (sqlDR.Read())
                {
                    dataGridView1.Rows.Add(sqlDR.GetValue(0).ToString(), //id
                                           sqlDR.GetValue(1).ToString(), //name
                                           sqlDR.GetValue(2).ToString(), //born
                                           sqlDR.GetValue(3).ToString()  //sex
                                           );
                }
                sqlDR.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);  //file is not database exeption
                //createTable();
            }
        }
        public void createTable ()
        {
            try
            {

                SQLiteCommand command = new SQLiteCommand($"CREATE TABLE {databaseTableName} (id INTEGER PRIMARY KEY AUTOINCREMENT, name VARCHAR(30), born INT, sex VARCHAR (10));", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addNewValues()
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand($"INSERT INTO {databaseTableName} (name, born, sex) VALUES ('{textBox1.Text}', {textBox2.Text}, '{comboBox1.Text}');", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void readNewValues()
        {
            try
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand($"SELECT * FROM  {databaseTableName} ORDER BY ID DESC LIMIT 1;", connection);
                SQLiteDataReader sqlDR = command.ExecuteReader();
                while (sqlDR.Read())
                {
                    dataGridView1.Rows.Add(sqlDR.GetValue(0).ToString(), //id
                                           sqlDR.GetValue(1).ToString(), //name
                                           sqlDR.GetValue(2).ToString(), //born
                                           sqlDR.GetValue(3).ToString()  //sex
                                           );
                }
                sqlDR.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //createTable();
            }
        }
        private void delSelectedID()
        {
            
            dataGridView1.Rows.Clear();
            string deleteQuery = $"DELETE FROM {databaseTableName} WHERE id = {Convert.ToInt32(numericUpDown1.Value)}";
            connection.Open();
            SQLiteCommand command = new SQLiteCommand(deleteQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            connection.Open();
                command = new SQLiteCommand($"SELECT * FROM {databaseTableName};", connection);
                SQLiteDataReader sqlDR = command.ExecuteReader();

                while (sqlDR.Read())
                {
                    dataGridView1.Rows.Add(sqlDR.GetValue(0).ToString(), //id
                                           sqlDR.GetValue(1).ToString(), //name
                                           sqlDR.GetValue(2).ToString(), //born
                                           sqlDR.GetValue(3).ToString()  //sex
                                           );
                }
                sqlDR.Close();
            connection.Close();
        }
        private void delAll()
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand($"DELETE FROM {databaseTableName};", connection);
            command.ExecuteNonQuery();
            connection.Close();
            dataGridView1.Rows.Clear();
        }





        private void debug_Button_Click(object sender, EventArgs e)
        {
           
            connection = new SQLiteConnection($"Data Source= {databaseName} ; Version=3; Password={debug_Text.Text.ToString()};");
        
            setDataBase();
            getDatabaseValue();

            try
            {
                connection.Open();
                debug_panel.Visible = false;

                connection.Close();
            }
            catch (Exception)
            {
                debug_label.Visible = true;
                debug_label1.Visible = true;
                debug_panel.BackColor = System.Drawing.Color.Red;
            }
            

        
            

            




            

            
        }
    }



}
