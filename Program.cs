using System;

namespace seminar9
{
    class Program
    {
        static int ReadInt(string prompt){
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int SumDigits(int num){
            if (num == 0) return 0;
            return (num % 10 + SumDigits(num / 10));
        }

        static void Main(string[] args)
        {
            Console.Write(SumDigits(ReadInt("Enter number: ")));
        }
    }
}
