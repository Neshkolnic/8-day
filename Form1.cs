using SchoolManagementSystem;
using System;
using System.Windows.Forms;


namespace day_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        College college = new College();
        School school = new School();
     
        private void Form1_Load(object sender, EventArgs e)
        {
            SchoolStudent schoolStudent = new SchoolStudent { Name = "Alice", Age = 15, Grade = "10 класс" };
            CollegeStudent collegeStudent = new CollegeStudent { Name = "Bob", Age = 20, Major = "Computer Science" };

            schoolStudent.DisplayStatus(textBox1);
            collegeStudent.DisplayStatus(textBox1);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("1st ");
            comboBox1.Items.Add("2nd ");
            comboBox1.Items.Add("3rd ");
            comboBox1.Items.Add("4th ");
            comboBox1.Items.Add("5th ");
            comboBox1.Items.Add("6th ");
            comboBox1.Items.Add("7th ");
            comboBox1.Items.Add("8th ");
            comboBox1.Items.Add("9th ");
            comboBox1.Items.Add("10th ");
            comboBox1.Items.Add("11th ");


            checkBox2.Checked = false;
            

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Information Technology");
            comboBox1.Items.Add("Mathematics and Statistics");
            comboBox1.Items.Add("Physics and Astronomy");
            comboBox1.Items.Add("Chemistry");
            comboBox1.Items.Add("Biology");
            comboBox1.Items.Add("Languages and Literature");
            comboBox1.Items.Add("History and Political Science");
            comboBox1.Items.Add("Economics and Business");
            comboBox1.Items.Add("Engineering");
            comboBox1.Items.Add("Medicine and Healthcare");
            comboBox1.Items.Add("Art and Design");


            checkBox1.Checked = false;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();

            string name = textBox2.Text;
            int age = (int)numericUpDown1.Value;

            // Проверяем, выбран ли чекбокс "Школьник"
            if (checkBox1.Checked)
            {
                string grade = comboBox1.Text; // Получаем выбранный класс из ComboBox
                SchoolStudent newSchoolStudent = new SchoolStudent { Name = name, Age = age, Grade = grade };
                school.AddStudent(newSchoolStudent);
                newSchoolStudent.DisplayStatus(textBox1);
            }
            // Проверяем, выбран чекбокс "Студент"
            else if (checkBox2.Checked)
            {
                string major = comboBox1.Text; // Получаем выбранную специальность из ComboBox
                CollegeStudent newCollegeStudent = new CollegeStudent { Name = name, Age = age, Major = major };
                college.AddStudent(newCollegeStudent);
                newCollegeStudent.DisplayStatus(textBox1);
            }

            // Очищаем поля ввода
            textBox2.Text = "";
            numericUpDown1.Value = 0;
            comboBox1.SelectedIndex = -1; // Сбрасываем выбор в ComboBox



        }

    }
}
