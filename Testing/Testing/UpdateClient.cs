using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Testing
{
    class UpdateClient
    {
        string Connect = @"Database=testing;Data Source=localhost;User Id=root;Password='simoncat@_99'";
        public UpdateClient(string Name, string Lastname, string Password)
        {
            MySqlConnection connection = new MySqlConnection(Connect);
            connection.Open();
            if (Name != "")
            {
                string sqlUpdateName = $"update testing.users set FirstName = '{Name}' where PasswordOfStud = '{GetData.Password}'";
                MySqlCommand command = new MySqlCommand(sqlUpdateName, connection);
                command.ExecuteNonQuery();
            }
            if (Lastname != "")
            {
                string sqlUpdateLastname = $"update testing.users set Lastname = '{Lastname}' where PasswordOfStud = '{GetData.Password}'";
                MySqlCommand command = new MySqlCommand(sqlUpdateLastname, connection);
                command.ExecuteNonQuery();
            }
            if(Password!="")
            {
                string sqlUpdatePass = $"update testing.users set PasswordOfStud = '{Password}' where PasswordOfStud = '{GetData.Password}'";
                MySqlCommand command = new MySqlCommand(sqlUpdatePass, connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

    }
}
