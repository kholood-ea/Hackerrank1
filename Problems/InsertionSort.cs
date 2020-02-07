using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Problems
{
   public class InsertionSort
    {
      public  static void insertionSort2(int n, int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int j = i + 1;
                if (arr[i] <= arr[j])
                {
                    Console.WriteLine("{0}", string.Join(" ", arr));
                }
                else if (arr[i] > arr[j])
                {
                    j = i;
                    for (; j >= 0; j--)
                    {
                        if (arr[j + 1] > arr[j])
                        {
                            break;
                        }
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                    Console.WriteLine("{0}", string.Join(" ", arr));
                }
            }

        }
            
      public  static void ReadVar()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '),
                arrTemp => Convert.ToInt32(arrTemp)
                )
            ;
            insertionSort2(n, arr);
        }
    }
    }
