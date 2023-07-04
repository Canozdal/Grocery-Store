using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Grocery_Store_Online
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValueUserName = textBox1.Text;
            string searchValuePassword = textBox2.Text;
            string sqlQuery = "SELECT * FROM user WHERE username = '{searchValueUserName}' AND password = '{searchValuePassword}'";


            using (MySqlCommand command = new MySqlCommand(sqlQuery, Program.getConnector()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Debug.WriteLine("Successful Read");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO user (username,password) VALUES (@usernamestr,@passwordstr)";
            string usernamestr = textBox1.Text;
            string passwordstr = textBox2.Text;
            using (MySqlCommand command = new MySqlCommand(sqlInsert, Program.getConnector()))
            {
                command.Parameters.AddWithValue("@usernamestr", usernamestr);
                command.Parameters.AddWithValue("@passwordstr", passwordstr);

                int rowsAffected = command.ExecuteNonQuery();

                if(rowsAffected == 0)
                {
                    Console.WriteLine("Failed");
                }
                else
                {
                    Debug.WriteLine("Successfully Inserted Values");
                }
            }
        }
    }
}
