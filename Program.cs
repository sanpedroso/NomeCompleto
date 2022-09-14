string nome, sobrenome;
Console.Write("digite seu nome");
nome = Console.ReadLine()!;

Console.WriteLine("digite seu nome");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");
