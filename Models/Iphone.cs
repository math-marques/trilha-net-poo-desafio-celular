namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
    public Iphone (string numero, string modelo, int imei, int memoria) : base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
    public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone capitalista da galerinha...");
        }
    }
}
