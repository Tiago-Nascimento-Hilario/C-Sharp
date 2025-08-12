namespace Aula03;
using System.IO;
public class program()
{
    public static void Main() 
    {
        //CriarArquivo();
        //EditarArquivo();
        //LerArquivo();
        //ExcluirArquivo();

    }


    public static void CriarArquivo()
    {

        //Caminho onde o arquivo será criado
        string path = @"C:\Users\Tiago\dev\Fundamentos\Aula03\file.txt";

        //Conteúdo do arquivo criado
        File.WriteAllText(path, "Tiago Nascimento Hilario");

        Console.WriteLine("Arquivo criado e adicionado informação com sucesso");
    }

    public static void EditarArquivo() 
    {

        //Caminho onde o arquivo será criado
        string path = @"C:\Users\Tiago\dev\Fundamentos\Aula03\file.txt";

        File.AppendAllText(path, "\nCurso de C#");

        Console.WriteLine("Arquivo editado com sucesso");

    }


    public static void LerArquivo()
    {
        //Caminho onde o arquivo será criado
        string path = @"C:\Users\Tiago\dev\Fundamentos\Aula03\file.txt";
        
        //Lendo o conteúdo do arquivo
        string content = File.ReadAllText(path);
        Console.WriteLine("Conteúdo do arquivo:");
        Console.WriteLine(content);
    }
    public static void ExcluirArquivo()
    {
        string path = @"C:\Users\Tiago\dev\Fundamentos\Aula03\file.txt";
        File.Delete(path);
        Console.WriteLine("Arquivo excluído com sucesso");
    }
}