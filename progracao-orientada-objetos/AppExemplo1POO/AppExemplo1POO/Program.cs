using AppExemplo1POO.Model;

//Criando vários objetos pessoa1
Pessoa pessoa1 = new Pessoa();
pessoa1.nome = "JOSÉ DAS COUVES";
pessoa1.dataNascimento = Convert.ToDateTime("22/4/1975");
pessoa1.cpf = "555.555.555-91";
pessoa1.nomeMae = "MARIA JOSÉ";
pessoa1.nomePai = "JOÃO DAS COUVES";
pessoa1.sexo = "Masculino";

Console.WriteLine(pessoa1.ImprimirPessoa());

//Criando vários objetos pessoa2
Pessoa pessoa2 = new Pessoa();
pessoa2.nome = "LARA DAS COUVES";
pessoa2.dataNascimento = Convert.ToDateTime("22/4/1975");
pessoa2.cpf = "555.555.555-91";
pessoa2.nomeMae = "LIRIS JOSÉ";
pessoa2.nomePai = "MURILO DAS COUVES";
pessoa2.sexo = "Feminino";

Console.WriteLine(pessoa2.ImprimirPessoa());