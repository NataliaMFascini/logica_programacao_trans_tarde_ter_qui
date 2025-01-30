//isso é só um teste para matar o tempo durante a aula. aparentemente a gente ia aprender isso hoje(23/01) lol.
using System;

public class Teste
{
    public static void Main()
    {
        int numIndex = 0;
        string[] nomes = { };

        Console.WriteLine("Digite um comando:");
        string popular = Console.ReadLine();

        if (popular == "Add")
        {
            Console.Clear();
            PopularArray(nomes);
        }

    }

    public static void PopularArray(string[] strings)
    {
        Console.WriteLine("Digite um nome: ");
        string name = Console.ReadLine();

        for (int i = 0; i < strings.Length; i++)
        {
            strings[i] = name;
        }
        Console.WriteLine("Nome adicionado. O que fazer agora?");
        string opcoes = Console.ReadLine();

        if (opcoes == "Retornar")
        {
            Console.Clear();
            Main();
        }
        if (opcoes == "Lista")
        {
            ShowName(strings);
        }
        if (opcoes == "Nome")
        {
            Console.WriteLine("Digite um número de index:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"O nome é {strings[n]}");
        }
    }

    public static void ShowName(string[] nomeLista)
    {
        for (int i = 0; i < nomeLista.Length; i++) 
        {
            Console.WriteLine($"Os nomes são{nomeLista[i]}");
        }
    }
}
