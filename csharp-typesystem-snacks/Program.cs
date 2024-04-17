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
            */
            /* 
            Snack 4
            Calcola la somma e la media dei numeri da 2 a 10.
            */
            /*
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
            */
            /*
             Snack 5
             Il software chiede all’utente di inserire un numero.
             Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.
            */
            /*
            Console.WriteLine("Inserisci un numero");
            int output = Convert.ToInt32(Console.ReadLine());
            if(output % 2 == 0) 
            {
                Console.WriteLine($"{output}");
            }
            else
            {
                Console.WriteLine($"{output + 1}");
            } 
            */
            /*
             Snack 6
             In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. 
             Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
            */
            /*
            string[] friends =
            {
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Emma",
                "Frank",
                "Gina"
            };
            Console.WriteLine("Inserisci il tuo nome");
            string output = Console.ReadLine();
            bool check = false;
            foreach (string friend in friends)
            {
                if(friend == output)
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine($"Benvenuto {output}, Divertiti");
            }
            else
            {
                Console.WriteLine("Non sei invitato, addio!");
            }
            */
            /*
            Snack 7
            Crea un array vuoto.
            Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
            */
            /*
            int[] arrayDispari = new int[6];
            Console.WriteLine("inserisci un numero");
            for (int i = 0; i < arrayDispari.Length; i++)
            {
                int output = Convert.ToInt32(Console.ReadLine());
                if(output % 2  != 0) arrayDispari[i] = output;
            }
            Console.WriteLine("Array");
            foreach(int i in arrayDispari) 
            { 
                if(i != 0) Console.WriteLine(i); 
            }
            */
            /*
             Snack 8
            Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
            */
            /*
            int[] numeriArray = { 10, 25, 6, 42, 3, 18, 33, 7, 48, 14, 30, 20, 9, 45, 2, 38, 17, 11, 49, 5 };
            int somma = 0;
            for (int i = 0; i < numeriArray.Length; i++)
            {
                if (i % 2 != 0)
                {
                    somma += numeriArray[i];
                }
            }
            Console.WriteLine($"la somma è {somma}");
            */
            /*
            Snack 9
            Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
            Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
            */
            /*
            int[] arrayDispari = new int[50];
            int somma = 0;
            int target = 50;
            int indice = 0; // Usato per tener traccia dell'indice corrente dell'array

            Console.WriteLine($"Inserisci numeri, diverso da 0, finché la somma non è maggiore di {target}:");
            while (somma < target)
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero != 0) 
                { 
                    arrayDispari[indice] = numero; 
                    somma += numero; 
                    indice++;
                }
                else
                {
                    Console.WriteLine("Numero non valido");
                }
            }

            Console.WriteLine($"La somma è: {somma}");
            */
            /*
            Snack 10
            Fai inserire un numero, che chiameremo N, all’utente.
            Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
            Ogni volta che ne crei uno, stampalo a schermo.
            */

            Console.WriteLine("Inserisci quanti array vuoi creare");
            Random random = new Random();
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int[] arrayNumber = new int[10];

                for (int x = 0; x < 10; x++)
                {
                    arrayNumber[x] = random.Next(1, 101); 
                }
                Console.WriteLine($"array {i+1}");
                foreach (int number in arrayNumber)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
