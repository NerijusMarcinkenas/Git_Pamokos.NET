using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Suskaičiuoti Žemės rutulio plota (spindulys: 6371 km).  
             * Rezultatą rašyti į kintamąjį.
             * Suskaičiuoti Žemės rutulio tūrį(spindulys: 6371 km). Rezultatą  rašyti įkintamąjį.
             * Suskaičiuoti stačiojo trikampio įžambinės(prieš statųjį kampą esantį stačiojo  trikampio kraštinė) ilgį
             * ,jei kitų kraštinių ilgiai yra 10 ir 15. Rezultatą rašyti į  kintamąjį.
             * Suskaičiuoti užduotyse 1-3 gautų kintamųjų sumą ir vidurkį.
             * Įekraną išvesti rezultatą, kaip pateikta pavyzdyje.*/



            Console.WriteLine("Hello World!");

            Console.WriteLine("Žemės ploto skaičiavimas");
            double spindulys = 6371 ;

          double plotas =  4* Math.PI * (Math.Pow(spindulys, 2));
            Console.WriteLine( $"Žemės plotas yra: {plotas} " );

        }
    }
}
