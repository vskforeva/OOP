using System.Xml.Serialization;
namespace OOP_1;
class Program()
{
    static void Main(string[] args)
    {
        // Используем конструктор, принимающий только имя
        Student student1 = new Student("Иван");
        Console.WriteLine(student1.WriteInfo()); // Вывод: Имя: Иван, Возраст: 0

        // Используем конструктор, принимающий имя и возраст
        Student student2 = new Student("Мария", 20);
        Console.WriteLine(student2.WriteInfo()); // Вывод: Имя: Мария, Возраст: 20

        // Увеличиваем возраст первого студента
        student1.BecomeOlder();
        Console.WriteLine(student1.WriteInfo()); // Вывод: Имя: Иван, Возраст: 1

        // Увеличиваем возраст второго студента
        student2.BecomeOlder();
        Console.WriteLine(student2.WriteInfo()); // Вывод: Имя: Мария, Возраст: 21
    }
}

