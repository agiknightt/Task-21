using System;

namespace Task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool enterOrExit = true;
            bool result;

            int number;
            while (enterOrExit)
            {
                Console.Write("Введите число : ");
                enterOrExit = OutputNumber(enterOrExit, out result, out number);

                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static bool OutputNumber(bool enterOrExit, out bool result, out int number)
        {
            result = int.TryParse(Console.ReadLine(), out number);

            if (result == true)
            {
                enterOrExit = false;
            }
            else
            {
                Console.WriteLine("Не верный формат числа");

            }
            return enterOrExit;
        }
    }
}
