using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Testing
{
    public partial class ResultsUsControl : UserControl
    {
        string Connect = @"Database=testing;Data Source=localhost;User Id=root;Password='simoncat@_99'";
        MySqlDataAdapter dataAdapter;
        DataTable table;

        public ResultsUsControl()
        {
            InitializeComponent();
        }

        public void FillDataGridView()
        {
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            try
            {
                string selectresults = $"select * from testing.results";
                dataAdapter = new MySqlDataAdapter(selectresults, myConnection);
                table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch { }
            myConnection.Close();
        }

        private void ResultsUsControl_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].HeaderText = "№";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Название теста";
            dataGridView1.Columns[3].HeaderText = "Уровень";
            dataGridView1.Columns[4].HeaderText = "Результат";
            dataGridView1.Columns[5].HeaderText = "Дата прохождения";
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void Update_table_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection(Connect);
            myConnection.Open();
            try
            {
                string selectresults = $"select * from testing.results";
                dataAdapter = new MySqlDataAdapter(selectresults, myConnection);
                table = new DataTable();
                table.Clear();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch { }
            myConnection.Close();
        }
    }
}
