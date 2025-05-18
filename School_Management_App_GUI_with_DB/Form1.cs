using Npgsql;
using School_Management_App_GUI_with_DB.NewFolder;
using School_Management_App_GUI_with_DB.Core;
using System.Data;
using System.Drawing.Text;


namespace School_Management_App_GUI_with_DB
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=School;";
        private DataBaseManager db = new DataBaseManager();

        public Form1()
        {
            InitializeComponent();
            LoadForm();
            //  list of student list
            db.ViewStudentList(connectionString, cbStudents);
        }

        //load form 
        private void LoadForm()
        {
            db.AddDataToDatabase(connectionString, flAttendance);
        }

        //mark attendance
        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            // check the date alreadyy exist in the database
            DateTime dateToCheck = dtpDate.Value;

            bool isDateAlreadyExists = DataValidator.IsDateAvailbale(dateToCheck, connectionString);
            if (!isDateAlreadyExists)
            {
                MessageBox.Show("Date Already exists");
                return;//stoped execution
            }

            db.MarkAttendance(connectionString, flAttendance, dtpDate);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today.Date;
            btnMarkAttendance.Enabled = true; //if attendance marked
            foreach (Panel studentPanel in flAttendance.Controls)
            {
                foreach (Control ctrl in studentPanel.Controls)
                {
                    if (ctrl is RadioButton rdoBtn)
                    {
                        rdoBtn.Checked = false;
                    }
                }
            }
        }

        private void btnLoadHistory_Click(object sender, EventArgs e)
        {
            int id = (int)cbStudents.SelectedValue;
            //student attendance history based on name and  id
            db.LoadHistory(connectionString,id, dgvHistory);
        }

        private void cbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       

        //formend.
    }
}
