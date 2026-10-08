namespace StudentRegistration
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            //Console.Write("Enter age: ");


            //if (int.TryParse(Console.ReadLine(), out int age))
            //{
            //    Console.WriteLine($"Възраст: {age}");
            //}
            //else
            //{
            //    Console.WriteLine("Невалидна възраст!");
            //}

            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                Console.WriteLine($"Клас: {grade}");
            }
            else
            {
                
            }


        }
    }
}
