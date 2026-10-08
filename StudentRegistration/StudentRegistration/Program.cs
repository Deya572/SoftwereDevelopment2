using System.Diagnostics;
using System.Globalization;

namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            ////godini
            //Console.Write("Enter age: ");
            //if (int.TryParse(Console.ReadLine(), out int age) || (int.TryParse(Console.ReadLine(), out int grade));
            //{
            //    Console.WriteLine($"Възраст: {age}");
            //}
            //else
            //{
            //    Console.WriteLine("Невалидна възраст!");
            //}

            ////klass
            //Console.Write("Enter grade: ");
            //if (int.TryParse(Console.ReadLine(), out int grade))
            //{
            //    Console.WriteLine($"Клас: {grade}");
            //}
            //else
            //{
            //    Console.WriteLine("Невалиден клас!");
            //}

            //sreden uspeh
            double average;
            while (true)
            {
                Console.Write("Среден успех: ");

                string input = Console.ReadLine();


                input = input.Replace(',', '.');

                if (double.TryParse(
                    input,
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out average))
                {
                    break;
                }

                Console.WriteLine("Невалиден среден успех! Опитайте отново.");
            }

            //    char letter;
            //while (char.TryParse(Console.ReadLine()),out letter)
            //{
            //}

        }
    }
}
