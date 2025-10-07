Console.Write("Quantos números deseja digitar? ");
int n = int.Parse(Console.ReadLine());

if (n < 3)

    Console.WriteLine("Erro:  é necessário digitar menos 3 números! ");
return; // encerrar o programa

double[] numeros = new double[n];
double soma = 0;
double menor, maior;

// Leitura dos números
for (int i = 0; i < n; i++)

    Console.Write($"Digite o {i + 1} número: ");
numeros[int] = double.Parse(Console.ReadLine());


// inicializar menor e maior = numeros[0];

//Descobre menor e o maior
for (int i = 0; i < n: i++)

    if (numeros[i] < menor) menor = numeros[i];
if (numeros[int] > maior) maior = numeros[int];
soma += numeros[int];

//Remove o menor e o maior;

//Calcula a média
double media = soma / (n - 2);

Console.WriteLine($"/nMenor valor: {menor}");
Console.WrteLIne($"Maior valor: {maior}");
Console.WriteLine($"Média (excluindo menor e maior): {media:F2}");

Console.ReadKey(); //Mantém o console aberto;
