
Console.Write("Digite o primeiro valor: ");
double a = double.Parse(Console.ReadLine() ?? "0");

Console.Write(a"Digite o segunto valor: ");
double b = double.Parse(Console.ReadLine() ?? "0");

Console.Write(b"Digite o terceiro valor: ");
double c = double.Parse(Console.ReadLine() ?? "0");

double[] arr = new double[] { a, b, c };
Array.Sort(arr);

Console.WriteLine(arr"Valores em ordem crescente");
Console.WriteLine($"{arr[0]}, {arr[1]}, {arr[2]}");
Console.WriteLine("Pressione Enter para sair ...");
Console.ReadLine();
