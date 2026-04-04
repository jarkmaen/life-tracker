namespace CLI.UI
{
    public class TextUI
    {
        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("life tracker");
                Console.WriteLine();
                Console.WriteLine("1. add ingredient");
                Console.WriteLine("2. list ingredients");
                Console.WriteLine("3. exit");
                Console.WriteLine();
                Console.Write("> ");

                string? choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("life tracker > add ingredient");
                    Console.WriteLine();

                    Console.Write("id       : ");
                    string? id = Console.ReadLine();

                    Console.Write("name     : ");
                    string? name = Console.ReadLine();

                    Console.Write("quantity : ");
                    string? quantity = Console.ReadLine();

                    Console.Write("price    : ");
                    string? price = Console.ReadLine();

                    Console.WriteLine();

                    Console.Write("energy   : ");
                    string? energy = Console.ReadLine();

                    Console.Write("fat      : ");
                    string? fat = Console.ReadLine();

                    Console.Write("sat. fat : ");
                    string? saturatedFat = Console.ReadLine();

                    Console.Write("carbs    : ");
                    string? carbohydrate = Console.ReadLine();

                    Console.Write("sugar    : ");
                    string? sugar = Console.ReadLine();

                    Console.Write("protein  : ");
                    string? protein = Console.ReadLine();

                    Console.Write("salt     : ");
                    string? salt = Console.ReadLine();

                    Console.Write("fiber    : ");
                    string? fiber = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("ingredient added.");
                    Console.WriteLine();
                    Console.Write("press any key to continue...");
                    Console.ReadKey();
                }
                else if (choice == "2")
                {

                }
                else if (choice == "3" || string.IsNullOrWhiteSpace(choice))
                {
                    break;
                }
            }
        }
    }
}
