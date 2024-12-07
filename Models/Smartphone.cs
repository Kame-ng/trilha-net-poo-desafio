namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SistemaOperacional { get; set; }
        public int Armazenamento { get; set; } // em GB

        // Construtor da classe
        public Smartphone(string numero, string marca, string modelo, string sistemaOperacional, int armazenamento)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
            Armazenamento = armazenamento;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}