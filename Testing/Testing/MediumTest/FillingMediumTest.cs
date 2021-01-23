using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Testing
{
    class FillingMediumTest
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=testing;password=simoncat@_99;");
        public List<string> Quest = new List<string>();   //список вопросов
        public List<string> TrueAnswers = new List<string>();  //список правильных ответов
        public List<string> FalseAnswers = new List<string>();  //список ошибочных ответов
        public HashSet<int> Number = new HashSet<int>();  //колличество тестов в тесте

        public List<string> QuestForСonformity = new List<string>();   //список вопросов
        public HashSet<int> Number1 = new HashSet<int>();  //колличество тестов в тесте часть вторая
        public List<string> Сonformity = new List<string>(); //список сопостовлений слева
        public List<string> Сouple = new List<string>(); //список сопостовлений справа

        Random Random = new Random();
        int idMAX, idMIN = 0;
        int idMAX1, idMIN1 = 0;

        public FillingMediumTest(int n)
        {
            connection.Open();
            MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT MAX(Id) FROM testing.questions_for_mediumtest_part1 where IdOfTopic = '{GetData.IDofTopic}'", connection);
            idMAX = Convert.ToInt32(sqlCommand2.ExecuteScalar());
            MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT MIN(Id) FROM testing.questions_for_mediumtest_part1 where IdOfTopic = '{GetData.IDofTopic}'", connection);
            idMIN = Convert.ToInt32(sqlCommand1.ExecuteScalar()) - 1;
            while (Number.Count < n)
            {
                Number.Add(Random.Next(idMIN, idMAX));
            }
            connection.Close();
        }

        public void FillConformity(int k)
        {
            connection.Open();
            MySqlCommand sqlCommand3 = new MySqlCommand($"SELECT MAX(Id) FROM testing.questions_for_mediumtest_part2 where IdOfTopic = '{GetData.IDofTopic}'", connection);
            idMAX1 = Convert.ToInt32(sqlCommand3.ExecuteScalar());
            MySqlCommand sqlCommand4 = new MySqlCommand($"SELECT MIN(Id) FROM testing.questions_for_mediumtest_part2 where IdOfTopic = '{GetData.IDofTopic}'", connection);
            idMIN1 = Convert.ToInt32(sqlCommand4.ExecuteScalar()) - 1;
            while (Number1.Count < k)
            {
                Number1.Add(Random.Next(idMIN1, idMAX1));
            }
            connection.Close();
        }

        public void Search1()
        {
            connection.Open();
            foreach (int i in Number)
            {
                MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT Question FROM testing.questions_for_mediumtest_part1 where Id='{i + 1}'", connection);
                Quest.Add(Convert.ToString(sqlCommand1.ExecuteScalar()));
                MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT TrueAnswer FROM testing.questions_for_mediumtest_part1 where Id='{i + 1}'", connection);
                TrueAnswers.Add(Convert.ToString(sqlCommand2.ExecuteScalar()));
                MySqlCommand sqlCommand3 = new MySqlCommand($"SELECT TrueAnswer FROM testing.questions_for_mediumtest_part1 where Id='{i + 1}'", connection);
                FalseAnswers.Add(Convert.ToString(sqlCommand3.ExecuteScalar()));
                MySqlCommand sqlCommand4 = new MySqlCommand($"SELECT FalseAnswer FROM testing.questions_for_mediumtest_part1 where Id='{i + 1}'", connection);
                FalseAnswers.Add(Convert.ToString(sqlCommand4.ExecuteScalar()));
                MySqlCommand sqlCommand5 = new MySqlCommand($"SELECT FalseAnswer1 FROM testing.questions_for_mediumtest_part1 where Id='{i + 1}'", connection);
                FalseAnswers.Add(Convert.ToString(sqlCommand5.ExecuteScalar()));
                MySqlCommand sqlCommand6 = new MySqlCommand($"SELECT FalseAnswer2 FROM testing.questions_for_mediumtest_part1 where Id='{i + 1}'", connection);
                FalseAnswers.Add(Convert.ToString(sqlCommand6.ExecuteScalar()));
            }
            connection.Close();
        }

        public void Search2()
        {
            connection.Open();
            foreach (int i in Number1)
            {
                MySqlCommand sqlCommand1 = new MySqlCommand($"SELECT Question FROM testing.questions_for_mediumtest_part2 where Id='{i + 1}'", connection);
                QuestForСonformity.Add(Convert.ToString(sqlCommand1.ExecuteScalar()));

                MySqlCommand sqlCommand2 = new MySqlCommand($"SELECT Сonformity FROM testing.questions_for_mediumtest_part2 where Id='{i + 1}'", connection);
                Сonformity.Add(Convert.ToString(sqlCommand2.ExecuteScalar()));

                MySqlCommand sqlCommand3 = new MySqlCommand($"SELECT Сonformity1 FROM testing.questions_for_mediumtest_part2 where Id='{i + 1}'", connection);
                Сonformity.Add(Convert.ToString(sqlCommand3.ExecuteScalar()));

                MySqlCommand sqlCommand4 = new MySqlCommand($"SELECT Сonformity2 FROM testing.questions_for_mediumtest_part2 where Id='{i + 1}'", connection);
                Сonformity.Add(Convert.ToString(sqlCommand4.ExecuteScalar()));

                MySqlCommand sqlCommand5 = new MySqlCommand($"SELECT Сonformity3 FROM testing.questions_for_mediumtest_part2 where Id='{i + 1}'", connection);
                Сonformity.Add(Convert.ToString(sqlCommand5.ExecuteScalar()));

                MySqlCommand sqlCommand6 = new MySqlCommand($"SELECT CoupleToConf FROM testing.questions_for_mediumtest_part2 where Id='{i + 1}'", connection);
                Сouple.Add(Convert.ToString(sqlCommand6.ExecuteScalar()));

                MySqlCommand sqlCommand7 = new MySqlCommand($"SELECT CoupleToConf1 FROM testing.questions_for_mediumtest_part2 where Id='{i + 1}'", connection);
                Сouple.Add(Convert.ToString(sqlCommand7.ExecuteScalar()));

                MySqlCommand sqlCommand8 = new MySqlCommand($"SELECT CoupleToConf2 FROM testing.questions_for_mediumtest_part2 where Id='{i + 1}'", connection);
                Сouple.Add(Convert.ToString(sqlCommand8.ExecuteScalar()));

                MySqlCommand sqlCommand9 = new MySqlCommand($"SELECT CoupleToConf3 FROM testing.questions_for_mediumtest_part2 where Id='{i + 1}'", connection);
                Сouple.Add(Convert.ToString(sqlCommand9.ExecuteScalar()));

            }
            connection.Close();
        }
    }
}
