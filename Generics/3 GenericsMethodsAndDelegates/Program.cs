using System;

namespace GenericsMethodsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyOverWriteQueue<double>();

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
            Console.WriteLine("5. Display foreach");
            Console.WriteLine("6. End of program");
            Console.WriteLine();
            Console.WriteLine("Choose an option:");
            int.TryParse(Console.ReadLine(), out int choise);
            return choise;
        }

        private static void WorkWithChoice(IMyCollection<double> collection, int choise)
        {
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Write element: ");
                    if (double.TryParse(Console.ReadLine(), out double value))
                        collection.WriteElement(value);
                    break;
                case 2:
                    Console.WriteLine($"This element readed: {collection.ReadElement()}");
                    break;
                case 3:
                    Console.WriteLine($"The output element is: {collection.CheckElement()}");
                    break;
                case 4:
                    collection.DisplayAll();
                    break;
                case 5:
                    var asInt = collection.AsEnumerableOf<int>();
                    foreach (var item in asInt)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 6:
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
