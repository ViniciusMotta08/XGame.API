namespace XGame.Domain.Entities
{
    public class JogoPlataforma
    {
        public Guid Id { get; set; }
        public Jogo Jogo { get; set; } = new Jogo();
        public Plataforma Plataforma { get; set; } = new Plataforma();
        public DateTime DataLançamento { get; set; }
    }
}