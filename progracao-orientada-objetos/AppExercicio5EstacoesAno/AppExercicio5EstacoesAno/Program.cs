using System.Diagnostics;

Int32 numeroestacao;

Console.WriteLine("Informe um número de 1 a 4 para saber a estação correspondente: ");
numeroestacao = Convert.ToInt32(Console.ReadLine());

switch (numeroestacao)
{
    case 1:
        Console.WriteLine("Primavera");
        break;

    case 2:
        Console.WriteLine("Verão");
        break;

    case 3:
        Console.WriteLine("Outono");
        break;

    case 4:
        Console.WriteLine("Inverno");
        break;

    default:
        Console.WriteLine("Informe somente números entre 1 e 4 para saber as estações do ano");
        break;
}