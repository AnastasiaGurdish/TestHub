using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Testing
{
    class FillingEasyTest
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=testing;password=simoncat@_99;");
        public List<string> Quest = new List<string>();   //список вопросов
        public List<string> TrueAnswers = new List<string>();  //список правильных ответов
        public List<string> FalseAnswers = new List<string>();  //список ошибочных ответов
        public HashSet<int> N = new HashSet<int>();  //колличество тестовых заданий в тесте
        Random Random = new Random();
        int idMAX, idMIN = 0;

        public int IDMAX { get { return idMAX; } }
        public int IDMIN { get { return idMIN; } }

        public FillingEasyTest(int n)
        {
            connection.Open();
            MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT MAX(Id) FROM testing.questions_for_easytest where IdOfTopic = '{GetData.IDofTopic}'", connection);
            idMAX = Convert.ToInt32(sqlCommand2.ExecuteScalar());
            MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT MIN(Id) FROM testing.questions_for_easytest where IdOfTopic = '{GetData.IDofTopic}'", connection);
            idMIN = Convert.ToInt32(sqlCommand1.ExecuteScalar()) - 1;
            while (N.Count < n)
            {
                N.Add(Random.Next(idMIN, idMAX));
            }
            connection.Close();
        }

        public void Search()
        {
            connection.Open();
            foreach (int i in N)
            {
                MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT Question FROM testing.questions_for_easytest where Id='{i + 1}'", connection);
                Quest.Add(Convert.ToString(sqlCommand1.ExecuteScalar()));
                MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT TrueAnswer FROM testing.questions_for_easytest where Id='{i + 1}'", connection);
                TrueAnswers.Add(Convert.ToString(sqlCommand2.ExecuteScalar()));
                MySqlCommand sqlCommand3 = new MySqlCommand($"SELECT TrueAnswer FROM testing.questions_for_easytest where Id='{i + 1}'", connection);
                FalseAnswers.Add(Convert.ToString(sqlCommand3.ExecuteScalar()));
                MySqlCommand sqlCommand4 = new MySqlCommand($"SELECT FalseAnswer FROM testing.questions_for_easytest where Id='{i + 1}'", connection);
                FalseAnswers.Add(Convert.ToString(sqlCommand4.ExecuteScalar()));
                MySqlCommand sqlCommand5 = new MySqlCommand($"SELECT FalseAnswer1 FROM testing.questions_for_easytest where Id='{i + 1}'", connection);
                FalseAnswers.Add(Convert.ToString(sqlCommand5.ExecuteScalar()));
                MySqlCommand sqlCommand6 = new MySqlCommand($"SELECT FalseAnswer2 FROM testing.questions_for_easytest where Id='{i + 1}'", connection);
                FalseAnswers.Add(Convert.ToString(sqlCommand6.ExecuteScalar()));
            }
            connection.Close();
        }

    }
}
