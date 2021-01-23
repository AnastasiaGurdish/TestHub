using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Testing
{
    class FillingArduousTest
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=testing;password=simoncat@_99;");
        public List<string> QuestForСonformity = new List<string>();   //список вопросов
        public HashSet<int> Number = new HashSet<int>();  //колличество тестов в тесте часть вторая
        public List<string> Сonformity = new List<string>(); //список сопостовлений слева
        public List<string> Сouple = new List<string>(); //список сопостовлений справа
        Random Random = new Random();
        int idMAX, idMIN = 0;

        public FillingArduousTest(int n)
        {
            connection.Open();
            MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT MAX(id) FROM testing.questions_for_arduoustest where idOfTopic = '{GetData.IDofTopic}'", connection);
            idMAX = Convert.ToInt32(sqlCommand2.ExecuteScalar());
            MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT MIN(id) FROM testing.questions_for_arduoustest where idOfTopic = '{GetData.IDofTopic}'", connection);
            idMIN = Convert.ToInt32(sqlCommand1.ExecuteScalar()) - 1;
            while (Number.Count < n)
            {
                Number.Add(Random.Next(idMIN, idMAX));
            }
            connection.Close();
        }

        public void Search2()
        {
            connection.Open();
            foreach (int i in Number)
            {
                MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT Question FROM testing.questions_for_arduoustest where id='{i + 1}'", connection);
                QuestForСonformity.Add(Convert.ToString(sqlCommand1.ExecuteScalar()));

                MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT Сonformity FROM testing.questions_for_arduoustest where id='{i + 1}'", connection);
                Сonformity.Add(Convert.ToString(sqlCommand2.ExecuteScalar()));

                MySqlCommand sqlCommand3 = new MySqlCommand($"SELECT Сonformity1 FROM testing.questions_for_arduoustest where id='{i + 1}'", connection);
                Сonformity.Add(Convert.ToString(sqlCommand3.ExecuteScalar()));

                MySqlCommand sqlCommand4 = new MySqlCommand($"SELECT Сonformity2 FROM testing.questions_for_arduoustest where id='{i + 1}'", connection);
                Сonformity.Add(Convert.ToString(sqlCommand4.ExecuteScalar()));

                MySqlCommand sqlCommand5 = new MySqlCommand($"SELECT CoupleToConf FROM testing.questions_for_arduoustest where id='{i + 1}'", connection);
                Сouple.Add(Convert.ToString(sqlCommand5.ExecuteScalar()));

                MySqlCommand sqlCommand6 = new MySqlCommand($"SELECT CoupleToConf1 FROM testing.questions_for_arduoustest where id='{i + 1}'", connection);
                Сouple.Add(Convert.ToString(sqlCommand6.ExecuteScalar()));

                MySqlCommand sqlCommand7 = new MySqlCommand($"SELECT CoupleToConf2 FROM testing.questions_for_arduoustest where id='{i + 1}'", connection);
                Сouple.Add(Convert.ToString(sqlCommand7.ExecuteScalar()));
            }
            connection.Close();
        }
    }
}
