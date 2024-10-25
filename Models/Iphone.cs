using System;

namespace DesafioPOO.Models
{
    // Classe Iphone herda de Smartphone
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone que chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria) { }

        // Sobrescrevendo o método InstalarAplicativo específico para iPhone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na App Store...");
        }
    }
}
