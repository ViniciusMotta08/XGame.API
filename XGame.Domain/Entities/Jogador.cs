using prmToolkit.NotificationPattern;
using XGame.Domain.Enum;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador()
        {
            
        }

        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6 a 32 caracteres");
        }

        public Guid Id { get; set; }
        public Nome Nome { get; set; } = new Nome();
        public Email Email { get; set; }
        public string Senha { get; private set; } = string.Empty;
        public EnumSituacaoJogador Status { get; set; }
    }
}