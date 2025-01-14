//Calcular as 4 operações

Console.WriteLine("Digite o primeiro numero: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
int n2 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("Soma: " + (n1 + n2));
Console.WriteLine("Subtração: " + (n1 - n2));
Console.WriteLine("Multiplicação: " + (n1 * n2));
if(n2 != 0) 
{
    Console.WriteLine("Divisão: " + (n1 / n2)); 
}
else
{
    Console.WriteLine("NÃO É PERMITIDA A DIVISÃO POR 0!");
}

Console.WriteLine("===============");
Console.WriteLine("Os números são iguais? " + (n1 == n2));
Console.WriteLine("Número 1 é maior Número 2? " + (n1 > n2));
Console.WriteLine("Número 1 é menor Número 2? " + (n1< n2));
Console.WriteLine("Número 1 é maior igual Número 2? " + (n1 >= n2));
Console.WriteLine("Número 1 é menor igual Número 2? " + (n1 <= n2));