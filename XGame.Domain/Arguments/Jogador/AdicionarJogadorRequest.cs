using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {        
        public string Email { get; set; } = string.Empty;
        public string Senha { get; private set; } = string.Empty;
        public string PrimeiroNome { get; private set; } = string.Empty;
        public string SegundoNome { get; private set; } = string.Empty;
    }
}