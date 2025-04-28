using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resources;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;
        public ServiceJogador()
        {
        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            var nome = new Nome("Vinicius", "Motta");
            var email = new Email("vinicius.analista@outlook.com");

            Jogador jogador = new Jogador(nome, email, "123456");

            if (this.IsInvalid())
            {
                return null;
            }

            Guid id = _repositoryJogador.AdicionarJogador(jogador);

            return new AdicionarJogadorResponse() { Id = id, Message = "Operação realizada com sucesso." };
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorRequest", string.Format(Message.X0_E_OBRIGATORIO.ToFormat("AutenticarJogadorRequest")));
            }

            var email = new Email(request.Email);
            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador);

            if (jogador.IsValid())
            {
                return null;
            }

            var response = _repositoryJogador.AutenticarJogador(jogador.Email.Endereco, jogador.Senha);
            return response;
        }
    }
}