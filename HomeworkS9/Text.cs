namespace Homework
{
    class Text
    {
        /// <summary>Метод выводит в консоль меню домашнего задания</summary>
        public static void Menu()
        {
            Console.WriteLine("\nSELECT A MENU ITEM AND PRESS THE CORRESPONDING KEY:\n");
            Console.WriteLine("If you want to choose   Task 64 press the button:\t1");
            Console.WriteLine("\t\t\tTask 66 press the button:\t2");
            Console.WriteLine("\t\t\tTask 68 press the button:\t3");
            Console.Write("\nIf you want to exit program press any other button\t");
        }
        /// <summary>Метод выводит в консоль условие задачи 64</summary>
        public static void Task64()
        {
            Console.Clear();
            Console.WriteLine("\nЗадача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");
        }
        /// <summary>Метод выводит в консоль условие задачи 66</summary>
        public static void Task66()
        {
            Console.Clear();
            Console.WriteLine("\nЗадача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
        }
        /// <summary>Метод выводит в консоль условие задачи 68</summary>
        public static void Task68()
        {
            Console.Clear();
            Console.WriteLine("\nЗадача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        }
    }
}