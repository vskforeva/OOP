using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP_1
{
    public class Student
    {
        private string _name; // Приватное поле для имени студента
        public int Age { get; set; } // Свойство для возраста



        // Статическое поле для подсчета количества экземпляров класса Student
        private static int _studentCount;

        // Статическое свойство для получения количества студентов
        public static int StudentCount
        {
            get { return _studentCount; }
        }

        // Статический метод для сброса счетчика студентов (для демонстрации)
        public static void ResetStudentCount()
        {
            _studentCount = 0;
            Console.WriteLine("Количество студентов сброшено.");
        }

        // Статический конструктор для инициализации статических членов
        static Student()
        {
            _studentCount = 0; // Инициализируем количество студентов нулем
        }



        // Свойство для имени студента
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Конструктор, принимающий только имя
        public Student(string name)
        {
            _name = name;
            Age = 0; // Устанавливаем возраст по умолчанию
            _studentCount++; // Увеличиваем счетчик студентов при создании нового экземпляра
        }

        // Конструктор, принимающий имя и возраст
        public Student(string name, int age)
        {
            _name = name;
            Age = age;
            _studentCount++; // Увеличиваем счетчик студентов при создании нового экземпляра
        }

        // Метод для получения информации о студенте
        public string WriteInfo()
        {
            return $"Имя: {_name}, Возраст: {Age}";
        }

        // Метод для увеличения возраста на единицу
        public void BecomeOlder()
        {
            Age++;
        }   
    }
}