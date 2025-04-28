using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Status { get; set; }

        public static explicit operator AutenticarJogadorResponse(Entities.Jogador entidade)
        {
            return new AutenticarJogadorResponse()
            {
                Email = entidade.Email.Endereco,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                Status = (int)entidade.Status
            };
        }
    }
}