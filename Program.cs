//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi
//potete usare per poter fare operazioni complesse nel vostro programma principale.
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il
//contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
//Potete prendere quella fatta in classe questa mattina.

//void ArrayToPrint(int[] array)
//{
//    Console.Write("[");

//    for (int i = 0; i < array.Length; i++)
//    {
//        if (i < array.Length - 1)
//        {
//            Console.Write($"{array[i]},");
//        }
//        else
//        {
//            Console.Write(array[i]);
//        }
//    }

//    Console.Write("];");
//}

/*------------------------------------------------------------------------------------------------------------------------------------------------*/

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

//int userNumber = Convert.ToInt32(Console.ReadLine());

//int squaredNumber = SquaredNumber(number);

//Console.WriteLine($"il quadrato di {number} è {squaredNumber}!");

//int SquaredNumber(int number)
//{
//    int squareResult = (int)Math.Pow(number, 2);

//    return squareResult;
//}

/*------------------------------------------------------------------------------------------------------------------------------------------------*/

//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca
//un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante
//restituire un nuovo array, e non modificare l’array come parametro della funzione!
//Vi ricordate perchè? Pensateci (vedi slide).

//int[] startArray = { 1, 4, 16, 7, 12, 100, 31, 3, 10, 24 };

//int[] newArray = ArrayToSquared(startArray);

//Console.Write("newArray: [");

//for (int i = 0; i < newArray.Length; i++)
//{
//    if (i < newArray.Length - 1)
//    {
//        Console.Write($"{newArray[i]},");
//    }
//    else
//    {
//        Console.Write(newArray[i]);
//    }
//}

//Console.Write("];");

//Console.WriteLine();

//Console.Write("startArray: [");

//for (int i = 0; i < startArray.Length; i++)
//{
//    if (i < startArray.Length - 1)
//    {
//        Console.Write($"{startArray[i]},");
//    }
//    else
//    {
//        Console.Write(startArray[i]);
//    }
//}

//Console.Write("];");

//int[] ArrayToSquared(int[] array)
//{
//    int[] squaredArray = new int[array.Length];

//    for (int i = 0; i < squaredArray.Length; i++)
//    {
//        squaredArray[i] = array[i];
//        squaredArray[i] = (int)Math.Pow(squaredArray[i], 2);
//    }

//    return squaredArray;
//}

/*------------------------------------------------------------------------------------------------------------------------------------------------*/

//int SommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

//int[] testArray = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

//int[] startArray = { 1, 23, 12, 54, 65, 44, 37, 75, 89, 11 };

//int arraySum = ArrayNumbersSum(startArray);

//Console.WriteLine($"la somma degli elementi dell'array è: {arraySum}");

//int ArrayNumbersSum(int[] array)
//{
//    int sum = 0;

//    for (int i = 0; i < array.Length; i++)
//    {
//        sum += array[i];
//    }

//    return sum;
//}

/*------------------------------------------------------------------------------------------------------------------------------------------------*/

//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri
//[2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video V
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al
//quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare
//nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9]) V
//Stampare la somma di tutti i numeri V
//Stampare la somma di tutti i numeri elevati al quadrati V

//int[] startArray = { 2, 6, 7, 5, 3, 9 };

//int squaredNumbersSum = ArrayNumbersSum(ArrayToSquared(startArray));

//Console.Write("startArray: [");

//for (int i = 0; i < startArray.Length; i++)
//{
//    if (i < startArray.Length - 1)
//    {
//        Console.Write($"{startArray[i]},");
//    }
//    else
//    {
//        Console.Write(startArray[i]);
//    }
//}

//Console.Write("];");

//Console.WriteLine();

//Console.WriteLine(squaredNumbersSum);

//int ArrayNumbersSum(int[] array)
//{
//    int sum = 0;

//    for (int i = 0; i < array.Length; i++)
//    {
//        sum += array[i];
//    }

//    return sum;
//}

//int[] ArrayToSquared(int[] array)
//{
//    int[] squaredArray = new int[array.Length];

//    for (int i = 0; i < squaredArray.Length; i++)
//    {
//        squaredArray[i] = array[i];
//        squaredArray[i] = (int)Math.Pow(squaredArray[i], 2);
//    }

//    return squaredArray;
//}

/*------------------------------------------------------------------------------------------------------------------------------------------------*/

//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche,
//ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
//ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
//A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire,
//e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente.

//Console.WriteLine("dimmi la lunghezza dell'array che desideri creare:");

//int userArrayLength = Convert.ToInt32(Console.ReadLine());

//int[] userArray = new int[userArrayLength];

//for (int i = 0; i < userArray.Length; i++)
//{
//    int userNumber = Convert.ToInt32(Console.ReadLine());
//    userArray[i] = userNumber;
//}

//ArrayToPrint(userArray);

/*------------------------------------------------------------------------------------------------------------------------------------------------*/

//Si chiede di implementare due funzioni che eseguano le corrsipettive funzioni matematiche:
//1 - Fattoriale di un numero

//Console.WriteLine("dimmi un numero e ti restituirò il suo fattoriale");

//int userNumber = Convert.ToInt32(Console.ReadLine());

//int userFactorialNumber = GetFactorialNumber(userNumber);

//Console.WriteLine($"il fattoriale di {userNumber} è: {userFactorialNumber}");

//int GetFactorialNumber(int number)
//{
//    int factorialNumber = number;
//    int factorialCounter = number - 1;

//    for (int i = 0; i < number - 1; i++)
//    {
//        factorialNumber *= factorialCounter;
//        factorialCounter--;
//    }

//    return factorialNumber;
//}

/*------------------------------------------------------------------------------------------------------------------------------------------------*/

//2 - La sequenza di fibonacci di un numero

//Console.WriteLine("scrivi un numero N e ti dirò il risultato corrispondente in posizione N nella Sequenza di Fibonacci");

//int userNumber = Convert.ToInt32(Console.ReadLine());

//int userFibonacciNumber = GetFibonacciSequenceNumber(userNumber);

//Console.WriteLine($"il numero presente nella Sequenza di Fibonacci in posizione {userNumber} è: {userFibonacciNumber}!");

//int GetFibonacciSequenceNumber(int number)
//{
//    int fibonacciDefault = 1;

//    int fibonacciNumber = 0;

//    int[] fibonacciArray = new int[number];

//    for (int i = 0; i < fibonacciArray.Length; i++)
//    {
//        if (i == 0 || i == 1)
//        {
//            fibonacciArray[i] = fibonacciDefault;
//        }
//        else
//        {
//            fibonacciNumber = fibonacciArray[i - 1] + fibonacciArray[i - 2];
//            fibonacciArray[i] = fibonacciNumber;
//        }
//    }

//    return fibonacciArray[fibonacciArray.Length - 1];
//}

/*------------------------------------------------------------------------------------------------------------------------------------------------*/

//chiedere all'utente una stringa, chiedere all'utente un chiave (numerica) che possa realizzare un CIFRATORE / DECIFRATORE del CIFRARIO DI CESARE:

Console.WriteLine("scrivi una frase");

string userString = Console.ReadLine().ToLower();

Console.WriteLine("inserisci una chiave numerica così che io possa codificare la frase da te digitata");

int userKey = Convert.ToInt32(Console.ReadLine());

Console.Write($"string after encoding: {GetEncodedString(userString, userKey)}");

string GetEncodedString(string stringToEncode, int key)
{
    char[] alphabeticalArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

    char[] specialCharsArray = { ' ', '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~' };

    char userChar = ' ';

    string encodedString = "";

    for (int i = 0; i < stringToEncode.Length; i++)
    {
        userChar = stringToEncode[i];

        int isLongerCounter = key;

        for (int j = 0; j < alphabeticalArray.Length; j++)
        {
            if (alphabeticalArray[j] == userChar && j + key < alphabeticalArray.Length - 1)
            {
                userChar = alphabeticalArray[j + key];
                break;
            }
            else if(alphabeticalArray[j] == userChar && j + key > alphabeticalArray.Length - 1)
            {
                isLongerCounter -= alphabeticalArray.Length - j;

                for (int k = 0; k < alphabeticalArray.Length;)
                {
                    if(isLongerCounter > alphabeticalArray.Length)
                    {
                        isLongerCounter -= alphabeticalArray.Length;
                        
                    }
                    else
                    {
                        k++;

                        if(k == isLongerCounter)
                        {
                            userChar = alphabeticalArray[k];
                        }
                    }
                }

                break;
            }
            else if(alphabeticalArray[j] != userChar && j == alphabeticalArray.Length - 1)
            {
                for (int y = 0; y < specialCharsArray.Length; y++)
                {
                    if (specialCharsArray[y] == userChar && y + key < specialCharsArray.Length - 1)
                    {
                        userChar = specialCharsArray[y + key];
                        break;
                    }
                    else if (specialCharsArray[y] == userChar && y + key > specialCharsArray.Length - 1)
                    {
                        isLongerCounter -= specialCharsArray.Length - y;

                        for (int k = 0; k < specialCharsArray.Length;)
                        {
                            if (isLongerCounter > specialCharsArray.Length)
                            {
                                isLongerCounter -= specialCharsArray.Length;
                            }
                            else
                            {
                                k++;

                                if (k == isLongerCounter)
                                {
                                    userChar = specialCharsArray[k];
                                }
                            }
                        }

                        break;
                    }
                    else if(specialCharsArray[y] != userChar && y == specialCharsArray.Length - 1)
                    {
                        userChar = 'x';
                        break;
                    }
                }
            }
        }

        encodedString += userChar;
    }

    return encodedString;
}