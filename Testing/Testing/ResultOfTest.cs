using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Testing
{
    class ResultOfTest
    {
        public void AddResultL(string User, string TestName, string Level, int trueAns, int Ans)
        {
            string push = Convert.ToString(Math.Round((double)trueAns * 100 / Ans, 2)) + "%";
            string Connect = @"Database=testing;Data Source=localhost;User Id=root;Password='simoncat@_99'";
            MySqlConnection myConnection = new MySqlConnection(Connect);
            try
            {
                myConnection.Open();
                string AddRes = $"insert testing.results (UserName,TestName,Level,Result,Date) values ('{User}','{TestName}','{Level}','{push}','{DateTime.Now}')";
                MySqlCommand sqlCommand = new MySqlCommand(AddRes, myConnection);
                sqlCommand.ExecuteNonQuery();
            }
            catch { }
            myConnection.Close();
        }

    }
}
