using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_четных_и_нечетных_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int x = 0;
            int y = 0;
            int j = 0;
            int k = 0;


            Console.WriteLine("Введите начало интервала: ");
            a = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Введите конец интервала: ");
            b = int.Parse(Console.ReadLine());
         


            for (; a <= b; a++)
            {
                if (a % 2 == 0)
                {
                    x = x + a;
                    y++;
                }
                else 

                { 
                    j = j + a;
                    k++;
                }
            }
         Console.WriteLine("Сумма четных чисел: " + x + " количество четных чисел: " + y);
         Console.WriteLine("Сумма нечетных чисел: " + j  + " количество нечетных чисел: " + k);
            Console.ReadLine();
            }
        }
    } 
