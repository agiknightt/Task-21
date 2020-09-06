using System;

namespace Task_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = inputValidationForNumber();

            Console.WriteLine(number);
            Console.ReadKey();
        }

        static int inputValidationForNumber()
        {
            bool outputNumeric = true;
            bool result;

            int number = 0;

            while (outputNumeric)
            {
                Console.Write("Введите число : ");

                result = int.TryParse(Console.ReadLine(), out number);

                if (result == true)
                {
                    outputNumeric = false;
                }
                else
                {
                    Console.WriteLine("Не верный формат числа");

                }
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
                Console.Clear();
            }
            return number;
        }
    }
}
