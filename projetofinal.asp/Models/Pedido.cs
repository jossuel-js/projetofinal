namespace projetofinal.asp.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DateTime { get; set; }
        public List<Produto> Itens { get; set; }
        public int QuantidadeSolicitada { get; set; }
    }
}
