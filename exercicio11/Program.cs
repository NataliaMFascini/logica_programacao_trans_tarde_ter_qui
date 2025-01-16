//Crie um programa que gera uma tabuada de um numero escolhido por um usuario
//For

Console.WriteLine("Digite um número para ver a tabuada: ");
int numero = Convert.ToInt32(Console.ReadLine());

for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

