namespace projetofinal.asp.Models
{
    public class Boleto : Pagamento
    {
        public int CodigoBoleto { get; set; }
        public DateTime ValidadeBoleto { get; set; }
    }
}
