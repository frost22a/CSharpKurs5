using System;

namespace _1_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyStack<double>();

            while (true)
            {
                int choise = DisplayMenu();

                WorkWithChoice(collection, choise);
                BackToMenu();
            }
        }

        

        private static int DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("\nMenu");
            Console.WriteLine();
            Console.WriteLine("1. Write element");
            Console.WriteLine("2. Read element");
            Console.WriteLine("3. Check element");
            Console.WriteLine("4. Display all");
            Console.WriteLine("5. End of program");
            Console.WriteLine();
            Console.WriteLine("Choose an option:");
            int.TryParse(Console.ReadLine(), out int choise);
            return choise;
        }

        private static void WorkWithChoice(IMyCollection<double> stack, int choise)
        {
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Write element: ");
                    if (double.TryParse(Console.ReadLine(), out double value))
                        stack.WriteElement(value);
                    break;
                case 2:
                    Console.WriteLine($"This element readed: {stack.ReadElement()}");
                    break;
                case 3:
                    Console.WriteLine($"The output element is: {stack.CheckElement()}");
                    break;
                case 4:
                    stack.DisplayAll();
                    break;
                case 5:
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("You made wrong choise");
                    break;
            }
        }

        private static void BackToMenu()
        {
            Console.WriteLine("Press enter do go back to the menu");
            Console.ReadLine();
        }

    }
}
