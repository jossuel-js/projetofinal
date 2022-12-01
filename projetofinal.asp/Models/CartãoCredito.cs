namespace projetofinal.asp.Models
{
    public class CartãoCredito:Pagamento
    {
        public int NumeroCartao { get; set; }
        public string BandeiraCartão { get; set; }
    }
}
