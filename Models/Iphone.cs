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
            // Exemplo de implementação para instalação de aplicativo no Nokia
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
            // Aqui você pode adicionar lógica adicional para simular a instalação
        }
    }
}