using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    // Cтатический класс
    public static class StudentManager
    {
        private static List<Student> _students = new List<Student>(); // Список студентов

        // Метод для добавления студента в список
        public static void AddStudent(Student student)
        {
            _students.Add(student);
            Console.WriteLine($"{student.Name} добавлен в список студентов.");
        }

        // Метод для отображения информации обо всех студентах
        public static void DisplayAllStudents()
        {
            Console.WriteLine("Список студентов:");
            foreach (var student in _students)
            {
                Console.WriteLine(student.WriteInfo());
            }
            Console.WriteLine($"Общее количество студентов: {Student.StudentCount}");
        }
    }
}
