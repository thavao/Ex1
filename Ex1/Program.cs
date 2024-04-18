//1 - faça um algoritmo que leia um numero e informe se é par ou ímpar

int numero;

Console.Write("Por favor, digite um numero inteiro: ");

numero = int.Parse(Console.ReadLine());

Console.Write("O número digitado é ");

if (numero % 2 == 0)
    Console.WriteLine("par!");
else
    Console.WriteLine("ímpar!");

Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();