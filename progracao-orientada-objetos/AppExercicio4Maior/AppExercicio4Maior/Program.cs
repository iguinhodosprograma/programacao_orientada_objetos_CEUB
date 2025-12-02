Int32 numero1, numero2;
string resultado;

Console.WriteLine("Digite o primeiro numero para saber qual é maior: ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero para saber qual é maior: ");
numero2 = Convert.ToInt32(Console.ReadLine());

resultado = (numero1 > numero2) ? $"O numero {numero1} é o maior numero" : $"O numero {numero2} é o maior numero";
Console.WriteLine(resultado);

