using System;

namespace DesafioPOO.Models
{
    // Classe Nokia herda de Smartphone
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia que chama o construtor da classe base (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria) { }

        // Sobrescrevendo o método InstalarAplicativo específico para Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na Nokia Store...");
        }
    }
}
