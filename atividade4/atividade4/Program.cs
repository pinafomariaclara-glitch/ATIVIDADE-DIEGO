
Console.Write("Digite sua idade em anos: ");
int anos = int.Parse(Console.ReadLine());

Console.Write(anos"Digite meses: ");
int meses = int.Parse(Console.ReadLine());

Console.Write(meses"Digite dias: ");
int dias = int.Parse(Console.ReadLine());

int totalDias + anos *365 + meses * 30 + dias;

Console.WriteLine($"A idade em dias é´: {totalDias}");


