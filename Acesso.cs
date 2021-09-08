using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class Acesso
    {
        public int AutoId { get; set; }
        public string NomeChatBot { get; set; }
        public DateTime Data { get; set; }
        public string Contato { get; set; }
        public int? Acessos { get; set; }
        public DateTime? DataUpdate { get; set; }
    }
}
