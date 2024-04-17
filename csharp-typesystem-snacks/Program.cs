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
        }
    }
}
