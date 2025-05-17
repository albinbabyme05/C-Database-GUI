namespace School_Management_App_GUI_with_DB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            cbStudents = new ComboBox();
            btnLoadHistory = new Button();
            dgvHistory = new DataGridView();
            groupBox2 = new GroupBox();
            btnMarkAttendance = new Button();
            btnReset = new Button();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            gbAttendance = new GroupBox();
            flAttendance = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            groupBox2.SuspendLayout();
            gbAttendance.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(51, 39);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 9;
            label2.Text = "Select Student : ";
            // 
            // cbStudents
            // 
            cbStudents.Font = new Font("Segoe UI", 12F);
            cbStudents.FormattingEnabled = true;
            cbStudents.Location = new Point(231, 36);
            cbStudents.Name = "cbStudents";
            cbStudents.Size = new Size(223, 36);
            cbStudents.TabIndex = 10;
            // 
            // btnLoadHistory
            // 
            btnLoadHistory.Font = new Font("Segoe UI", 12F);
            btnLoadHistory.Location = new Point(853, 39);
            btnLoadHistory.Name = "btnLoadHistory";
            btnLoadHistory.Size = new Size(103, 36);
            btnLoadHistory.TabIndex = 11;
            btnLoadHistory.Text = "Load";
            btnLoadHistory.UseVisualStyleBackColor = true;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(37, 87);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.ScrollBars = ScrollBars.Vertical;
            dgvHistory.Size = new Size(919, 231);
            dgvHistory.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cbStudents);
            groupBox2.Controls.Add(dgvHistory);
            groupBox2.Controls.Add(btnLoadHistory);
            groupBox2.Location = new Point(12, 465);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1037, 324);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnMarkAttendance
            // 
            btnMarkAttendance.Font = new Font("Segoe UI", 12F);
            btnMarkAttendance.Location = new Point(464, 351);
            btnMarkAttendance.Name = "btnMarkAttendance";
            btnMarkAttendance.Size = new Size(194, 45);
            btnMarkAttendance.TabIndex = 7;
            btnMarkAttendance.Text = "Mark Attendance";
            btnMarkAttendance.UseVisualStyleBackColor = true;
            btnMarkAttendance.Click += btnMarkAttendance_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F);
            btnReset.Location = new Point(903, 351);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(99, 45);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 12F);
            dtpDate.Location = new Point(106, 91);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 34);
            dtpDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(33, 91);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 0;
            label1.Text = "Date : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 60);
            label4.Name = "label4";
            label4.Size = new Size(999, 20);
            label4.TabIndex = 5;
            label4.Text = "===================================================================================================";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(269, 23);
            label3.Name = "label3";
            label3.Size = new Size(440, 37);
            label3.TabIndex = 4;
            label3.Text = "Attendence Form N.H.S.S. Chemperi";
            // 
            // gbAttendance
            // 
            gbAttendance.Controls.Add(flAttendance);
            gbAttendance.Controls.Add(label3);
            gbAttendance.Controls.Add(label4);
            gbAttendance.Controls.Add(label1);
            gbAttendance.Controls.Add(dtpDate);
            gbAttendance.Controls.Add(btnReset);
            gbAttendance.Controls.Add(btnMarkAttendance);
            gbAttendance.Location = new Point(9, 12);
            gbAttendance.Name = "gbAttendance";
            gbAttendance.Size = new Size(1040, 411);
            gbAttendance.TabIndex = 13;
            gbAttendance.TabStop = false;
            gbAttendance.Text = "Student Attendance";
            // 
            // flAttendance
            // 
            flAttendance.AutoScroll = true;
            flAttendance.FlowDirection = FlowDirection.TopDown;
            flAttendance.Location = new Point(33, 131);
            flAttendance.Name = "flAttendance";
            flAttendance.Size = new Size(984, 214);
            flAttendance.TabIndex = 9;
            flAttendance.WrapContents = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 801);
            Controls.Add(groupBox2);
            Controls.Add(gbAttendance);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbAttendance.ResumeLayout(false);
            gbAttendance.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private ComboBox cbStudents;
        private Button btnLoadHistory;
        private DataGridView dgvHistory;
        private GroupBox groupBox2;
        private Button btnMarkAttendance;
        private Button btnReset;
        private DateTimePicker dtpDate;
        private Label label1;
        private Label label4;
        private Label label3;
        private GroupBox gbAttendance;
        private FlowLayoutPanel flAttendance;
    }
}
