using System;

namespace seminar9
{
    class Program
    {
        // Задача 63: Задайте значение N. Напишите программу, 
        // которая выведет все натуральные числа в промежутке от 1 до N.
        // N = 5 -> "1, 2, 3, 4, 5"
        // N = 6 -> "1, 2, 3, 4, 5, 6"
        static int ReadInt(string prompt){
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void WriteNumbers(int num){
            if (num == 0) return;
            Console.Write(num+" ");
            WriteNumbers(num-1);
        }

        static void Main(string[] args)
        {
            WriteNumbers(ReadInt("Введите число: "));
        }
    }
}
