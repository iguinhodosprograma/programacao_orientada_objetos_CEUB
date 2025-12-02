double nota;
string resultado;

Console.WriteLine("Insira sua nota:");
nota = Convert.ToDouble(Console.ReadLine());

//if (nota >= 7)
//{
//    resultado = "Aprovado";
//}
//else if ((nota >= 5) && (nota < 7))
//{
//    resultado = "Recuperacão";
//}
//else
//{
//    resultado = "Reprovado";
//}

resultado = (nota >= 7) ? "Aprovado" : (nota >= 5) && (nota < 7)? "Recuperacão" : "Reprovado";

Console.WriteLine(resultado);