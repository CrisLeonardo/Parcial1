

{
    Console.WriteLine("Ingresa un numero entero positivo que sea mayor que 0 porfavor\n");
    int n = int.Parse(Console.ReadLine());




    



    //Numeros Primos
    Console.WriteLine("\n\nNumeros primos del 1 al " + n + ":\n");

    for (int p = 2; p <= n; p++)
    {
        bool esPrimo = true;

        for (int j = 2; j <= Math.Sqrt(p); j++)
        {
            if (p % j == 0)
            {
                esPrimo = false;
                
            }
        }

        if (esPrimo)
        {
            Console.Write("{0} ", p);
        }
    }

    //Multiplos de 4
    Console.WriteLine("\n\nNumeros que son multiplos de 4 del 1 al " + n+"\n");

    for (int i = 1; i <= n; i++)
    {
        if (i % 4 == 0)
        {
            Console.WriteLine(i);
        }
    }

    Console.WriteLine("\n\nIncremento de 3 hasta llegar a " + n+"\n");
    
    int E = 1;
    while (E <= n)
    {
        E += 3;
        Console.WriteLine(E);
    }


    int a = 0;

    Console.WriteLine("Su Numero es: " + n + "\n\nResultado: \n");

    for (int i = 1; i <= n; i++)
    {

        a++;
        int C = i * i;
        Console.WriteLine(a + "*" + a + " = " + C);


    }

}









