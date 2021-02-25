using System;

namespace operazioni
{
    public class Gestione
    {
        public static void NumeriRandom(int[] array, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(min, max);
            }
        }
        public static void BubbleSort(int[] array, int lunghezza)
        {
            int temp;
            int x, y;
            for (x = 0; x < lunghezza - 1; x++)
            {
                for (y = 0; y < lunghezza - 1 - x; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }
                }
            }
        }
        public static void LeggiArray(int[] array)
        {
            Console.WriteLine($"inserisci le presenze mese per mese");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"inserisci le presenze del {i + 1}° mese");
                int n = int.Parse(Console.ReadLine());
                array[i] = n;
            }

        }
        public static void StampaArray(int[] array, string parola)
        {
            Console.WriteLine($"{parola}");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
        public static void SeparaPariDispari(int[] array,int lunghezza)
        {
            int cont_pari = 0, cont_dispari = 0;          
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    cont_pari++;                  
                }
                else
                {
                    cont_dispari++;                    
                }
            }
            int[] array_pari = new int[cont_pari];
            int[] array_dispari = new int[cont_dispari];
            for (int i = 0, k = 0, j = 0; i < lunghezza; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array_pari[j] = array[i];
                    j++;
                }
                else
                {                   
                    array_dispari[k] = array[i];
                    k++;
                }
            }
            StampaArray(array_pari, "numeri pari");
            Console.WriteLine("");
            StampaArray(array_dispari, "numeri dispari");
        }
    }
}
