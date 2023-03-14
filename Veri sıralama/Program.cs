using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_sıralama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10000];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)//rastgele sayılar oluşturuluyor ve diziye giriliyor.
            {
                arr[i] = Convert.ToInt32(100000 * rnd.NextDouble());
            }

            QuickSort(arr, 0,arr.Length-1);

            for (int i = 0; i < arr.Length; i++)//kontrol etmek için kullandım açılması bir şeyi etkilemiyor
            {
                Console.WriteLine(arr[i] + "--" + i);
            }

            Console.ReadLine();
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                {
                    QuickSort(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(array, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right])
                    {
                        return right;
                    }

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
