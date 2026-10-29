using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    internal class Program
    {
        private static int nextId = 1;
        static void Main(string[] args)
        {
           
        CultureInfo.CurrentCulture = new CultureInfo("bg-BG");

        Console.WriteLine("=== РЕГИСТРАЦИЯ НА УЧЕНИК ===");

        // Създаваме празен обект, който ще пълним с входни данни
        int currentId = nextId++;
        string name = ReadName(currentId);
        Student student = new Student(currentId, name);

        student.Age = ReadAge();
        student.Grade = ReadGrade();
        student.AverageScore = ReadAverageScore();
        student.Fee = ReadFee();
        student.HasScholarship = ReadScholarship();
        student.ClassLetter = ReadClassLetter();
        student.BirthDate = ReadBirthDate();

        // Извеждане на крайния резултат
        Console.Clear();
        Console.WriteLine("=== ДАННИ ЗА УЧЕНИК ===");
        Console.WriteLine("Id: " + student.id);
        Console.WriteLine("Име: " + student.Name);
        Console.WriteLine("Възраст: " + student.Age);
        Console.WriteLine("Клас: " + student.Grade);
        Console.WriteLine("Среден успех: " + student.AverageScore.ToString("F2"));
        Console.WriteLine("Такса: " + student.Fee.ToString("F2") + " лв.");
        Console.WriteLine("Стипендия: " + (student.HasScholarship? "Да" : "Не"));
        Console.WriteLine("Паралелка: " + student.ClassLetter);
        Console.WriteLine("Дата на раждане: " + student.BirthDate.ToString("dd.MM.yyyy"));
        }

        private static string ReadName(int id)
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете име на ученика: ");
                    string input = Console.ReadLine();
                    // Проверяваме чрез временно създаване на обект или директно
                    Student temp = new Student(id, input);
                    return temp.Name;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ГРЕШКА: " + ex.Message);
                }
            }
        }

        private static int ReadAge()
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете възраст (6-20): ");
                    int age = int.Parse(Console.ReadLine());
                    Student temp = new Student(1, "Test");
                    temp.Age = age; // Тук ще гръмне, ако е извън диапазона
                    return age;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ГРЕШКА: " + ex.Message);
                }
            }
        }

        private static int ReadGrade()
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете клас (1-12): ");
                    int grade = int.Parse(Console.ReadLine());
                    Student temp = new Student(1, "Test");
                    temp.Grade = grade;
                    return grade;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ГРЕШКА: " + ex.Message);
                }
            }
        }

        private static double ReadAverageScore()
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете среден успех (2.00-6.00): ");
                    double score = double.Parse(Console.ReadLine());
                    Student temp = new Student(1, "Test");
                    temp.AverageScore = score;
                    return score;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ГРЕШКА: " + ex.Message);
                }
            }
        }

        private static decimal ReadFee()
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете такса: ");
                    decimal fee = decimal.Parse(Console.ReadLine());
                    Student temp = new Student(1, "Test");
                    temp.Fee = fee;
                    return fee;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ГРЕШКА: " + ex.Message);
                }
            }
        }

        private static bool ReadScholarship()
        {
            while (true)
            {
                Console.Write("Получава ли стипендия (да/не): ");
                string input = Console.ReadLine().ToLower();
                if (input == "да" || input == "yes" || input == "true") return true;
                if (input == "не" || input == "no" || input == "false") return false;
                Console.WriteLine("Моля, въведете 'да' или 'не'.");
            }
        }

        private static char ReadClassLetter()
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете паралелка (буква): ");
                    char letter = char.Parse(Console.ReadLine());
                    Student temp = new Student(1, "Test");
                    temp.ClassLetter = letter;
                    return letter;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ГРЕШКА: " + ex.Message);
                }
            }
        }

        private static DateTime ReadBirthDate()
        {
            while (true)
            {
                try
                {
                    Console.Write("Въведете дата на раждане (дд.мм.гггг): ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    Student temp = new Student(1, "Test");
                    temp.BirthDate = date;
                    return date;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ГРЕШКА: " + ex.Message);
                }
            }
        }
    }
}
  