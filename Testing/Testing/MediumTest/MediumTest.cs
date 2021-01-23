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
    public partial class MediumTest : Form
    {
        static readonly Random Random = new Random();
        HashSet<int> Order = new HashSet<int>();
        HashSet<int> OrderTwo = new HashSet<int>();
        FillingForm1 fillForm = new FillingForm1();
        ResultOfTest Result = new ResultOfTest(); //результаты теста
        List<string> ClientAnswers = new List<string>();
        List<string> ClientAnswers1 = new List<string>();


        Color[] Colors = { Color.FromArgb(0, 125, 255), Color.FromArgb(26, 177, 136), Color.FromArgb(255, 49, 49), Color.FromArgb(255, 255, 49) };
        Color c1 = Color.FromArgb(0, 125, 255), c2 = Color.FromArgb(0, 125, 255), c3 = Color.FromArgb(0, 125, 255);

        public MediumTest()
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

            Qst6.Text = fillForm.AddQuest(5);
            Order.Clear();
            BuildOrder(20, 24);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer6_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer6_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer6_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer6_4.Text = fillForm.AddErrorAns(mass[3]);

            Qst7.Text = fillForm.AddQuest(6);
            Order.Clear();
            BuildOrder(24, 28);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Answer7_1.Text = fillForm.AddErrorAns(mass[0]);
            Answer7_2.Text = fillForm.AddErrorAns(mass[1]);
            Answer7_3.Text = fillForm.AddErrorAns(mass[2]);
            Answer7_4.Text = fillForm.AddErrorAns(mass[3]);
            Order.Clear();
        }

        private void Built2()
        {
            Qst8.Text = fillForm.AddQuestForСonformity(0);
            Qst9.Text = fillForm.AddQuestForСonformity(1);
            Qst10.Text = fillForm.AddQuestForСonformity(2);

            Сonformity1_1.Text = fillForm.AddConformity(0);
            Сonformity1_2.Text = fillForm.AddConformity(1);
            Сonformity1_3.Text = fillForm.AddConformity(2);
            Сonformity1_4.Text = fillForm.AddConformity(3);
            BuildOrderTwo(0, 4);
            int a = 0;
            int[] mass = new int[4];

            foreach (int i in OrderTwo)
            {
                mass[a++] = i;
            }
            Couple1_1.Text = fillForm.AddCouple(mass[0]);
            Couple1_2.Text = fillForm.AddCouple(mass[1]);
            Couple1_3.Text = fillForm.AddCouple(mass[2]);
            Couple1_4.Text = fillForm.AddCouple(mass[3]);

            Сonformity2_1.Text = fillForm.AddConformity(4);
            Сonformity2_2.Text = fillForm.AddConformity(5);
            Сonformity2_3.Text = fillForm.AddConformity(6);
            Сonformity2_4.Text = fillForm.AddConformity(7);
            OrderTwo.Clear();
            BuildOrderTwo(4, 8);
            a = 0;
            foreach (int i in OrderTwo)
            {
                mass[a++] = i;
            }
            Couple2_1.Text = fillForm.AddCouple(mass[0]);
            Couple2_2.Text = fillForm.AddCouple(mass[1]);
            Couple2_3.Text = fillForm.AddCouple(mass[2]);
            Couple2_4.Text = fillForm.AddCouple(mass[3]);

            Сonformity3_1.Text = fillForm.AddConformity(8);
            Сonformity3_2.Text = fillForm.AddConformity(9);
            Сonformity3_3.Text = fillForm.AddConformity(10);
            Сonformity3_4.Text = fillForm.AddConformity(11);
            OrderTwo.Clear();
            BuildOrderTwo(8, 12);
            a = 0;
            foreach (int i in OrderTwo)
            {
                mass[a++] = i;
            }
            Couple3_1.Text = fillForm.AddCouple(mass[0]);
            Couple3_2.Text = fillForm.AddCouple(mass[1]);
            Couple3_3.Text = fillForm.AddCouple(mass[2]);
            Couple3_4.Text = fillForm.AddCouple(mass[3]);
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



            if (Couple1_1.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple1_1.Text); }
            else if (Couple1_2.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple1_2.Text); }
            else if (Couple1_3.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple1_3.Text); }
            else if (Couple1_4.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple1_4.Text); }

            if (Couple1_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple1_1.Text); }
            else if (Couple1_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple1_2.Text); }
            else if (Couple1_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple1_3.Text); }
            else if (Couple1_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple1_4.Text); }

            if (Couple1_1.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple1_1.Text); }
            else if (Couple1_2.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple1_2.Text); }
            else if (Couple1_3.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple1_3.Text); }
            else if (Couple1_4.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple1_4.Text); }

            if (Couple1_1.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple1_1.Text); }
            else if (Couple1_2.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple1_2.Text); }
            else if (Couple1_3.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple1_3.Text); }
            else if (Couple1_4.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple1_4.Text); }



            if (Couple2_1.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple2_1.Text); }
            else if (Couple2_2.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple2_2.Text); }
            else if (Couple2_3.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple2_3.Text); }
            else if (Couple2_4.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple2_4.Text); }

            if (Couple2_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple2_1.Text); }
            else if (Couple2_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple2_2.Text); }
            else if (Couple2_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple2_3.Text); }
            else if (Couple2_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple2_4.Text); }

            if (Couple2_1.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple2_1.Text); }
            else if (Couple2_2.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple2_2.Text); }
            else if (Couple2_3.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple2_3.Text); }
            else if (Couple2_4.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple2_4.Text); }

            if (Couple1_1.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple2_1.Text); }
            else if (Couple2_2.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple2_2.Text); }
            else if (Couple2_3.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple2_3.Text); }
            else if (Couple2_4.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple2_4.Text); }



            if (Couple3_1.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple3_1.Text); }
            else if (Couple3_2.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple3_2.Text); }
            else if (Couple3_3.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple3_3.Text); }
            else if (Couple3_4.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple3_4.Text); }

            if (Couple3_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple3_1.Text); }
            else if (Couple3_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple3_2.Text); }
            else if (Couple3_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple3_3.Text); }
            else if (Couple3_4.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple3_4.Text); }

            if (Couple3_1.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple3_1.Text); }
            else if (Couple3_2.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple3_2.Text); }
            else if (Couple3_3.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple3_3.Text); }
            else if (Couple3_4.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple3_4.Text); }

            if (Couple3_1.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple3_1.Text); }
            else if (Couple3_2.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple3_2.Text); }
            else if (Couple3_3.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple3_3.Text); }
            else if (Couple3_4.BackColor == Color.FromArgb(255, 255, 49)) { ClientAnswers1.Add(Couple3_4.Text); }

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


            if (Couple1_1.Text == fillForm.AddCouple(0)) { Couple1_1.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple1_2.Text == fillForm.AddCouple(0)) { Couple1_2.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple1_3.Text == fillForm.AddCouple(0)) { Couple1_3.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple1_4.Text == fillForm.AddCouple(0)) { Couple1_4.BackColor = Color.FromArgb(0, 125, 255); }

            if (Couple1_1.Text == fillForm.AddCouple(1)) { Couple1_1.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple1_2.Text == fillForm.AddCouple(1)) { Couple1_2.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple1_3.Text == fillForm.AddCouple(1)) { Couple1_3.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple1_4.Text == fillForm.AddCouple(1)) { Couple1_4.BackColor = Color.FromArgb(26, 177, 136); }

            if (Couple1_1.Text == fillForm.AddCouple(2)) { Couple1_1.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple1_2.Text == fillForm.AddCouple(2)) { Couple1_2.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple1_3.Text == fillForm.AddCouple(2)) { Couple1_3.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple1_4.Text == fillForm.AddCouple(2)) { Couple1_4.BackColor = Color.FromArgb(255, 49, 49); }

            if (Couple1_1.Text == fillForm.AddCouple(3)) { Couple1_1.BackColor = Color.FromArgb(255, 255, 49); }
            else if (Couple1_2.Text == fillForm.AddCouple(3)) { Couple1_2.BackColor = Color.FromArgb(255, 255, 49); }
            else if (Couple1_3.Text == fillForm.AddCouple(3)) { Couple1_3.BackColor = Color.FromArgb(255, 255, 49); }
            else if (Couple1_4.Text == fillForm.AddCouple(3)) { Couple1_4.BackColor = Color.FromArgb(255, 255, 49); }



            if (Couple2_1.Text == fillForm.AddCouple(4)) { Couple2_1.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple2_2.Text == fillForm.AddCouple(4)) { Couple2_2.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple2_3.Text == fillForm.AddCouple(4)) { Couple2_3.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple2_4.Text == fillForm.AddCouple(4)) { Couple2_4.BackColor = Color.FromArgb(0, 125, 255); }

            if (Couple2_1.Text == fillForm.AddCouple(5)) { Couple2_1.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple2_2.Text == fillForm.AddCouple(5)) { Couple2_2.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple2_3.Text == fillForm.AddCouple(5)) { Couple2_3.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple2_4.Text == fillForm.AddCouple(5)) { Couple2_4.BackColor = Color.FromArgb(26, 177, 136); }

            if (Couple2_1.Text == fillForm.AddCouple(6)) { Couple2_1.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple2_2.Text == fillForm.AddCouple(6)) { Couple2_2.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple2_3.Text == fillForm.AddCouple(6)) { Couple2_3.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple2_4.Text == fillForm.AddCouple(6)) { Couple2_4.BackColor = Color.FromArgb(255, 49, 49); }

            if (Couple2_1.Text == fillForm.AddCouple(7)) { Couple2_1.BackColor = Color.FromArgb(255, 255, 49); }
            else if (Couple2_2.Text == fillForm.AddCouple(7)) { Couple2_2.BackColor = Color.FromArgb(255, 255, 49); }
            else if (Couple2_3.Text == fillForm.AddCouple(7)) { Couple2_3.BackColor = Color.FromArgb(255, 255, 49); }
            else if (Couple2_4.Text == fillForm.AddCouple(7)) { Couple2_4.BackColor = Color.FromArgb(255, 255, 49); }



            if (Couple3_1.Text == fillForm.AddCouple(8)) { Couple3_1.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple3_2.Text == fillForm.AddCouple(8)) { Couple3_2.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple3_3.Text == fillForm.AddCouple(8)) { Couple3_3.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple3_4.Text == fillForm.AddCouple(8)) { Couple3_4.BackColor = Color.FromArgb(0, 125, 255); }

            if (Couple3_1.Text == fillForm.AddCouple(9)) { Couple3_1.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple3_2.Text == fillForm.AddCouple(9)) { Couple3_2.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple3_3.Text == fillForm.AddCouple(9)) { Couple3_3.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple3_4.Text == fillForm.AddCouple(9)) { Couple3_4.BackColor = Color.FromArgb(26, 177, 136); }

            if (Couple3_1.Text == fillForm.AddCouple(10)) { Couple3_1.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple3_2.Text == fillForm.AddCouple(10)) { Couple3_2.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple3_3.Text == fillForm.AddCouple(10)) { Couple3_3.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple3_4.Text == fillForm.AddCouple(10)) { Couple3_4.BackColor = Color.FromArgb(255, 49, 49); }

            if (Couple3_1.Text == fillForm.AddCouple(11)) { Couple3_1.BackColor = Color.FromArgb(255, 255, 49); }
            else if (Couple3_2.Text == fillForm.AddCouple(11)) { Couple3_2.BackColor = Color.FromArgb(255, 255, 49); }
            else if (Couple3_3.Text == fillForm.AddCouple(11)) { Couple3_3.BackColor = Color.FromArgb(255, 255, 49); }
            else if (Couple3_4.Text == fillForm.AddCouple(11)) { Couple3_4.BackColor = Color.FromArgb(255, 255, 49); }

        }

        private void Finish_Test_Click(object sender, EventArgs e)
        {
            int result = 0;
            GetAnswers();
            if (ClientAnswers.Count == 7)
            {
                if(ClientAnswers1.Count == 12)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (ClientAnswers[i] == fillForm.GetTrueAns(i))
                        { result++; }
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        if (ClientAnswers1[i] == fillForm.AddCouple(i))
                        { result++; }
                    }
                    Results res1 = new Results(result);
                    res1.Show();
                    Result.AddResultL(GetData.User, GetData.TestName, "Средний", result, ClientAnswers.Count + ClientAnswers1.Count);
                    ShowCorrectAnswers();
                }
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

        private void Сonformity1_1_Click(object sender, EventArgs e)
        {
            c1 = Color.FromArgb(0, 125, 255);
        }

        private void Сonformity1_2_Click(object sender, EventArgs e)
        {
            c1 = Color.FromArgb(26, 177, 136);
        }

        private void Сonformity1_3_Click(object sender, EventArgs e)
        {
            c1 = Color.FromArgb(255, 49, 49);
        }

        private void Сonformity1_4_Click(object sender, EventArgs e)
        {
            c1 = Color.FromArgb(255, 255, 49);
        }

        private void Сonformity2_1_Click(object sender, EventArgs e)
        {
            c2 = Color.FromArgb(0, 125, 255);
        }

        private void Сonformity2_2_Click(object sender, EventArgs e)
        {
            c2 = Color.FromArgb(26, 177, 136);
        }

        private void Сonformity2_3_Click(object sender, EventArgs e)
        {
            c2 = Color.FromArgb(255, 49, 49);
        }

        private void Сonformity2_4_Click(object sender, EventArgs e)
        {
            c2 = Color.FromArgb(255, 255, 49);
        }

        private void Сonformity3_1_Click(object sender, EventArgs e)
        {
            c3 = Color.FromArgb(0, 125, 255);
        }

        private void Сonformity3_2_Click(object sender, EventArgs e)
        {
            c3 = Color.FromArgb(26, 177, 136);
        }

        private void Сonformity3_3_Click(object sender, EventArgs e)
        {
            c3 = Color.FromArgb(255, 49, 49);
        }

        private void Сonformity3_4_Click(object sender, EventArgs e)
        {
            c3 = Color.FromArgb(255, 255, 49);
        }

        private void Couple1_1_Click(object sender, EventArgs e)
        {
            Couple1_1.BackColor = c1;
            Couple1_1.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple1_2_Click(object sender, EventArgs e)
        {
            Couple1_2.BackColor = c1;
            Couple1_2.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple1_3_Click(object sender, EventArgs e)
        {
            Couple1_3.BackColor = c1;
            Couple1_3.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple1_4_Click(object sender, EventArgs e)
        {
            Couple1_4.BackColor = c1;
            Couple1_4.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple2_1_Click(object sender, EventArgs e)
        {
            Couple2_1.BackColor = c2;
            Couple2_1.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple2_2_Click(object sender, EventArgs e)
        {
            Couple2_2.BackColor = c2;
            Couple2_2.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple2_3_Click(object sender, EventArgs e)
        {
            Couple2_3.BackColor = c2;
            Couple2_3.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple2_4_Click(object sender, EventArgs e)
        {
            Couple2_4.BackColor = c2;
            Couple2_4.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple3_1_Click(object sender, EventArgs e)
        {
            Couple3_1.BackColor = c3;
            Couple3_1.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple3_2_Click(object sender, EventArgs e)
        {
            Couple3_2.BackColor = c3;
            Couple3_2.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple3_3_Click(object sender, EventArgs e)
        {
            Couple3_3.BackColor = c3;
            Couple3_3.ForeColor = System.Drawing.SystemColors.ControlText;

        }

        private void Couple3_4_Click(object sender, EventArgs e)
        {
            Couple3_4.BackColor = c3;
            Couple3_4.ForeColor = System.Drawing.SystemColors.ControlText;
        }
    }
}
