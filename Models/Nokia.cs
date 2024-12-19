namespace DesafioPOO.Models
{
    // TODO: Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrevendo o método "InstalarAplicativo"
        public Nokia (string numero, string modelo, int imei, int memoria) : base(numero)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
        }
    }
}
