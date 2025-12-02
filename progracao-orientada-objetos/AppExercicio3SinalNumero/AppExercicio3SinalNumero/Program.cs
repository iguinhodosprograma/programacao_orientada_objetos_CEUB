Int32 numero;
string resultado;

Console.WriteLine("Escreva um número para saber seu sinal: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    resultado = $"O numero {numero} é positivo";
}
else if (numero == 0)
{
    resultado = $"O numero {numero} é igual a zero";
}
else
{
    resultado = $"O numero {numero} é negativo";
}

Console.WriteLine(resultado);