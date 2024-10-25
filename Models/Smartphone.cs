using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }      // Propriedade adicionada para o modelo do smartphone
        public string IMEI { get; set; }        // Propriedade adicionada para o número IMEI do smartphone
        public int Memoria { get; set; }        // Propriedade adicionada para a quantidade de memória do smartphone

        // Construtor atualizado para incluir as propriedades adicionadas
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que será implementado em classes derivadas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
