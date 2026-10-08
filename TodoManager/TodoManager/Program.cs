using System.Security.Cryptography.X509Certificates;

namespace TodoManager
{
    internal class Program
    {
        static List<TaskItem> tasks = new List<TaskItem>();
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                //string RESET = "\u001b[0m";
                //Console.WriteLine($"{PASTEL_PINK}-------- TodoManager --------{RESET}");

                Console.WriteLine("\n--- ---- TodoManager ----");
                Console.WriteLine("1. Добави нова задача");
                Console.WriteLine("2. Покажи всички задачи");
                Console.WriteLine("3. Маркирай задача като изпълнена");
                Console.WriteLine("4. Изтрий задача");
                Console.WriteLine("5. Изход");
                Console.Write("Избери опция: ");
                 string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n --- ---- Нова задача -----");

                        Console.Write("Заглавие: ");
                        string title = Console.ReadLine();

                        Console.Write("Описание: ");
                        string description = Console.ReadLine();

                        DateTime OverTime;
                        Console.Write("Краен срок (дата.месец.година): "); 
                        

                        

                        while (!DateTime.TryParse (Console.ReadLine(),out OverTime))
                        {
                            Console.Write("Невалидна дата! Въведи отново: ");
                        }

                        tasks.Add(new TaskItem(title, description, OverTime));
                        Console.WriteLine("Задачата е добавена успешно!");
                       break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n ---- Всички задачи -----");

                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Няма въведени задачи!");
                            return;
                        }

                        for (int i = 0; i < tasks.Count; i++)
                        {
                            TaskItem task = tasks[i];
                            Console.WriteLine();
                            Console.WriteLine($"Задача #{i + 1}");
                            Console.WriteLine($"Заглавие: {task.Title}");
                            Console.WriteLine($"Описание: {task.Description}");
                            Console.WriteLine($"Краен срок: {task: data,mounth,year}");
                            Console.WriteLine($"Статус: {(task.IsCompleted ? "Изпълнена" : "Неизпълнена")}");
                        }
                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n ----- Маркиране на задача -----");
                        if (tasks.Count == 0) 
                        {
                         Console.WriteLine("Няма въведени задачи!");
                         
                        }
                        
                        Console.Write("Въведи номер на задачата: "); 
                        int number; 
                        if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= tasks.Count) 
                        {
                            tasks[number - 1].IsCompleted = true; 
                            Console.WriteLine("Задачата е маркирана като изпълнена!");
                        } 
                        else 
                        { 
                            Console.WriteLine("Невалиден номер на задача!"); 
                        }

                        ShowTaskTitles();
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\\n ---- Изтриване на задача -----");

                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Няма въведени задачи!");

                            break;
                        }

                        ShowTaskTitles();

                        Console.Write("Въведи номер на задачата: ");
                        number = 0;

                        if (int.TryParse(Console.ReadLine(), out number) &&
                            number >= 1 && number <= tasks.Count)
                        {
                            tasks.RemoveAt(number - 1);
                            Console.WriteLine("Задачата е изтрита!");
                        }
                        else
                        {
                            Console.WriteLine("Невалиден номер на задача!");
                        }
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Невалиден избор!");
                        break;
                }
            }


            static void ShowTaskTitles()
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i].Title}");
                }
            }

        }

    }
}


