namespace ProvaApi.Model{
    public class Pedido{
        [Obsolete]
        public int Id { get; set; }
        public string? NomeProduto { get; set; }
        public string? Celular { get; set; }
    }
}