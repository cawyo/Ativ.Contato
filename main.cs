using System;

public class Contato
{
    public string Name { get; set; }
    public string Numero { get; set; }
}

public class InputProcessor
{
    public static Contato GetNewContato()
    {
        Contato newContato = new Contato();

        Console.Write("Nome: ");
        newContato.Name = Console.ReadLine();

        Console.Write("Numero: ");
        newContato.Numero = Console.ReadLine();

        return newContato;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criar novo contato:");
        Contato newContato = InputProcessor.GetNewContato();

        Console.WriteLine("Nome: " + newContato.Name);
        Console.WriteLine("Numero: " + newContato.Numero);
    }
}
