using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    // Интерфейс для учебных заведений
    interface IInstitution
    {
        string Name { get; set; }
        void AddStudent(Student student);
    }

    // Абстрактный класс Учащийся
    abstract class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Абстрактный метод для отображения информации о статусе учащегося
        public abstract void DisplayStatus(TextBox textBox);
    }

    // Подкласс Школьник
    class SchoolStudent : Student
    {
        public string Grade { get; set; }

        // Реализация метода для отображения информации о статусе учащегося (Школьник)
        public override void DisplayStatus(TextBox textBox)
        {
            textBox.AppendText($"School student {Name} is in {Grade} grade.\r\n");
        }
    }

    // Подкласс Студент
    class CollegeStudent : Student
    {
        public string Major { get; set; }

        // Реализация метода для отображения информации о статусе учащегося (Студент)
        public override void DisplayStatus(TextBox textBox)
        {
            textBox.AppendText($"College student {Name} is majoring in {Major}.\r\n");
        }
    }
    class School : IInstitution
    {
        public string Name { get; set; }
        private List<Student> students = new List<Student>();

        // Метод добавления студента в школу
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine($"Added {student.Name} to {Name}");
        }
    }

    // Класс колледжа
    class College : IInstitution
    {
        public string Name { get; set; }
        private List<Student> students = new List<Student>();

        // Метод добавления студента в колледж
        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine($"Added {student.Name} to {Name}");
        }
    }
}
