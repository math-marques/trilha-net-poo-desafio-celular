//aqui nessa área podem ser adicionados outros USING's, para trazer novas funcionalidades para a aplicação.

//esse namespace representa um espaço que armazenará um conjunto de classes com o mesmo contexto.
namespace DesafioPOO.Models
{

//criação da classe abstrata Smartphone. É uma classe que não pode ser instanciada, mas serve de modelo, iniciação, referência, definindo um esqueleto comum para outras classes vindouras.
    public abstract class Smartphone
    {
        // aqui, pode-se utilizar o famoso "props" + Tab. essas são as prorpriedades da classe ==> numero, smartphone.
        public string Numero { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
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
