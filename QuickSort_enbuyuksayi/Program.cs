using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_enbuyuksayi
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
            /*for (int i = 0; i < arr.Length; i++)--kontrol etmek için kullandım açılması bir şeyi etkilemiyor
            {
                Console.WriteLine(arr[i] + "--" + i);
            }*/

            //aynı değeri verip vermediğini kontrol etmek için aşağıdaki yorum alanını açınız

            /* int bigNum = 0, numIndex = 0;
              for (int i = 0; i < arr.Length; i++)//BruteForce ile bütün diziyi bir kez dolaşıyoruz
            {
                if (arr[i] > bigNum)//indexte olduğumuz eleman bigNum sayısından büyükse parantez içine giriyoruz
                {
                    bigNum = arr[i];//bigNum'ı dizideki sayıya eşitliyoruz
                    numIndex = i;//numIndex'i sayının dizi index'ine eşitliyoruz
                }
            }
            Console.WriteLine("en Büyük sayi = " + bigNum);
            Console.WriteLine("en Büyük sayi index = " + numIndex);*/

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("en Büyük sayi = " + arr[arr.Length-1]);
            Console.WriteLine("en Büyük sayi index = " +((arr.Length)-1));
            Console.ReadKey();
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
