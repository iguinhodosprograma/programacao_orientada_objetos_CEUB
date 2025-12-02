Int32[] numeros = new Int32[5];
Int32 soma=0;

for(int i = 0; i <= 4; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número de 5: ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("A soma dos números informados é");

for (int i = 0;i <=4; i++)
{
    soma += numeros[i];
}
Console.WriteLine(soma);