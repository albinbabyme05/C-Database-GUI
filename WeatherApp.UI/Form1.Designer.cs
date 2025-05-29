namespace WeatherApp.UI
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
            tbCity = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblTemp = new Label();
            lblTempFeel = new Label();
            label4 = new Label();
            lblCondition = new Label();
            btnSubmit = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(117, 83);
            label1.Name = "label1";
            label1.Size = new Size(74, 32);
            label1.TabIndex = 0;
            label1.Text = "City : ";
            // 
            // tbCity
            // 
            tbCity.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCity.Location = new Point(197, 89);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(278, 34);
            tbCity.TabIndex = 1;
            tbCity.TextChanged += tbCity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.Location = new Point(117, 189);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 2;
            label2.Text = "Temperature : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new Point(136, 300);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 3;
            label3.Text = "Feels Like :";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Font = new Font("Segoe UI", 13.8F);
            lblTemp.Location = new Point(316, 189);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(96, 31);
            lblTemp.TabIndex = 4;
            lblTemp.Text = "lblTemp";
            // 
            // lblTempFeel
            // 
            lblTempFeel.AutoSize = true;
            lblTempFeel.Font = new Font("Segoe UI", 13.8F);
            lblTempFeel.Location = new Point(316, 300);
            lblTempFeel.Name = "lblTempFeel";
            lblTempFeel.Size = new Size(137, 31);
            lblTempFeel.TabIndex = 5;
            lblTempFeel.Text = "lblTempFeel";
            lblTempFeel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new Point(146, 386);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 6;
            label4.Text = "Condition : ";
            // 
            // lblCondition
            // 
            lblCondition.AutoSize = true;
            lblCondition.Font = new Font("Segoe UI", 13.8F);
            lblCondition.Location = new Point(316, 386);
            lblCondition.Name = "lblCondition";
            lblCondition.Size = new Size(89, 31);
            lblCondition.TabIndex = 7;
            lblCondition.Text = "lblDesc";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 14F);
            btnSubmit.Location = new Point(528, 89);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(127, 48);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 14F);
            btnReset.Location = new Point(528, 386);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(127, 47);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 743);
            Controls.Add(btnReset);
            Controls.Add(btnSubmit);
            Controls.Add(lblCondition);
            Controls.Add(label4);
            Controls.Add(lblTempFeel);
            Controls.Add(lblTemp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbCity);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCity;
        private Label label2;
        private Label label3;
        private Label lblTemp;
        private Label lblTempFeel;
        private Label label4;
        private Label lblCondition;
        private Button btnSubmit;
        private Button btnReset;
    }
}
