using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il totale della spesa");
            double tot = double.Parse(Console.ReadLine());
            double sconto = (tot * 20) / 100;
            if (tot > 100)
            {
                double importo = tot - sconto;
                Console.WriteLine($"il totale è {importo:c}");
            }
            else
            {
                Console.WriteLine("la spesa non supera i 100 euro");
            }
            Console.ReadLine();
        }
    }
}
