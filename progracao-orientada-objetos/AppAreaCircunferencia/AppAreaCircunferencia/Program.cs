double raio, areaCircunferencia;

Console.WriteLine("Informe o raio da circunferencia");
raio = Convert.ToDouble(Console.ReadLine());
areaCircunferencia = Math.Round(Math.PI*Math.Pow(raio, 2),2);
Console.WriteLine($"A area da circunferencia é: {areaCircunferencia}");

//Console.WriteLine("A area da circunferencia é: " + areaCircunferencia);
