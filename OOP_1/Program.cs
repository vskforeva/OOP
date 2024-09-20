using System.Xml.Serialization;
namespace OOP_1;
class Program()
{
    static void Main(string[] args)
    {
        // Используем конструктор, принимающий только имя
        Student student1 = new Student("Иван");
        Subject favoriteSubject1 = new Subject("Программирование");
        Game favoriteGame1 = new Game("Футбол");
        student1.SetFavorites(favoriteSubject1, favoriteGame1);
        Console.WriteLine(student1.WriteInfo()); // Вывод: Имя: Иван, Возраст: 0, Программ-е, Футбол

        // Используем конструктор, принимающий имя и возраст
        Student student2 = new Student("Мария", 20);
        Subject favoriteSubject2 = new Subject("Математика");
        Game favoriteGame2 = new Game("Шахматы");
        student2.SetFavorites(favoriteSubject2, favoriteGame2);
        Console.WriteLine(student2.WriteInfo()); // Вывод: Имя: Мария, Возраст: 20, Математика, Шахматы

        Console.WriteLine(" ");

        // Увеличиваем возраст первого студента
        student1.BecomeOlder();
        Console.WriteLine(student1.WriteInfo()); // Вывод: Имя: Иван, Возраст: 1, Программ-е, Футбол

        // Увеличиваем возраст второго студента
        student2.BecomeOlder();
        Console.WriteLine(student2.WriteInfo()); // Вывод: Имя: Мария, Возраст: 21, Математика, Шахматы

        Console.WriteLine(" ");

        // Демонстрация передачи параметров
        string nameValue = "Оригинальное имя";
        student2.ChangeNameByValue(nameValue);
        Console.WriteLine($"Имя после вызова ChangeNameByValue: {nameValue}");

        student2.ChangeNameByReference(ref nameValue);
        Console.WriteLine($"Имя после вызова ChangeNameByReference: {nameValue}");
    }
}

