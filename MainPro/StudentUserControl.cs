using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hackerme.DB;

namespace MainPro
{
    public partial class StudentUserControl : UserControl
    {
        private string? rowId;
        private List<Student> students = MyDB.students;
        public StudentUserControl()
        {
            InitializeComponent();
            students.Add(new Student() { Id = "308127125" });
            StudentDataGridView.DataSource = students;
        }
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                DOB = DOBDateTimePicker.Value,
                City = CityComboBox.SelectedItem.ToString()                
            };
            try
            {
                if (!IdTextBox.Text.ValidateId())
                    throw new NotValidInbutExcebtion();
                student.Id = IdTextBox.Text;
            }
            catch(NotValidInbutExcebtion)
            {
                StatusLabelToolStrip.Text = "Not Valid Id";
                return;
            }
            try
            {
                if (!FirstNameTextBox.Text.ValidateName())
                    throw new NotValidInbutExcebtion();
                student.FirstName = FirstNameTextBox.Text;
            }
            catch (NotValidInbutExcebtion)
            {
                StatusLabelToolStrip.Text = "Not Valid FirstName";
                return;
            }
            try
            {
                if (!LastNameTextBox.Text.ValidateName())
                    throw new NotValidInbutExcebtion();
                student.LastName = LastNameTextBox.Text;
            }
            catch (NotValidInbutExcebtion)
            {
                StatusLabelToolStrip.Text = "Not Valid LastName";
                return;
            }
            try
            {
                if (!PhoneNumberTextBox.Text.ValidatePhoneNumber())
                    throw new NotValidInbutExcebtion();
                student.Phone = PhoneNumberTextBox.Text;
            }
            catch (NotValidInbutExcebtion)
            {
                StatusLabelToolStrip.Text = "Not Valid Phone Number";
                return;
            }
            try
            {
                if (!EmailTextBox.Text.ValidateEmail())
                    throw new NotValidInbutExcebtion();
                student.Email = EmailTextBox.Text;
            }
            catch (NotValidInbutExcebtion)
            {
                StatusLabelToolStrip.Text = "Not Valid Email";
                return;
            }
            foreach (string item in CoursesCheckedListBox.SelectedItems)
            {
                switch (item)
                {
                    case ".NET Basic":
                        Course dotNetBasic = new Course();
                        dotNetBasic = MyDB.courses[0];
                        student.CoursesList.Add(dotNetBasic);
                        break;
                    case "OOP":
                        Course oOP = new Course();
                        dotNetBasic = MyDB.courses[1];
                        student.CoursesList.Add(oOP);
                        break;
                    case "Core":
                        Course core = new Course();
                        dotNetBasic = MyDB.courses[2];
                        student.CoursesList.Add(core);
                        break;
                    case "HTML":
                        Course hTML = new Course();
                        dotNetBasic = MyDB.courses[3];
                        student.CoursesList.Add(hTML);
                        break;
                    case "CSS":
                        Course cSS = new Course();
                        dotNetBasic = MyDB.courses[4];
                        student.CoursesList.Add(cSS);
                        break;
                }
            }
            students.Add(student);
            StudentDataGridView.DataSource = null;
            StudentDataGridView.DataSource = students;
            StatusLabelToolStrip.Text = "Student sucsessefully add";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SearchByComboBox.Text != "None")
            {
                students = MyDB.Search(SearchByComboBox.Text, SearchTextBox.Text);
                StudentDataGridView.DataSource = null;
                StudentDataGridView.DataSource = students;
            }
            else
            {
                students = MyDB.students;
                StudentDataGridView.DataSource = null;
                StudentDataGridView.DataSource = students;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(rowId != null)
            {
                MyDB.RemoveStudent(rowId);
                StatusLabelToolStrip.Text = "Studend sucsessefully removed";
                StudentDataGridView.DataSource = null;
                StudentDataGridView.DataSource = MyDB.students;
                rowId = null;
            }
        }

        private void StudentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex >= 0)
            {
                DataGridViewRow row = StudentDataGridView.Rows[rowIndex];
                if(StudentDataGridView.CurrentCell.ColumnIndex == 9)
                {
                    DataGridViewComboBoxCell coursesData = new DataGridViewComboBoxCell();
                    row.Cells[9].Value = null;
                    foreach(Course course in students[rowIndex].CoursesList)
                    {
                        coursesData.Items.Add(course);
                    }
                    StudentDataGridView.Rows[rowIndex].Cells[9] = coursesData;
                }
                else
                    rowId = row.Cells[0].Value.ToString();
            }
        }
    }
}
