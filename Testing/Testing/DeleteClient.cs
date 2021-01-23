using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Testing
{
    class DeleteClient
    {
        string Connect = @"Database=testing;Data Source=localhost;User Id=root;Password='simoncat@_99'";
        public DeleteClient ()
        {
            MySqlConnection connection = new MySqlConnection(Connect);
            connection.Open();
            string DeleteClient = $"delete from testing.users where PasswordOfStud = '{GetData.Password}'";
            MySqlCommand command = new MySqlCommand(DeleteClient, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
