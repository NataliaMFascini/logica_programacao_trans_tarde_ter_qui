//Escreva um programa que pergunte o nome do usuario e apresente o nome + boas vindas

Console.WriteLine("Diga seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Diga seu sobrenome: ");
string sobrenome = Console.ReadLine();

Console.WriteLine("Diga seu ultimo nome: ");
string ultimonome = Console.ReadLine();

//Console.WriteLine("Olá " + nome + " " + sobrenome + " " + ultimonome + "! Seja bem-vindo(a)!");
Console.WriteLine($"Olá {nome} {sobrenome} {ultimonome}! Seja bem-vindo(a)!");