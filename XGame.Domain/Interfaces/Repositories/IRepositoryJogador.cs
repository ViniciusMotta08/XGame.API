using XGame.Domain.Entities;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);
        Jogador AdicionarJogador(Jogador request);
        IEnumerable<Jogador> ListarJogador();
        Jogador ObterJogadorPorId(Guid id);
        void AlterarJogador(Nome nome, Email email, Jogador jogador);
    }
}