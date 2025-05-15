using Npgsql;
using System.Data;

namespace School_Management_App_GUI_with_DB
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=School;";
        public Form1()
        {
            InitializeComponent();
            LoadForm();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbPresent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {

        }

        private void LoadForm()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("SELECT id, name, roll_no FROM students ORDER BY roll_no", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }

    }
}
