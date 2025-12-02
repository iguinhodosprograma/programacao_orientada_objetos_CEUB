Int32 numero, sucessor, antecessor;

Console.WriteLine("Digite um número para saber seu sucessor e seu antecessor: ");
numero = Convert.ToInt32(Console.ReadLine());

sucessor = numero + 1;
antecessor = numero - 1;

Console.WriteLine ($"O número {numero} tem como seu antecessor: {antecessor}, e como seu sucessor: {sucessor}");
Console.ReadKey();