namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia que chama o construtor da classe base
        public Nokia(string numero, string marca, string modelo, string sistemaOperacional, int armazenamento)
            : base(numero, marca, modelo, sistemaOperacional, armazenamento)
        {
        }

        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
        }
    }
}
