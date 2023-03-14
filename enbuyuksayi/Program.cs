using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enbuyuksayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bigNum=0, numIndex=0;
            int[] arr = new  int[10000];
            Random rnd = new Random();
            
            for (int i = 0; i < arr.Length; i++)//rastgele sayılar oluşturuluyor ve diziye giriliyor.
            {
                arr[i] = Convert.ToInt32( 100000*rnd.NextDouble());
            }
            /*for (int i = 0; i < arr.Length; i++)--kontrol etmek için kullandım açılması bir şeyi etkilemiyor
            {
                Console.WriteLine(arr[i] + "--" + i);
            }*/
            for (int i = 0; i < arr.Length; i++)//BruteForce ile bütün diziyi bir kez dolaşıyoruz
            {
                if (arr[i]>bigNum)//indexte olduğumuz eleman bigNum sayısından büyükse parantez içine giriyoruz
                {
                    bigNum = arr[i];//bigNum'ı dizideki sayıya eşitliyoruz
                    numIndex= i;//numIndex'i sayının dizi index'ine eşitliyoruz
                }
            }
            Console.WriteLine("en Büyük sayi = " + bigNum);
            Console.WriteLine("en Büyük sayi index = " + numIndex);
            Console.ReadKey();

        }
    }
}
