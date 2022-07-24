namespace Homework
{
    class Solutions
    {
        /// <summary>Метод запускает в консоли решение задачи 64</summary>
        public static void Task64Sol()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Methods.AskValuesMN(out int m, out int n);
            Methods.PrintValues(m, n);
        }
        /// <summary>Метод запускает в консоли решение задачи 66</summary>
        public static void Task66Sol()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Methods.AskValuesMN(out int m, out int n);
            Methods.PrintValues(m, n);
            Methods.PrintSumValues(m, n);
        }
        /// <summary>Метод запускает в консоли решение задачи 68</summary>
        public static void Task68Sol()
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Methods.AskValuesAckMN(out int m, out int n);
            Console.WriteLine($"Ack({m},{n}) = {Methods.Ack(m, n)}");
        }
    }
}
