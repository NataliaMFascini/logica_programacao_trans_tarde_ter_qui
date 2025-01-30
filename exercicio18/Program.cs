/*
 * Desafio: Criar um programa que receba 6 nomes utilizando arrays
 * Ao final, o programa deve exibir todos os nomes digitados.
 */

string[] nomes = new string[6];

for (int i = 0; i < nomes.Length; i++)
{
    Console.Write($"Digite o {i + 1}º nome: ");
    nomes[i] = Console.ReadLine();
}

Console.Clear();

for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine($"O {i + 1}º nome na posição {i} é: {nomes[i]}");
}