using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace antesquence20th
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[500];
            int[] array = new int[500];
            int count = 1;
            int a = 0, b = 0;

            num[0] = 1;

            Console.WriteLine("1번째 수열: " + num[0]);
            for (int i = 0; i < 19;i++)
            {
                while (num[a] != 0)
                {
                    if (num[a] == num[a + 1])
                        count++;
                    else
                    {
                        array[b] = num[a];
                        array[b + 1] = count;
                        b += 2;
                        count = 1;
                    }
                    a++;
                }
                Array.Copy(array, num, array.Length);
                a = 0; 
                b = 0;

                Console.Write(i + 2 + "번째 수열: ");
                foreach (var item in num)
                {
                    if (item == 0) break;
                    Console.Write(item);
                }
                Console.WriteLine();



            }

        }
    }
}
