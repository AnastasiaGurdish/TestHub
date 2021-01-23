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
    public partial class SettingsUsControl : UserControl
    {
        public string NewName;
        public string NewLastname;
        public string NewPassword;
        public SettingsUsControl()
        {
            InitializeComponent();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            NewName = NameBox.Text;
        }

        private void LastnameBox_TextChanged(object sender, EventArgs e)
        {
            NewLastname = LastnameBox.Text;
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            NewPassword = PasswordBox.Text;
        }

        private void UpdateA_Click(object sender, EventArgs e)
        {
            UpdateClient Client = new UpdateClient(NewName, NewLastname, NewPassword);
            GetData.Password = NewPassword;
            NameBox.Text = "";
            LastnameBox.Text = "";
            PasswordBox.Text = "";
        }

        private void DeleteA_Click(object sender, EventArgs e)
        {
            DeleteClient del = new DeleteClient();
            Testingcards Form = (Testingcards)this.Parent;
            Form.Close();
        }
    }
}
