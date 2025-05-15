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
            label1 = new Label();
            dtpDate = new DateTimePicker();
            btnViewHistory = new Button();
            label3 = new Label();
            label4 = new Label();
            panelAttendance = new Panel();
            btnMarkAttendance = new Button();
            btnReset = new Button();
            label2 = new Label();
            cbStudents = new ComboBox();
            btnLoadHistory = new Button();
            dgvHistory = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            // dtpDate
            // 
            dtpDate.Font = new Font("Segoe UI", 12F);
            dtpDate.Location = new Point(106, 91);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 34);
            dtpDate.TabIndex = 1;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Font = new Font("Segoe UI", 12F);
            btnViewHistory.Location = new Point(464, 91);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(168, 40);
            btnViewHistory.TabIndex = 2;
            btnViewHistory.Text = "View History ⏩";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 60);
            label4.Name = "label4";
            label4.Size = new Size(999, 20);
            label4.TabIndex = 5;
            label4.Text = "===================================================================================================";
            // 
            // panelAttendance
            // 
            panelAttendance.AutoScroll = true;
            panelAttendance.Location = new Point(17, 137);
            panelAttendance.Name = "panelAttendance";
            panelAttendance.Size = new Size(995, 208);
            panelAttendance.TabIndex = 6;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(btnViewHistory);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(panelAttendance);
            groupBox1.Controls.Add(btnMarkAttendance);
            groupBox1.Location = new Point(9, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1040, 411);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 801);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Button btnViewHistory;
        private Label label3;
        private Label label4;
        private Panel panelAttendance;
        private Button btnMarkAttendance;
        private Button btnReset;
        private Label label2;
        private ComboBox cbStudents;
        private Button btnLoadHistory;
        private DataGridView dgvHistory;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
