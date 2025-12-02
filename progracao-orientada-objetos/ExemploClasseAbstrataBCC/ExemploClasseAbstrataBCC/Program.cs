using ExemploClasseAbstrataBCC.Model;

//Personagem personagem = new Personagem();
Mago mago = new Mago();
Guerreiro guerreiro = new Guerreiro();

Console.WriteLine("Informe o nome do mago: ");
mago.Nome = Console.ReadLine();
mago.Nivel = 10;
mago.Vida = 5;

Console.WriteLine($"O mago {mago.Nome} que possui {mago.Vida} vidas e esta no nível {mago.Nivel}");
mago.UsarHabilidade();

Console.WriteLine("Informe o nome do guerreiro: ");
guerreiro.Nome = Console.ReadLine();
guerreiro.Nivel = 10;
guerreiro.Vida = 5;

Console.WriteLine($"O guerreiro {guerreiro.Nome} que possui {guerreiro.Vida} vidas e esta no nível {guerreiro.Nivel}");
guerreiro.UsarHabilidade();