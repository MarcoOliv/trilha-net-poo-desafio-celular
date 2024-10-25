using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um Nokia e um iPhone com informações fictícias
            Smartphone nokia = new Nokia(numero: "12345", modelo: "Nokia 3310", imei: "111111111111111", memoria: 64);
            Smartphone iphone = new Iphone(numero: "67890", modelo: "iPhone 12", imei: "222222222222222", memoria: 128);

            // Testando os métodos da classe Nokia
            Console.WriteLine("Testes com Nokia:");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Testando os métodos da classe iPhone
            Console.WriteLine("Testes com iPhone:");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}
