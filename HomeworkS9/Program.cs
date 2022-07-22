namespace Homework
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Text.Menu();
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key == ConsoleKey.D1)
                {
                    Text.Task64();
                    Solutions.Task64Sol();
                }
                else if (input.Key == ConsoleKey.D2)
                {
                    Text.Task66();
                    Solutions.Task66Sol();
                }
                else if (input.Key == ConsoleKey.D3)
                {
                    Text.Task68();
                    Solutions.Task68Sol();
                }
            }
            catch
            {
                Console.WriteLine("INCORRECT DATA TRY AGAIN!");
                Main();
            }
        }
    }
}
