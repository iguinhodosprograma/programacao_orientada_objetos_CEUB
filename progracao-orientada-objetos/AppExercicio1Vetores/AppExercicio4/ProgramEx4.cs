Int32[] numerosPares = new Int32[10];
Int32[] numerosImpares = new Int32[10];
Int32 numero;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i+1}º número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero%2 == 0)
    {
        numerosPares[i] = numero;
    }
    else
    {
        numerosImpares[i] = numero;
    }
}
Console.WriteLine("Números pares:");
for (int i = 0;i < 10; i++)
{
    if (numerosPares[i] != 0)
    {
        Console.WriteLine(numerosPares[i]);
    }
}

Console.WriteLine("Números impares:");
for (int i = 0; i < 10; i++)
{
    if (numerosImpares[i] != 0)
    {
        Console.WriteLine(numerosImpares[i]);
    }
}