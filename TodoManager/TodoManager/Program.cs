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
                Console.WriteLine("---- TodoManager ----");
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
                        Console.WriteLine("---- Нова задача -----");

                        Console.Write("Заглавие: ");
                        string title = Console.ReadLine();

                        Console.Write("Описание: ");
                        string description = Console.ReadLine();

                        int data = int.Parse(Console.ReadLine());
                        int mounth = int.Parse(Console.ReadLine());
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Краен срок (дата.месец.година): " + data + mounth + year);


                        if ()
                        {
                            Console.Write("Невалидна дата. Въведи отново: ");
                        }



                        Console.WriteLine("Задачата е добавена успешно!");
                        break;

                    case "2":
                        Console.WriteLine("---- Всички задачи -----");

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
                            Console.WriteLine($"Краен срок: {task:дата.месец. година}");
                            //Console.WriteLine($"Статус: {(task.IsCompleted ? "Изпълнена" : "Неизпълнена")}");
                        }
                        if (tasks.Count > 0)
                        {

                        }
                        break;

                    case "3":
                        Console.WriteLine("===== Маркиране като изпълнена =====");

                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Няма въведени задачи.");
                            ;
                            return;
                        }

                        ShowTaskTitles();

                        Console.Write("Въведи номер на задачата: ");
                        int number;

                        if (int.TryParse(Console.ReadLine(), out number) &&
                            number >= 1 && number <= tasks.Count)
                        {
                            tasks[number - 1].IsCompleted = true;
                            Console.WriteLine("Задачата е маркирана като изпълнена.");
                        }
                        else
                        {
                            Console.WriteLine("Невалиден номер на задача.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("---- Изтриване на задача -----");

                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("Няма въведени задачи!");

                            return;
                        }

                        ShowTaskTitles();

                        Console.Write("Въведи номер на задачата: ");
                        //int number = 0;

                        if (int.TryParse(Console.ReadLine(), out number) &&
                            number >= 1 && number <= tasks.Count)
                        {
                            tasks.RemoveAt(number - 1);
                            Console.WriteLine("Задачата е изтрита.");
                        }
                        else
                        {
                            Console.WriteLine("Невалиден номер на задача.");
                        }
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Невалиден избор!");
                        ;
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


            //static void CompleteTask()
            //{
            //    Console.Clear();
            //    Console.WriteLine("===== Маркиране като изпълнена =====");

            //    if (tasks.Count == 0)
            //    {
            //        Console.WriteLine("Няма въведени задачи.");
            //        ;
            //        return;
            //    }

            //    ShowTaskTitles();

            //    Console.Write("Въведи номер на задачата: ");
            //    int number;

            //    if (int.TryParse(Console.ReadLine(), out number) &&
            //        number >= 1 && number <= tasks.Count)
            //    {
            //        tasks[number - 1].IsCompleted = true;
            //        Console.WriteLine("Задачата е маркирана като изпълнена.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Невалиден номер на задача.");
            //    }


            //}

        }

    }
}


