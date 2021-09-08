using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class Contato
    {
        public int AutoId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Marca { get; set; }
        public DateTime? Acesso { get; set; }
        public DateTime? DataUpdate { get; set; }
    }
}
