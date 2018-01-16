using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace SleepSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();

            using (StreamReader file = new StreamReader(@"C:\Users\Tech N choice\Desktop\haha.txt"))
            {
                while (!file.EndOfStream)
                {
                    arr.Add(Convert.ToInt32(file.ReadLine()));
                }
            }
            int[] array = arr.ToArray();
            int[] a = new int[array.Length];
            Stopwatch stop = new Stopwatch();
            stop.Start();
            int i = 0;

            while (true)
            {
                if (i == array.Length)
                {
                    break;
                }
                if (stop.Elapsed.Seconds == array[minimum(array)])
                {
                    a[i] = array[minimum(array)];
                    array[minimum(array)] = -1;
                    i++;
                }

            }
            Console.WriteLine("sorted array");
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total time taken " + stop.Elapsed.Seconds);
        }

        static int minimum( int[] b)
        {
            int x = 0;
            int min=1000000000;
            int i = 0;
            for ( i = 0; i < b.Length; i++)
			{
                if (b[i] < 0)
                {
                    continue;
                }

			 if (min>b[i])
	            {
		            min=b[i];
                    x = i;
	            }
             
			}
            if (i == b.Length)
            {
                return x;
            }
            else
            {
                return -1;
            }
            
        }

        }

    }


