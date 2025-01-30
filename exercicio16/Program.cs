//arrays.
//int num1 = 1;
//int num2 = 2;
//int num3 = 3;
//int num4 = 4;
//int num5 = 5;

//Console.WriteLine($"{num1} , {num2} , {num3} , {num4} , {num5}. Eca");

int[] num = { 1, 2, 3, 4, 5 };

//Console.WriteLine(num[0]);
//Console.WriteLine(num[1]);
//Console.WriteLine(num[2]);
//Console.WriteLine(num[3]);
//Console.WriteLine(num[4]);

for(int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"O valor que está na posição {i} é {num[i]}");
}
