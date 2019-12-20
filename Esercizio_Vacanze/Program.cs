using System;

namespace Esercizio_Vacanze
{
    class Program
    {
        static void Main(string[] args)
        {
            //la variabile può contenere valori compresi fra -2147483648(2^32-1) e 2147483647(2^32): si tratta esattamente di 2^32 = 4294967296 valori suddivisi fra negativi e positivi. quindi l'output alla riga 10 è il valore massimo ottenibile, mentre quello alla riga 11 è il valore minimo, cioè  2^31, quindi l'ultimo bit è occupato dal segno meno.
            int a = int.MaxValue;
            Console.WriteLine(a);
            if (a == 2147483647)
            {
                Console.WriteLine(a + 1);//l'output per essere giusto deve essere uguale a 2147483647, quindi in tutti i casi in cui il risultato è diverso da 2147483647, l'istruzione della riga 14 non viene effettuata
            }
            Console.WriteLine("inserisci un numero");
            int b = int.Parse(Console.ReadLine());
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2));
            Console.WriteLine(" nelle 2 righe sopra viene prima visulizzato il numero scelto da te in base binaria, mentre nella riga sotto viene visualizzato l'opposto del numero citato prima");
            int value = 31;
            int somma = value;
            value = ~value + 1;//NOT
                               //value=value+1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);
            
        }
    }
}
