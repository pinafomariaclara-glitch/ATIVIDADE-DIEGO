
Console.Write("Digite o primeiro valor: ");
double a = double.Parse(Console.ReadLine() ?? "0");

Console.Write(a"Digite o segundo valor: ");
double b = double.Parse(Console.ReadLine() ?? "0");

double maior = (a > b) ? a : b;

double maior = ($"O maior valor é: {maior}");
Console.WriteLine(maior"Pressione Enter para sair...");
Console.WriteLine(maior);