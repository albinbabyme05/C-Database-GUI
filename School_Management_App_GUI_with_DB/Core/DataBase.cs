using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School_Management_App_GUI_with_DB.Core
{
    public class DataBaseManager
    {
        Student student = new Student();
        public void MarkAttendance(string connectionString,  FlowLayoutPanel flAttendance, DateTimePicker dtpDate)
        {
            using (var conn = new NpgsqlConnection(connectionString))
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
                                        cmd.Parameters.AddWithValue("date", dtpDate.Value.Date);
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

        public void AddDataToDatabase(string connectionString, FlowLayoutPanel flAttendance)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string QueryString = "SELECT id, name, roll_no FROM student ORDER BY roll_no";
                    using (var cmd = new NpgsqlCommand(QueryString, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        // Clear previous entries
                        flAttendance.Controls.Clear();

                        while (reader.Read())
                        {
                            int studentId = Convert.ToInt32(reader["id"]);
                            string studentName = Convert.ToString(reader["name"]);
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

        public void LoadHistory(string connectionString)
        {
            //populate student attendance history based on date
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string QueryString = "SELECT date, status FROM attendence WHERE  student_id = @id ORDER BY date DESC";
                    using (var cmd = new NpgsqlCommand(QueryString, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

        }

        // show stduent listitem.Name
        public List<Student> ViewStudentList(string connectionString)
        {
            //populate student attendance history based on date
            using (var conn = new NpgsqlConnection(connectionString))
            {
                List<Student> studentsNameList = new List<Student>();
                try
                {
                    conn.Open();
                    string QueryString = "SELECT id, name FROM student";
                    using (var cmd = new NpgsqlCommand(QueryString, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string studentsName = reader["name"].ToString();
                            int studentsId = Convert.ToInt32(reader["id"]);

                            studentsNameList.Add( new Student
                            {
                                Id = studentsId, 
                                Name = studentsName
                            });
                        }
                    }
                    return studentsNameList;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    return studentsNameList;
                }
            }
        }

       



    }
}
