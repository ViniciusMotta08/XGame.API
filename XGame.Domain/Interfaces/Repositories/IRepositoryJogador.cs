using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(string email, string senha);
        Guid AdicionarJogador(Jogador request);
    }
}