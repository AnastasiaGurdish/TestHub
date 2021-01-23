using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class ArduousTest : Form
    {
        static readonly Random Random = new Random();
        HashSet<int> Order = new HashSet<int>();
        FillingForm2 fillForm = new FillingForm2();
        ResultOfTest Result = new ResultOfTest(); //результаты теста
        List<string> ClientAnswers1 = new List<string>();

        Color[] Colors = { Color.FromArgb(0, 125, 255), Color.FromArgb(26, 177, 136), Color.FromArgb(255, 49, 49) };
        Color c1 = Color.FromArgb(0, 125, 255), c2 = Color.FromArgb(0, 125, 255), c3 = Color.FromArgb(0, 125, 255), c4 = Color.FromArgb(0, 125, 255), c5 = Color.FromArgb(0, 125, 255);

        public ArduousTest()
        {
            InitializeComponent();
            Built1();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Built1()
        {
            Qst1.Text = fillForm.AddQuestForСonformity(0);
            Qst2.Text = fillForm.AddQuestForСonformity(1);
            Qst3.Text = fillForm.AddQuestForСonformity(2);
            Qst4.Text = fillForm.AddQuestForСonformity(3);
            Qst5.Text = fillForm.AddQuestForСonformity(4);

            Сonformity1_1.Text = fillForm.AddConformity(0);
            Сonformity1_2.Text = fillForm.AddConformity(1);
            Сonformity1_3.Text = fillForm.AddConformity(2);
            BuildOrder(0, 3);
            int a = 0;
            int[] mass = new int[4];

            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Couple1_1.Text = fillForm.AddCouple(mass[0]);
            Couple1_2.Text = fillForm.AddCouple(mass[1]);
            Couple1_3.Text = fillForm.AddCouple(mass[2]);

            Сonformity2_1.Text = fillForm.AddConformity(3);
            Сonformity2_2.Text = fillForm.AddConformity(4);
            Сonformity2_3.Text = fillForm.AddConformity(5);
            Order.Clear();
            BuildOrder(3, 6);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Couple2_1.Text = fillForm.AddCouple(mass[0]);
            Couple2_2.Text = fillForm.AddCouple(mass[1]);
            Couple2_3.Text = fillForm.AddCouple(mass[2]);

            Сonformity3_1.Text = fillForm.AddConformity(6);
            Сonformity3_2.Text = fillForm.AddConformity(7);
            Сonformity3_3.Text = fillForm.AddConformity(8);
            Order.Clear();
            BuildOrder(6, 9);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Couple3_1.Text = fillForm.AddCouple(mass[0]);
            Couple3_2.Text = fillForm.AddCouple(mass[1]);
            Couple3_3.Text = fillForm.AddCouple(mass[2]);

            Сonformity4_1.Text = fillForm.AddConformity(9);
            Сonformity4_2.Text = fillForm.AddConformity(10);
            Сonformity4_3.Text = fillForm.AddConformity(11);
            Order.Clear();
            BuildOrder(9, 12);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Couple4_1.Text = fillForm.AddCouple(mass[0]);
            Couple4_2.Text = fillForm.AddCouple(mass[1]);
            Couple4_3.Text = fillForm.AddCouple(mass[2]);

            Сonformity5_1.Text = fillForm.AddConformity(12);
            Сonformity5_2.Text = fillForm.AddConformity(13);
            Сonformity5_3.Text = fillForm.AddConformity(14);
            Order.Clear();
            BuildOrder(12, 15);
            a = 0;
            foreach (int i in Order)
            {
                mass[a++] = i;
            }
            Couple5_1.Text = fillForm.AddCouple(mass[0]);
            Couple5_2.Text = fillForm.AddCouple(mass[1]);
            Couple5_3.Text = fillForm.AddCouple(mass[2]);
        }

        void BuildOrder(int a, int b)
        {
            while (Order.Count < 3)
            {
                Order.Add(Random.Next(a, b));
            }
        }

        private void GetAnswers()
        {
            if (Couple1_1.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple1_1.Text); }
            else if (Couple1_2.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple1_2.Text); }
            else if (Couple1_3.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple1_3.Text); }

            if (Couple1_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple1_1.Text); }
            else if (Couple1_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple1_2.Text); }
            else if (Couple1_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple1_3.Text); }

            if (Couple1_1.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple1_1.Text); }
            else if (Couple1_2.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple1_2.Text); }
            else if (Couple1_3.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple1_3.Text); }



            if (Couple2_1.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple2_1.Text); }
            else if (Couple2_2.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple2_2.Text); }
            else if (Couple2_3.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple2_3.Text); }

            if (Couple2_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple2_1.Text); }
            else if (Couple2_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple2_2.Text); }
            else if (Couple2_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple2_3.Text); }

            if (Couple2_1.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple2_1.Text); }
            else if (Couple2_2.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple2_2.Text); }
            else if (Couple2_3.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple2_3.Text); }



            if (Couple3_1.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple3_1.Text); }
            else if (Couple3_2.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple3_2.Text); }
            else if (Couple3_3.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple3_3.Text); }

            if (Couple3_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple3_1.Text); }
            else if (Couple3_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple3_2.Text); }
            else if (Couple3_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple3_3.Text); }

            if (Couple3_1.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple3_1.Text); }
            else if (Couple3_2.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple3_2.Text); }
            else if (Couple3_3.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple3_3.Text); }



            if (Couple4_1.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple4_1.Text); }
            else if (Couple4_2.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple4_2.Text); }
            else if (Couple4_3.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple4_3.Text); }

            if (Couple4_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple4_1.Text); }
            else if (Couple4_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple4_2.Text); }
            else if (Couple4_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple4_3.Text); }

            if (Couple4_1.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple4_1.Text); }
            else if (Couple4_2.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple4_2.Text); }
            else if (Couple4_3.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple4_3.Text); }



            if (Couple5_1.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple5_1.Text); }
            else if (Couple5_2.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple5_2.Text); }
            else if (Couple5_3.BackColor == Color.FromArgb(0, 125, 255)) { ClientAnswers1.Add(Couple5_3.Text); }

            if (Couple5_1.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple5_1.Text); }
            else if (Couple5_2.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple5_2.Text); }
            else if (Couple5_3.BackColor == Color.FromArgb(26, 177, 136)) { ClientAnswers1.Add(Couple5_3.Text); }

            if (Couple5_1.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple5_1.Text); }
            else if (Couple5_2.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple5_2.Text); }
            else if (Couple5_3.BackColor == Color.FromArgb(255, 49, 49)) { ClientAnswers1.Add(Couple5_3.Text); }
        }

        private void ShowCorrectAnswers()
        {
            if (Couple1_1.Text == fillForm.AddCouple(0)) { Couple1_1.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple1_2.Text == fillForm.AddCouple(0)) { Couple1_2.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple1_3.Text == fillForm.AddCouple(0)) { Couple1_3.BackColor = Color.FromArgb(0, 125, 255); }

            if (Couple1_1.Text == fillForm.AddCouple(1)) { Couple1_1.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple1_2.Text == fillForm.AddCouple(1)) { Couple1_2.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple1_3.Text == fillForm.AddCouple(1)) { Couple1_3.BackColor = Color.FromArgb(26, 177, 136); }

            if (Couple1_1.Text == fillForm.AddCouple(2)) { Couple1_1.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple1_2.Text == fillForm.AddCouple(2)) { Couple1_2.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple1_3.Text == fillForm.AddCouple(2)) { Couple1_3.BackColor = Color.FromArgb(255, 49, 49); }



            if (Couple2_1.Text == fillForm.AddCouple(3)) { Couple2_1.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple2_2.Text == fillForm.AddCouple(3)) { Couple2_2.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple2_3.Text == fillForm.AddCouple(3)) { Couple2_3.BackColor = Color.FromArgb(0, 125, 255); }

            if (Couple2_1.Text == fillForm.AddCouple(4)) { Couple2_1.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple2_2.Text == fillForm.AddCouple(4)) { Couple2_2.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple2_3.Text == fillForm.AddCouple(4)) { Couple2_3.BackColor = Color.FromArgb(26, 177, 136); }

            if (Couple2_1.Text == fillForm.AddCouple(5)) { Couple2_1.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple2_2.Text == fillForm.AddCouple(5)) { Couple2_2.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple2_3.Text == fillForm.AddCouple(5)) { Couple2_3.BackColor = Color.FromArgb(255, 49, 49); }



            if (Couple3_1.Text == fillForm.AddCouple(6)) { Couple3_1.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple3_2.Text == fillForm.AddCouple(6)) { Couple3_2.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple3_3.Text == fillForm.AddCouple(6)) { Couple3_3.BackColor = Color.FromArgb(0, 125, 255); }

            if (Couple3_1.Text == fillForm.AddCouple(7)) { Couple3_1.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple3_2.Text == fillForm.AddCouple(7)) { Couple3_2.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple3_3.Text == fillForm.AddCouple(7)) { Couple3_3.BackColor = Color.FromArgb(26, 177, 136); }

            if (Couple3_1.Text == fillForm.AddCouple(8)) { Couple3_1.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple3_2.Text == fillForm.AddCouple(8)) { Couple3_2.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple3_3.Text == fillForm.AddCouple(8)) { Couple3_3.BackColor = Color.FromArgb(255, 49, 49); }



            if (Couple4_1.Text == fillForm.AddCouple(9)) { Couple4_1.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple4_2.Text == fillForm.AddCouple(9)) { Couple4_2.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple4_3.Text == fillForm.AddCouple(9)) { Couple4_3.BackColor = Color.FromArgb(0, 125, 255); }

            if (Couple4_1.Text == fillForm.AddCouple(10)) { Couple4_1.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple4_2.Text == fillForm.AddCouple(10)) { Couple4_2.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple4_3.Text == fillForm.AddCouple(10)) { Couple4_3.BackColor = Color.FromArgb(26, 177, 136); }

            if (Couple4_1.Text == fillForm.AddCouple(11)) { Couple4_1.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple4_2.Text == fillForm.AddCouple(11)) { Couple4_2.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple4_3.Text == fillForm.AddCouple(11)) { Couple4_3.BackColor = Color.FromArgb(255, 49, 49); }



            if (Couple5_1.Text == fillForm.AddCouple(12)) { Couple5_1.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple5_2.Text == fillForm.AddCouple(12)) { Couple5_2.BackColor = Color.FromArgb(0, 125, 255); }
            else if (Couple3_3.Text == fillForm.AddCouple(12)) { Couple5_3.BackColor = Color.FromArgb(0, 125, 255); }

            if (Couple5_1.Text == fillForm.AddCouple(13)) { Couple5_1.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple5_2.Text == fillForm.AddCouple(13)) { Couple5_2.BackColor = Color.FromArgb(26, 177, 136); }
            else if (Couple5_3.Text == fillForm.AddCouple(13)) { Couple5_3.BackColor = Color.FromArgb(26, 177, 136); }

            if (Couple5_1.Text == fillForm.AddCouple(14)) { Couple5_1.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple5_2.Text == fillForm.AddCouple(14)) { Couple5_2.BackColor = Color.FromArgb(255, 49, 49); }
            else if (Couple5_3.Text == fillForm.AddCouple(14)) { Couple5_3.BackColor = Color.FromArgb(255, 49, 49); }
        }

        private void Finish_Test_Click(object sender, EventArgs e)
        {
            int result = 0;
            GetAnswers();
            if (ClientAnswers1.Count == 15)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (ClientAnswers1[i] == fillForm.AddCouple(i))
                    { result++; }
                }
                Results res2 = new Results(result);
                res2.Show();
                Result.AddResultL(GetData.User, GetData.TestName, "Сложный", result, ClientAnswers1.Count);
                ShowCorrectAnswers();
            }
            else
            {
                MessageBox.Show("Вы не ответили на все тестовые задания!\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            ClientAnswers1.Clear();
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

        private void Сonformity4_1_Click(object sender, EventArgs e)
        {
            c4 = Color.FromArgb(0, 125, 255);
        }

        private void Сonformity4_2_Click(object sender, EventArgs e)
        {
            c4 = Color.FromArgb(26, 177, 136);
        }

        private void Сonformity4_3_Click(object sender, EventArgs e)
        {
            c4 = Color.FromArgb(255, 49, 49);
        }

        private void Сonformity5_1_Click(object sender, EventArgs e)
        {
            c5 = Color.FromArgb(0, 125, 255);
        }

        private void Сonformity5_2_Click(object sender, EventArgs e)
        {
            c5 = Color.FromArgb(26, 177, 136);
        }

        private void Сonformity5_3_Click(object sender, EventArgs e)
        {
            c5 = Color.FromArgb(255, 49, 49);
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

        private void Couple4_1_Click(object sender, EventArgs e)
        {
            Couple4_1.BackColor = c4;
            Couple4_1.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple4_2_Click(object sender, EventArgs e)
        {
            Couple4_2.BackColor = c4;
            Couple4_2.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple4_3_Click(object sender, EventArgs e)
        {
            Couple4_3.BackColor = c4;
            Couple4_3.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple5_1_Click(object sender, EventArgs e)
        {
            Couple5_1.BackColor = c5;
            Couple5_1.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple5_2_Click(object sender, EventArgs e)
        {
            Couple5_2.BackColor = c5;
            Couple5_2.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void Couple5_3_Click(object sender, EventArgs e)
        {
            Couple5_3.BackColor = c5;
            Couple5_3.ForeColor = System.Drawing.SystemColors.ControlText;
        }
    }
}
