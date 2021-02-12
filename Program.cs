using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[55];
            int i, j, n, x, y, temp;

            Console.WriteLine("Enter the Size of Array :");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Array Elements :");
            for (i = 0; i < n; i++)
            {
                arr[i] = int.Parse((Console.ReadLine()));
            }
            for (i = 0; i < (n - 1); i++)
            {
                y = arr[i];
                x = i;
                for (j = i + 1; j < n; j++)
                {
                    if (y > arr[j])
                    {
                        y = arr[j];
                        x = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[x];
                arr[x] = temp;
            }
            Console.WriteLine("After Selection Sort :");
            for (i = 0; i < n; i++)
                Console.WriteLine(arr[i] + " ");
            Console.ReadKey();
        }
    }
}