namespace XGame.Domain.Arguments.Jogador
{
    public class AlterarJogadorRequest
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PrimeiroNome { get; set; } = string.Empty;
        public string UltimoNome { get; set; } = string.Empty;
    }
}