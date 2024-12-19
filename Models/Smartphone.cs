//aqui nessa área podem ser adicionados outros USING's, para trazer novas funcionalidades para a aplicação.

//esse namespace representa um espaço que armazenará um conjunto de classes com o mesmo contexto.
namespace DesafioPOO.Models
{

//criação da classe abstrata Smartphone. É uma classe que não pode ser instanciada, mas serve de modelo, iniciação, referência, definindo um esqueleto comum para outras classes vindouras.
    public abstract class Smartphone
    {
        // aqui, pode-se utilizar o famoso "props" + Tab. essas são as prorpriedades da classe ==> numero, smartphone.
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public int IMEI { get; set; }
        public int Memoria { get; set; }
        // TODO: Implementar as propriedades de acordo com o diagrama e em uma ocasião futura, complexar mais

        // construtor
        public Smartphone(string numero)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passei os parâmetros do construtor para as propriedades
        }

        // aqui estão os métodos
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
// método sem retorno ===> vídeo aulas de macoratti de número 69 do curso da udemy
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
