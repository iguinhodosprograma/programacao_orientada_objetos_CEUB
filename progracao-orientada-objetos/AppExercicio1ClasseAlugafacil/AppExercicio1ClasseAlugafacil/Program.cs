using AppExercicio1ClasseAlugafacil.Model;

//Criando o objeto cliente
Cliente cliente = new Cliente();

Console.WriteLine("Informe o nome do cliente: ");
cliente.nome = Console.ReadLine();

Console.WriteLine("Informe o cpf do cliente: ");
cliente.cpf = Console.ReadLine();

Console.WriteLine("Informe o numero da cnh do cliente: ");
cliente.cnh = Console.ReadLine();

Cliente cliente2 = new Cliente();

Console.WriteLine("Informe o nome do cliente: ");
cliente2.nome = Console.ReadLine();

Console.WriteLine("Informe o cpf do cliente: ");
cliente2.cpf = Console.ReadLine();

Console.WriteLine("Informe o numero da cnh do cliente: ");
cliente2.cnh = Console.ReadLine();



//Criando o objeto carro
Carro carro = new Carro();

Console.WriteLine("Informe a placa do veículo: ");
carro.placa = Console.ReadLine();

Console.WriteLine("Informe o fabricante do veículo: ");
carro.fabricante = Console.ReadLine();

Console.WriteLine("Informe o modelo do veículo: ");
carro.modelo = Console.ReadLine();

Console.WriteLine("Informe o ano do veículo: ");
carro.ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a cor do veículo: ");
carro.cor = Console.ReadLine();

Console.WriteLine("Informe o valor da diária do veículo: ");
carro.valorDiaria = Convert.ToDouble(Console.ReadLine());
