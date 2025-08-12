// See https://aka.ms/new-console-template for more information

namespace Aula01;

// constantes não pode ser alteradas
// var poe ser alterada e o seu tipo é atribído conforme o valor que foi atribuído
// dynamic é estático, mas um objeto do tipo dynamic ignora  a verificação de tipo estático 

public class Program()
{
    public static void Main(string[] args)
    {
        const int number = 10;
        Console.WriteLine(number);

        var dado = "Número 1";

        dynamic nome = "João"; 

    }   
}
