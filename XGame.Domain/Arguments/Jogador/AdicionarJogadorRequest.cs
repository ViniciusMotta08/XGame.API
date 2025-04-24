using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; set; } = new Nome();
        public Email Email { get; set; } = new Email();
        public string Senha { get; private set; } = string.Empty;
    }
}