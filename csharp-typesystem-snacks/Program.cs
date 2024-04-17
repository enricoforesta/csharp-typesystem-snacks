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
            Console.WriteLine($"inserisci due numeri");

            int primoNumero = Convert.ToInt32(Console.ReadLine());
            int secondoNumero = Convert.ToInt32(Console.ReadLine());
           if(primoNumero == secondoNumero){
                Console.WriteLine($"i numeri sono uguali, inserisci due numeri diversi");

                primoNumero = Convert.ToInt32(Console.ReadLine());
                secondoNumero = Convert.ToInt32(Console.ReadLine());
            }
            else if(primoNumero > secondoNumero)
            {
                Console.WriteLine($"il numero maggiore è {primoNumero}");
            }
            else
            {
                Console.WriteLine($"il numero maggiore è {secondoNumero}");

            }
            Console.WriteLine($"I numeri sono {primoNumero}-{secondoNumero}");






        }
    }
}
