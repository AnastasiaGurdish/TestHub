using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Testing
{
    class PutTopic
    {
        string Connect = @"Database=testing;Data Source=localhost;User Id=root;Password='simoncat@_99'";
        public List<string> putTopic = new List<string>();
        public PutTopic()
        {
            putTopic.Clear();
            MySqlConnection connection = new MySqlConnection(Connect);
            connection.Open();
            string select = $"select topic from testing.topics";
            MySqlCommand sqlCommand = new MySqlCommand(select, connection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                putTopic.Add(reader[0].ToString());
            }
            reader.Close();
            connection.Close();
        }
    }
}
