namespace Aula02;

public class Program()
{
    public static void Main()
    {
        ExecutaLista();

    }

    public static void ExecutaArrays()
    {
        string separator = "-------------------------";

        // Declaração do array incicializado com valores
        String[] fruits = { "banana", "maça" };

        // Declaração do array vazio
        int[] numbers = new int[2];

        // Acessando o primeiro elemento do array
        Console.WriteLine(fruits[0]);
        Console.WriteLine(separator);

        //Percorrer um array
        foreach (String fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine(separator);

        //Quantidde de indice
        Console.WriteLine($"Quantidades de índices {fruits.Length}");
        Console.WriteLine(separator);

        //Adicionando elementos no array
        numbers[0] = 10;
        Console.WriteLine(numbers[0]);

    }

    public static void ExecutaLista()
    {
        string separator = "-------------------------";

        // Declaração da lista com inicialização
        List<string> fruits = new List<string>();

        fruits.Add("Laranaja");
        fruits.Add("Limão");

        Console.WriteLine("Lista de frutas");
        foreach ( string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine(separator);




    }
}