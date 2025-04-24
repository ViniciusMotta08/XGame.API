namespace XGame.Domain.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Produtora { get; set; } = string.Empty;
        public string Distribuidora { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
    }
}