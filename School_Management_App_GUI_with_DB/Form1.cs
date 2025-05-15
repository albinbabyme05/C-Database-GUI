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

                    using (var cmd = new NpgsqlCommand("SELECT id, name, roll_no FROM student ORDER BY roll_no", conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Clear previous entries
                        flAttendance.Controls.Clear();

                        while (reader.Read())
                        {
                            int studentId = Convert.ToInt32(reader["id"]);
                            string studentName = reader["name"].ToString();
                            int studentRollNo = Convert.ToInt32(reader["roll_no"]);

                            // created a panel for adding student data
                            Panel studentPanel = new Panel();
                            studentPanel.Width = flAttendance.Width - 40;
                            studentPanel.Height = 50; // increased height
                            studentPanel.Margin = new Padding(5);

                            // Label
                            Label lblStudent = new Label();
                            lblStudent.Text = $"{studentRollNo} - {studentName}";
                            lblStudent.Width = 150;
                            lblStudent.Location = new Point(5, 15);
                        }
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
