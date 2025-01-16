// - Crie um programa que peça ao usuario para inserir um numero inteiro positivo e então conte de 1 até esse numero, exibindo cada numero. O programa deve implementar essa contagem usando while, do while, e for.

int limite = 1;

Console.WriteLine("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

while (limite <= numero)
{
    Console.WriteLine(limite);
    limite ++;
}

