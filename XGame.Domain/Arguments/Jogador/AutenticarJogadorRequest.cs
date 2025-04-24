using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorRequest
    {
        public string Email { get; set; } = string.Empty;    
        public string Senha { get; private set; } = string.Empty;
    }
}