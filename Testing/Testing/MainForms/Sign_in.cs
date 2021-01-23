using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Testing
{
    public partial class Sign_in : Form
    {
        string Connect = @"Database=testing;Data Source=localhost;User Id=root;Password='simoncat@_99'";
        public Sign_in()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            string firstName = Convert.ToString(FirstName.Text);
            if (FirstName.Text != "")
            {
                this.label1.ForeColor = System.Drawing.SystemColors.Info;
                label1.Text = Convert.ToString("Имя");
            }
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {
            string lastName = Convert.ToString(LastName.Text);
            if (LastName.Text != "")
            {
                this.label2.ForeColor = System.Drawing.SystemColors.Info;
                label2.Text = Convert.ToString("Фамилия");
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
            string password = Convert.ToString(Password.Text);
            if (Password.Text != "")
            {
                this.label3.ForeColor = System.Drawing.SystemColors.Info;
                label3.Text = Convert.ToString("Введите пароль");
            }
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                this.label1.ForeColor = System.Drawing.Color.LightCoral;
                label1.Text = Convert.ToString("Введите имя!");
            }
            if (LastName.Text == "")
            {
                this.label2.ForeColor = System.Drawing.Color.LightCoral;
                label2.Text = Convert.ToString("Введите фамилию!");
            }
            if (Password.Text == "")
            {
                this.label3.ForeColor = System.Drawing.Color.LightCoral;
                label3.Text = Convert.ToString("Вы не ввели пароль!");
            }
            if ((FirstName.Text == LastName.Text) && (FirstName.Text != "") && (LastName.Text != ""))
            {
                this.label1.ForeColor = System.Drawing.Color.LightCoral;
                label1.Text = Convert.ToString("Введены одиннаковые данные!");
                this.label2.ForeColor = System.Drawing.Color.LightCoral;
                label2.Text = Convert.ToString("Введены одиннаковые данные!");
            }
            if ((FirstName.Text != "") && (LastName.Text != "") && (Password.Text != ""))
            {
                string CommandText = "SELECT FirstName FROM users WHERE FirstName=@FirstName";
                string CommandText1 = "SELECT Lastname FROM users WHERE Lastname=@Lastname";
                string CommandText2 = "SELECT PasswordOfStud FROM users WHERE PasswordOfStud=@PasswordOfStud";
                MySqlConnection myConnection = new MySqlConnection(Connect);
                myConnection.Open();

                var myCommand = new MySqlCommand(CommandText, myConnection);
                myCommand.Parameters.AddWithValue("@FirstName", FirstName.Text);

                var myCommand1 = new MySqlCommand(CommandText1, myConnection);
                myCommand1.Parameters.AddWithValue("@LastName", LastName.Text);

                var myCommand2 = new MySqlCommand(CommandText2, myConnection);
                myCommand2.Parameters.AddWithValue("@PasswordOfStud", Password.Text);

                myCommand.ExecuteNonQuery();
                myCommand1.ExecuteNonQuery();
                myCommand2.ExecuteNonQuery();
                string rez = (string)myCommand.ExecuteScalar();//результат запроса
                string rez1 = (string)myCommand1.ExecuteScalar();//результат запроса
                string rez2 = (string)myCommand2.ExecuteScalar();//результат запроса
                GetData.Password = rez2;
                GetData.User = rez + " " + rez1;
                if ((rez == FirstName.Text) && (rez1 == LastName.Text) && (rez2 == Password.Text))
                {
                    Testingcards newForm = new Testingcards(this.FirstName.Text + Convert.ToString(" ") + this.LastName.Text);
                    newForm.Show();
                }
                else
                {
                    label6.Text = Convert.ToString("Ошибка входа! Неправильно ведены данные!");
                }
                myConnection.Close();
                FirstName.Text = "";
                LastName.Text = "";
                Password.Text = "";
            }
        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            Sign_up newForm = new Sign_up();
            newForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if ((Password.Text == "") && (FirstName.Text == "") && (LastName.Text == ""))
            {
                this.label6.ForeColor = System.Drawing.SystemColors.Info;
                label6.Text = Convert.ToString("");
            }
        }
    }
}


