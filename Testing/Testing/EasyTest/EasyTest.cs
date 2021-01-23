using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Testing
{
    public partial class EasyTest : Form
    {
        static readonly Random Random = new Random();
        HashSet<int> Order = new HashSet<int>();
        HashSet<int> OrderTwo = new HashSet<int>();
        FillingForm fillForm = new FillingForm();
        ResultOfTest Result = new ResultOfTest(); //результаты теста
        List<string> ClientAnswers = new List<string>();

        public EasyTest()
        {
            InitializeComponent();
            Thread myThread = new Thread(new ThreadStart(Built2));
            myThread.Start();
            Built1();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Built1()
        {
            Qst1.Text = fillForm.AddQuest(0);
            BuildOrder(0, 4);
            int[] mass = new int[4];
            int a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer1_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer1_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer1_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer1_4.Text = fillForm.AddErrorAns(mass[3]);

            Qst2.Text = fillForm.AddQuest(1);
            Order.Clear();
            BuildOrder(4, 8);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer2_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer2_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer2_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer2_4.Text = fillForm.AddErrorAns(mass[3]);

            Qst3.Text = fillForm.AddQuest(2);
            Order.Clear();
            BuildOrder(8, 12);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer3_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer3_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer3_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer3_4.Text = fillForm.AddErrorAns(mass[3]);

            Qst4.Text = fillForm.AddQuest(3);
            Order.Clear();
            BuildOrder(12, 16);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer4_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer4_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer4_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer4_4.Text = fillForm.AddErrorAns(mass[3]);

            Qst5.Text = fillForm.AddQuest(4);
            Order.Clear();
            BuildOrder(16, 20);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer5_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer5_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer5_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer5_4.Text = fillForm.AddErrorAns(mass[3]);
            Order.Clear();
        }

        private void Built2()
        {
            Qst6.Text = fillForm.AddQuest(5);
            BuildOrderTwo(20, 24);
            int[] mass = new int[4];
            int m = 0;
            foreach (int i in OrderTwo)
            {
                mass[m++] = i;
            }
            Answer6_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer6_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer6_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer6_4.Text = fillForm.AddErrorAns(mass[3]);

            OrderTwo.Clear();
            Qst7.Text = fillForm.AddQuest(6);
            BuildOrderTwo(24, 28);
            m = 0;
            foreach (int i in OrderTwo)
            {
                mass[m++] = i;
            }
            Answer7_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer7_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer7_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer7_4.Text = fillForm.AddErrorAns(mass[3]);

            OrderTwo.Clear();
            Qst8.Text = fillForm.AddQuest(7);
            BuildOrderTwo(28, 32);
            m = 0;
            foreach (int i in OrderTwo)
            {
                mass[m++] = i;
            }
            Answer8_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer8_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer8_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer8_4.Text = fillForm.AddErrorAns(mass[3]);

            OrderTwo.Clear();
            Qst9.Text = fillForm.AddQuest(8);
            BuildOrderTwo(32, 36);
            m = 0;
            foreach (int i in OrderTwo)
            {
                mass[m++] = i;
            }
            Answer9_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer9_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer9_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer9_4.Text = fillForm.AddErrorAns(mass[3]);

            OrderTwo.Clear();
            Qst10.Text = fillForm.AddQuest(9);
            BuildOrderTwo(36, 40);
            m = 0;
            foreach (int i in OrderTwo)
            {
                mass[m++] = i;
            }
            Answer10_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer10_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer10_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer10_4.Text = fillForm.AddErrorAns(mass[3]);
        }

        void BuildOrder(int a, int b)
        {
            while (Order.Count < 4)
            {
                Order.Add(Random.Next(a, b));
            }
        }

        void BuildOrderTwo(int a, int b)
        {
            while (OrderTwo.Count < 4)
            {
                OrderTwo.Add(Random.Next(a, b));
            }
        }

        private void GetAnswers()
        {
            if (Answer1_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer1_1.Text); }
            else if (Answer1_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer1_2.Text); }
            else if (Answer1_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer1_3.Text); }
            else if (Answer1_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer1_4.Text); }

            if (Answer2_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer2_1.Text); }
            else if (Answer2_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer2_2.Text); }
            else if (Answer2_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer2_3.Text); }
            else if (Answer2_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer2_4.Text); }

            if (Answer3_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer3_1.Text); }
            else if (Answer3_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer3_2.Text); }
            else if (Answer3_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer3_3.Text); }
            else if (Answer3_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer3_4.Text); }

            if (Answer4_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer4_1.Text); }
            else if (Answer4_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer4_2.Text); }
            else if (Answer4_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer4_3.Text); }
            else if (Answer4_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer4_4.Text); }

            if (Answer5_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer5_1.Text); }
            else if (Answer5_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer5_2.Text); }
            else if (Answer5_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer5_3.Text); }
            else if (Answer5_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer5_4.Text); }

            if (Answer6_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer6_1.Text); }
            else if (Answer6_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer6_2.Text); }
            else if (Answer6_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer6_3.Text); }
            else if (Answer6_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer6_4.Text); }

            if (Answer7_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer7_1.Text); }
            else if (Answer7_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer7_2.Text); }
            else if (Answer7_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer7_3.Text); }
            else if (Answer7_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer7_4.Text); }

            if (Answer8_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer8_1.Text); }
            else if (Answer8_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer8_2.Text); }
            else if (Answer8_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer8_3.Text); }
            else if (Answer8_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer8_4.Text); }

            if (Answer9_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer9_1.Text); }
            else if (Answer9_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer9_2.Text); }
            else if (Answer9_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer9_3.Text); }
            else if (Answer9_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer9_4.Text); }

            if (Answer10_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer10_1.Text); }
            else if (Answer10_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer10_2.Text); }
            else if (Answer10_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer10_3.Text); }
            else if (Answer10_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers.Add(Answer10_4.Text); }
        }

        private void ShowCorrectAnswers()
        {
            if (Answer1_1.Text == fillForm.GetTrueAns(0)) { Answer1_1.BackColor = Color.Green; }
            else if (Answer1_2.Text == fillForm.GetTrueAns(0)) { Answer1_2.BackColor = Color.Green; }
            else if (Answer1_3.Text == fillForm.GetTrueAns(0)) { Answer1_3.BackColor = Color.Green; }
            else if (Answer1_4.Text == fillForm.GetTrueAns(0)) { Answer1_4.BackColor = Color.Green; }

            if (Answer2_1.Text == fillForm.GetTrueAns(1)) { Answer2_1.BackColor = Color.Green; }
            else if (Answer2_2.Text == fillForm.GetTrueAns(1)) { Answer2_2.BackColor = Color.Green; }
            else if (Answer2_3.Text == fillForm.GetTrueAns(1)) { Answer2_3.BackColor = Color.Green; }
            else if (Answer2_4.Text == fillForm.GetTrueAns(1)) { Answer2_4.BackColor = Color.Green; }

            if (Answer3_1.Text == fillForm.GetTrueAns(2)) { Answer3_1.BackColor = Color.Green; }
            else if (Answer3_2.Text == fillForm.GetTrueAns(2)) { Answer3_2.BackColor = Color.Green; }
            else if (Answer3_3.Text == fillForm.GetTrueAns(2)) { Answer3_3.BackColor = Color.Green; }
            else if (Answer3_4.Text == fillForm.GetTrueAns(2)) { Answer3_4.BackColor = Color.Green; }

            if (Answer4_1.Text == fillForm.GetTrueAns(3)) { Answer4_1.BackColor = Color.Green; }
            else if (Answer4_2.Text == fillForm.GetTrueAns(3)) { Answer4_2.BackColor = Color.Green; }
            else if (Answer4_3.Text == fillForm.GetTrueAns(3)) { Answer4_3.BackColor = Color.Green; }
            else if (Answer4_4.Text == fillForm.GetTrueAns(3)) { Answer4_4.BackColor = Color.Green; }

            if (Answer5_1.Text == fillForm.GetTrueAns(4)) { Answer5_1.BackColor = Color.Green; }
            else if (Answer5_2.Text == fillForm.GetTrueAns(4)) { Answer5_2.BackColor = Color.Green; }
            else if (Answer5_3.Text == fillForm.GetTrueAns(4)) { Answer5_3.BackColor = Color.Green; }
            else if (Answer5_4.Text == fillForm.GetTrueAns(4)) { Answer5_4.BackColor = Color.Green; }

            if (Answer6_1.Text == fillForm.GetTrueAns(5)) { Answer6_1.BackColor = Color.Green; }
            else if (Answer6_2.Text == fillForm.GetTrueAns(5)) { Answer6_2.BackColor = Color.Green; }
            else if (Answer6_3.Text == fillForm.GetTrueAns(5)) { Answer6_3.BackColor = Color.Green; }
            else if (Answer6_4.Text == fillForm.GetTrueAns(5)) { Answer6_4.BackColor = Color.Green; }

            if (Answer7_1.Text == fillForm.GetTrueAns(6)) { Answer7_1.BackColor = Color.Green; }
            else if (Answer7_2.Text == fillForm.GetTrueAns(6)) { Answer7_2.BackColor = Color.Green; }
            else if (Answer7_3.Text == fillForm.GetTrueAns(6)) { Answer7_3.BackColor = Color.Green; }
            else if (Answer7_4.Text == fillForm.GetTrueAns(6)) { Answer7_4.BackColor = Color.Green; }

            if (Answer8_1.Text == fillForm.GetTrueAns(7)) { Answer8_1.BackColor = Color.Green; }
            else if (Answer8_2.Text == fillForm.GetTrueAns(7)) { Answer8_2.BackColor = Color.Green; }
            else if (Answer8_3.Text == fillForm.GetTrueAns(7)) { Answer8_3.BackColor = Color.Green; }
            else if (Answer8_4.Text == fillForm.GetTrueAns(7)) { Answer8_4.BackColor = Color.Green; }

            if (Answer9_1.Text == fillForm.GetTrueAns(8)) { Answer9_1.BackColor = Color.Green; }
            else if (Answer9_2.Text == fillForm.GetTrueAns(8)) { Answer9_2.BackColor = Color.Green; }
            else if (Answer9_3.Text == fillForm.GetTrueAns(8)) { Answer9_3.BackColor = Color.Green; }
            else if (Answer9_4.Text == fillForm.GetTrueAns(8)) { Answer9_4.BackColor = Color.Green; }

            if (Answer10_1.Text == fillForm.GetTrueAns(9)) { Answer10_1.BackColor = Color.Green; }
            else if (Answer10_2.Text == fillForm.GetTrueAns(9)) { Answer10_2.BackColor = Color.Green; }
            else if (Answer10_3.Text == fillForm.GetTrueAns(9)) { Answer10_3.BackColor = Color.Green; }
            else if (Answer10_4.Text == fillForm.GetTrueAns(9)) { Answer10_4.BackColor = Color.Green; }
        }

        private void Finish_Test_Click(object sender, EventArgs e)
        {
            int result = 0;
            GetAnswers();
            if (ClientAnswers.Count == 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (ClientAnswers[i] == fillForm.GetTrueAns(i))
                    { result++; }
                }
                Results res = new Results(result);
                res.Show();
                Result.AddResultL(GetData.User, GetData.TestName, "Легкий", result, ClientAnswers.Count);
                ShowCorrectAnswers();
            }
            else
            {
                MessageBox.Show("Вы не ответили на все тестовые задания!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            ClientAnswers.Clear();
        }

        private void Answer1_1_Click(object sender, EventArgs e)
        {
            Answer1_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer1_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer1_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer1_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer1_2_Click(object sender, EventArgs e)
        {
            Answer1_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer1_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer1_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer1_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer1_3_Click(object sender, EventArgs e)
        {
            Answer1_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer1_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer1_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer1_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer1_4_Click(object sender, EventArgs e)
        {
            Answer1_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer1_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer1_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer1_4.BackColor = Color.FromArgb(26, 177, 136);
        }

        private void Answer2_1_Click(object sender, EventArgs e)
        {
            Answer2_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer2_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer2_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer2_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer2_2_Click(object sender, EventArgs e)
        {
            Answer2_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer2_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer2_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer2_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer2_3_Click(object sender, EventArgs e)
        {
            Answer2_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer2_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer2_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer2_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer2_4_Click(object sender, EventArgs e)
        {
            Answer2_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer2_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer2_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer2_4.BackColor = Color.FromArgb(26, 177, 136);
        }

        private void Answer3_1_Click(object sender, EventArgs e)
        {
            Answer3_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer3_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer3_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer3_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer3_2_Click(object sender, EventArgs e)
        {
            Answer3_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer3_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer3_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer3_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer3_3_Click(object sender, EventArgs e)
        {
            Answer3_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer3_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer3_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer3_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer3_4_Click(object sender, EventArgs e)
        {
            Answer3_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer3_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer3_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer3_4.BackColor = Color.FromArgb(26, 177, 136);
        }

        private void Answer4_1_Click(object sender, EventArgs e)
        {
            Answer4_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer4_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer4_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer4_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer4_2_Click(object sender, EventArgs e)
        {
            Answer4_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer4_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer4_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer4_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer4_3_Click(object sender, EventArgs e)
        {
            Answer4_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer4_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer4_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer4_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer4_4_Click(object sender, EventArgs e)
        {
            Answer4_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer4_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer4_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer4_4.BackColor = Color.FromArgb(26, 177, 136);
        }

        private void Answer5_1_Click(object sender, EventArgs e)
        {
            Answer5_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer5_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer5_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer5_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer5_2_Click(object sender, EventArgs e)
        {
            Answer5_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer5_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer5_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer5_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer5_3_Click(object sender, EventArgs e)
        {
            Answer5_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer5_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer5_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer5_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer5_4_Click(object sender, EventArgs e)
        {
            Answer5_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer5_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer5_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer5_4.BackColor = Color.FromArgb(26, 177, 136);
        }

        private void Answer6_1_Click(object sender, EventArgs e)
        {
            Answer6_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer6_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer6_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer6_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer6_2_Click(object sender, EventArgs e)
        {
            Answer6_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer6_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer6_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer6_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer6_3_Click(object sender, EventArgs e)
        {
            Answer6_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer6_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer6_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer6_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer6_4_Click(object sender, EventArgs e)
        {
            Answer6_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer6_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer6_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer6_4.BackColor = Color.FromArgb(26, 177, 136);
        }

        private void Answer7_1_Click(object sender, EventArgs e)
        {
            Answer7_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer7_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer7_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer7_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer7_2_Click(object sender, EventArgs e)
        {
            Answer7_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer7_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer7_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer7_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer7_3_Click(object sender, EventArgs e)
        {
            Answer7_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer7_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer7_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer7_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer7_4_Click(object sender, EventArgs e)
        {
            Answer7_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer7_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer7_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer7_4.BackColor = Color.FromArgb(26, 177, 136);
        }

        private void Answer8_1_Click(object sender, EventArgs e)
        {
            Answer8_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer8_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer8_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer8_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer8_2_Click(object sender, EventArgs e)
        {
            Answer8_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer8_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer8_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer8_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer8_3_Click(object sender, EventArgs e)
        {
            Answer8_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer8_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer8_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer8_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer8_4_Click(object sender, EventArgs e)
        {
            Answer8_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer8_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer8_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer8_4.BackColor = Color.FromArgb(26, 177, 136);
        }

        private void Answer9_1_Click(object sender, EventArgs e)
        {
            Answer9_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer9_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer9_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer9_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer9_2_Click(object sender, EventArgs e)
        {
            Answer9_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer9_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer9_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer9_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer9_3_Click(object sender, EventArgs e)
        {
            Answer9_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer9_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer9_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer9_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer9_4_Click(object sender, EventArgs e)
        {
            Answer9_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer9_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer9_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer9_4.BackColor = Color.FromArgb(26, 177, 136);
        }

        private void Answer10_1_Click(object sender, EventArgs e)
        {
            Answer10_1.BackColor = Color.FromArgb(26, 177, 136);
            Answer10_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer10_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer10_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer10_2_Click(object sender, EventArgs e)
        {
            Answer10_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer10_2.BackColor = Color.FromArgb(26, 177, 136);
            Answer10_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer10_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer10_3_Click(object sender, EventArgs e)
        {
            Answer10_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer10_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer10_3.BackColor = Color.FromArgb(26, 177, 136);
            Answer10_4.BackColor = Color.FromArgb(36, 49, 60);
        }

        private void Answer10_4_Click(object sender, EventArgs e)
        {
            Answer10_1.BackColor = Color.FromArgb(36, 49, 60);
            Answer10_2.BackColor = Color.FromArgb(36, 49, 60);
            Answer10_3.BackColor = Color.FromArgb(36, 49, 60);
            Answer10_4.BackColor = Color.FromArgb(26, 177, 136);
        }

    }
}
