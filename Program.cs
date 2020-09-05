using System;

namespace Task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            OutputNumber();
        }

        private static void OutputNumber()
        {
            bool enterOrExit = true;
            bool result;

            int number;

            while (enterOrExit)
            {
                Console.Write("Введите число : ");

                result = int.TryParse(Console.ReadLine(), out number);

                if (result == true)
                {
                    enterOrExit = false;
                }
                else
                {
                    Console.WriteLine("Не верный формат числа");

                }
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
