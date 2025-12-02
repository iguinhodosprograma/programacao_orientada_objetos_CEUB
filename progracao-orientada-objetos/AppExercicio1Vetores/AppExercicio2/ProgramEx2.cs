double[] salarios = new double[5];

for (int i = 0; i < salarios.Length; i++)
{
    Console.WriteLine($"Escreva o {i + 1}º salário: ");
    salarios[i] = Convert.ToDouble(Console.ReadLine());
    if (salarios[i] < 1000)
    {
        salarios[i] = salarios[i] * 1.1;
    }
}
Console.WriteLine("Os novos salários são: ");
for (int i = 0;i < salarios.Length; i++)
{
    Console.WriteLine($"{Math.Round(salarios[i], 2)}");
}
