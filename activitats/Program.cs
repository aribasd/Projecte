using System.Runtime.ConstrainedExecution;

static int NewMethod(int numero, int numfinal, int countmultiples)
{
    for (int i = 0; numero * i < numfinal; i++)
    {
        countmultiples++;
    }

    return countmultiples;
}

/*MISSATGE PER FER UN CANVI DEL NOSTRE PROJECTE*/

/*Comentari Github*/

/*ULTIM EXERCICI!*/ 


/*d*/





/*Activitat 1*/

static void Main(string[] args)
{
    int numero = 7;
    int numfinal = 200;
    int countmultiples = 0;

    countmultiples = NewMethod(numero, numfinal, countmultiples);

    Console.WriteLine("Multiples de 7 fins el 200" + countmultiples);
}



/*IA */

using System;

class Metodes
{
    public static int ComptadorMultiples(int numero, int numfinal)
    {
        int countmultiples = 0;
        for (int i = numero; i <= numfinal; i++)
        {
            if (i % numero == 0)
            {
                countmultiples++;
            }
        }
        return countmultiples;
    }
}

class Program
{
  static void Main(string[] args) => MostrarMultiples();

static void MostrarMultiples()
{
    int numero = 7;
    int numfinal = 200;
    int countmultiples = Metodes.ComptadorMultiples(numero, numfinal);
    Console.WriteLine($"Múltiples de {numero} fins al {numfinal}: {countmultiples}");
}
}



using System;

class Metodes
{
    public static int ComptadorMultiples(int limit)
    {
        int numero = 7;
        int countmultiples = 0;
        for (int i = numero; i < limit; i++)
        {
            if (i % numero == 0)
            {
                countmultiples++;
            }
        }
        return countmultiples;
    }
}

class Program
{
    static void Main(string[] args) => MostrarMultiples();

    static void MostrarMultiples()
    {
        int limit = 200;
        int countmultiples = Metodes.ComptadorMultiples(limit);
        Console.WriteLine($"Múltiples de 7 fins al {limit}: {countmultiples}");
    }
}


using System;

class Metodes
{
    public static int ComptadorMultiples(int limit)
    {
        int numero = 7;
        int countmultiples = 0;
        for (int i = numero; i < limit; i++)
        {
            if (i % numero == 0)
            {
                countmultiples++;
            }
        }
        return countmultiples;
    }
}

class Program
{
    static void Main(string[] args) => MostrarMultiples();

    static void MostrarMultiples()
    {
        Console.Write("Introdueix un valor límit: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int limit))
        {
            int countmultiples = Metodes.ComptadorMultiples(limit);
            Console.WriteLine($"Múltiples de 7 fins al {limit}: {countmultiples}");
        }
        else
        {
            Console.WriteLine("El valor introduït no és un número vàlid.");
        }
    }
}



using System;
using System.Collections.Generic;

class Metodes
{
    public static List<int> ComptadorMultiples(int limit)
    {
        int numero = 7;
        List<int> multiples = new List<int>();

        for (int i = numero; i < limit; i++)
        {
            if (i % numero == 0)
            {
                multiples.Add(i);
            }
        }

        return multiples;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix un valor límit: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int limit))
        {
            List<int> multiples = Metodes.ComptadorMultiples(limit);
            Console.WriteLine($"Múltiples de 7 més petits que {limit}:");

            foreach (int m in multiples)
            {
                Console.WriteLine(m);
            }
        }
        else
        {
            Console.WriteLine("El valor introduït no és un número vàlid.");
        }
    }
}


/* Activitat 2 */


