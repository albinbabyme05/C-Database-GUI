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

                            // RadioButton: Present
                            RadioButton rdoPresent = new RadioButton();
                            rdoPresent.Text = "Present";
                            rdoPresent.Location = new Point(170, 15);
                            rdoPresent.Name = $"present_{studentId}";
                            rdoPresent.AutoSize = true;

                            // RadioButton: Absent
                            RadioButton rdoAbsent = new RadioButton();
                            rdoAbsent.Text = "Absent";
                            rdoAbsent.Location = new Point(250, 15);
                            rdoAbsent.Name = $"absent_{studentId}";
                            rdoAbsent.AutoSize = true;

                            // Add controls to panel
                            studentPanel.Controls.Add(lblStudent);
                            studentPanel.Controls.Add(rdoPresent);
                            studentPanel.Controls.Add(rdoAbsent);

                            // Add panel to FlowLayoutPanel
                            flAttendance.Controls.Add(studentPanel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading students: " + ex.Message);
                }
            }
        }

        //mark attendance
        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            using(var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var trans = conn.BeginTransaction())
                    {
                        try
                        {
                            foreach (Panel studentPanel in flAttendance.Controls)
                            {
                                int student_id = -1;
                                string status = "";

                                foreach (Control ctrol in studentPanel.Controls)
                                {
                                    if (ctrol is RadioButton rdoBtn && rdoBtn.Checked)
                                    {
                                        if (rdoBtn.Name.StartsWith("present_"))
                                        {
                                            string[] id = rdoBtn.Name.Split("_");
                                            student_id = Convert.ToInt32(id[1]);
                                            status = id[0];
                                        }
                                        else if (rdoBtn.Name.StartsWith("absent_"))
                                        {
                                            string[] id = rdoBtn.Name.Split("_");
                                            student_id = Convert.ToInt32(id[1]);
                                            status = id[0];
                                        }
                                    }
                                }
                                // insert studnet with status only
                                if (student_id != -1 && !string.IsNullOrEmpty(status))
                                {
                                    string insertDataQuery = "INSERT INTO attendence (student_id, date, status) VALUES (@student_id, @date, @status)";
                                    using (var cmd = new NpgsqlCommand(insertDataQuery, conn, trans))
                                    {
                                        cmd.Parameters.AddWithValue("student_id", student_id);
                                        cmd.Parameters.AddWithValue("date", DateTime.Now.Date);
                                        cmd.Parameters.AddWithValue("status", status);

                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                            trans.Commit();
                            MessageBox.Show("Date inserted to Attendence Table");
                        }
                        catch (PostgresException ex) when (ex.SqlState == "23503")
                        {
                            MessageBox.Show("Error: student ID not found. \n " +
                                "Make sure all students exist in the student table.");
                            trans.Rollback();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }   
        }

        


    //formend.
    }
}
