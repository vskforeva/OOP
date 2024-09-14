using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class Student
    {
        private string _name;
        public int Age { get; set; }

        // Свойство для имени
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Конструктор, принимающий только имя
        public Student(string name)
        {
            _name = name;
            Age = 0;
        }

        // Конструктор, принимающий имя и возраст
        public Student(string name, int age)
        {
            _name = name;
            Age = age;
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
