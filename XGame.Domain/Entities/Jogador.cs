namespace XGame.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; } = string.Empty;
        public string UltimoNome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public int Status { get; set; }
    }
}