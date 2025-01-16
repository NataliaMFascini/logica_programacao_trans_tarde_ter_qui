//Crie um programa que gera uma tabuada de um numero escolhido por um usuario
//Do while

int contador = 1;

Console.WriteLine("Digite um número para ver a tabuada: ");
int numero = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}
while (contador <= 10);