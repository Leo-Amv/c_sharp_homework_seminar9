namespace Homework
{
    class Methods
    {
        /// <summary>Метод спрашивает значения M и N и присваивает эти значения переменным m и n</summary>
        /// <param name="m">Переменная первое целое натуральное число</param>
        /// <param name="n">Переменная первое целое натуральное число</param>
        public static void AskValuesMN(out int m, out int n)
        {
            Console.Write("\nEnter number M:\t");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.Write("\nEnter number N:\t");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            if (m <= 0 || n <= 0 || m > n)
            {
                Console.WriteLine("Incorrect data try enter positive numbers or M must be greater than N!");
                AskValuesMN(out m, out n);
            }
        }
        /// <summary>Метод печатает в консоли все числа от m до n</summary>
        /// <param name="m">Переменная первое целое натуральное число (от)</param>
        /// <param name="n">Переменная второе целое натуральное число (до)</param>
        public static void PrintValues(int m, int n)
        {
            while (m <= n)
            {
                Console.Write($"{m}\t");
                m++;
            }
        }
        /// <summary>Метод печатает в консоли сумму всех элементов от m до n</summary>
        /// <param name="m">Переменная первое целое натуральное число (от)</param>
        /// <param name="n">Переменная второе целое натуральное число (до)</param>
        public static void PrintSumValues(int m, int n)
        {
            int summary = 0;
            for (; m <= n; m++)
            {
                summary += m;
            }
            Console.WriteLine($"\nSummary = {summary}");
        }
        /// <summary>Метод спрашивает значения M и N и присваивает эти значения переменным m и n</summary>
        /// <param name="m">Переменная первое целое неотрицательное число</param>
        /// <param name="n">Переменная первое целое неотрицательное число</param>
        public static void AskValuesAckMN(out int m, out int n)
        {
            Console.Write("\nEnter number M:\t");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.Write("\nEnter number N:\t");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            if (m < 0 || n < 0)
            {
                Console.WriteLine("Incorrect data try enter positive numbers !");
                AskValuesAckMN(out m, out n);
            }
        }
        /// <summary>Рекурсивная функция Аккермана</summary>
        /// <param name="m">Переменная первое целое неотрицательное число</param>
        /// <param name="n">Переменная второе целое неотрицательное число</param>
        /// <returns></returns>
        public static int Ack(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return Ack(m - 1, 1);
            }
            else
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
        }
    }
}