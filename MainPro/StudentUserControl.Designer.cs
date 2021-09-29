namespace MainPro
{
    partial class StudentUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CoursesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.StudentDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchByComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StudentPanelStatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabelToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).BeginInit();
            this.StudentPanelStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(21, 41);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(133, 23);
            this.IdTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(212, 41);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(133, 23);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(404, 41);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(133, 23);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Number";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(589, 41);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(133, 23);
            this.PhoneNumberTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(21, 90);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(133, 23);
            this.EmailTextBox.TabIndex = 8;
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Items.AddRange(new object[] {
            "Betah Tekva",
            "Jaljulia",
            "Kefar Bara",
            "Kefar Kasem",
            "Kefar Sava",
            "None",
            "Tell Aviv"});
            this.CityComboBox.Location = new System.Drawing.Point(212, 90);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(133, 23);
            this.CityComboBox.Sorted = true;
            this.CityComboBox.TabIndex = 10;
            this.CityComboBox.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Of Birth";
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBDateTimePicker.Location = new System.Drawing.Point(404, 90);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(133, 23);
            this.DOBDateTimePicker.TabIndex = 13;
            // 
            // CoursesCheckedListBox
            // 
            this.CoursesCheckedListBox.FormattingEnabled = true;
            this.CoursesCheckedListBox.Items.AddRange(new object[] {
            ".NET Basic",
            "OOP",
            "Core",
            "HTML",
            "CSS"});
            this.CoursesCheckedListBox.Location = new System.Drawing.Point(780, 52);
            this.CoursesCheckedListBox.Name = "CoursesCheckedListBox";
            this.CoursesCheckedListBox.Size = new System.Drawing.Size(84, 94);
            this.CoursesCheckedListBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(780, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Courses";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(589, 92);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(133, 23);
            this.AddStudentButton.TabIndex = 16;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // StudentDataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentDataGridView.Location = new System.Drawing.Point(21, 168);
            this.StudentDataGridView.Name = "StudentDataGridView";
            this.StudentDataGridView.RowTemplate.Height = 25;
            this.StudentDataGridView.Size = new System.Drawing.Size(1032, 339);
            this.StudentDataGridView.TabIndex = 17;
            this.StudentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGridView_CellClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(388, 511);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 28);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchByComboBox
            // 
            this.SearchByComboBox.FormattingEnabled = true;
            this.SearchByComboBox.Items.AddRange(new object[] {
            "None",
            "First Name",
            "Last Name",
            "Full Name",
            "City",
            "Id",
            "Phone",
            "Email",
            "Corse"});
            this.SearchByComboBox.Location = new System.Drawing.Point(71, 513);
            this.SearchByComboBox.Name = "SearchByComboBox";
            this.SearchByComboBox.Size = new System.Drawing.Size(146, 23);
            this.SearchByComboBox.TabIndex = 19;
            this.SearchByComboBox.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Search by:";
            // 
            // StudentPanelStatusStrip
            // 
            this.StudentPanelStatusStrip.AutoSize = false;
            this.StudentPanelStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.StudentPanelStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelToolStrip});
            this.StudentPanelStatusStrip.Location = new System.Drawing.Point(613, 513);
            this.StudentPanelStatusStrip.Name = "StudentPanelStatusStrip";
            this.StudentPanelStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StudentPanelStatusStrip.Size = new System.Drawing.Size(374, 22);
            this.StudentPanelStatusStrip.TabIndex = 21;
            this.StudentPanelStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabelToolStrip
            // 
            this.StatusLabelToolStrip.Name = "StatusLabelToolStrip";
            this.StatusLabelToolStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(223, 513);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(159, 23);
            this.SearchTextBox.TabIndex = 22;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(499, 511);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(105, 28);
            this.RemoveButton.TabIndex = 23;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // StudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchByComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StudentPanelStatusStrip);
            this.Controls.Add(this.StudentDataGridView);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CoursesCheckedListBox);
            this.Controls.Add(this.DOBDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CityComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdTextBox);
            this.Name = "StudentUserControl";
            this.Size = new System.Drawing.Size(1076, 542);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGridView)).EndInit();
            this.StudentPanelStatusStrip.ResumeLayout(false);
            this.StudentPanelStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DOBDateTimePicker;
        private System.Windows.Forms.CheckedListBox CoursesCheckedListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.DataGridView StudentDataGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox SearchByComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip StudentPanelStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelToolStrip;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button RemoveButton;
    }
}
