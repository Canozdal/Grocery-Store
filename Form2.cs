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

namespace Grocery_Store_Online
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM groceries";

            using (MySqlCommand command = new MySqlCommand(sqlQuery, Program.getConnector()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string data = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                        groceryListBox.Items.Add(data);
                    }
                }
            }
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
        }
    }
}
