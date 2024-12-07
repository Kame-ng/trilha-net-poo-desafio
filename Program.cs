using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto Nokia
        Nokia nokia = new Nokia("123456789", "Nokia", "3310", "Nokia OS", 16);

        // Criando um objeto Iphone (Assumindo que a classe Iphone foi implementada corretamente de forma semelhante à Nokia)
        Iphone iphone = new Iphone("987654321", "Apple", "iPhone 14", "iOS", 128);

        // Testando o método Ligar
        Console.WriteLine("Testando Nokia:");
        nokia.Ligar();
        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();

        // Testando o método ReceberLigacao
        Console.WriteLine("\nTestando Receber Ligação:");
        nokia.ReceberLigacao();
        iphone.ReceberLigacao();

        // Testando o método InstalarAplicativo
        Console.WriteLine("\nTestando Instalação de Aplicativo:");
        nokia.InstalarAplicativo("WhatsApp");
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("\nTestes concluídos.");
    }
}