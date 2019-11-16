using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    class Program
    {

        static void Main(string[] args)
        {
            var masiv = new int[100];
            masiv = Push(masiv);
            Sort(masiv);
            Write(masiv);
            Console.ReadKey();
        }
        static int[] Sort(int[] masiv)
        {
            if(masiv.Length == 1)
            {
                return masiv;
            }

            var mid = masiv.Length / 2;

            var left = new int[mid];
            for (int x = 0; x < mid; x++)
            {
                left[x] = masiv[x];
            }
            Write(left);

            var right = new int[mid];
            for (int y = 0; y < mid; y++)
            {
                right[y] = masiv[y+mid];
            }
            Write(right);
            Merge(masiv, left, right);
            return masiv;
        }
        static int[] Merge(int[] masiv, int[] left, int[] right)
        {
            var lenght = left.Length + right.Length;
            var leftPointer = 0;
            var rightPointer = 0;

            for(int i = 0; i < lenght; i++)
            {
                if (leftPointer < left.Length && rightPointer < right.Length)
                {
                    if (left[leftPointer] < right[rightPointer])
                    {
                        masiv[i] = left[leftPointer];
                        leftPointer++;
                    }
                    else
                    {
                        masiv[i] = right[rightPointer];
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer < right.Length)
                    {
                        masiv[i] = right[rightPointer];
                        rightPointer++;
                    }
                    else
                    {
                        masiv[i] = left[leftPointer];
                        leftPointer++;
                    }
                }
            }

            return masiv;
        }
        static int[] Push(int[] masiv)
        {
            var random = new Random();
            for (int i = 0; i < masiv.Length; i++)
            {
                masiv[i] = random.Next(1, 100);
                if (masiv[i] < 10)
                {
                    Console.Write(" " + masiv[i] + " ");
                }
                else
                {
                    Console.Write(masiv[i] + " ");
                }

            }
            return masiv;
        }
        static int[] Swap(int[] masiv, int x, int MinIndex)
        {
            int t = masiv[x];
            masiv[x] = masiv[MinIndex];
            masiv[MinIndex] = t;
            return masiv;
        }
        static void Write(int[] masiv)
        {
            Console.WriteLine("\n");
            for (int v = 0; v < masiv.Length; v++)
            {
                if (masiv[v] < 10)
                {
                    Console.Write(" " + masiv[v] + " ");
                }
                else
                {
                    Console.Write(masiv[v] + " ");
                }
            }
        }
    }
}
