//Crie um programa que gera uma tabuada de um numero escolhido por um usuario

int contador = 1;

Console.WriteLine("Digite um número para ver a tabuada: ");
int numero = Convert.ToInt32(Console.ReadLine());

while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}