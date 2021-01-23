using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MySql.Data.MySqlClient;



namespace Testing
{
    public partial class Testingcards : Form
    {
        string data;
        public Testingcards(string data)
        {
            InitializeComponent();
            this.data = data;

            passTheTestUsControl1.BringToFront();
            settingsUsControl1.BringToFront();
            aboutProgramUsControl1.BringToFront();
            resultsUsControl1.BringToFront();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = Convert.ToString("Привет, ") + data + Convert.ToString("!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutProgramUsControl1.Visible = false;
            settingsUsControl1.Visible = false;
            resultsUsControl1.Visible = false;

            passTheTestUsControl1.Visible = true;
            passTheTestUsControl1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            passTheTestUsControl1.Visible = false;
            settingsUsControl1.Visible = false;
            resultsUsControl1.Visible = false;

            aboutProgramUsControl1.Visible = true;
            aboutProgramUsControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            passTheTestUsControl1.Visible = false;
            settingsUsControl1.Visible = false;
            aboutProgramUsControl1.Visible = false;

            resultsUsControl1.Visible = true;
            resultsUsControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aboutProgramUsControl1.Visible = false;
            passTheTestUsControl1.Visible = false;
            resultsUsControl1.Visible = false;

            settingsUsControl1.Visible = true;
            settingsUsControl1.BringToFront();
        }
    }
}
