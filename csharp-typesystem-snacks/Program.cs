using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
            Snack 1
            L’utente inserisce due numeri in successione.
            Il software stampa il maggiore.
            */
            /*
            Console.WriteLine($"inserisci due numeri");

            int primoNumero = Convert.ToInt32(Console.ReadLine());
            int secondoNumero = Convert.ToInt32(Console.ReadLine());
            if (primoNumero == secondoNumero)
            {
                Console.WriteLine($"i numeri sono uguali, inserisci due numeri diversi");

                primoNumero = Convert.ToInt32(Console.ReadLine());
                secondoNumero = Convert.ToInt32(Console.ReadLine());
            }
            else if (primoNumero > secondoNumero)
            {
                Console.WriteLine($"il numero maggiore è {primoNumero}");
            }
            else
            {
                Console.WriteLine($"il numero maggiore è {secondoNumero}");

            }
            Console.WriteLine($"I numeri sono {primoNumero}-{secondoNumero}");
            */



            /*
            Snack 2
            L’utente inserisce due parole in successione.
            Il software stampa prima la parola più corta, poi la parola più lunga.
            */

            /*
             Console.WriteLine($"inserisci due parole");

             string primaParola = Console.ReadLine();
             string secondaParola = Console.ReadLine();
             if (primaParola.Length == secondaParola.Length)
             {
                 Console.WriteLine($"Le parole hanno la stessa lunghezza {primaParola} - {secondaParola}");
             }
             else if (primaParola.Length > secondaParola.Length)
             {
                 Console.WriteLine($"La parola più corta è {secondaParola}, la parola più lunga è {primaParola}");
             }
             else
             {
                 Console.WriteLine($"La parola più corta è {primaParola} , la parola più lunga è {secondaParola}");
             }
             */


            /* 
            Snack 3
            Il software deve chiedere per 10 volte all’utente di inserire un numero.
            Il programma stampa la somma di tutti i numeri inseriti.
            */
            /*
           { int richiesta = 10;
            int somma = 0;

            Console.WriteLine($"inserisci {richiesta} numeri");
            for (int i = 0; i < richiesta; i++)
            {
                int output = Convert.ToInt32(Console.ReadLine());
                somma += output;

            }
                Console.WriteLine($"La somma dei numeri è {somma}");
            }
            /*


            /* 
            Snack 4
            Calcola la somma e la media dei numeri da 2 a 10.
            */
            {
                int somma = 0;

                int primoNumero = 2;
                int ultimoNumero = 10;

                int numeriTotali = ultimoNumero - primoNumero + 1;
                for(int i = primoNumero;  i <= ultimoNumero; i++)
                {
                    somma += i;
                }
                double media =Convert.ToDouble( somma) / numeriTotali;
                Console.WriteLine($"La somma è: {somma}");
                Console.WriteLine($"La media è: {media}");
            }

        }
    }
}
