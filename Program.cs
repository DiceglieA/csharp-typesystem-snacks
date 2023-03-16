
//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
//snack6();
//snack7();
//snack8();
snack9();
//snack10();
//snack11();
//snack12();

// L’utente inserisce duenumeri in successione, Il software stampa il maggiore.
void snack1()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());

    int maxNum = num1 > num2 ? num1 : num2;

    if (num1 == num2)
    {
        Console.WriteLine("Equal Number");
    }
    else
    {
        Console.WriteLine(maxNum);
    }
}

//L’utente inserisce due parole in successione Il software stampa prima la parola più corta, poi la parola più lunga

void snack2()
{
    string str1 = Console.ReadLine() ?? "";
    string str2 = Console.ReadLine() ?? "";

    if (str1.Length > str2.Length)
    {
        Console.WriteLine(str2);
        Console.WriteLine(str1);            
    }
    else
    {
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}

//Il software deve chiedere per 10 volte all’utente di inserire un numero Il programma stampa la somma di tutti i numeri inseriti.

void snack3()
{
    var numbers = new int[10];
    int sum = 0;
    
    Console.WriteLine("Inserisci 10 numeri: ");
    
    for (var i = 0; i < 10; i++)
    {   
        numbers[i] = Convert.ToInt32(Console.ReadLine());
        sum += numbers[i];
    }

    //var sum = numbers.Sum(); metodo con funzione sum()

    Console.WriteLine($"la somma dei numeri è {sum}");
}

//Calcola la somma e la media dei numeri da 2 a 10

void snack4()
{
    int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];

    }
    int media = sum / numbers.Length;
    Console.WriteLine("La somma è " + sum);
    Console.WriteLine("La media è " + media);
}

//Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo

void snack5()
{
    Console.WriteLine("Inserisci un numero: ");

    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num % 2 == 0 ? num + " è un numero pari" : "è un numero dispari quindi ti do il successivo cioè " + (num + 1));
}

//In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunica gli se può partecipare o meno alla festa.

void snack6()
{
    string[] guests = { "Felice", "Francesco", "Andrea", "Alessandro", "Carlo", "Gabriele", "Dario" };
    Console.WriteLine("Benvenuto alla festa, come ti chiami? ");

    var name = Console.ReadLine();

    var text = (Array.IndexOf(guests, name) != -1 ? "Benvenuto, può entrare" : "Non posso farla entrare, non è in lista. Mi spiace");

    Console.WriteLine(text);

}

//Crea un array vuoto. Chiedi per 6 volte all'utente di inserire un numero, se è dispari inseriscilo nell'array

void snack7()
{
    int[] numbers = new int[6];
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine("Inserisci un numero");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("Il numero è pari");
        }
        else
        {
            numbers[i] = num;
        }
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.WriteLine(numbers[i]);
    }

    //verificare la stampa 0 su numero pari
}

//Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

void snack8()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += numbers[i];
        }
    }
    Console.WriteLine(sum);
}

//Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array,fino a quando la somma degli elementi è minore di 50.

void snack9()
{
    int[] numbers = new int[50];
    int sum = 0;
    int i = 0;
    while (sum < 50)
    {
        Console.WriteLine("Dammi un numero?");
        int num = Convert.ToInt32(Console.ReadLine());
        numbers[i] = num;
        sum += num;
        i += sum;
        Console.WriteLine(sum);
    }
}

//Fai inserire un numero,che chiameremo N,all’utente. Genera N array,ognuno formato da 10 numeri casuali tra 1 e 100.

void snack10()
{
    Console.WriteLine("Inserisci un numero: ");
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();

    for (int i = 0; i < N; i++)
    {
        var integers = new int[10];

        for (int j = 0; j < 10; j++)
        {
            integers[j] = random.Next(1, 100);
        }

        foreach (var num in integers)
        {
            //Console.WriteLine(num);
            Console.Write($"{num}; ");
        }

        Console.WriteLine();
    }
}

// Dare la possibilità di inserire due parole. Verificare tramite una funzione che le due parole abbiano la stessa lunghezza.Se hanno la stessa lunghezza,stamparle entrambe, altrimenti stampare la più lunga delle due.

void snack11()
{
    Console.WriteLine("Scrivi una parola:");
    string word1 = Console.ReadLine() ?? "";
    Console.WriteLine("scrivine un'altra:");
    string word2 = Console.ReadLine() ?? "";
    wordLenght(word1, word2);

    void wordLenght(string word1, string word2)
    {
        if (word1.Length == word2.Length)
        {
            Console.WriteLine(word1 + word2);
        }
        else if (word1.Length > word2.Length)
        {
            Console.WriteLine(word1);
        }
        else
        {
            Console.WriteLine(word2);
        }
    }
}

    //Scrivere una funzione per verificare se un numero è pari o dispari. Quindi chiedere un numero all'utente e comunicargli se è pari o dispari.

    void snack12()
{
    Console.WriteLine("Inserisci un numero");
    int num = Convert.ToInt32(Console.ReadLine());
    checkNum(num);
    void checkNum(int num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine("Il numero è pari");
        }
        else
        {
            Console.WriteLine("Il numero è dispari");
        }
    }
}