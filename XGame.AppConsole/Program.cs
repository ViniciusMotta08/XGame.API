using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando ...");

            var service = new ServiceJogador();
            Console.WriteLine("Criei instancia do servico");

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei instancia do meu objeto request");

            var result = service.AutenticarJogador(request);
            Console.ReadKey();
        }
    }
}