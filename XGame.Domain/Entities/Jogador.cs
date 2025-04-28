using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Enum;
using XGame.Domain.Extensions;
using XGame.Domain.Resources;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador(Nome nome, Email email)
        {
            Nome = nome;
            Email = email;

            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6 a 32 caracteres");
        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = senha;
            Status = EnumSituacaoJogador.EmAnalise;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Senha", "3", "50"));
            
            if (IsInvalid())
                Senha = Senha.ConvertToMD5();

            AddNotifications(nome, email);
        }

        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; } = string.Empty;
        public EnumSituacaoJogador Status { get; private set; }
    }
}