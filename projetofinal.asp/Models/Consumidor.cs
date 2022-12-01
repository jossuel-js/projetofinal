using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace projetofinal.asp.Models
{

    public class Consumidor
    {
        public int   Id { get; set; }
        public string ConsumidorName { get; set; }

        public string ConsumidorCPF { get; set; }
        public string ConsumidorTelefone { get; set; }
    }
}
