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

        // Свойства для любимого предмета и игры
        public Subject FavoriteSubject { get; private set; }
        public Game FavoriteGame { get; private set; }

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

        // Метод для установки любимого предмета и игры
        public void SetFavorites(Subject subject, Game game)
        {
            FavoriteSubject = subject;
            FavoriteGame = game;
        }

        // Метод для получения информации о студенте
        public string WriteInfo()
        {
            return $"Имя: {_name}, Возраст: {Age}, Любимый предмет: {FavoriteSubject?.Name}, Любимая игра: {FavoriteGame?.Name}";
        }

        // Метод для увеличения возраста на единицу
        public void BecomeOlder()
        {
            Age++;
        }

        // Метод для демонстрации передачи параметра по значению и по ссылке
        public void ChangeNameByValue(string newName)
        {
            newName = "Измененное имя";
            Console.WriteLine($"Имя внутри метода (по значению): {newName}");
        }

        public void ChangeNameByReference(ref string newName)
        {
            newName = "Измененное имя";
            Console.WriteLine($"Имя внутри метода (по ссылке): {newName}");
        }
    }
    public class Subject
    {
        public string Name { get; set; }

        public Subject(string name)
        {
            Name = name;
        }
    }

    public class Game
    {
        public string Name { get; set; }

        public Game(string name)
        {
            Name = name;
        }
    }
}
