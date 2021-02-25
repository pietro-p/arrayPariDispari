using System;
using operazioni;
namespace inserimentoNumeriPariDispari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quanti numeri vuoi generare? ");
            int x = int.Parse(Console.ReadLine());
            int[] array = new int[x];
            Gestione.NumeriRandom(array, 0, 100);                   
            Gestione.StampaArray(array, "Numeri generati");
            Console.WriteLine("");
            Gestione.SeparaPariDispari(array,x);
            Gestione.BubbleSort(array, x);
            Console.WriteLine("");
            Gestione.StampaArray(array, "Numeri in ordine crescente");


        }
    }
}
