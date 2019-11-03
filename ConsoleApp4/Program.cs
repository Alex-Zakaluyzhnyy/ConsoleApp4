using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]);
        }

        private static int TakeLengthOfArray(int num)
        {
            int LengthOfArray = 0;
            int dec = 10;
            if (num > 0)
            {
                while (num > 0)
                {
                    int devide = num % dec;
                    num = num / dec;
                    LengthOfArray++;
                }
            }
            return LengthOfArray;
        }

        public static int Readnum()
        {
            int anyNumber;
            int numberrr;
 m1:           Console.WriteLine("Введите число");
            if (int.TryParse(Console.ReadLine(), out numberrr))
                return anyNumber = numberrr;
            else
            {
                Console.WriteLine("Введено нечисловое значение!\nНажмите клавишу 'enter'для продолжения...");
                Console.ReadLine();
                Console.Clear();
                goto m1;
            }
        }

        private static int[] SortArray(int[] array)
        {
            for (int j = 1; j < array.Length; j++) 
            {
                for (int i = 0; i < array.Length - j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int new_element = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = new_element;
                    }
                }
            }
            return array;
        }

        public static void Reverse (int num)
        {
            int dec = 10;
            int k = 0;
            if (num > 0)
            {
                Console.Clear();
                Console.WriteLine("Исходный порядок: ");
                Console.WriteLine(num);
                int n = TakeLengthOfArray(num);
                int[] array = new int[n];
                while (num > 0)
                {
                    int devide = num % dec;
                    num = num / dec;
                    array[k] = devide;
                    k++;
                }
                Program.SortArray(array);
                Console.WriteLine("Порядок по возрастанию: ");
                Program.Print(array);
                Console.WriteLine("\nНажмите клавишу 'enter'...");
                Console.ReadLine();
            }
            else if (num == 0)
            {
                Console.Clear();
                Console.WriteLine("Исходный порядок: ");
                Console.WriteLine(num);
                Console.WriteLine("Порядок по возрастанию: \n0");
                Console.ReadLine();
            }

            else if (num < 0)
            {
                Console.Clear();
                Console.WriteLine("Исходный порядок: ");
                Console.WriteLine(num);
                num = Math.Abs(num);
                int n = TakeLengthOfArray(num);
                int[] array = new int[n];
                while (num > 0)
                {
                    int devide = num % dec;
                    num = num / dec;
                    array[k] = devide;
                    k++;
                }
                Program.SortArray(array);
                Console.Write("Порядок по возрастанию: \n-");
                Program.Print(array);
                Console.WriteLine("\nНажмите клавишу 'enter'...");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            int number = Program.Readnum();
            Program.Reverse(number);
        }
    }
}
