using System;

namespace UnicamFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabile per immagazzinare la risposta dell'utente (proseguire o no alla fine del calcolo)
            String risposta = "s";
            //Ciclo il programma finchè la risposta non sarà diversa da s
            while (risposta.Equals("s"))
            {
                //Creo la variabile intera numero e la inizializzo a -1
                int numero = -1;
                //Finchè l'utente non inserisce un numero accettabile chiedo di inserire un numero
                while (numero < 0 || numero > 10)
                {
                    //Stampo dei messaggi di cortesia per l'utente, così lo guido all'utilizzo del programma
                    Console.WriteLine("Questo programma calcola il fattoriale di un numero");
                    Console.Write("Digita un numero intero e premi invio: ");

                    //Console.ReadLine si mette in attesa che l'utente digiti qualcosa e prema invio.
                    //Quando ha premuto invio, il testo che ha digitato lo assegno ad una variabile di tipo string.
                    string testoDigitatoDallUtente = Console.ReadLine();

                    //Interpreto il testo come un numero intero
                    //Se l'utente non inserisce un intero, ma una stringa catturo l'eccezione
                    try
                    {
                        numero = int.Parse(testoDigitatoDallUtente);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Spiacente, non posso calcolare il fattoriale per questo valore");
                        Console.ReadLine();
                    }
                }

                //Creo una variabile per lasciare invariato il numero originale
                int numeroCopia = numero;

                //Calcolo il fattoriale
                int risultato = 1;
                while (numeroCopia > 0)
                {
                    risultato *= numeroCopia;
                    numeroCopia--;
                }

                //Stampo il risultato
                Console.WriteLine("Il fattoriale di " + numero + " e' " + risultato);
                //Chiedo all'utente se vuole inserire un nuovo numero o fermarsi e chiudere il programma
                Console.WriteLine("Inserire un nuovo numero? (Scrivi s per confermare, oppure un tasto qualsiasi per uscire)");
                risposta = Console.ReadLine();
                //Se l'utente decide di uscire lo saluto
                if (risposta!="s")
                {
                    Console.WriteLine("Arrivederci");
                    Console.ReadLine();
                }
            }
        }
    }
}
