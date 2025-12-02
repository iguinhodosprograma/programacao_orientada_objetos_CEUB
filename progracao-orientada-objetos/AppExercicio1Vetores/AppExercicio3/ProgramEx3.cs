double[] numeros = new double[5];
double soma=0, media;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Escreva o {i+1}º número");
    numeros[i] = Convert.ToDouble(Console.ReadLine());
    soma += numeros[i];
}
media = soma / (numeros.Length);
Console.WriteLine($"A media dos numeros foi {media}");