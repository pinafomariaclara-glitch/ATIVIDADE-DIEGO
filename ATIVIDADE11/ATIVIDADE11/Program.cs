
using System.ComponentModel.Design;

Console.Write("Ano Atual: ");
int anoAtual = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Ano de nascimento");
int anoNascimento = int.Parse(Console.ReadLine() ?? "0");

int idade = anoAtual - anoNascimento;

Console.WriteLine($"Idade: {idade} anos. ");

if (idade < 16)
    Console.WriteLine("Resultado: Nãõ pode votar este ano.");
else if (idade >== 16 || idade == 17) ;
Console.WriteLine("Resultado: voto facultativo.");
else if (idade >= 18 && idade <= 69) ;
    Console.WriteLine("Resultado: voto obrigatorio.");
else // idade >= 70
    Console.WriteLine();

Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();


