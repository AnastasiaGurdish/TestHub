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
    public partial class Sign_up : Form
    {
        string Connect = @"Database=testing;Data Source=localhost;User Id=root;Password='simoncat@_99'";
        public Sign_up()
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
            string password = Convert.ToString(Password.Text);
            if (Password.Text != "")
            {
                this.label3.ForeColor = System.Drawing.SystemColors.Info;
                label3.Text = Convert.ToString("Введите пароль");
            }
        }

        private void Password2_TextChanged(object sender, EventArgs e)
        {
            if (Password2.Text != "")
            {
                this.label5.ForeColor = System.Drawing.SystemColors.Info;
                label5.Text = Convert.ToString("Введите пароль");
            }
        }

        private void Sign__up_Click(object sender, EventArgs e)
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
            if (Password2.Text == "")
            {
                this.label5.ForeColor = System.Drawing.Color.LightCoral;
                label5.Text = Convert.ToString("Вы не ввели пароль!");
            }
            if ((FirstName.Text == LastName.Text) && (FirstName.Text != "") && (LastName.Text != ""))
            {
                this.label1.ForeColor = System.Drawing.Color.LightCoral;
                label1.Text = Convert.ToString("Введены одиннаковые данные!");
                this.label2.ForeColor = System.Drawing.Color.LightCoral;
                label2.Text = Convert.ToString("Введены одиннаковые данные!");
            }
            if (Password.Text != Password2.Text)
            {
                this.label3.ForeColor = System.Drawing.Color.LightCoral;
                this.label5.ForeColor = System.Drawing.Color.LightCoral;
                label3.Text = Convert.ToString("Пароли не сопадают!");
                label5.Text = Convert.ToString("Пароли не сопадают!");
            }
           
            if ((FirstName.Text != "") && (LastName.Text != "") && (Password.Text != "") && (Password2.Text != "") && (Password.Text == Password2.Text))
            {
                string CommandText = "INSERT INTO Users (FirstName, Lastname, PasswordOfStud) VALUES (@FirstName, @LastName, @PasswordOfStud)";
                MySqlConnection myConnection = new MySqlConnection(Connect);
                myConnection.Open();
                var myCommand = new MySqlCommand(CommandText, myConnection);
                myCommand.Parameters.AddWithValue("@FirstName", FirstName.Text);
                myCommand.Parameters.AddWithValue("@LastName", LastName.Text);
                myCommand.Parameters.AddWithValue("@PasswordOfStud", Password.Text);
                try
                {
                    myCommand.ExecuteNonQuery();
                }
                catch
                {
                    label6.Text = Convert.ToString("Такой пароль уже существует!");
                    Password.Text = "";
                    Password2.Text = "";
                    return;
                }
                GetData.Password = Password.Text;
                GetData.User = FirstName.Text + " " + LastName.Text;
                Testingcards newForm = new Testingcards(this.FirstName.Text + Convert.ToString(" ") + this.LastName.Text);
                newForm.Show();
                myConnection.Close();
                FirstName.Text = "";
                LastName.Text = "";
                Password.Text = "";
                Password2.Text = "";
            }

        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (Password.Text != "")
            {
                this.label6.ForeColor = System.Drawing.SystemColors.Info;
                label6.Text = Convert.ToString("");
            }
        }
    }
}
