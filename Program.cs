using System;

namespace seminar9
{
    class Program
    {
        static int ReadInt(string prompt){
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void WriteNumbers(int m, int n){
            if (n == m-1) return;
            WriteNumbers(m, n-1);
            Console.Write(n+" ");
        }

        static void Main(string[] args)
        {
            int m = ReadInt("Введите число m: ");
            int n = ReadInt("Введите число n: ");
            if (m < n){
                WriteNumbers(m, n);
            } else {
                WriteNumbers(n, m);
            }
        }
    }
}
