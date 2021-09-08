using System;
using System.Collections.Generic;

#nullable disable

namespace TesteEF
{
    public partial class Flow
    {
        public int AutoId { get; set; }
        public string NomeChatBot { get; set; }
        public DateTime Data { get; set; }
        public string Menu { get; set; }
        public int? Acessos { get; set; }
        public DateTime? DataUpdate { get; set; }
    }
}
