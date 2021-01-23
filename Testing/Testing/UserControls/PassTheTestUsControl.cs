using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class PassTheTestUsControl : UserControl
    { 
        public PassTheTestUsControl()
        {
            InitializeComponent();
            List();
            AddLevel();
        }

        void List()
        {
            ListOfTopics.Items.Clear();
            PutTopic topic = new PutTopic();
            string[] Name = new string[256];
            for (int i = 0; i < topic.putTopic.Count; i++)
            {
                Name[i] = topic.putTopic[i];
                ListOfTopics.Items.Add(Name[i]);
            }
        }

        void AddLevel()
        {
            Level.Items.Add("Легкий");
            Level.Items.Add("Средний");
            Level.Items.Add("Сложный");
        }

        private void Pass_the_test_Click(object sender, EventArgs e)
        {
            GetData.TestName = Convert.ToString(ListOfTopics.SelectedItem);
            GetData.Level = Convert.ToString(Level.SelectedItem);
            GetData.IDofTopic = Convert.ToString(ListOfTopics.SelectedIndex + 1);
            if((ListOfTopics.SelectedItem != null ) && (Level.SelectedItem != null))
            {
                if (Convert.ToString(Level.SelectedItem) == "Легкий")
                {
                    EasyTest EasyTest = new EasyTest();
                    EasyTest.Show();
                }
                else if (Convert.ToString(Level.SelectedItem) == "Средний")
                {
                    MediumTest MediumTest = new MediumTest();
                    MediumTest.Show();
                }
                else if (Convert.ToString(Level.SelectedItem) == "Сложный")
                {
                    ArduousTest ArduousTest = new ArduousTest();
                    ArduousTest.Show();
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали категорию или уровень!");
            }
        }
    }
}
