using System.Xml.Serialization;
namespace OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем три объекта класса Student различными способами
            Student student1 = new Student("Иван");
            Student student2 = new Student("Мария", 20);
            Student student3 = new Student("Петр", 22);

            // Добавляем студентов в менеджер студентов
            StudentManager.AddStudent(student1);
            StudentManager.AddStudent(student2);
            StudentManager.AddStudent(student3);

            // Отображаем информацию о всех студентах
            StudentManager.DisplayAllStudents();

            // Увеличиваем возраст первого студента и отображаем информацию снова
            student1.BecomeOlder();
            Console.WriteLine(student1.WriteInfo());

            // Увеличиваем возраст второго студента и отображаем информацию снова
            student2.BecomeOlder();
            Console.WriteLine(student2.WriteInfo());

            // Увеличиваем возраст третьего студента и отображаем информацию снова
            student3.BecomeOlder();
            Console.WriteLine(student3.WriteInfo());

            // Отображаем информацию о всех студентах после увеличения возраста
            StudentManager.DisplayAllStudents();

            // Сбрасываем количество студентов (для демонстрации)
            Student.ResetStudentCount();

            Console.WriteLine($"Количество студентов после сброса: {Student.StudentCount}");
        }
    }
}