using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_sıralama_BruteForce
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


            for (int i = 0; i < 10000; i++)//sayıları en büyükten en küçüğe yerleştirmek için bu for u kullanıyorum
            {
                int enBuyukSayı = 0;
                int enBuyukSayıIndex = 0;
                for (int j = 0; j < 10000-i; j++)//dizideki en büyük sayıyı bulmak için bu for u kullanıyorum sondan yerleştirdiğim her sayı için döngü sayımı i değerinde azaltıyorum.
                {
                    if (arr[j]>enBuyukSayı)
                    {
                        enBuyukSayı = arr[j];
                        enBuyukSayıIndex = j;
                    }
                }

                //aşağıdaki 3 satırda swap işlemi yaparak son indexten başlayarak büyük sayıları yerleştiriyorum
                int temp = arr[enBuyukSayıIndex];
                arr[enBuyukSayıIndex] = arr[9999-i];
                arr[9999 - i] = temp;
            }


            for (int i = 0; i < arr.Length; i++)//kontrol için çalıştırılan consola yazdırma işlemi
            {
                Console.WriteLine(arr[i] + "--" + i);
            }

            Console.ReadLine();
        }
    }
}
